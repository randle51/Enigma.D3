using Enigma.D3.ApplicationModel.Caching;
using Enigma.D3.AttributeModel;
using Enigma.D3.DataTypes;
using Enigma.D3.Enums;
using Enigma.D3.MemoryModel;
using Enigma.D3.MemoryModel.Preferences;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Enigma.D3.MemoryModel.Core;
using Enigma.D3.MemoryModel.Assets;
using Enigma.D3.Assets;

namespace Enigma.D3.ApplicationModel
{
    public static class Extensions
    {
        public static TValue GetValueOrDefault<TKey, TValue>(this IDictionary<TKey, TValue> dic, TKey key)
        {
            TValue value;
            if (dic.TryGetValue(key, out value))
                return value;
            return default(TValue);
        }
    }

    public static class AssetCache
    {
        private static Dictionary<SNOType, Dictionary<SNO, string>> _snoSlugs;
        private static Dictionary<string, string> _powersStringLookup;
        private static Dictionary<string, string> _monstersStringLookup;
        private static Dictionary<string, string> _itemsStringLookup;
        private static Dictionary<string, string> _levelAreaNamesLookup;

        public static void Initialize(MemoryContext ctx)
        {
            _snoSlugs = new Dictionary<SNOType, Dictionary<SNO, string>>();
            foreach (SNOType snoType in Enum.GetValues(typeof(SNOType)))
                _snoSlugs.Add(snoType, new Dictionary<SNO, string>());

            var snoDiskEntries = ctx.DataSegment.SNOFiles.SNODiskEntries.ToArray();
            foreach (var item in snoDiskEntries)
            {
                item.TakeSnapshot();
                _snoSlugs[item.SNOType][item.SNO] = item.Slug;
            }

            //var ac = new AllocationCache<MemoryModel.Collections.LinkedListNode<SNODiskEntry>>(ctx, ctx.DataSegment.SNOFiles.SNODiskEntries.Allocator);
            //ac.Update();
            //var nodes = ac.GetItems();
            //var snoSlugs2 = new Dictionary<SNOType, Dictionary<SNO, string>>();
            //foreach (SNOType snoType in Enum.GetValues(typeof(SNOType)))
            //    snoSlugs2.Add(snoType, new Dictionary<SNO, string>());
            //foreach (var node in nodes)
            //{
            //    var v = node.Value;
            //    if (v.SNO == -1 ||
            //        v.SNO == 0)
            //        continue;
            //    snoSlugs2[v.SNOType][v.SNO] = v.Slug;
            //}

            var stringListGroupStorage = ctx.DataSegment.SNOGroupStorage[(int)SNOType.StringList].Cast<SNOGroupStorage<StringList>>().Dereference();

            _powersStringLookup = GetLookup(stringListGroupStorage, "Powers");
            _monstersStringLookup = GetLookup(stringListGroupStorage, "Monsters");
            _itemsStringLookup = GetLookup(stringListGroupStorage, "Items");
            _levelAreaNamesLookup = GetLookup(stringListGroupStorage, "LevelAreaNames");

            var stringLookupMaps = new Dictionary<string, Dictionary<string, string>>();
            foreach (var item in stringListGroupStorage.Container.Where(x => x.ID != -1 && x.SNOType == SNOType.StringList).Select(x => x.PtrValue.Dereference()))
            {
                var name = _snoSlugs[SNOType.StringList][item.x00_Header.x00_SnoId];
                var map = new Dictionary<string, string>();
                foreach (var kvp in item.x10_StringTableEntries)
                    map[kvp.x00_Text.ToLowerInvariant()] = kvp.x10_Text;
                stringLookupMaps[name] = map;
            }

            var matcs = stringLookupMaps.Where(x => x.Value.Any(b => b.Key.IndexOf("X1_Tristram_Adventure_Mode_Hub", StringComparison.OrdinalIgnoreCase) != -1)).ToArray();

            IsInitialized = true;
        }

        private static Dictionary<string, string> GetLookup(SNOGroupStorage<StringList> storage, string name)
        {
            var stringListSNO = _snoSlugs[SNOType.StringList].First(x => x.Value == name).Key;
            var stringList = storage.Container.Where(x => x.ID != -1 && x.SNOType == SNOType.StringList).Select(x => x.PtrValue.Dereference()).First(x => x.x00_Header.x00_SnoId == stringListSNO);
            var lookup = new Dictionary<string, string>();
            foreach (var item in stringList.x10_StringTableEntries)
                lookup[item.x00_Text.ToLowerInvariant()] = item.x10_Text;
            return lookup;
        }

