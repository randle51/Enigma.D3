using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.MemoryModel
{
    partial class SymbolTable
    {
        private void InitX64()
        {
            Version = new Version(2, 6, 0, 46568);
            Platform = Platform.X64;

            DataSegment.Address = 0x141B57000;
            DataSegment.VideoPreferences = 0x141BE5C00;
            DataSegment.SoundPreferences = 0x141BE5CA0;
            DataSegment.HotkeyPreferences = 0x141BE5CF0;
            DataSegment.GameplayPreferences = 0x141BE6170;
            DataSegment.SocialPreferences = 0x141BE61D8;
            DataSegment.ChatPreferences = 0x141BE6208;
            DataSegment.LevelArea = 0x141DDF788;
            DataSegment.LevelAreaName = 0x141DDF790;
            DataSegment.LevelAreaNameLength = 0x80;
            DataSegment.MapActID = 0x141DDFA98;
            DataSegment.ScreenManagerRoot = 0x141DDFCC0;
            DataSegment.TrickleManager = 0x141E32B90;
            DataSegment.LocalData = 0x141E5FBD8;
            DataSegment.ObjectManager = 0x141E5FCE0;
            DataSegment.ApplicationLoopCount = 0x141E5FD64;
            DataSegment.AttributeDescriptors = 0x141ED3820;
            DataSegment.AttributeDescriptorsCount = 0x5B9;
            DataSegment.MemoryManager = 0x141F6E460;
            DataSegment.SNOFiles = 0x141E5A020;
            DataSegment.SNOGroups = 0x141E5FAE0;
            DataSegment.SNOGroupsByCode = 0x141E5F8B0;
            DataSegment.ContainerManager = 0x141F71D80;
            DataSegment.MessageDescriptor = 0x1413B1C18;

            ObjectManager.SizeOf = 0xBC0;
            ObjectManager.RenderTick = 0x4;
            ObjectManager.GameGlobals = 0x68;
            ObjectManager.GameState = 0x84;
            ObjectManager.Storage = 0x7E8;
            ObjectManager.Actors = 0xA50;
            ObjectManager.Scenes = 0xAD0;
            ObjectManager.SubObjectGfx = 0xB28;
            ObjectManager.RWindowMgr = 0xB30;
            ObjectManager.UIManager = 0xB38;
            ObjectManager.Worlds = 0xB48;
            ObjectManager.Player = 0xB58;
            ObjectManager.TexAnim = 0xBA0;
            ObjectManager.TimedEvents = 0xBA8;

            GameGlobals.SizeOf = 0x3A0;
            GameGlobals.GameServerAddress = 0x5C;
            GameGlobals.GameServerAddressLength = 0x80;

            Storage.GameDifficulty = 0x4;
            Storage.GameTick = 0x120;
            Storage.PlayerDataManager = 0x140;
            Storage.FastAttrib = 0x180;
            Storage.ACDManager = 0x198;
            Storage.QuestManager = 0x1B8;
            Storage.WaypointManager = 0x210;

            Actor.SizeOf = 0x4F8;
            Actor.ID = 0x0;
            Actor.Name = 0x4;
            Actor.NameLength = 0x80;
            Actor.SSceneID = 0xE4;

            ACDManager.SizeOf = 0x150;
            ACDManager.ActorCommonData = 0x0;

            ACD.SizeOf = 0x3A0;
            ACD.ID = 0x0;
            ACD.Name = 0x4;
            ACD.NameLength = 0x80;
            ACD.ActorID = 0x8C;
            ACD.ActorSNO = 0x90;
            ACD.MonsterQuality = 0xB8;
            ACD.Position = 0xD8;
            ACD.Radius = 0xE4;
            ACD.SWorldID = 0x118;
            ACD.SSceneID = 0x11C;
            ACD.ItemLocation = 0x124;
            ACD.ItemSlotX = 0x128;
            ACD.ItemSlotY = 0x12C;
            ACD.FastAttribGroupID = 0x130;
            ACD.ActorType = 0x1BC;
            ACD.GizmoType = 0x1B8;
            ACD.Hitpoints = 0x1C0;
            ACD.TeamID = 0x1C8;
            ACD.ObjectFlags = 0x1CC;
            ACD.Animation = 0x290;
            ACD.CollisionFlags = 0x2D8;

            LocalData.SizeOf = 0x38;
            LocalData.IsPlayerValid = 0x0;
            LocalData.IsStartUpGame = 0x4;
            LocalData.SceneSNO = 0x8;
            LocalData.WorldSNO = 0xC;
            LocalData.ActorSNO = 0x10;
            LocalData.ActID = 0x14;
            LocalData.WorldSeed = 0x18;
            LocalData.QuestSNO = 0x1C;
            LocalData.QuestStepUID = 0x20;
            LocalData.WorldPos = 0x24;
            LocalData.PlayerCount = 0x30;
            LocalData.LocalPlayerCount = 0x34;

            FastAttrib.SizeOf = 0xA0;
            FastAttrib.FastAttribGroups = 0x90;

            FastAttribGroup.SizeOf = 0x12E8;
            FastAttribGroup.ID = 0x0;
            FastAttribGroup.Flags = 0x4;
            FastAttribGroup.PtrMap = 0x10;
            FastAttribGroup.Map = 0x18;

            PlayerDataManager.SizeOf = 0x69BA0;
            PlayerDataManager.Items = 0x60;

            PlayerData.SizeOf = 0xD368;
            PlayerData.Index = 0x0;
            PlayerData.ACDID = 0x4;
            PlayerData.ActorID = 0x8;
            PlayerData.PlayerSavedData = 0x130;
            PlayerData.HeroID = 0xB1D0;
            PlayerData.HeroName = 0xB1D8;
            PlayerData.ActorSNO = 0xC210;
            PlayerData.LifePercentage = 0xC214;
            PlayerData.HeroClass = 0xC220;
            PlayerData.Level = 0xC224;
            PlayerData.AltLevel = 0xC228;

            PlayerSavedData.SizeOf = 0x12AC;
            PlayerSavedData.ActiveSkillSavedData = 0x1218;
            PlayerSavedData.PassiveSkills = 0x1278;

            ActiveSkillSavedData.SizeOf = 0x10;
            ActiveSkillSavedData.PowerSNO = 0x0;
            ActiveSkillSavedData.Modifier = 0x4;

            Scene.SizeOf = 0x7B8;

            World.SizeOf = 0x98;

            QuestManager.SizeOf = 0x4A0;
            QuestManager.Quests = 0x30;

            Quest.SizeOf = 0x178;

            WaypointManager.SizeOf = 0x18;
            WaypointManager.Array = 0x0;
            WaypointManager.Count = 0x10;

            Waypoint.SizeOf = 0x2C;
            Waypoint.ActID = 0x0;
            Waypoint.LevelAreaSNO = 0xC;
            Waypoint.X = 0x24;
            Waypoint.Y = 0x28;

            TrickleManager.SizeOf = 0x10;
            TrickleManager.Allocator = 0x0;
            TrickleManager.Items = 0x4;

            Trickle.SizeOf = 0x78;

            UIManager.SizeOf = 0x27B8;

            LevelArea.SizeOf = 0x980;

            Player.SizeOf = 0xA3C8;
            Player.LocalPlayerIndex = 0x0;
            Player.FloatingNumbers = 0xA218;
            Player.LatencySamples = 0xA348;

            AttributeDescriptor.SizeOf = 0x40;
            AttributeDescriptor.ID = 0x0;
            AttributeDescriptor.DefaultValue = 0x4;
            AttributeDescriptor.DataType = 0x10;
            AttributeDescriptor.Name = 0x28;
            AttributeDescriptor.NameLength = 0x100;

            FloatingNumber.SizeOf = 0x60;
            FloatingNumber.Type = 0x0;
            FloatingNumber.WorldPos = 0x8;
            FloatingNumber.SWorldID = 0x14;
            FloatingNumber.Value = 0x5C;

            TimedEvent.SizeOf = 0x58;

            MemoryManager.SizeOf = 0x68;
            MemoryManager.LocalHeap = 0x58;

            LocalHeap.FirstNode = 0x8;
            LocalHeap.TotalSize = 0x10;
            LocalHeap.NodeCount = 0x20;
            LocalHeap.LastNode = 0x68;

            HeapNode.HeaderSize = 0x20;
            HeapNode.SizeAndFlag = 0x18;

            TexAnim.SizeOf = 0x30;

            RWindowMgr.SizeOf = 0x28;

            SubObjectGfx.SizeOf = 0x128;

            SNOFiles.SizeOf = 0x5568;
            SNOFiles.SNODiskEntries = 0x118;

            SNOGroupStorage.SizeOf = 0xA8;
            SNOGroupStorage.Container = 0x18;
            SNOGroupStorage.Name = 0x30;
            SNOGroupStorage.NameLength = 0x20;
        }
    }
}
