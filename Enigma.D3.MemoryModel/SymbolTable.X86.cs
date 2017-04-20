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
            Version = new Version(2, 4, 3, 43048);
            Platform = Platform.X86;

            DataSegment.Address = 0x0199B000;
            DataSegment.VideoPreferences = 0x019CD0A0;
            DataSegment.SoundPreferences = 0x019CD140;
            DataSegment.HotkeyPreferences = 0x019CD190;
            DataSegment.GameplayPreferences = 0x019CD610;
            DataSegment.SocialPreferences = 0x019CD674;
            DataSegment.ChatPreferences = 0x019CD6A4;
            DataSegment.LevelArea = 0x01B9D68C;
            DataSegment.LevelAreaName = 0x01B9D6BC;
            DataSegment.LevelAreaNameLength = 0x80;
            DataSegment.MapActID = 0x01B9DA00;
            DataSegment.ScreenManagerRoot = 0x01B9DC5C;
            DataSegment.TrickleManager = 0x01BEFA08;
            DataSegment.LocalData = 0x01C14148;
            DataSegment.ObjectManager = 0x01C12E98;
            DataSegment.ApplicationLoopCount = 0x01C12F14;
            DataSegment.AttributeDescriptors = 0x01C65660;
            DataSegment.AttributeDescriptorsCount = 1442;
            DataSegment.MemoryManager = 0x01CD2ED0;

            ObjectManager.SizeOf = 0xA40;
            ObjectManager.RenderTick = -1; // TODO
            ObjectManager.GameState = -1; // TODO
            ObjectManager.GameServerAddress = -1; // TODO
            ObjectManager.GameServerAddressLength = 128;
            ObjectManager.Storage = 0x7C0;
            Storage.GameHandicap = 0x004; // TODO
            Storage.GameStartingAct = 0x04C; // TODO
            Storage.GameBountyBonus = 0x050; // TODO
            Storage.GameTick = 0x120; // TODO
            Storage.PlayerDataManager = 0x134;
            Storage.FastAttrib = 0x154;
            Storage.ACDManager = 0x160;
            Storage.QuestManager = 0x170;
            Storage.WaypointManager = 0x19C;
            ObjectManager.Actors = 0x988;
            ObjectManager.Scenes = 0x9C8;
            ObjectManager.SubObjectGfx = 0x9E4;
            ObjectManager.RWindowMgr = 0x9E8;
            ObjectManager.UIManager = 0x9FC;
            ObjectManager.Worlds = 0xA04;
            ObjectManager.Player = 0xA0C;
            ObjectManager.TexAnim = 0xA20;
            ObjectManager.TimedEvents = 0xA34;

            Actor.SizeOf = 0x454;
            Actor.ID = 0x000;
            Actor.Name = 0x004;
            Actor.NameLength = 0x080;

            ACDManager.SizeOf = 0xE8;
            ACDManager.ActorCommonData = 0x00;

            ACD.SizeOf = 0x2F8;
            ACD.ID = 0x000;
            ACD.Name = 0x004;
            ACD.NameLength = 0x080;
            ACD.Position = 0x0D0;
            ACD.WorldSNO = 0x108;

            LocalData.SizeOf = 0x38;
            LocalData.IsPlayerValid = 0x00;
            LocalData.IsStartUpGame = 0x04;
            LocalData.SceneSNO = 0x08;
            LocalData.WorldSNO = 0x0C;
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
            FastAttribGroup.ID = 0x000;

            PlayerDataManager.SizeOf = 0x59BB8;
            PlayerDataManager.Items = 0x00000;

            PlayerData.SizeOf = 0xB370;
            PlayerData.Index = 0x0000;
            PlayerData.ACDID = 0x0004;
            PlayerData.ActorID = 0x0008;

            Scene.SizeOf = 0x6C8;

            World.SizeOf = 0x68;

            QuestManager.SizeOf = 0x450;
            QuestManager.Quests = 0x01C;

            Quest.SizeOf = 0x168;

            WaypointManager.SizeOf = 0x0C;
            WaypointManager.Array = 0x00;
            WaypointManager.Count = 0x04;

            Waypoint.SizeOf = 0x2C;
            Waypoint.ActID = 0x00;
            Waypoint.LevelAreaSNO = 0x0C;
            Waypoint.X = 0x24;
            Waypoint.Y = 0x28;

            TrickleManager.SizeOf = 0x08;
            TrickleManager.Allocator = 0x00;
            TrickleManager.Items = 0x04;

            Trickle.SizeOf = 0x68;

            UIManager.SizeOf = 0x2780;

            LevelArea.SizeOf = 0x938;

            Player.SizeOf = 0xA128;
            Player.LocalPlayerIndex = 0x0000;
            Player.LatencySamples = 0xA0CC;
            Player.FloatingNumbers = -1; // TODO

            AttributeDescriptor.SizeOf = 0x28;
            AttributeDescriptor.ID = 0x00;
            AttributeDescriptor.DataType = 0x10;
            AttributeDescriptor.Name = 0x1C;
            AttributeDescriptor.NameLength = 256;

            FloatingNumber.SizeOf = 0x50;
            FloatingNumber.WorldPos = 0x04;
            FloatingNumber.WorldSNO = 0x10;
            FloatingNumber.Type = 0x48;
            FloatingNumber.Value = 0x4C;

            TimedEvent.SizeOf = 0x0C;

            MemoryManager.SizeOf = 0x38;
            MemoryManager.LocalHeap = 0x30;

            LocalHeap.FirstNode = 0x04;
            LocalHeap.TotalSize = 0x08;
            LocalHeap.NodeCount = 0x10;
            LocalHeap.LastNode = 0x38;

            HeapNode.HeaderSize = 0x10;
            HeapNode.SizeAndFlag = 0x0C;

            TexAnim.SizeOf = 0x1C;

            RWindowMgr.SizeOf = 0x14;

            SubObjectGfx.SizeOf = 0; // TODO
        }
    }
}
