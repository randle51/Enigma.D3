using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.MemoryModel
{
    partial class SymbolTable
    {
        private void InitX86()
        {
            Version = new Version(2, 6, 1, 47710);
            Platform = Platform.X86;

            DataSegment.Address = 0x1E29000;
            DataSegment.VideoPreferences = 0x1E967F0;
            DataSegment.SoundPreferences = 0x1E96890;
            DataSegment.HotkeyPreferences = 0x1E968E0;
            DataSegment.GameplayPreferences = 0x1E96D60;
            DataSegment.SocialPreferences = 0x1E96DC8;
            DataSegment.ChatPreferences = 0x1E96DF8;
            DataSegment.LevelArea = 0x207A7C0;
            DataSegment.LevelAreaName = 0x207A7C8;
            DataSegment.LevelAreaNameLength = 0x80;
            DataSegment.MapActID = 0x207AAB0;
            DataSegment.ScreenManagerRoot = 0x207ACD8;
            DataSegment.TrickleManager = 0x20C8FD4;
            DataSegment.LocalData = 0x20ED320;
            DataSegment.ObjectManager = 0x20EC070;
            DataSegment.ApplicationLoopCount = 0x20EC0EC;
            DataSegment.AttributeDescriptors = 0x21443D0;
            DataSegment.AttributeDescriptorsCount = 0x5BB;
            DataSegment.MemoryManager = 0x1E467A8;
            DataSegment.SNOFiles = 0x20E71E4;
            DataSegment.SNOGroups = 0x20EBE24;
            DataSegment.SNOGroupsByCode = 0x20EBE28;
            DataSegment.ContainerManager = 0x21B6E64;
            DataSegment.MessageDescriptor = 0x21B6E70;

            ObjectManager.SizeOf = 0xA60;
            ObjectManager.RenderTick = 0x4;
            ObjectManager.GameGlobals = 0x68;
            ObjectManager.GameState = 0x84;
            ObjectManager.Storage = 0x7E0;
            ObjectManager.Actors = 0x9A8;
            ObjectManager.Scenes = 0x9E8;
            ObjectManager.SubObjectGfx = 0xA14;
            ObjectManager.RWindowMgr = 0xA18;
            ObjectManager.UIManager = 0xA1C;
            ObjectManager.Worlds = 0xA24;
            ObjectManager.Player = 0xA2C;
            ObjectManager.TexAnim = 0xA50;
            ObjectManager.TimedEvents = 0xA54;

            GameGlobals.SizeOf = 0x3B0;
            GameGlobals.GameServerAddress = 0x5C;
            GameGlobals.GameServerAddressLength = 0x80;

            Storage.GameDifficulty = 0x4;
            Storage.GameTick = 0x120;
            Storage.PlayerDataManager = 0x134;
            Storage.FastAttrib = 0x154;
            Storage.ACDManager = 0x160;
            Storage.QuestManager = 0x170;
            Storage.WaypointManager = 0x19C;

            Actor.SizeOf = 0x454;
            Actor.ID = 0x0;
            Actor.Name = 0x4;
            Actor.NameLength = 0x80;
            Actor.SSceneID = 0xE4;

            ACDManager.SizeOf = 0xE8;
            ACDManager.ActorCommonData = 0x0;

            ACD.SizeOf = 0x2F0;
            ACD.ID = 0x0;
            ACD.Name = 0x4;
            ACD.NameLength = 0x80;
            ACD.ActorID = 0x8C;
            ACD.ActorSNO = 0x90;
            ACD.GBType = 0xB0;
            ACD.GBID = 0xB4;
            ACD.MonsterQuality = 0xB8;
            ACD.Position = 0xD0;
            ACD.Radius = 0xDC;
            ACD.SWorldID = 0x108;
            ACD.SSceneID = 0x10C;
            ACD.ItemLocation = 0x114;
            ACD.ItemSlotX = 0x118;
            ACD.ItemSlotY = 0x11C;
            ACD.FastAttribGroupID = 0x120;
            ACD.ActorType = 0x17C;
            ACD.GizmoType = 0x178;
            ACD.Hitpoints = 0x180;
            ACD.TeamID = 0x188;
            ACD.ObjectFlags = 0x190;
            ACD.Animation = 0x208;
            ACD.CollisionFlags = 0x240;

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

            FastAttrib.SizeOf = 0x5C;
            FastAttrib.FastAttribGroups = 0x54;

            FastAttribGroup.SizeOf = 0x9C8;
            FastAttribGroup.ID = 0x0;
            FastAttribGroup.Flags = 0x4;
            FastAttribGroup.PtrMap = 0xC;
            FastAttribGroup.Map = 0x10;

            PlayerDataManager.SizeOf = 0x68AF8;
            PlayerDataManager.Items = 0x38;

            PlayerData.SizeOf = 0xD158;
            PlayerData.Index = 0x0;
            PlayerData.ACDID = 0x4;
            PlayerData.ActorID = 0x8;
            PlayerData.PlayerSavedData = 0x118;
            PlayerData.HeroID = 0xB1B8;
            PlayerData.HeroName = 0xB1C0;
            PlayerData.ActorSNO = 0xC1B8;
            PlayerData.LifePercentage = 0xC1BC;
            PlayerData.HeroClass = 0xC1C8;
            PlayerData.Level = 0xC1CC;
            PlayerData.AltLevel = 0xC1D0;

            PlayerSavedData.SizeOf = 0x12AC;
            PlayerSavedData.ActiveSkillSavedData = 0x1218;
            PlayerSavedData.PassiveSkills = 0x1278;

            ActiveSkillSavedData.SizeOf = 0x10;
            ActiveSkillSavedData.PowerSNO = 0x0;
            ActiveSkillSavedData.Modifier = 0x4;

            Scene.SizeOf = 0x6C8;

            World.SizeOf = 0x68;

            QuestManager.SizeOf = 0x450;
            QuestManager.Quests = 0x1C;

            Quest.SizeOf = 0x170;

            WaypointManager.SizeOf = 0xC;
            WaypointManager.Array = 0x0;
            WaypointManager.Count = 0x8;

            Waypoint.SizeOf = 0x2C;
            Waypoint.ActID = 0x0;
            Waypoint.LevelAreaSNO = 0xC;
            Waypoint.X = 0x24;
            Waypoint.Y = 0x28;

            TrickleManager.SizeOf = 0x8;
            TrickleManager.Allocator = 0x0;
            TrickleManager.Items = 0x4;

            Trickle.SizeOf = 0x70;

            UIManager.SizeOf = 0x2780;

            LevelArea.SizeOf = 0x938;

            Player.SizeOf = 0xA128;
            Player.LocalPlayerIndex = 0x0;
            Player.FloatingNumbers = 0xA018;
            Player.LatencySamples = 0xA0CC;

            AttributeDescriptor.SizeOf = 0x28;
            AttributeDescriptor.ID = 0x0;
            AttributeDescriptor.DefaultValue = 0x4;
            AttributeDescriptor.DataType = 0x10;
            AttributeDescriptor.Name = 0x1C;
            AttributeDescriptor.NameLength = 0x80;

            FloatingNumber.SizeOf = 0x50;
            FloatingNumber.Type = 0x48;
            FloatingNumber.WorldPos = 0x4;
            FloatingNumber.SWorldID = 0x10;
            FloatingNumber.Value = 0x4C;

            TimedEvent.SizeOf = 0x30;

            MemoryManager.SizeOf = 0x38;
            MemoryManager.LocalHeap = 0x30;

            LocalHeap.FirstNode = 0x4;
            LocalHeap.TotalSize = 0x8;
            LocalHeap.NodeCount = 0x10;
            LocalHeap.LastNode = 0x38;

            HeapNode.HeaderSize = 0x10;
            HeapNode.SizeAndFlag = 0xC;

            TexAnim.SizeOf = 0x1C;

            RWindowMgr.SizeOf = 0x14;

            SubObjectGfx.SizeOf = 0x118;

            SNOFiles.SizeOf = 0x4A88;
            SNOFiles.SNODiskEntries = 0x118;

            SNOGroupStorage.SizeOf = 0x7C;
            SNOGroupStorage.Container = 0x10;
            SNOGroupStorage.Name = 0x1C;
            SNOGroupStorage.NameLength = 0x20;
        }
    }
}
