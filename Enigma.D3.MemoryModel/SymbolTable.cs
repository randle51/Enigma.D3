using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.MemoryModel
{
	public struct SymbolTable
	{
		public static SymbolTable Current;

		public SymbolTable(MemoryContext ctx)
			: this(ctx.Memory.Reader.PointerSize == 8 ? Platform.X64 : Platform.X86) { }

		public SymbolTable(Platform platform)
		{
			Version = new Version(2, 4, 3, 43048);

			DataSegment = new DataSegmentSymbols(platform);
			ObjectManager = new ObjectManagerSymbols(platform);
			Actor = new ActorSymbols(platform);
			ACDManager = new ACDManagerSymbols(platform);
			ACD = new ACDSymbols(platform);
			LocalData = new LocalDataSymbols(platform);
			FastAttrib = new FastAttribSymbols(platform);
			FastAttribGroup = new FastAttribGroupSymbols(platform);
			PlayerDataManager = new PlayerDataManagerSymbols(platform);
			PlayerData = new PlayerDataSymbols(platform);
			Scene = new SceneSymbols(platform);
			World = new WorldSymbols(platform);
			QuestManager = new QuestManagerSymbols(platform);
			Quest = new QuestSymbols(platform);
			WaypointManager = new WaypointManagerSymbols(platform);
			Waypoint = new WaypointSymbols(platform);
			TrickleManager = new TrickleManagerSymbols(platform);
			Trickle = new TrickleSymbols(platform);
			UIManager = new UIManagerSymbols(platform);
			LevelArea = new LevelAreaSymbols(platform);
			Player = new PlayerSymbols(platform);
			AttributeDescriptor = new AttributeDescriptorSymbols(platform);
			FloatingNumber = new FloatingNumberSymbols(platform);
			TimedEvent = new TimedEventSymbols(platform);
			MemoryManager = new MemoryManagerSymbols(platform);
			LocalHeap = new LocalHeapSymbols(platform);
			HeapNode = new HeapNodeSymbols(platform);
		}

		public readonly Version Version;

		public readonly DataSegmentSymbols DataSegment;
		public readonly ObjectManagerSymbols ObjectManager;
		public readonly ActorSymbols Actor;
		public readonly ACDManagerSymbols ACDManager;
		public readonly ACDSymbols ACD;
		public readonly LocalDataSymbols LocalData;
		public readonly FastAttribSymbols FastAttrib;
		public readonly FastAttribGroupSymbols FastAttribGroup;
		public readonly PlayerDataManagerSymbols PlayerDataManager;
		public readonly PlayerDataSymbols PlayerData;
		public readonly SceneSymbols Scene;
		public readonly WorldSymbols World;
		public readonly QuestManagerSymbols QuestManager;
		public readonly QuestSymbols Quest;
		public readonly WaypointManagerSymbols WaypointManager;
		public readonly WaypointSymbols Waypoint;
		public readonly TrickleManagerSymbols TrickleManager;
		public readonly TrickleSymbols Trickle;
		public readonly UIManagerSymbols UIManager;
		public readonly LevelAreaSymbols LevelArea;
		public readonly PlayerSymbols Player;
		public readonly AttributeDescriptorSymbols AttributeDescriptor;
		public readonly FloatingNumberSymbols FloatingNumber;
		public readonly TimedEventSymbols TimedEvent;
		public readonly MemoryManagerSymbols MemoryManager;
		public readonly LocalHeapSymbols LocalHeap;
		public readonly HeapNodeSymbols HeapNode;
	}

	public struct DataSegmentSymbols
	{
		public DataSegmentSymbols(Platform platform)
		{
			if (platform == Platform.X86)
			{
				MemoryManager = 0x020FFC2C; // PTR
				throw new NotImplementedException();
			}
			else if (platform == Platform.X64)
			{
				Address = 0x00000001415CD000;
				VideoPreferences = 0x0000000141616DF0;
				SoundPreferences = 0x0000000141616E90;
				HotkeyPreferences = 0x0000000141616EE0;
				GameplayPreferences = 0x0000000141617360;
				SocialPreferences = 0x00000001416173C4;
				ChatPreferences = 0x00000001416173F4;
				LevelArea = 0x00000001417F8698;
				LevelAreaName = 0x00000001417F86A0;
				LevelAreaNameLength = 0x80;
				MapActID = 0x00000001417F8A38;
				ScreenManagerRoot = 0x00000001417F8C98;
				TrickleManager = 0x000000000141850888;
				LocalData = 0x000000014187D758;
				ObjectManager = 0x000000014187D7A0;
				ApplicationLoopCount = 0x000000014187D824;
				AttributeDescriptors = 0x00000001418E9770;
				AttributeDescriptorsCount = 0x000005A2;
				MemoryManager = ulong.MaxValue;
			}
			else throw new PlatformNotSupportedException();
		}

		public readonly ulong Address;
		public readonly ulong VideoPreferences;
		public readonly ulong SoundPreferences;
		public readonly ulong HotkeyPreferences;
		public readonly ulong GameplayPreferences;
		public readonly ulong SocialPreferences;
		public readonly ulong ChatPreferences;
		public readonly ulong LevelArea;
		public readonly ulong LevelAreaName;
		public readonly int LevelAreaNameLength;
		public readonly ulong MapActID;
		public readonly ulong ScreenManagerRoot;
		public readonly ulong TrickleManager;
		public readonly ulong LocalData;
		public readonly ulong ObjectManager;
		public readonly ulong ApplicationLoopCount;
		public readonly ulong AttributeDescriptors;
		public readonly int AttributeDescriptorsCount;
		public readonly ulong MemoryManager;
	}

	public struct ObjectManagerSymbols
	{
		public ObjectManagerSymbols(Platform platform)
		{
			if (platform == Platform.X86)
			{
				throw new NotImplementedException();
			}
			else if (platform == Platform.X64)
			{
				SizeOf = 0xB98;
				RenderTick = 0x060;
				GameState = 0x084;
				GameServerAddress = 0x0C0;
				GameServerAddressLength = 128;
				Storage = 0x7C8;
				GameHandicap = Storage + 0x004;
				GameStartingAct = Storage + 0x04C;
				GameBountyBonus = Storage + 0x050;
				GameTick = Storage + 0x120;
				PlayerDataManager = Storage + 0x140;
				FastAttrib = Storage + 0x180;
				ACDManager = Storage + 0x198;
				QuestManager = Storage + 0x1B8;
				WaypointManager = Storage + 0x210;
				Actors = 0xA28;
				Scenes = 0xAA8;
				UIManager = 0xB10;
				Worlds = 0xB20;
				Player = 0xB30;
				TimedEvents = 0xB80;
			}
			else throw new PlatformNotSupportedException();
		}

		public readonly int SizeOf;
		public readonly int RenderTick;
		public readonly int GameState;
		public readonly int GameServerAddress;
		public readonly int GameServerAddressLength;
		public readonly int Storage;
		public readonly int GameHandicap;
		public readonly int GameStartingAct;
		public readonly int GameBountyBonus;
		public readonly int GameTick;
		public readonly int PlayerDataManager;
		public readonly int FastAttrib;
		public readonly int ACDManager;
		public readonly int QuestManager;
		public readonly int WaypointManager;
		public readonly int Actors;
		public readonly int Scenes;
		public readonly int UIManager;
		public readonly int Worlds;
		public readonly int Player;
		public readonly int TimedEvents;
	}

	public struct ActorSymbols
	{
		public ActorSymbols(Platform platform)
		{
			if (platform == Platform.X86)
			{
				throw new NotImplementedException();
			}
			else if (platform == Platform.X64)
			{
				SizeOf = 0x4F8;
				ID = 0x000;
				Name = 0x004;
				NameLength = 0x080;
				Position = 0x0B0;
			}
			else throw new PlatformNotSupportedException();
		}

		public readonly int SizeOf;
		public readonly int ID;
		public readonly int Name;
		public readonly int NameLength;
		public readonly int Position;
	}

	public struct ACDManagerSymbols
	{
		public ACDManagerSymbols(Platform platform)
		{
			if (platform == Platform.X86)
			{
				throw new NotImplementedException();
			}
			else if (platform == Platform.X64)
			{
				ActorCommonData = 0x00;
			}
			else throw new PlatformNotSupportedException();
		}

		public readonly int ActorCommonData;
	}

	public struct ACDSymbols
	{
		public ACDSymbols(Platform platform)
		{
			if (platform == Platform.X86)
			{
				throw new NotImplementedException();
			}
			else if (platform == Platform.X64)
			{
				SizeOf = 0x3A8;
				ID = 0x000;
				Name = 0x004;
				NameLength = 0x080;
			}
			else throw new PlatformNotSupportedException();
		}

		public readonly int SizeOf;
		public readonly int ID;
		public readonly int Name;
		public readonly int NameLength;
	}

	public struct LocalDataSymbols
	{
		public LocalDataSymbols(Platform platform)
		{
			if (platform == Platform.X86)
			{
				throw new NotImplementedException();
			}
			else if (platform == Platform.X64)
			{
				SizeOf = 0x38;
				IsPlayerValid = 0x00;
				IsStartUpGame = 0x04;
				SceneSNO = 0x08;
				WorldSNO = 0x0C;
				ActorSNO = 0x10;
				ActID = 0x14;
				WorldSeed = 0x18;
				QuestSNO = 0x1C;
				QuestStepUID = 0x20;
				WorldPos = 0x24;
				PlayerCount = 0x30;
				LocalPlayerCount = 0x34;
			}
			else throw new PlatformNotSupportedException();
		}

		public readonly int SizeOf;
		public readonly int IsPlayerValid;
		public readonly int IsStartUpGame;
		public readonly int SceneSNO;
		public readonly int WorldSNO;
		public readonly int ActorSNO;
		public readonly int ActID;
		public readonly int WorldSeed;
		public readonly int QuestSNO;
		public readonly int QuestStepUID;
		public readonly int WorldPos;
		public readonly int PlayerCount;
		public readonly int LocalPlayerCount;
	}

	public struct FastAttribSymbols
	{
		public FastAttribSymbols(Platform platform)
		{
			if (platform == Platform.X86)
			{
				throw new NotImplementedException();
			}
			else if (platform == Platform.X64)
			{
				SizeOf = 0xA0;
				FastAttribGroups = 0x90;
			}
			else throw new PlatformNotSupportedException();
		}

		public readonly int SizeOf;
		public readonly int FastAttribGroups;
	}

	public struct FastAttribGroupSymbols
	{
		public FastAttribGroupSymbols(Platform platform)
		{
			if (platform == Platform.X86)
			{
				throw new NotImplementedException();
			}
			else if (platform == Platform.X64)
			{
				SizeOf = 0x12E8;
				ID = 0x0000;
			}
			else throw new PlatformNotSupportedException();
		}

		public readonly int SizeOf;
		public readonly int ID;
	}

	public struct PlayerDataManagerSymbols
	{
		public PlayerDataManagerSymbols(Platform platform)
		{
			if (platform == Platform.X86)
			{
				throw new NotImplementedException();
			}
			else if (platform == Platform.X64)
			{
				SizeOf = 0x5AB60;
				Items = 0x00000;
			}
			else throw new PlatformNotSupportedException();
		}

		public readonly int SizeOf;
		public readonly int Items;
	}

	public struct PlayerDataSymbols
	{
		public PlayerDataSymbols(Platform platform)
		{
			if (platform == Platform.X86)
			{
				throw new NotImplementedException();
			}
			else if (platform == Platform.X64)
			{
				SizeOf = 0xB560;
				Index = 0x0000;
				ACDID = 0x0004;
				ActorID = 0x0008;
			}
			else throw new PlatformNotSupportedException();
		}

		public readonly int SizeOf;
		public readonly int Index;
		public readonly int ACDID;
		public readonly int ActorID;
	}

	public struct SceneSymbols
	{
		public SceneSymbols(Platform platform)
		{
			if (platform == Platform.X86)
			{
				throw new NotImplementedException();
			}
			else if (platform == Platform.X64)
			{
				SizeOf = 0x7B8;
			}
			else throw new PlatformNotSupportedException();
		}

		public readonly int SizeOf;
	}

	public struct WorldSymbols
	{
		public WorldSymbols(Platform platform)
		{
			if (platform == Platform.X86)
			{
				throw new NotImplementedException();
			}
			else if (platform == Platform.X64)
			{
				SizeOf = 0x98;
			}
			else throw new PlatformNotSupportedException();
		}

		public readonly int SizeOf;
	}

	public struct QuestManagerSymbols
	{
		public QuestManagerSymbols(Platform platform)
		{
			if (platform == Platform.X86)
			{
				throw new NotImplementedException();
			}
			else if (platform == Platform.X64)
			{
				SizeOf = 0x4A0;
				Quests = 0x030;
			}
			else throw new PlatformNotSupportedException();
		}

		public readonly int SizeOf;
		public readonly int Quests;
	}

	public struct QuestSymbols
	{
		public QuestSymbols(Platform platform)
		{
			if (platform == Platform.X86)
			{
				throw new NotImplementedException();
			}
			else if (platform == Platform.X64)
			{
				SizeOf = 0x168;
			}
			else throw new PlatformNotSupportedException();
		}

		public readonly int SizeOf;
	}

	public struct WaypointManagerSymbols
	{
		public WaypointManagerSymbols(Platform platform)
		{
			if (platform == Platform.X86)
			{
				throw new NotImplementedException();
			}
			else if (platform == Platform.X64)
			{
				SizeOf = 0x18;
				Array = 0x00;
				Count = 0x08;
			}
			else throw new PlatformNotSupportedException();
		}

		public readonly int SizeOf;
		public readonly int Array;
		public readonly int Count;
	}

	public struct WaypointSymbols
	{
		public WaypointSymbols(Platform platform)
		{
			if (platform == Platform.X86)
			{
				throw new NotImplementedException();
			}
			else if (platform == Platform.X64)
			{
				SizeOf = 0x2C;
				ActID = 0x00;
				LevelAreaSNO = 0x0C;
				X = 0x24;
				Y = 0x28;
			}
			else throw new PlatformNotSupportedException();
		}

		public readonly int SizeOf;
		public readonly int ActID;
		public readonly int LevelAreaSNO;
		public readonly int X;
		public readonly int Y;
	}

	public struct TrickleManagerSymbols
	{
		public TrickleManagerSymbols(Platform platform)
		{
			if (platform == Platform.X86)
			{
				throw new NotImplementedException();
			}
			else if (platform == Platform.X64)
			{
				SizeOf = 0x10;
				Allocator = 0x00;
				Items = 0x08;
			}
			else throw new PlatformNotSupportedException();
		}

		public readonly int SizeOf;
		public readonly int Allocator;
		public readonly int Items;
	}

	public struct TrickleSymbols
	{
		public TrickleSymbols(Platform platform)
		{
			if (platform == Platform.X86)
			{
				throw new NotImplementedException();
			}
			else if (platform == Platform.X64)
			{
				SizeOf = 0x68;
			}
			else throw new PlatformNotSupportedException();
		}

		public readonly int SizeOf;
	}

	public struct UIManagerSymbols
	{
		public UIManagerSymbols(Platform platform)
		{
			if (platform == Platform.X86)
			{
				throw new NotImplementedException();
			}
			else if (platform == Platform.X64)
			{
				SizeOf = 0x27B8;
			}
			else throw new PlatformNotSupportedException();
		}

		public readonly int SizeOf;
	}

	public struct LevelAreaSymbols
	{
		public LevelAreaSymbols(Platform platform)
		{
			if (platform == Platform.X86)
			{
				throw new NotImplementedException();
			}
			else if (platform == Platform.X64)
			{
				SizeOf = 0x980;
			}
			else throw new PlatformNotSupportedException();
		}

		public readonly int SizeOf;
	}

	public struct PlayerSymbols
	{
		public PlayerSymbols(Platform platform)
		{
			if (platform == Platform.X86)
			{
				throw new NotImplementedException();
			}
			else if (platform == Platform.X64)
			{
				SizeOf = 0xA3C8;
				LocalPlayerIndex = 0x0000;
				LatencySamples = 0xA348;
				FloatingNumbers = 0xA218;
			}
			else throw new PlatformNotSupportedException();
		}

		public readonly int SizeOf;
		public readonly int LocalPlayerIndex;
		public readonly int LatencySamples;
		public readonly int FloatingNumbers;
	}

	public struct AttributeDescriptorSymbols
	{
		public AttributeDescriptorSymbols(Platform platform)
		{
			if (platform == Platform.X86)
			{
				throw new NotImplementedException();
			}
			else if (platform == Platform.X64)
			{
				SizeOf = 0x40;
				ID = 0x00;
				DataType = 0x10;
				Name = 0x28;
				NameLength = 256;
			}
			else throw new PlatformNotSupportedException();
		}

		public readonly int SizeOf;
		public readonly int ID;
		public readonly int DataType;
		public readonly int Name;
		public readonly int NameLength;
	}

	public struct FloatingNumberSymbols
	{
		public FloatingNumberSymbols(Platform platform)
		{
			if (platform == Platform.X86)
			{
				throw new NotImplementedException();
			}
			else if (platform == Platform.X64)
			{
				SizeOf = 0x64;
				WorldPos = 0x04;
				WorldSNO = 0x10;
				Type = 0x5C;
				Value = 0x60;
			}
			else throw new PlatformNotSupportedException();
		}

		public readonly int SizeOf;
		public readonly int WorldPos;
		public readonly int WorldSNO;
		public readonly int Type;
		public readonly int Value;
	}

	public struct TimedEventSymbols
	{
		public TimedEventSymbols(Platform platform)
		{
			if (platform == Platform.X86)
			{
				throw new NotImplementedException();
			}
			else if (platform == Platform.X64)
			{
				SizeOf = 0x0C;
			}
			else throw new PlatformNotSupportedException();
		}

		public readonly int SizeOf;
	}

	public struct MemoryManagerSymbols
	{
		public MemoryManagerSymbols(Platform platform)
		{
			if (platform == Platform.X86)
			{
				SizeOf = 0x38;
				LocalHeap = 0x30;
			}
			else if (platform == Platform.X64)
			{
				throw new NotImplementedException();
			}
			else throw new PlatformNotSupportedException();
		}

		public readonly int SizeOf;
		public readonly int LocalHeap;
	}

	public struct LocalHeapSymbols
	{
		public LocalHeapSymbols(Platform platform)
		{
			if (platform == Platform.X86)
			{
				FirstNode = 0x04;
				TotalSize = 0x08;
				NodeCount = 0x10;
				LastNode = 0x38;
			}
			else if (platform == Platform.X64)
			{
				throw new NotImplementedException();
			}
			else throw new PlatformNotSupportedException();
		}

		public readonly int FirstNode;
		public readonly int TotalSize;
		public readonly int NodeCount;
		public readonly int LastNode;
	}

	public struct HeapNodeSymbols
	{
		public HeapNodeSymbols(Platform platform)
		{
			if (platform == Platform.X86)
			{
				HeaderSize = 0x10;
				SizeAndFlag = 0x0C;
			}
			else if (platform == Platform.X64)
			{
				throw new NotImplementedException();
			}
			else throw new PlatformNotSupportedException();
		}

		public readonly int HeaderSize;
		public readonly int SizeAndFlag;
	}
}
