using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.MemoryModel64
{
	internal static class Constants
	{
		public static readonly Version Version = new Version(2, 4, 3, 43048);

		public static class DataSegment
		{
			public const ulong VideoPreferences = 0x0000000141616DF0;
			public const ulong SoundPreferences = 0x0000000141616E90;
			public const ulong HotkeyPreferences = 0x0000000141616EE0;
			public const ulong GameplayPreferences = 0x0000000141617360;
			public const ulong SocialPreferences = 0x00000001416173C4;
			public const ulong ChatPreferences = 0x00000001416173F4;
			public const ulong LevelArea = 0x00000001417F8698;
			public const ulong LevelAreaName = 0x00000001417F86A0;
			public const int LevelAreaNameLength = 0x80;
			public const ulong MapActID = 0x00000001417F8A38;
			public const ulong ScreenManagerRoot = 0x00000001417F8C98;
			public const ulong TrickleManager = 0x000000000141850888;
			public const ulong LocalData = 0x000000014187D758;
			public const ulong ObjectManager = 0x000000014187D7A0;
			public const ulong ApplicationLoopCount = 0x000000014187D824;
			public const ulong AttributeDescriptors = 0x00000001418E9770;
			public const int AttributeDescriptorsCount = 0x000005A2;
		}

		public static class ObjectManager
		{
			public const int SizeOf = 0xB98;
			public const int RenderTick = 0x060;
			public const int GameState = 0x084;
			public const int GameServerAddress = 0x0C0;
			public const int GameServerAddressLength = 128;
			public const int Storage = 0x7C8;
			public const int GameHandicap = Storage + 0x004;
			public const int GameStartingAct = Storage + 0x04C;
			public const int GameBountyBonus = Storage + 0x050;
			public const int GameTick = Storage + 0x120;
			public const int PlayerDataManager = Storage + 0x140;
			public const int FastAttrib = Storage + 0x180;
			public const int ACDManager = Storage + 0x198;
			public const int QuestManager = Storage + 0x1B8;
			public const int WaypointManager = Storage + 0x210;
			public const int Actors = 0xA28;
			public const int Scenes = 0xAA8;
			public const int UIManager = 0xB10;
			public const int Worlds = 0xB20;
			public const int Player = 0xB30;
			public const int TimedEvents = 0xB80;
		}

		public static class Actor
		{
			public const int SizeOf = 0x4F8;
			public const int ID = 0x000;
			public const int Name = 0x004;
			public const int NameLength = 0x080;
			public const int Position = 0x0B0;
		}

		public static class ACDManager
		{
			public const int ActorCommonData = 0x00;
		}

		public static class ACD
		{
			public const int SizeOf = 0x3A8;
			public const int ID = 0x000;
			public const int Name = 0x004;
			public const int NameLength = 0x080;
		}

		public static class LocalData
		{
			public const int SizeOf = 0x38;
			public const int IsPlayerValid = 0x00;
			public const int IsStartUpGame = 0x04;
			public const int SceneSNO = 0x08;
			public const int WorldSNO = 0x0C;
			public const int ActorSNO = 0x10;
			public const int ActID = 0x14;
			public const int WorldSeed = 0x18;
			public const int QuestSNO = 0x1C;
			public const int QuestStepUID = 0x20;
			public const int WorldPos = 0x24;
			public const int PlayerCount = 0x30;
			public const int LocalPlayerCount = 0x34;
		}

		public static class FastAttrib
		{
			public const int SizeOf = 0xA0;
			public const int FastAttribGroups = 0x90;
		}

		public static class FastAttribGroup
		{
			public const int SizeOf = 0x12E8;
			public const int ID = 0x0000;
		}

		public static class PlayerDataManager
		{
			public const int SizeOf = 0x5AB60;
			public const int Items = 0x00060;
		}

		public static class PlayerData
		{
			public const int SizeOf = 0xB560;
			public const int Index = 0x0000;
			public const int ACDID = 0x0004;
			public const int ActorID = 0x0008;
		}

		public static class Scene
		{
			public const int SizeOf = 0x7B8;
		}

		public static class World
		{
			public const int SizeOf = 0x98;
		}

		public static class QuestManager
		{
			public const int SizeOf = 0x4A0;
			public const int Quests = 0x030;
		}

		public static class Quest
		{
			public const int SizeOf = 0x168;
		}

		public static class WaypointManager
		{
			public const int SizeOf = 0x18;
			public const int Array = 0x00;
			public const int Count = 0x08;
		}

		public static class Waypoint
		{
			public const int SizeOf = 0x2C;
			public const int ActID = 0x00;
			public const int LevelAreaSNO = 0x0C;
			public const int X = 0x24;
			public const int Y = 0x28;
		}

		public static class TrickleManager
		{
			public const int SizeOf = 0x10;
			public const int Allocator = 0x00;
			public const int Items = 0x08;
		}

		public static class Trickle
		{
			public const int SizeOf = 0x68;
		}

		public static class UIManager
		{
			public const int SizeOf = 0x27B8;
		}

		public static class LevelArea
		{
			public const int SizeOf = 0x980;
		}

		public static class Player
		{
			public const int SizeOf = 0xA3C8;
			public const int LocalPlayerIndex = 0x0000;
			public const int LatencySamples = 0xA348;
			public const int FloatingNumbers = 0xA218;
		}

		public static class AttributeDescriptor
		{
			public const int SizeOf = 0x40;
			public const int ID = 0x00;
			public const int DataType = 0x10;
			public const int Name = 0x28;
			public const int NameLength = 256;
		}

		public static class FloatingNumber
		{
			public const int SizeOf = 0x64;
			public const int WorldPos = 0x04;
			public const int WorldSNO = 0x10;
			public const int Type = 0x5C;
			public const int Value = 0x60;
		}

		public static class TimedEvent
		{
			public const int SizeOf = 0x0C;
		}
	}
}
