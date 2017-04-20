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
            Version = new Version(2, 4, 3, 43048);
            Platform = Platform.X64;

            DataSegment.Address = 0x00000001415CD000;
            DataSegment.VideoPreferences = 0x0000000141616DF0;
            DataSegment.SoundPreferences = 0x0000000141616E90;
            DataSegment.HotkeyPreferences = 0x0000000141616EE0;
            DataSegment.GameplayPreferences = 0x0000000141617360;
            DataSegment.SocialPreferences = 0x00000001416173C4;
            DataSegment.ChatPreferences = 0x00000001416173F4;
            DataSegment.LevelArea = 0x00000001417F8698;
            DataSegment.LevelAreaName = 0x00000001417F86A0;
            DataSegment.LevelAreaNameLength = 0x80;
            DataSegment.MapActID = 0x00000001417F8A38;
            DataSegment.ScreenManagerRoot = 0x00000001417F8C98;
            DataSegment.TrickleManager = 0x000000000141850888;
            DataSegment.LocalData = 0x000000014187D758;
            DataSegment.ObjectManager = 0x000000014187D7A0;
            DataSegment.ApplicationLoopCount = 0x000000014187D824;
            DataSegment.AttributeDescriptors = 0x00000001418E9770;
            DataSegment.AttributeDescriptorsCount = 0x000005A2;
            DataSegment.MemoryManager = 0x0000000141981288;

            ObjectManager.SizeOf = 0xB98;
            ObjectManager.RenderTick = 0x060;
            ObjectManager.GameState = 0x084;
            ObjectManager.GameServerAddress = 0x0C0;
            ObjectManager.GameServerAddressLength = 128;
            ObjectManager.Storage = 0x7C8;
            Storage.GameHandicap = 0x004;
            Storage.GameStartingAct = 0x04C;
            Storage.GameBountyBonus = 0x050;
            Storage.GameTick = 0x120;
            Storage.PlayerDataManager = 0x140;
            Storage.FastAttrib = 0x180;
            Storage.ACDManager = 0x198;
            Storage.QuestManager = 0x1B8;
            Storage.WaypointManager = 0x210;
            ObjectManager.Actors = 0xA28;
            ObjectManager.Scenes = 0xAA8;
            ObjectManager.SubObjectGfx = 0; // TODO
            ObjectManager.RWindowMgr = 0; //TODO
            ObjectManager.UIManager = 0xB10;
            ObjectManager.Worlds = 0xB20;
            ObjectManager.Player = 0xB30;
            ObjectManager.TexAnim = 0; // TODO
            ObjectManager.TimedEvents = 0xB80;

            Actor.SizeOf = 0x4F8;
            Actor.ID = 0x000;
            Actor.Name = 0x004;
            Actor.NameLength = 0x080;

            ACDManager.SizeOf = -1; // TODO
            ACDManager.ActorCommonData = 0x00;

            ACD.SizeOf = 0x3A8;
            ACD.ID = 0x000;
            ACD.Name = 0x004;
            ACD.NameLength = 0x080;
            ACD.Position = 0x0D8;
            ACD.WorldSNO = 0x118;

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

            FastAttrib.SizeOf = 0xA0;
            FastAttrib.FastAttribGroups = 0x90;

            FastAttribGroup.SizeOf = 0x12E8;
            FastAttribGroup.ID = 0x0000;

            PlayerDataManager.SizeOf = 0x5AB60;
            PlayerDataManager.Items = 0x00000;

            PlayerData.SizeOf = 0xB560;
            PlayerData.Index = 0x0000;
            PlayerData.ACDID = 0x0004;
            PlayerData.ActorID = 0x0008;

            Scene.SizeOf = 0x7B8;

            World.SizeOf = 0x98;

            QuestManager.SizeOf = 0x4A0;
            QuestManager.Quests = 0x030;

            Quest.SizeOf = 0x168;

            WaypointManager.SizeOf = 0x18;
            WaypointManager.Array = 0x00;
            WaypointManager.Count = 0x08;

            Waypoint.SizeOf = 0x2C;
            Waypoint.ActID = 0x00;
            Waypoint.LevelAreaSNO = 0x0C;
            Waypoint.X = 0x24;
            Waypoint.Y = 0x28;

            TrickleManager.SizeOf = 0x10;
            TrickleManager.Allocator = 0x00;
            TrickleManager.Items = 0x08;

            Trickle.SizeOf = 0x68;

            UIManager.SizeOf = 0x27B8;

            LevelArea.SizeOf = 0x980;

            Player.SizeOf = 0xA3C8;
            Player.LocalPlayerIndex = 0x0000;
            Player.LatencySamples = 0xA348;
            Player.FloatingNumbers = 0xA218;

            AttributeDescriptor.SizeOf = 0x40;
            AttributeDescriptor.ID = 0x00;
            AttributeDescriptor.DataType = 0x10;
            AttributeDescriptor.Name = 0x28;
            AttributeDescriptor.NameLength = 256;

            FloatingNumber.SizeOf = 0x64;
            FloatingNumber.WorldPos = 0x04;
            FloatingNumber.WorldSNO = 0x10;
            FloatingNumber.Type = 0x5C;
            FloatingNumber.Value = 0x60;

            TimedEvent.SizeOf = 0x0C;

            MemoryManager.SizeOf = 0x68;
            MemoryManager.LocalHeap = 0x58;

            LocalHeap.FirstNode = 0x08;
            LocalHeap.TotalSize = 0x10;
            LocalHeap.NodeCount = 0x20;
            LocalHeap.LastNode = 0x68;

            HeapNode.HeaderSize = 0x20;
            HeapNode.SizeAndFlag = 0x18;

            TexAnim.SizeOf = 0; // TODO

            RWindowMgr.SizeOf = 0; // TODO

            SubObjectGfx.SizeOf = 0; // TODO
        }
    }
}
