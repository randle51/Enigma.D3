using System.Runtime.CompilerServices;
using Enigma.D3.Collections;
using Enigma.D3.Memory;
using Enigma.Memory;

namespace Enigma.D3.Sno
{
	[CompilerGenerated]
	public partial class Quest : SerializeMemoryObject
	{
		public const int SizeOf = 0x118; // 280
		
		public SnoHeader x000_Header { get { return Read<SnoHeader>(0x000); } }
		public int x00C_Enum { get { return Read<int>(0x00C); } } // Main Quest = 0, Event = 2, Challenge = 4, Bounty = 5, Horadric Quest = 6
		public int x010 { get { return Read<int>(0x010); } }
		public int x014 { get { return Read<int>(0x014); } }
		public int x018 { get { return Read<int>(0x018); } }
		public int x01C { get { return Read<int>(0x01C); } }
		public int x020 { get { return Read<int>(0x020); } }
		public int x024 { get { return Read<int>(0x024); } }
		public QuestUnassignedStep x028_QuestUnassignedStep { get { return Read<QuestUnassignedStep>(0x028); } }
		public QuestStep[] x050_QuestSteps { get { return Deserialize<QuestStep>(x058_SerializeData); } }
		public SerializeData x058_SerializeData { get { return Read<SerializeData>(0x058); } }
		public QuestCompletionStep[] x060_QuestCompletionSteps { get { return Deserialize<QuestCompletionStep>(x068_SerializeData); } }
		public SerializeData x068_SerializeData { get { return Read<SerializeData>(0x068); } }
		public Sno[] x070_Snos { get { return Read<Sno>(0x070, 18); } }
		public Sno x0B8_WorldsSno { get { return Read<Sno>(0x0B8); } }
		public int x0BC_Enum { get { return Read<int>(0x0BC); } } // - None - = -1, Timed Dungeon = 0, Wave Fight = 1, Horde = 2, Zapper = 3, Goblin Hunt = 4
		public BountyData x0C0_BountyData { get { return Read<BountyData>(0x0C0); } }
		
		[CompilerGenerated]
		public partial class QuestUnassignedStep : SerializeMemoryObject
		{
			public const int SizeOf = 0x28; // 40
			
			public int x00 { get { return Read<int>(0x00); } }
			public int x04 { get { return Read<int>(0x04); } }
			public QuestStepObjectiveSet[] x08_QuestStepObjectiveSets { get { return Deserialize<QuestStepObjectiveSet>(x10_SerializeData); } }
			public SerializeData x10_SerializeData { get { return Read<SerializeData>(0x10); } }
			public QuestStepFailureConditionSet[] x18_QuestStepFailureConditionSets { get { return Deserialize<QuestStepFailureConditionSet>(x20_SerializeData); } }
			public SerializeData x20_SerializeData { get { return Read<SerializeData>(0x20); } }
		}
		
		[CompilerGenerated]
		public partial class QuestStep : SerializeMemoryObject
		{
			public const int SizeOf = 0xA8; // 168
			
			public string x00_Text { get { return DeserializeString(x08_SerializeData); } }
			public SerializeData x08_SerializeData { get { return Read<SerializeData>(0x08); } }
			public int x10 { get { return Read<int>(0x10); } }
			public int x14 { get { return Read<int>(0x14); } }
			public int x18_Enum { get { return Read<int>(0x18); } } // - No Item - = 0, Shared Recipe = 1, Class Recipe = 2, Treasure Class = 3
			public Sno[] x1C_Snos { get { return Read<Sno>(0x1C, 6); } }
			public Sno x34_TreasureClassSno { get { return Read<Sno>(0x34); } }
			public int x38 { get { return Read<int>(0x38); } }
			public int x3C { get { return Read<int>(0x3C); } }
			public int x40_Enum { get { return Read<int>(0x40); } } // - No Item - = 0, Shared Recipe = 1, Class Recipe = 2, Treasure Class = 3
			public Sno[] x44_Snos { get { return Read<Sno>(0x44, 6); } }
			public Sno x5C_TreasureClassSno { get { return Read<Sno>(0x5C); } }
			public int x60 { get { return Read<int>(0x60); } }
			public int x64 { get { return Read<int>(0x64); } }
			public Sno x68_PowerSno { get { return Read<Sno>(0x68); } }
			public Sno[] x6C_Snos { get { return Read<Sno>(0x6C, 2); } }
			public QuestStepObjectiveSet[] x78_QuestStepObjectiveSets { get { return Deserialize<QuestStepObjectiveSet>(x80_SerializeData); } }
			public SerializeData x80_SerializeData { get { return Read<SerializeData>(0x80); } }
			public QuestStepBonusObjectiveSet[] x88_QuestStepBonusObjectiveSets { get { return Deserialize<QuestStepBonusObjectiveSet>(x90_SerializeData); } }
			public SerializeData x90_SerializeData { get { return Read<SerializeData>(0x90); } }
			public QuestStepFailureConditionSet[] x98_QuestStepFailureConditionSets { get { return Deserialize<QuestStepFailureConditionSet>(xA0_SerializeData); } }
			public SerializeData xA0_SerializeData { get { return Read<SerializeData>(0xA0); } }
		}
		
