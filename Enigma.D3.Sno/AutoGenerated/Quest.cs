using System.Runtime.CompilerServices;
using Enigma.D3.Collections;
using Enigma.D3.Memory;

namespace Enigma.D3.Sno
{
	[CompilerGenerated]
	public partial class Quest : SerializeMemoryObject
	{
		// 2.0.6.24641
		public const int SizeOf = 0x110; // 272
		
		public int x00C_Enum { get { return Field<int>(0x00C); } } // Main Quest = 0, Event = 2, Challenge = 4, Bounty = 5
		public int x010 { get { return Field<int>(0x010); } }
		public int x014 { get { return Field<int>(0x014); } }
		public int x018 { get { return Field<int>(0x018); } }
		public int x01C { get { return Field<int>(0x01C); } }
		public int x020 { get { return Field<int>(0x020); } }
		public int x024 { get { return Field<int>(0x024); } }
		public QuestUnassignedStep x028_QuestUnassignedStep { get { return Field<QuestUnassignedStep>(0x028); } }
		public QuestStep[] x050_QuestSteps { get { return Deserialize<QuestStep>(x058_SerializeData); } }
		public SerializeData x058_SerializeData { get { return Field<SerializeData>(0x058); } }
		public QuestCompletionStep[] x060_QuestCompletionSteps { get { return Deserialize<QuestCompletionStep>(x068_SerializeData); } }
		public SerializeData x068_SerializeData { get { return Field<SerializeData>(0x068); } }
		public Sno[] x070_Snos { get { return Field<Sno>(0x070, 18); } }
		public Sno x0B8_WorldsSno { get { return Field<Sno>(0x0B8); } }
		public int x0BC_Enum { get { return Field<int>(0x0BC); } } // - None - = -1, Timed Dungeon = 0, Wave Fight = 1, Horde = 2, Zapper = 3, Goblin Hunt = 4
		public BountyData x0C0_BountyData { get { return Field<BountyData>(0x0C0); } }
		
		[CompilerGenerated]
		public partial class QuestUnassignedStep : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x28; // 40
			
			public int x00 { get { return Field<int>(0x00); } }
			public int x04 { get { return Field<int>(0x04); } }
			public QuestStepObjectiveSet[] x08_QuestStepObjectiveSets { get { return Deserialize<QuestStepObjectiveSet>(x10_SerializeData); } }
			public SerializeData x10_SerializeData { get { return Field<SerializeData>(0x10); } }
			public QuestStepFailureConditionSet[] x18_QuestStepFailureConditionSets { get { return Deserialize<QuestStepFailureConditionSet>(x20_SerializeData); } }
			public SerializeData x20_SerializeData { get { return Field<SerializeData>(0x20); } }
		}
		
		[CompilerGenerated]
		public partial class QuestStep : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0xD8; // 216
			