        public static bool IsInitialized { get; private set; }

        public static Dictionary<SNO, string> GetSlugs(SNOType type) => _snoSlugs[type];
        
        public static string GetPowerName(string powerSlug)
            => _powersStringLookup.GetValueOrDefault(powerSlug.ToLowerInvariant() + "_name");

        public static string GetPowerDescription(string powerSlug)
            => _powersStringLookup.GetValueOrDefault(powerSlug.ToLowerInvariant() + "_desc");
        
        public static string GetMonsterName(string monsterSlug)
            => _monstersStringLookup.GetValueOrDefault(monsterSlug.ToLowerInvariant());
        
        public static string GetItemName(string itemSlug)
            => _itemsStringLookup.GetValueOrDefault(itemSlug.ToLowerInvariant());
        
        public static string GetSlug(SNOType type, SNO sno)
            => _snoSlugs[type][sno];

        public static string GetLevelAreaName(string levelAreaSlug)
            => _levelAreaNamesLookup[levelAreaSlug.ToLowerInvariant()];
    }

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

            // TODO: Reduce number of actual memory reads, but do not snapshot entire PlayerData struct.
            var playerData = _objMgrCache.PlayerDataManager[_playerCache.LocalPlayerIndex];
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

    public class Window
    {
        public IntPtr Handle { get; internal set; }

        public Int32Rect ClientRect { get; internal set; }

        internal static Int32Rect GetClientRect(IntPtr windowHandle)
        {
            Int32Rect clientRect;
            Win32.GetClientRect(windowHandle, out clientRect);
            Win32.ClientToScreen(windowHandle, ref clientRect);
            return clientRect;
        }

        private static class Win32
        {
            private const string User32 = "user32.dll";

            [DllImport(User32)]
            internal static extern bool GetClientRect(IntPtr windowHandle, out Int32Rect clientRect);

            [DllImport(User32)]
            internal static extern bool ClientToScreen(IntPtr windowHandle, ref Int32Rect point);
        }
    }

    public class Game
    {
        internal Dictionary<int, Monster> MonsterProxies { get; } = new Dictionary<int, Monster>();
        internal Dictionary<int, Item> ItemProxies { get; } = new Dictionary<int, Item>();
        internal Dictionary<int, World> WorldProxies { get; } = new Dictionary<int, World>();
        internal Dictionary<int, Scene> SceneProxies { get; } = new Dictionary<int, Scene>();

        public int Tick { get; internal set; }

        public TimeSpan Clock => TimeSpan.FromSeconds((double)Tick / 60);

        public GameDifficulty Difficulty { get; internal set; }

        public LocalPlayer Player { get; internal set; }

        public IEnumerable<Monster> Monsters => MonsterProxies.Values;

        public IEnumerable<Item> Items => ItemProxies.Values;

        public IEnumerable<Item> Equipment => Items.Where(x => x.IsEquipped);

        public IEnumerable<Item> Backpack => Items.Where(x => x.IsInInventory);

        public IEnumerable<Item> StashedItems => Items.Where(x => x.IsStashed);

        public IEnumerable<Item> Loot => Items.Where(x => (int)x.ItemLocation == -1);

        public IEnumerable<World> Worlds => WorldProxies.Values;
    }

    public class LocalPlayer : Player
    {
        public ActionBar ActionBar { get; } = new ActionBar();
    }

    public class Player : Actor
    {
        public int Index { get; internal set; }

        public HeroProfile HeroProfile { get; } = new HeroProfile();
    }

    public class Monster : Actor
    {
        public MonsterQuality Rarity => ACD.MonsterQuality;

        public bool IsEnemy => ACD.TeamID == 10;

        public bool IsAlive => ACD.Hitpoints > 0.00001;

        public bool IsTargetable => (ACD.ObjectFlags & 1) == 0;
    }

    public class Item : Actor
    {
        public string ItemSlug => AssetCache.GetSlug(SNOType.Actor, ACD.ActorSNO);

        public string ItemName => AssetCache.GetItemName(ItemSlug);

        public ItemQuality Quality => (ItemQuality)Read(Attributes.ItemQualityLevel);