		[CompilerGenerated]
		public partial class QuestCompletionStep : SerializeMemoryObject
		{
			public const int SizeOf = 0x18; // 24
			
			public string x00_Text { get { return DeserializeString(x08_SerializeData); } }
			public SerializeData x08_SerializeData { get { return Read<SerializeData>(0x08); } }
			public int x10 { get { return Read<int>(0x10); } }
			public int x14 { get { return Read<int>(0x14); } }
		}
		
		[CompilerGenerated]
		public partial class BountyData : MemoryObject
		{
			public const int SizeOf = 0x54; // 84
			
			public int x00_Enum { get { return Read<int>(0x00); } } // Invalid = -1, A1 = 0, A2 = 100, A3 = 200, A4 = 300, A5 = 400, OpenWorld = 3000, WeeklyChallenge = 4000, Test = 1000
			public int x04_Enum { get { return Read<int>(0x04); } } // - None - = -1, Kill Unique = 0, Kill Boss = 1, Complete Event = 2, Clear Dungeon = 3, Camps = 4, HQ - Color Orbs = 5, HQ - Hot Cold = 6
			public int x08 { get { return Read<int>(0x08); } }
			public Sno x0C_LevelAreaSno { get { return Read<Sno>(0x0C); } }
			public Sno x10_WorldsSno { get { return Read<Sno>(0x10); } }
			public Sno x14_QuestSno { get { return Read<Sno>(0x14); } }
			public Sno x18_WorldsSno { get { return Read<Sno>(0x18); } }
			public Sno x1C_ActorSno { get { return Read<Sno>(0x1C); } }
			public Sno x20_WorldsSno { get { return Read<Sno>(0x20); } }
			public Sno x24_LevelAreaSno { get { return Read<Sno>(0x24); } }
			public Sno x28_SceneSno { get { return Read<Sno>(0x28); } }
			public Sno x2C_WorldsSno { get { return Read<Sno>(0x2C); } }
			public GameBalanceId x30_LabelsGameBalanceId { get { return Read<GameBalanceId>(0x30); } }
			public Sno x34_AdventureSno { get { return Read<Sno>(0x34); } }
			public Sno x38_WorldsSno { get { return Read<Sno>(0x38); } }
			public Sno x3C_LevelAreaSno { get { return Read<Sno>(0x3C); } }
			public Sno x40_EncounterSno { get { return Read<Sno>(0x40); } }
			public Sno x44_SceneSno { get { return Read<Sno>(0x44); } }
			public Sno x48_WorldsSno { get { return Read<Sno>(0x48); } }
			public GameBalanceId x4C_LabelsGameBalanceId { get { return Read<GameBalanceId>(0x4C); } }
			public Sno x50_54Sno { get { return Read<Sno>(0x50); } }
		}
		
		[CompilerGenerated]
		public partial class QuestStepObjectiveSet : SerializeMemoryObject
		{
			public const int SizeOf = 0x18; // 24
			
			public int x00 { get { return Read<int>(0x00); } }
			public QuestStepObjective[] x08_QuestStepObjectives { get { return Deserialize<QuestStepObjective>(x10_SerializeData); } }
			public SerializeData x10_SerializeData { get { return Read<SerializeData>(0x10); } }
		}
		
		[CompilerGenerated]
		public partial class QuestStepFailureConditionSet : SerializeMemoryObject
		{
			public const int SizeOf = 0x10; // 16
			
			public QuestStepFailureCondition[] x00_QuestStepFailureConditions { get { return Deserialize<QuestStepFailureCondition>(x08_SerializeData); } }
			public SerializeData x08_SerializeData { get { return Read<SerializeData>(0x08); } }
		}
		
