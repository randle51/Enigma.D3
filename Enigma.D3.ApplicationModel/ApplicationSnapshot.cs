using Enigma.D3.Enums;
using Enigma.D3.MemoryModel;
using Enigma.D3.MemoryModel.Preferences;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Enigma.D3.MemoryModel.Core;
using Enigma.D3.MemoryModel.Caching;

namespace Enigma.D3.ApplicationModel
{
    public class ApplicationSnapshot
    {
        private MemoryModel.Core.LocalData _localDataCache;
        private MemoryModel.Core.ObjectManager _objMgrCache;
        private MemoryModel.Core.Player _playerCache;
        private ContainerCache<MemoryModel.Core.ACD> _acdCache;
        private ContainerCache<MemoryModel.Core.Actor> _actorCache;
        private ContainerCache<MemoryModel.Core.World> _worldCache;
        private ContainerCache<MemoryModel.Core.Scene> _sceneCache;
        private AttributeCache _attributeCache;
        private HotkeyPreferences _hotkeyCache;

        public ApplicationSnapshot(MemoryContext ctx)
        {
            MemoryContext = ctx ?? throw new ArgumentNullException(nameof(ctx));
        }

        public MemoryContext MemoryContext { get; }

        public Window Window { get; private set; }

        public Game Game { get; private set; } // null when not inside a game (being in lobby)

        public void Update()
        {
            Window = Window ?? new Window();
            Window.Handle = (MemoryContext.Memory.Reader as Memory.ProcessMemoryReader)?.Process.MainWindowHandle ?? IntPtr.Zero;
            if (Window.Handle != IntPtr.Zero)
            {
                Window.ClientRect = Window.Handle == IntPtr.Zero ? default(Int32Rect) : Window.GetClientRect(Window.Handle);
            }

            RenewCache();

            if (!AssetCache.IsInitialized)
                AssetCache.Initialize(MemoryContext);

            if (_localDataCache.IsStartUpGame)
            {
                Game = null;
                return;
            }

            Game = Game ?? new Game();

            foreach (var oldItem in _worldCache.OldItems)
                Game.WorldProxies.Remove(oldItem.SWorldID);
            foreach (var newItem in _worldCache.NewItems)
                Game.WorldProxies.Add(newItem.SWorldID, new World { Memory = newItem, WorldSNO = newItem.WorldSNO });

            foreach (var oldItem in _sceneCache.OldItems)
                Game.SceneProxies.Remove(oldItem.SSceneID);
            foreach (var newItem in _sceneCache.NewItems)
                Game.SceneProxies.Add(newItem.SSceneID, new Scene { Memory = newItem, World = Game.WorldProxies[newItem.SWorldID], LevelAreaSNO = newItem.LevelAreaSNO, SceneSNO = newItem.SceneSNO });

            foreach (var oldMonster in _acdCache.OldItems.Where(x => x.ActorType == ActorType.Monster))
                Game.MonsterProxies.Remove(oldMonster.ID);
            foreach (var newMonster in _acdCache.NewItems.Where(x => x.ActorType == ActorType.Monster))
                Game.MonsterProxies.Add(newMonster.ID, CreateMonsterProxy(newMonster));

            foreach (var oldItem in _acdCache.OldItems.Where(x => x.ActorType == ActorType.Item))
                Game.ItemProxies.Remove(oldItem.ID);
            foreach (var newItem in _acdCache.NewItems.Where(x => x.ActorType == ActorType.Item))
                Game.ItemProxies.Add(newItem.ID, CreateItemProxy(newItem));

            Game.Tick = _objMgrCache.GameTick;
            Game.Difficulty = _objMgrCache.GameDifficulty;
            Game.Player = Game.Player ?? new LocalPlayer();
            Game.Player.Game = Game;

            // TODO: Reduce number of actual memory reads, but do not snapshot entire PlayerData struct.
            var playerData = _objMgrCache.PlayerDataManager[_playerCache.LocalPlayerIndex];
            Game.Player.HeroProfile.ID = playerData.HeroID;
            Game.Player.HeroProfile.Name = playerData.HeroName;
            Game.Player.HeroProfile.Class = playerData.HeroClass;
            Game.Player.HeroProfile.Level = playerData.Level;
            Game.Player.HeroProfile.Paragon = playerData.AltLevel;
            Game.Player.ACD = _acdCache.Items[(short)playerData.ACDID];
            Game.Player.Location.World = Game.WorldProxies[Game.Player.ACD.SWorldID];
            Game.Player.Location.Scene = Game.SceneProxies[Game.Player.ACD.SSceneID];
            Game.Player.Location.Position = Game.Player.ACD.Position;
            var activeSkills = playerData.PlayerSavedData.ActiveSkillSavedData;
            for (int i = 0; i < 6; i++)
            {
                activeSkills[i].TakeSnapshot();
                Game.Player.HeroProfile.ActiveSkills[i].PowerSNO = activeSkills[i].PowerSNO;
                if (activeSkills[i].Modifier == -1)
                    Game.Player.HeroProfile.ActiveSkills[i].Rune = null;
                else (Game.Player.HeroProfile.ActiveSkills[i].Rune = Game.Player.HeroProfile.ActiveSkills[i].Rune ?? new Rune()).Type = activeSkills[i].Modifier;
            }
            Game.Player.ActionBar.PrimaryAction.PowerSNO = Game.Player.HeroProfile.ActiveSkills[0].PowerSNO;
            Game.Player.ActionBar.SecondaryAction.PowerSNO = Game.Player.HeroProfile.ActiveSkills[1].PowerSNO;
            Game.Player.ActionBar.Hotbar1.PowerSNO = Game.Player.HeroProfile.ActiveSkills[2].PowerSNO;
            Game.Player.ActionBar.Hotbar2.PowerSNO = Game.Player.HeroProfile.ActiveSkills[3].PowerSNO;
            Game.Player.ActionBar.Hotbar3.PowerSNO = Game.Player.HeroProfile.ActiveSkills[4].PowerSNO;
            Game.Player.ActionBar.Hotbar4.PowerSNO = Game.Player.HeroProfile.ActiveSkills[5].PowerSNO;
            Game.Player.ActionBar.PrimaryAction.Rune = Game.Player.HeroProfile.ActiveSkills[0].Rune;
            Game.Player.ActionBar.SecondaryAction.Rune = Game.Player.HeroProfile.ActiveSkills[1].Rune;
            Game.Player.ActionBar.Hotbar1.Rune = Game.Player.HeroProfile.ActiveSkills[2].Rune;
            Game.Player.ActionBar.Hotbar2.Rune = Game.Player.HeroProfile.ActiveSkills[3].Rune;
            Game.Player.ActionBar.Hotbar3.Rune = Game.Player.HeroProfile.ActiveSkills[4].Rune;
            Game.Player.ActionBar.Hotbar4.Rune = Game.Player.HeroProfile.ActiveSkills[5].Rune;
            var passiveSkills = playerData.PlayerSavedData.PassiveSkills;
            for (int i = 0; i < 4; i++)
            {
                Game.Player.HeroProfile.PassiveSkills[i].PowerSNO = passiveSkills[i];
            }

            (_hotkeyCache = _hotkeyCache ?? MemoryContext.DataSegment.HotkeyPreferences).TakeSnapshot();
            Game.Player.ActionBar.Hotbar1.Hotkey = _hotkeyCache.Hotkeys[(int)HotkeyIndex.ActionBarSkill1];
            Game.Player.ActionBar.Hotbar2.Hotkey = _hotkeyCache.Hotkeys[(int)HotkeyIndex.ActionBarSkill2];
            Game.Player.ActionBar.Hotbar3.Hotkey = _hotkeyCache.Hotkeys[(int)HotkeyIndex.ActionBarSkill3];
            Game.Player.ActionBar.Hotbar4.Hotkey = _hotkeyCache.Hotkeys[(int)HotkeyIndex.ActionBarSkill4];
            Game.Player.ActionBar.Potion.Hotkey = _hotkeyCache.Hotkeys[(int)HotkeyIndex.PotionButton];
        }