			public string x00_Text { get { return Field(0x00, 64); } }
			public int x40 { get { return Field<int>(0x40); } }
			public int x44 { get { return Field<int>(0x44); } }
			public int x48_Enum { get { return Field<int>(0x48); } } // - No Item - = 0, Shared Recipe = 1, Class Recipe = 2, Treasure Class = 3
			public Sno[] x4C_Snos { get { return Field<Sno>(0x4C, 6); } }
			public Sno x64_TreasureClassSno { get { return Field<Sno>(0x64); } }
			public int x68 { get { return Field<int>(0x68); } }
			public int x6C { get { return Field<int>(0x6C); } }
			public int x70_Enum { get { return Field<int>(0x70); } } // - No Item - = 0, Shared Recipe = 1, Class Recipe = 2, Treasure Class = 3
			public Sno[] x74_Snos { get { return Field<Sno>(0x74, 6); } }
			public Sno x8C_TreasureClassSno { get { return Field<Sno>(0x8C); } }
			public int x90 { get { return Field<int>(0x90); } }
			public int x94 { get { return Field<int>(0x94); } }
			public Sno x98_PowerSno { get { return Field<Sno>(0x98); } }
			public Sno[] x9C_Snos { get { return Field<Sno>(0x9C, 2); } }
			public QuestStepObjectiveSet[] xA8_QuestStepObjectiveSets { get { return Deserialize<QuestStepObjectiveSet>(xB0_SerializeData); } }
			public SerializeData xB0_SerializeData { get { return Field<SerializeData>(0xB0); } }
			public QuestStepBonusObjectiveSet[] xB8_QuestStepBonusObjectiveSets { get { return Deserialize<QuestStepBonusObjectiveSet>(xC0_SerializeData); } }
			public SerializeData xC0_SerializeData { get { return Field<SerializeData>(0xC0); } }
			public QuestStepFailureConditionSet[] xC8_QuestStepFailureConditionSets { get { return Deserialize<QuestStepFailureConditionSet>(xD0_SerializeData); } }
			public SerializeData xD0_SerializeData { get { return Field<SerializeData>(0xD0); } }
		}
		
		[CompilerGenerated]
		public partial class QuestCompletionStep : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x48; // 72
			
			public string x00_Text { get { return Field(0x00, 64); } }
			public int x40 { get { return Field<int>(0x40); } }
			public int x44 { get { return Field<int>(0x44); } }
		}
		
		[CompilerGenerated]
		public partial class BountyData : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x4C; // 76
			
			public int x00_Enum { get { return Field<int>(0x00); } } // Invalid = -1, A1 = 0, A2 = 100, A3 = 200, A4 = 300, A5 = 400, OpenWorld = 3000, Test = 1000
			public int x04_Enum { get { return Field<int>(0x04); } } // - None - = -1, Kill Unique = 0, Kill Boss = 1, Complete Event = 2, Clear Dungeon = 3
			public Sno x08_LevelAreaSno { get { return Field<Sno>(0x08); } }
			public Sno x0C_WorldsSno { get { return Field<Sno>(0x0C); } }
			public Sno x10_QuestSno { get { return Field<Sno>(0x10); } }
			public Sno x14_WorldsSno { get { return Field<Sno>(0x14); } }
			public Sno x18_ActorSno { get { return Field<Sno>(0x18); } }
			public Sno x1C_WorldsSno { get { return Field<Sno>(0x1C); } }
			public Sno x20_LevelAreaSno { get { return Field<Sno>(0x20); } }
			public Sno x24_SceneSno { get { return Field<Sno>(0x24); } }
			public Sno x28_WorldsSno { get { return Field<Sno>(0x28); } }
			public GameBalanceId x2C_LabelsGameBalanceId { get { return Field<GameBalanceId>(0x2C); } }
			public Sno x30_AdventureSno { get { return Field<Sno>(0x30); } }
			public Sno x34_WorldsSno { get { return Field<Sno>(0x34); } }
			public Sno x38_LevelAreaSno { get { return Field<Sno>(0x38); } }
			public Sno x3C_EncounterSno { get { return Field<Sno>(0x3C); } }
			public Sno x40_SceneSno { get { return Field<Sno>(0x40); } }
			public Sno x44_WorldsSno { get { return Field<Sno>(0x44); } }
			public GameBalanceId x48_LabelsGameBalanceId { get { return Field<GameBalanceId>(0x48); } }
		}
		
		[CompilerGenerated]
		public partial class QuestStepObjectiveSet : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x18; // 24
			
			public int x00 { get { return Field<int>(0x00); } }
			public QuestStepObjective[] x08_QuestStepObjectives { get { return Deserialize<QuestStepObjective>(x10_SerializeData); } }
			public SerializeData x10_SerializeData { get { return Field<SerializeData>(0x10); } }
		}
		
		[CompilerGenerated]
		public partial class QuestStepFailureConditionSet : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x10; // 16
			
			public QuestStepFailureCondition[] x00_QuestStepFailureConditions { get { return Deserialize<QuestStepFailureCondition>(x08_SerializeData); } }
			public SerializeData x08_SerializeData { get { return Field<SerializeData>(0x08); } }
		}
		
		[CompilerGenerated]
		public partial class QuestStepBonusObjectiveSet : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x28; // 40
			
			public int x00 { get { return Field<int>(0x00); } }
			public int x04 { get { return Field<int>(0x04); } }
			public int x08 { get { return Field<int>(0x08); } }
			public int x0C { get { return Field<int>(0x0C); } }
			public int x10 { get { return Field<int>(0x10); } }
			public QuestStepObjective[] x18_QuestStepObjectives { get { return Deserialize<QuestStepObjective>(x20_SerializeData); } }
			public SerializeData x20_SerializeData { get { return Field<SerializeData>(0x20); } }
		}
		
		[CompilerGenerated]
		public partial class QuestStepObjective : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x234; // 564
			
			public int x000 { get { return Field<int>(0x000); } }
			public int x004_Enum { get { return Field<int>(0x004); } } // Had Conversation = 0, Possess Item = 1, Kill Monster = 2, Interact With Actor = 3, Enter Level Area = 4, Enter Scene = 5, Enter World = 6, Enter Trigger = 7, Complete Quest = 8, Player Flag Set = 9, Timed Event Expired = 10, Kill Group = 11, Game Flag Set = 12, Event Received = 13, Kill Monster From Group = 14, Kill Monster From Family = 15, Kill Elite Pack In Level Area = 16, Kill Any Monster In Level Area = 17, Kill All Monsters In World = 18
			public int x008 { get { return Field<int>(0x008); } }
			public int x00C { get { return Field<int>(0x00C); } }
			public SNOName x010_SNOName { get { return Field<SNOName>(0x010); } }
			public SNOName x018_SNOName { get { return Field<SNOName>(0x018); } }
			public GameBalanceId x020_GameBalanceId { get { return Field<GameBalanceId>(0x020); } }
			public GameBalanceId x024_GameBalanceId { get { return Field<GameBalanceId>(0x024); } }
			public string x028_Text { get { return Field(0x028, 256); } }
			public string x128_Text { get { return Field(0x128, 256); } }
			public int x228 { get { return Field<int>(0x228); } }
			public int x22C { get { return Field<int>(0x22C); } }
			public GameBalanceId x230_ItemsGameBalanceId { get { return Field<GameBalanceId>(0x230); } }
		}
		
		[CompilerGenerated]
		public partial class QuestStepFailureCondition : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x224; // 548
			
			public int x000_Enum { get { return Field<int>(0x000); } } // Monster Died = 0, Player Died = 1, Actor Died = 2, Timed Event Expired = 3, Item Used = 4, Game Flag Set = 5, Player Flag Set = 6, Event Received = 7
			public int x004 { get { return Field<int>(0x004); } }
			public int x008 { get { return Field<int>(0x008); } }
			public SNOName x00C_SNOName { get { return Field<SNOName>(0x00C); } }
			public SNOName x014_SNOName { get { return Field<SNOName>(0x014); } }
			public GameBalanceId x01C_GameBalanceId { get { return Field<GameBalanceId>(0x01C); } }
			public GameBalanceId x020_GameBalanceId { get { return Field<GameBalanceId>(0x020); } }
			public string x024_Text { get { return Field(0x024, 256); } }
			public string x124_Text { get { return Field(0x124, 256); } }
		}
		
		[CompilerGenerated]
		public partial class SNOName : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x8; // 8
			
			public SnoGroup x00_SnoGroup { get { return Field<SnoGroup>(0x00); } }
			public SnoNameHandle x04_SnoNameHandle { get { return Field<SnoNameHandle>(0x04); } }
		}
	}
}