		[CompilerGenerated]
		public partial class QuestStepBonusObjectiveSet : SerializeMemoryObject
		{
			public const int SizeOf = 0x28; // 40
			
			public int x00 { get { return Read<int>(0x00); } }
			public int x04 { get { return Read<int>(0x04); } }
			public int x08 { get { return Read<int>(0x08); } }
			public int x0C { get { return Read<int>(0x0C); } }
			public int x10 { get { return Read<int>(0x10); } }
			public QuestStepObjective[] x18_QuestStepObjectives { get { return Deserialize<QuestStepObjective>(x20_SerializeData); } }
			public SerializeData x20_SerializeData { get { return Read<SerializeData>(0x20); } }
		}
		
		[CompilerGenerated]
		public partial class QuestStepObjective : SerializeMemoryObject
		{
			public const int SizeOf = 0x58; // 88
			
			public int x00 { get { return Read<int>(0x00); } }
			public int x04_Enum { get { return Read<int>(0x04); } } // Had Conversation = 0, Possess Item = 1, Kill Monster = 2, Interact With Actor = 3, Enter Level Area = 4, Enter Scene = 5, Enter World = 6, Enter Trigger = 7, Complete Quest = 8, Player Flag Set = 9, Timed Event Expired = 10, Kill Group = 11, Game Flag Set = 12, Event Received = 13, Kill Monster From Group = 14, Kill Monster From Family = 15, Kill Elite Pack In Level Area = 16, Kill Any Monster In Level Area = 17, Kill All Monsters In World = 18, HQ Act Reagents Collected = 19
			public int x08 { get { return Read<int>(0x08); } }
			public int x0C { get { return Read<int>(0x0C); } }
			public SNOName x10_SNOName { get { return Read<SNOName>(0x10); } }
			public SNOName x18_SNOName { get { return Read<SNOName>(0x18); } }
			public GameBalanceId x20_GameBalanceId { get { return Read<GameBalanceId>(0x20); } }
			public GameBalanceId x24_GameBalanceId { get { return Read<GameBalanceId>(0x24); } }
			public string x28_Text { get { return DeserializeString(x30_SerializeData); } }
			public SerializeData x30_SerializeData { get { return Read<SerializeData>(0x30); } }
			public string x38_Text { get { return DeserializeString(x40_SerializeData); } }
			public SerializeData x40_SerializeData { get { return Read<SerializeData>(0x40); } }
			public int x48 { get { return Read<int>(0x48); } }
			public int x4C { get { return Read<int>(0x4C); } }
			public GameBalanceId x50_ItemsGameBalanceId { get { return Read<GameBalanceId>(0x50); } }
		}
		
		[CompilerGenerated]
		public partial class QuestStepFailureCondition : SerializeMemoryObject
		{
			public const int SizeOf = 0x48; // 72
			
			public int x00_Enum { get { return Read<int>(0x00); } } // Monster Died = 0, Player Died = 1, Actor Died = 2, Timed Event Expired = 3, Item Used = 4, Game Flag Set = 5, Player Flag Set = 6, Event Received = 7
			public int x04 { get { return Read<int>(0x04); } }
			public int x08 { get { return Read<int>(0x08); } }
			public SNOName x0C_SNOName { get { return Read<SNOName>(0x0C); } }
			public SNOName x14_SNOName { get { return Read<SNOName>(0x14); } }
			public GameBalanceId x1C_GameBalanceId { get { return Read<GameBalanceId>(0x1C); } }
			public GameBalanceId x20_GameBalanceId { get { return Read<GameBalanceId>(0x20); } }
			public string x28_Text { get { return DeserializeString(x30_SerializeData); } }
			public SerializeData x30_SerializeData { get { return Read<SerializeData>(0x30); } }
			public string x38_Text { get { return DeserializeString(x40_SerializeData); } }
			public SerializeData x40_SerializeData { get { return Read<SerializeData>(0x40); } }
		}
		
		[CompilerGenerated]
		public partial class SNOName : MemoryObject
		{
			public const int SizeOf = 0x08; // 8
			
			public SnoGroup x00_SnoGroup { get { return Read<SnoGroup>(0x00); } }
			public SnoNameHandle x04_SnoNameHandle { get { return Read<SnoNameHandle>(0x04); } }
		}
	}
}