        private Monster CreateMonsterProxy(ACD acd)
        {
            var monster = new Monster { ACD = acd };
            monster.Location.World = Game.WorldProxies[acd.SWorldID];
            monster.Location.Scene = Game.SceneProxies[acd.SSceneID];
            monster.Location.Position = acd.Position;
            return monster;
        }

        private Item CreateItemProxy(ACD acd)
        {
            var item = new Item { ACD = acd };
            if ((int)acd.ItemLocation == -1)
            {
                item.Location.World = Game.WorldProxies[acd.SWorldID];
                item.Location.Scene = Game.SceneProxies[acd.SSceneID];
                item.Location.Position = acd.Position;
            }
            return item;
        }

        private void RenewCache()
        {
            _localDataCache = _localDataCache ?? MemoryContext.DataSegment.LocalData;
            _localDataCache.TakeSnapshot();

            _objMgrCache = _objMgrCache ?? MemoryContext.DataSegment.ObjectManager;
            _objMgrCache.TakeSnapshot();

            _playerCache = _playerCache ?? _objMgrCache.Player;
            _playerCache.TakeSnapshot();

            (_acdCache = _acdCache ?? new ContainerCache<MemoryModel.Core.ACD>(_objMgrCache.ACDManager.ActorCommonData)).Update();
            (_actorCache = _actorCache ?? new ContainerCache<MemoryModel.Core.Actor>(_objMgrCache.Actors)).Update();
            (_attributeCache = _attributeCache ?? new AttributeCache(MemoryContext, _objMgrCache.FastAttrib)).Update();
            (_worldCache = _worldCache ?? new ContainerCache<MemoryModel.Core.World>(_objMgrCache.Worlds)).Update();
            (_sceneCache = _sceneCache ?? new ContainerCache<MemoryModel.Core.Scene>(_objMgrCache.Scenes)).Update();

            AttributeCache.Current = _attributeCache;
        }
    }
}
