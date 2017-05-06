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
            Version = new Version(2, 5, 0, 44247);
            Platform = Platform.X86;

            DataSegment.Address = 0x1DAB000;
            DataSegment.VideoPreferences = 0x1E0F438;
            DataSegment.SoundPreferences = 0x1E0F4D8;
            DataSegment.HotkeyPreferences = 0x1E0F528;
            DataSegment.GameplayPreferences = 0x1E0F9A8;
            DataSegment.SocialPreferences = 0x1E0FA10;
            DataSegment.ChatPreferences = 0x1E0FA40;
            DataSegment.LevelArea = 0x1FEABE0;
            DataSegment.LevelAreaName = 0x1FEABE8;
            DataSegment.LevelAreaNameLength = 0x80;
            DataSegment.MapActID = 0x1FEAED0;
            DataSegment.ScreenManagerRoot = 0x1FEB0F8;
            DataSegment.TrickleManager = 0x20393EC;
            DataSegment.LocalData = 0x205D3A0;
            DataSegment.ObjectManager = 0x205C0F0;
            DataSegment.ApplicationLoopCount = 0x205C16C;
            DataSegment.AttributeDescriptors = 0x20B3A60;
            DataSegment.AttributeDescriptorsCount = 0x5A5;
            DataSegment.MemoryManager = 0x2121A64;
            DataSegment.SNOGroups = 0x2059FB8;
            DataSegment.SNOGroupsByCode = 0x2059EA0;
            DataSegment.ContainerManager = 0x2124644;
            DataSegment.MessageDescriptor = 0x2124650;

            ObjectManager.SizeOf = 0xA30;
            ObjectManager.RenderTick = 0x4;
            ObjectManager.GameGlobals = 0x68;
            ObjectManager.GameState = 0x84;
            ObjectManager.Storage = 0x7B0;
            ObjectManager.Actors = 0x978;
            ObjectManager.Scenes = 0x9B8;
            ObjectManager.SubObjectGfx = 0x9E4;
            ObjectManager.RWindowMgr = 0x9E8;
            ObjectManager.UIManager = 0x9EC;
            ObjectManager.Worlds = 0x9F4;
            ObjectManager.Player = 0x9FC;
            ObjectManager.TexAnim = 0xA20;
            ObjectManager.TimedEvents = 0xA24;

            GameGlobals.SizeOf = 0x398;
            GameGlobals.GameServerAddress = 0x5C;
            GameGlobals.GameServerAddressLength = 0x80;

            Storage.GameHandicap = 0x4;
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

            ACDManager.SizeOf = 0x88F0;
            ACDManager.ActorCommonData = 0x0;

            ACD.SizeOf = 0x2F0;
            ACD.ID = 0x0;
            ACD.Name = 0x4;
            ACD.NameLength = 0x80;
            ACD.ActorSNO = 0x90;
            ACD.MonsterQuality = 0xB8;
            ACD.Position = 0xD0;
            ACD.Radius = 0xDC;
            ACD.WorldSNO = 0x108;
            ACD.FastAttribGroupID = 0x120;
            ACD.ActorType = 0x17C;
            ACD.GizmoType = 0x178;
            ACD.Hitpoints = 0x180;
            ACD.TeamID = 0x188;
            ACD.ObjectFlags = 0x190;
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

            PlayerDataManager.SizeOf = 0x60738;
            PlayerDataManager.Items = 0x38;

            PlayerData.SizeOf = 0xC0E0;
            PlayerData.Index = 0x0;
            PlayerData.ACDID = 0x4;
            PlayerData.ActorID = 0x8;
            PlayerData.HeroName = 0xA1D0;
            PlayerData.ActorSNO = 0xB150;
            PlayerData.LifePercentage = 0xB154;
            PlayerData.HeroClass = 0xB160;
            PlayerData.Level = 0xB164;
            PlayerData.AltLevel = 0xB168;

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
            Player.LatencySamples = 0xA0CC;
            Player.FloatingNumbers = 0xA018;

            AttributeDescriptor.SizeOf = 0x28;
            AttributeDescriptor.ID = 0x0;
            AttributeDescriptor.DefaultValue = 0x4;
            AttributeDescriptor.DataType = 0x10;
            AttributeDescriptor.Name = 0x1C;
            AttributeDescriptor.NameLength = 0x80;

            FloatingNumber.SizeOf = 0x50;
            FloatingNumber.WorldPos = 0x4;
            FloatingNumber.WorldSNO = 0x10;
            FloatingNumber.Type = 0x48;
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
        }
    }
}