        public ItemLocation ItemLocation => ACD.ItemLocation;

        public int ItemSlotX => ACD.ItemSlotX;

        public int ItemSlotY => ACD.ItemSlotY;

        public bool IsEquipped => ItemLocation >= ItemLocation.PlayerHead && ItemLocation <= ItemLocation.PlayerNeck;

        public bool IsStashed => ItemLocation == ItemLocation.Stash;

        public bool IsInInventory => ItemLocation == ItemLocation.PlayerBackpack;
    }

    public class HeroProfile
    {
        public string Name { get; internal set; }

        public HeroClass Class { get; internal set; }

        public int Level { get; internal set; }

        public int Paragon { get; internal set; }

        public Skill[] ActiveSkills { get; } = Enumerable.Range(0, 6).Select(x => new Skill()).ToArray();

        public Skill[] PassiveSkills { get; } = Enumerable.Range(0, 4).Select(x => new Skill()).ToArray();
    }

    public class WorldLocation
    {
        public World World { get; internal set; }

        public Scene Scene { get; internal set; }

        public Vector3 Position { get; internal set; }
    }

    public class World
    {
        public MemoryModel.Core.World Memory { get; internal set; }

        public SNO WorldSNO { get; internal set; }

        public string Slug => AssetCache.GetSlug(SNOType.Worlds, WorldSNO);
    }

    public class Scene
    {
        public MemoryModel.Core.Scene Memory { get; internal set; }

        public SNO SceneSNO { get; internal set; }

        public string SceneSlug => AssetCache.GetSlug(SNOType.Scene, SceneSNO);

        public World World { get; internal set; }

        public SNO LevelAreaSNO { get; internal set; }

        public string LevelAreaSlug => AssetCache.GetSlug(SNOType.LevelArea, LevelAreaSNO);

        public string LevelAreaName => AssetCache.GetLevelAreaName(LevelAreaSlug);
    }

    public class Skill
    {
        public string Slug => AssetCache.GetSlug(SNOType.Power, PowerSNO);

        public string Name => AssetCache.GetPowerName(Slug);

        public string Description => AssetCache.GetPowerDescription(Slug);

        public SNO PowerSNO { get; internal set; }

        public Rune Rune { get; internal set; } // null for passive skills
    }

    public class Rune
    {
        public int Type { get; internal set; }
    }

    public class Actor
    {
        private readonly IAttributeReader _attributeReader;

        public Actor()
        {
            _attributeReader = AttributeCache.Current;
        }

        public ACD ACD { get; set; }

        public SNO ActorSNO => ACD.ActorSNO;

        public ActorType Type => ACD.ActorType;

        public WorldLocation Location { get; } = new WorldLocation();

        public virtual string Slug => AssetCache.GetSlug(SNOType.Actor, ActorSNO);

        public virtual string Name => AssetCache.GetSlug(SNOType.Actor, ActorSNO);

        public T Read<T>(Attribute<T> attribute) where T : struct
        {
            return Read(attribute, -1);
        }

        public T Read<T>(Attribute<T> attribute, int modifier) where T : struct
        {
            if (_attributeReader == null || ACD == null)
                return attribute.DefaultValue;
            return attribute.GetValue(_attributeReader, ACD.FastAttribGroupID);
        }
    }

    public class ActionBar
    {
        public ActiveSkill PrimaryAction { get; } = new ActiveSkill { Hotkey = new Hotkey { PrimaryGesture = new KeyGesture { Key = Key.Mouse1 }, SecondaryGesture = KeyGesture.None } };
        public ActiveSkill SecondaryAction { get; } = new ActiveSkill { Hotkey = new Hotkey { PrimaryGesture = new KeyGesture { Key = Key.Mouse2 }, SecondaryGesture = KeyGesture.None } };
        public ActiveSkill Hotbar1 { get; } = new ActiveSkill();
        public ActiveSkill Hotbar2 { get; } = new ActiveSkill();
        public ActiveSkill Hotbar3 { get; } = new ActiveSkill();
        public ActiveSkill Hotbar4 { get; } = new ActiveSkill();
        public ActiveSkill Potion { get; } = new ActiveSkill();

        public ActiveSkill[] Hotbar => new[] { Hotbar1, Hotbar2, Hotbar3, Hotbar4 };
    }

    public class ActiveSkill : Skill
    {
        public Hotkey Hotkey { get; internal set; }
    }
}
