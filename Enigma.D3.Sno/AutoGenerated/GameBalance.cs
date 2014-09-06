using System.Runtime.CompilerServices;
using Enigma.D3.Collections;
using Enigma.D3.Memory;
using Enigma.Memory;

namespace Enigma.D3.Sno
{
	[CompilerGenerated]
	public partial class GameBalance : SerializeMemoryObject
	{
		// 2.1.0.26451
		public const int SizeOf = 0x268; // 616
		
		public int x00C { get { return Read<int>(0x00C); } }
		public int x010 { get { return Read<int>(0x010); } }
		public int x014 { get { return Read<int>(0x014); } }
		public ItemTypes x018_ItemTypes { get { return Read<ItemTypes>(0x018); } }
		public Items x028_Items { get { return Read<Items>(0x028); } }
		public ExperienceTable x038_ExperienceTable { get { return Read<ExperienceTable>(0x038); } }
		public ExperienceTableAlt x048_ExperienceTableAlt { get { return Read<ExperienceTableAlt>(0x048); } }
		public HelpCodes x058_HelpCodes { get { return Read<HelpCodes>(0x058); } }
		public MonsterLevelTable x068_MonsterLevelTable { get { return Read<MonsterLevelTable>(0x068); } }
		public AffixTable x078_AffixTable { get { return Read<AffixTable>(0x078); } }
		public Heros x088_Heros { get { return Read<Heros>(0x088); } }
		public MovementStyles x098_MovementStyles { get { return Read<MovementStyles>(0x098); } }
		public Labels x0A8_Labels { get { return Read<Labels>(0x0A8); } }
		public LootDistributionTable x0B8_LootDistributionTable { get { return Read<LootDistributionTable>(0x0B8); } }
		public RareItemNamesTable x0C8_RareItemNamesTable { get { return Read<RareItemNamesTable>(0x0C8); } }
		public MonsterAffixesTable x0D8_MonsterAffixesTable { get { return Read<MonsterAffixesTable>(0x0D8); } }
		public RareMonsterNamesTable x0E8_RareMonsterNamesTable { get { return Read<RareMonsterNamesTable>(0x0E8); } }
		public SocketedEffectsTable x0F8_SocketedEffectsTable { get { return Read<SocketedEffectsTable>(0x0F8); } }
		public ItemEnchantmentTable x108_ItemEnchantmentTable { get { return Read<ItemEnchantmentTable>(0x108); } }
		public ItemDropTable x118_ItemDropTable { get { return Read<ItemDropTable>(0x118); } }
		public ItemLevelModTable x128_ItemLevelModTable { get { return Read<ItemLevelModTable>(0x128); } }
		public QualityClassTable x138_QualityClassTable { get { return Read<QualityClassTable>(0x138); } }
		public HandicapLevelTable x148_HandicapLevelTable { get { return Read<HandicapLevelTable>(0x148); } }
		public ItemSalvageLevelTable x158_ItemSalvageLevelTable { get { return Read<ItemSalvageLevelTable>(0x158); } }
		public Hirelings x168_Hirelings { get { return Read<Hirelings>(0x168); } }
		public SetItemBonusTable x178_SetItemBonusTable { get { return Read<SetItemBonusTable>(0x178); } }
		public EliteModifiers x188_EliteModifiers { get { return Read<EliteModifiers>(0x188); } }
		public ItemTiers x198_ItemTiers { get { return Read<ItemTiers>(0x198); } }
		public PowerFormulaTable x1A8_PowerFormulaTable { get { return Read<PowerFormulaTable>(0x1A8); } }
		public RecipesTable x1B8_RecipesTable { get { return Read<RecipesTable>(0x1B8); } }
		public ScriptedAchievementEventsTable x1C8_ScriptedAchievementEventsTable { get { return Read<ScriptedAchievementEventsTable>(0x1C8); } }
		public ItemDurabilityCostScalarsTable x1D8_ItemDurabilityCostScalarsTable { get { return Read<ItemDurabilityCostScalarsTable>(0x1D8); } }
		public LootRunQuestTierTable x1E8_LootRunQuestTierTable { get { return Read<LootRunQuestTierTable>(0x1E8); } }
		public ParagonBonusesTable x1F8_ParagonBonusesTable { get { return Read<ParagonBonusesTable>(0x1F8); } }
		public MadeToOrderTypesTable x208_MadeToOrderTypesTable { get { return Read<MadeToOrderTypesTable>(0x208); } }
		public MadeToOrderAffixFoldersTable x218_MadeToOrderAffixFoldersTable { get { return Read<MadeToOrderAffixFoldersTable>(0x218); } }
		public DevilsHandRedeemableSetTable x228_DevilsHandRedeemableSetTable { get { return Read<DevilsHandRedeemableSetTable>(0x228); } }
		public LegacyItemConversionTable x238_LegacyItemConversionTable { get { return Read<LegacyItemConversionTable>(0x238); } }
		public EnchantItemAffixUseCountCostScalarsTable x248_EnchantItemAffixUseCountCostScalarsTable { get { return Read<EnchantItemAffixUseCountCostScalarsTable>(0x248); } }
		public TieredLootRunLevelTable x258_TieredLootRunLevelTable { get { return Read<TieredLootRunLevelTable>(0x258); } }
		
		[CompilerGenerated]
		public partial class ItemTypes : SerializeMemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x10; // 16
			
			public SerializeData x00_SerializeData { get { return Read<SerializeData>(0x00); } }
			public ItemType[] x08_ItemTypes { get { return Deserialize<ItemType>(x00_SerializeData); } }
		}
		
		[CompilerGenerated]
		public partial class Items : SerializeMemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x10; // 16
			
			public SerializeData x00_SerializeData { get { return Read<SerializeData>(0x00); } }
			public Item[] x08_Items { get { return Deserialize<Item>(x00_SerializeData); } }
		}
		
		[CompilerGenerated]
		public partial class ExperienceTable : SerializeMemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x10; // 16
			
			public SerializeData x00_SerializeData { get { return Read<SerializeData>(0x00); } }
			public ExperienceLevel[] x08_ExperienceLevels { get { return Deserialize<ExperienceLevel>(x00_SerializeData); } }
		}
		
		[CompilerGenerated]
		public partial class ExperienceTableAlt : SerializeMemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x10; // 16
			
			public SerializeData x00_SerializeData { get { return Read<SerializeData>(0x00); } }
			public ExperienceLevelAlt[] x08_ExperienceLevelAlts { get { return Deserialize<ExperienceLevelAlt>(x00_SerializeData); } }
		}
		
		[CompilerGenerated]
		public partial class HelpCodes : SerializeMemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x10; // 16
			
			public SerializeData x00_SerializeData { get { return Read<SerializeData>(0x00); } }
			public HelpCodes[] x08_HelpCodes { get { return Deserialize<HelpCodes>(x00_SerializeData); } }
		}
		
		[CompilerGenerated]
		public partial class MonsterLevelTable : SerializeMemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x10; // 16
			
			public SerializeData x00_SerializeData { get { return Read<SerializeData>(0x00); } }
			public MonsterLevelDefinition[] x08_MonsterLevelDefinitions { get { return Deserialize<MonsterLevelDefinition>(x00_SerializeData); } }
		}
		
		[CompilerGenerated]
		public partial class AffixTable : SerializeMemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x10; // 16
			
			public SerializeData x00_SerializeData { get { return Read<SerializeData>(0x00); } }
			public AffixTableEntry[] x08_AffixTableEntries { get { return Deserialize<AffixTableEntry>(x00_SerializeData); } }
		}
		
		[CompilerGenerated]
		public partial class Heros : SerializeMemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x10; // 16
			
			public SerializeData x00_SerializeData { get { return Read<SerializeData>(0x00); } }
			public HeroData[] x08_HeroDatas { get { return Deserialize<HeroData>(x00_SerializeData); } }
		}
		
		[CompilerGenerated]
		public partial class MovementStyles : SerializeMemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x10; // 16
			
			public SerializeData x00_SerializeData { get { return Read<SerializeData>(0x00); } }
			public MovementStyleDefinition[] x08_MovementStyleDefinitions { get { return Deserialize<MovementStyleDefinition>(x00_SerializeData); } }
		}
		
		[CompilerGenerated]
		public partial class Labels : SerializeMemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x10; // 16
			
			public SerializeData x00_SerializeData { get { return Read<SerializeData>(0x00); } }
			public LabelGBID[] x08_LabelGBIDs { get { return Deserialize<LabelGBID>(x00_SerializeData); } }
		}
		
		[CompilerGenerated]
		public partial class LootDistributionTable : SerializeMemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x10; // 16
			
			public SerializeData x00_SerializeData { get { return Read<SerializeData>(0x00); } }
			public LootDistribution[] x08_LootDistributions { get { return Deserialize<LootDistribution>(x00_SerializeData); } }
		}
		
		[CompilerGenerated]
		public partial class RareItemNamesTable : SerializeMemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x10; // 16
			
			public SerializeData x00_SerializeData { get { return Read<SerializeData>(0x00); } }
			public RareItemNamesEntry[] x08_RareItemNamesEntries { get { return Deserialize<RareItemNamesEntry>(x00_SerializeData); } }
		}
		
		[CompilerGenerated]
		public partial class MonsterAffixesTable : SerializeMemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x10; // 16
			
			public SerializeData x00_SerializeData { get { return Read<SerializeData>(0x00); } }
			public MonsterAffixesEntry[] x08_MonsterAffixesEntries { get { return Deserialize<MonsterAffixesEntry>(x00_SerializeData); } }
		}
		
		[CompilerGenerated]
		public partial class RareMonsterNamesTable : SerializeMemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x10; // 16
			
			public SerializeData x00_SerializeData { get { return Read<SerializeData>(0x00); } }
			public RareMonsterNamesEntry[] x08_RareMonsterNamesEntries { get { return Deserialize<RareMonsterNamesEntry>(x00_SerializeData); } }
		}
		
		[CompilerGenerated]
		public partial class SocketedEffectsTable : SerializeMemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x10; // 16
			
			public SerializeData x00_SerializeData { get { return Read<SerializeData>(0x00); } }
			public SocketedEffectsTableEntry[] x08_SocketedEffectsTableEntries { get { return Deserialize<SocketedEffectsTableEntry>(x00_SerializeData); } }
		}
		
		[CompilerGenerated]
		public partial class ItemEnchantmentTable : SerializeMemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x10; // 16
			
			public SerializeData x00_SerializeData { get { return Read<SerializeData>(0x00); } }
			public ItemEnchantment[] x08_ItemEnchantments { get { return Deserialize<ItemEnchantment>(x00_SerializeData); } }
		}
		
		[CompilerGenerated]
		public partial class ItemDropTable : SerializeMemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x10; // 16
			
			public SerializeData x00_SerializeData { get { return Read<SerializeData>(0x00); } }
			public ItemDropTableEntry[] x08_ItemDropTableEntries { get { return Deserialize<ItemDropTableEntry>(x00_SerializeData); } }
		}
		
		[CompilerGenerated]
		public partial class ItemLevelModTable : SerializeMemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x10; // 16
			
			public SerializeData x00_SerializeData { get { return Read<SerializeData>(0x00); } }
			public LootDistribution[] x08_LootDistributions { get { return Deserialize<LootDistribution>(x00_SerializeData); } }
		}
		
		[CompilerGenerated]
		public partial class QualityClassTable : SerializeMemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x10; // 16
			
			public SerializeData x00_SerializeData { get { return Read<SerializeData>(0x00); } }
			public QualityClass[] x08_QualityClass { get { return Deserialize<QualityClass>(x00_SerializeData); } }
		}
		
		[CompilerGenerated]
		public partial class HandicapLevelTable : SerializeMemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x10; // 16
			
			public SerializeData x00_SerializeData { get { return Read<SerializeData>(0x00); } }
			public HandicapLevel[] x08_HandicapLevels { get { return Deserialize<HandicapLevel>(x00_SerializeData); } }
		}
		
		[CompilerGenerated]
		public partial class ItemSalvageLevelTable : SerializeMemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x10; // 16
			
			public SerializeData x00_SerializeData { get { return Read<SerializeData>(0x00); } }
			public ItemSalvageLevel[] x08_ItemSalvageLevels { get { return Deserialize<ItemSalvageLevel>(x00_SerializeData); } }
		}
		
		[CompilerGenerated]
		public partial class Hirelings : SerializeMemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x10; // 16
			
			public SerializeData x00_SerializeData { get { return Read<SerializeData>(0x00); } }
			public HirelingEntry[] x08_HirelingEntries { get { return Deserialize<HirelingEntry>(x00_SerializeData); } }
		}
		
		[CompilerGenerated]
		public partial class SetItemBonusTable : SerializeMemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x10; // 16
			
			public SerializeData x00_SerializeData { get { return Read<SerializeData>(0x00); } }
			public SetItemBonusTableEntry[] x08_SetItemBonusTableEntries { get { return Deserialize<SetItemBonusTableEntry>(x00_SerializeData); } }
		}
		
		[CompilerGenerated]
		public partial class EliteModifiers : SerializeMemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x10; // 16
			
			public SerializeData x00_SerializeData { get { return Read<SerializeData>(0x00); } }
			public EliteModifierData[] x08_EliteModifierDatas { get { return Deserialize<EliteModifierData>(x00_SerializeData); } }
		}
		
		[CompilerGenerated]
		public partial class ItemTiers : SerializeMemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x10; // 16
			
			public SerializeData x00_SerializeData { get { return Read<SerializeData>(0x00); } }
			public ItemTierData[] x08_ItemTierDatas { get { return Deserialize<ItemTierData>(x00_SerializeData); } }
		}
		
		[CompilerGenerated]
		public partial class PowerFormulaTable : SerializeMemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x10; // 16
			
			public SerializeData x00_SerializeData { get { return Read<SerializeData>(0x00); } }
			public PowerFormulaTableEntry[] x08_PowerFormulaTableEntries { get { return Deserialize<PowerFormulaTableEntry>(x00_SerializeData); } }
		}
		
		[CompilerGenerated]
		public partial class RecipesTable : SerializeMemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x10; // 16
			
			public SerializeData x00_SerializeData { get { return Read<SerializeData>(0x00); } }
			public RecipeEntry[] x08_RecipeEntries { get { return Deserialize<RecipeEntry>(x00_SerializeData); } }
		}
		
		[CompilerGenerated]
		public partial class ScriptedAchievementEventsTable : SerializeMemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x10; // 16
			
			public SerializeData x00_SerializeData { get { return Read<SerializeData>(0x00); } }
			public ScriptedAchievementEvent[] x08_ScriptedAchievementEvents { get { return Deserialize<ScriptedAchievementEvent>(x00_SerializeData); } }
		}
		
		[CompilerGenerated]
		public partial class ItemDurabilityCostScalarsTable : SerializeMemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x10; // 16
			
			public SerializeData x00_SerializeData { get { return Read<SerializeData>(0x00); } }
			public ItemDurabilityCostScalar[] x08_ItemDurabilityCostScalars { get { return Deserialize<ItemDurabilityCostScalar>(x00_SerializeData); } }
		}
		
		[CompilerGenerated]
		public partial class LootRunQuestTierTable : SerializeMemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x10; // 16
			
			public SerializeData x00_SerializeData { get { return Read<SerializeData>(0x00); } }
			public LootRunQuestTierEntry[] x08_LootRunQuestTierEntries { get { return Deserialize<LootRunQuestTierEntry>(x00_SerializeData); } }
		}
		
		[CompilerGenerated]
		public partial class ParagonBonusesTable : SerializeMemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x10; // 16
			
			public SerializeData x00_SerializeData { get { return Read<SerializeData>(0x00); } }
			public ParagonBonus[] x08_ParagonBonus { get { return Deserialize<ParagonBonus>(x00_SerializeData); } }
		}
		
		[CompilerGenerated]
		public partial class MadeToOrderTypesTable : SerializeMemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x10; // 16
			
			public SerializeData x00_SerializeData { get { return Read<SerializeData>(0x00); } }
			public MadeToOrderTypesEntry[] x08_MadeToOrderTypesEntries { get { return Deserialize<MadeToOrderTypesEntry>(x00_SerializeData); } }
		}
		
		[CompilerGenerated]
		public partial class MadeToOrderAffixFoldersTable : SerializeMemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x10; // 16
			
			public SerializeData x00_SerializeData { get { return Read<SerializeData>(0x00); } }
			public MadeToOrderAffixFoldersEntry[] x08_MadeToOrderAffixFoldersEntries { get { return Deserialize<MadeToOrderAffixFoldersEntry>(x00_SerializeData); } }
		}
		
		[CompilerGenerated]
		public partial class DevilsHandRedeemableSetTable : SerializeMemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x10; // 16
			
			public SerializeData x00_SerializeData { get { return Read<SerializeData>(0x00); } }
			public DevilsHandRedeemableSet[] x08_DevilsHandRedeemableSets { get { return Deserialize<DevilsHandRedeemableSet>(x00_SerializeData); } }
		}
		
		[CompilerGenerated]
		public partial class LegacyItemConversionTable : SerializeMemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x10; // 16
			
			public SerializeData x00_SerializeData { get { return Read<SerializeData>(0x00); } }
			public LegacyItemConversion[] x08_LegacyItemConversions { get { return Deserialize<LegacyItemConversion>(x00_SerializeData); } }
		}
		
		[CompilerGenerated]
		public partial class EnchantItemAffixUseCountCostScalarsTable : SerializeMemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x10; // 16
			
			public SerializeData x00_SerializeData { get { return Read<SerializeData>(0x00); } }
			public EnchantItemAffixUseCountCostScalar[] x08_EnchantItemAffixUseCountCostScalars { get { return Deserialize<EnchantItemAffixUseCountCostScalar>(x00_SerializeData); } }
		}
		
		[CompilerGenerated]
		public partial class TieredLootRunLevelTable : SerializeMemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x10; // 16
			
			public SerializeData x00_SerializeData { get { return Read<SerializeData>(0x00); } }
			public TieredLootRunLevel[] x08_TieredLootRunLevels { get { return Deserialize<TieredLootRunLevel>(x00_SerializeData); } }
		}
		
		[CompilerGenerated]
		public partial class ItemType : MemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x150; // 336
			
			public string x000_Text { get { return ReadString(0x000, 256); } }
			public int x100 { get { return Read<int>(0x100); } }
			public int x104 { get { return Read<int>(0x104); } }
			public GameBalanceId x108_ItemTypesGameBalanceId { get { return Read<GameBalanceId>(0x108); } }
			public int x10C { get { return Read<int>(0x10C); } }
			public int x110 { get { return Read<int>(0x110); } }
			public int x114 { get { return Read<int>(0x114); } }
			public bool x118_Bit0 { get { return (Read<int>(0x118) & 0x00000001) != 0; } }
			public bool x118_Bit1 { get { return (Read<int>(0x118) & 0x00000002) != 0; } }
			public bool x118_Bit3 { get { return (Read<int>(0x118) & 0x00000008) != 0; } }
			public bool x118_Bit6 { get { return (Read<int>(0x118) & 0x00000040) != 0; } }
			public bool x118_Bit7 { get { return (Read<int>(0x118) & 0x00000080) != 0; } }
			public bool x118_Bit8 { get { return (Read<int>(0x118) & 0x00000100) != 0; } }
			public bool x118_Bit9 { get { return (Read<int>(0x118) & 0x00000200) != 0; } }
			public bool x118_Bit10 { get { return (Read<int>(0x118) & 0x00000400) != 0; } }
			public bool x118_Bit11 { get { return (Read<int>(0x118) & 0x00000800) != 0; } }
			public bool x118_Bit12 { get { return (Read<int>(0x118) & 0x00001000) != 0; } }
			public bool x118_Bit13 { get { return (Read<int>(0x118) & 0x00002000) != 0; } }
			public bool x118_Bit14 { get { return (Read<int>(0x118) & 0x00004000) != 0; } }
			public bool x118_Bit15 { get { return (Read<int>(0x118) & 0x00008000) != 0; } }
			public bool x118_Bit16 { get { return (Read<int>(0x118) & 0x00010000) != 0; } }
			public bool x118_Bit17 { get { return (Read<int>(0x118) & 0x00020000) != 0; } }
			public bool x118_Bit18 { get { return (Read<int>(0x118) & 0x00040000) != 0; } }
			public int x11C_Enum { get { return Read<int>(0x11C); } } // Player:Backpack = 0, Player:Head = 1, Player:Torso = 2, Player:RightHand = 3, Player:LeftHand = 4, Player:Hands = 5, Player:Waist = 6, Player:Feet = 7, Player:Shoulders = 8, Player:Legs = 9, Player:Bracers = 10, Player:LeftFinger = 12, Player:RightFinger = 11, Player:Neck = 13, Merchant = 18, Pet:RightHand = 21, Pet:LeftHand = 22, Pet:Special = 23, Pet:LeftFinger = 26, Pet:RightFinger = 25, Pet:Neck = 24
			public int x120_Enum { get { return Read<int>(0x120); } } // Player:Backpack = 0, Player:Head = 1, Player:Torso = 2, Player:RightHand = 3, Player:LeftHand = 4, Player:Hands = 5, Player:Waist = 6, Player:Feet = 7, Player:Shoulders = 8, Player:Legs = 9, Player:Bracers = 10, Player:LeftFinger = 12, Player:RightFinger = 11, Player:Neck = 13, Merchant = 18, Pet:RightHand = 21, Pet:LeftHand = 22, Pet:Special = 23, Pet:LeftFinger = 26, Pet:RightFinger = 25, Pet:Neck = 24
			public int x124_Enum { get { return Read<int>(0x124); } } // Player:Backpack = 0, Player:Head = 1, Player:Torso = 2, Player:RightHand = 3, Player:LeftHand = 4, Player:Hands = 5, Player:Waist = 6, Player:Feet = 7, Player:Shoulders = 8, Player:Legs = 9, Player:Bracers = 10, Player:LeftFinger = 12, Player:RightFinger = 11, Player:Neck = 13, Merchant = 18, Pet:RightHand = 21, Pet:LeftHand = 22, Pet:Special = 23, Pet:LeftFinger = 26, Pet:RightFinger = 25, Pet:Neck = 24
			public int x128_Enum { get { return Read<int>(0x128); } } // Player:Backpack = 0, Player:Head = 1, Player:Torso = 2, Player:RightHand = 3, Player:LeftHand = 4, Player:Hands = 5, Player:Waist = 6, Player:Feet = 7, Player:Shoulders = 8, Player:Legs = 9, Player:Bracers = 10, Player:LeftFinger = 12, Player:RightFinger = 11, Player:Neck = 13, Merchant = 18, Pet:RightHand = 21, Pet:LeftHand = 22, Pet:Special = 23, Pet:LeftFinger = 26, Pet:RightFinger = 25, Pet:Neck = 24
			public GameBalanceId x12C_AffixListGameBalanceId { get { return Read<GameBalanceId>(0x12C); } }
			public GameBalanceId x130_AffixListGameBalanceId { get { return Read<GameBalanceId>(0x130); } }
			public GameBalanceId x134_AffixListGameBalanceId { get { return Read<GameBalanceId>(0x134); } }
			public GameBalanceId x138_47GameBalanceId { get { return Read<GameBalanceId>(0x138); } }
			public int[] x13C_int { get { return Read<int>(0x13C, 4); } }
			public int x14C { get { return Read<int>(0x14C); } }
		}
		
		[CompilerGenerated]
		public partial class Item : SerializeMemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x528; // 1320
			
			public string x000_Text { get { return ReadString(0x000, 256); } }
			public int x100 { get { return Read<int>(0x100); } }
			public int x104 { get { return Read<int>(0x104); } }
			public Sno x108_ActorSno { get { return Read<Sno>(0x108); } }
			public GameBalanceId x10C_ItemTypesGameBalanceId { get { return Read<GameBalanceId>(0x10C); } }
			public bool x110_Bit0 { get { return (Read<int>(0x110) & 0x00000001) != 0; } }
			public bool x110_Bit1 { get { return (Read<int>(0x110) & 0x00000002) != 0; } }
			public bool x110_Bit2 { get { return (Read<int>(0x110) & 0x00000004) != 0; } }
			public bool x110_Bit3 { get { return (Read<int>(0x110) & 0x00000008) != 0; } }
			public bool x110_Bit4 { get { return (Read<int>(0x110) & 0x00000010) != 0; } }
			public bool x110_Bit5 { get { return (Read<int>(0x110) & 0x00000020) != 0; } }
			public bool x110_Bit6 { get { return (Read<int>(0x110) & 0x00000040) != 0; } }
			public bool x110_Bit7 { get { return (Read<int>(0x110) & 0x00000080) != 0; } }
			public bool x110_Bit8 { get { return (Read<int>(0x110) & 0x00000100) != 0; } }
			public bool x110_Bit9 { get { return (Read<int>(0x110) & 0x00000200) != 0; } }
			public bool x110_Bit10 { get { return (Read<int>(0x110) & 0x00000400) != 0; } }
			public bool x110_Bit11 { get { return (Read<int>(0x110) & 0x00000800) != 0; } }
			public bool x110_Bit12 { get { return (Read<int>(0x110) & 0x00001000) != 0; } }
			public bool x110_Bit13 { get { return (Read<int>(0x110) & 0x00002000) != 0; } }
			public bool x110_Bit14 { get { return (Read<int>(0x110) & 0x00004000) != 0; } }
			public bool x110_Bit15 { get { return (Read<int>(0x110) & 0x00008000) != 0; } }
			public bool x110_Bit16 { get { return (Read<int>(0x110) & 0x00010000) != 0; } }
			public bool x110_Bit17 { get { return (Read<int>(0x110) & 0x00020000) != 0; } }
			public bool x110_Bit18 { get { return (Read<int>(0x110) & 0x00040000) != 0; } }
			public bool x110_Bit19 { get { return (Read<int>(0x110) & 0x00080000) != 0; } }
			public bool x110_Bit20 { get { return (Read<int>(0x110) & 0x00100000) != 0; } }
			public bool x110_Bit21 { get { return (Read<int>(0x110) & 0x00200000) != 0; } }
			public bool x110_Bit22 { get { return (Read<int>(0x110) & 0x00400000) != 0; } }
			public bool x110_Bit23 { get { return (Read<int>(0x110) & 0x00800000) != 0; } }
			public int x114 { get { return Read<int>(0x114); } }
			public int x118 { get { return Read<int>(0x118); } }
			public int x11C_Enum { get { return Read<int>(0x11C); } } // Invalid = -1, A1 = 0, A2 = 100, A3 = 200, A4 = 300, A5 = 400, OpenWorld = 3000, Test = 1000
			public int x120 { get { return Read<int>(0x120); } }
			public int x124 { get { return Read<int>(0x124); } }
			public int x128 { get { return Read<int>(0x128); } }
			public int x12C { get { return Read<int>(0x12C); } }
			public int x130 { get { return Read<int>(0x130); } }
			public int x134 { get { return Read<int>(0x134); } }
			public int x138 { get { return Read<int>(0x138); } }
			public int x13C { get { return Read<int>(0x13C); } }
			public int x140 { get { return Read<int>(0x140); } }
			public int x144 { get { return Read<int>(0x144); } }
			public int x148 { get { return Read<int>(0x148); } }
			public int x14C { get { return Read<int>(0x14C); } }
			public int x150 { get { return Read<int>(0x150); } }
			public int x154 { get { return Read<int>(0x154); } }
			public int x158 { get { return Read<int>(0x158); } }
			public int x15C { get { return Read<int>(0x15C); } }
			public int x160 { get { return Read<int>(0x160); } }
			public int x164 { get { return Read<int>(0x164); } }
			public int x168 { get { return Read<int>(0x168); } }
			public int x16C { get { return Read<int>(0x16C); } }
			public int x170 { get { return Read<int>(0x170); } }
			public GameBalanceId x174_ItemsGameBalanceId { get { return Read<GameBalanceId>(0x174); } }
			public GameBalanceId x178_SetItemBonusesGameBalanceId { get { return Read<GameBalanceId>(0x178); } }
			public Sno x17C_TreasureClassSno { get { return Read<Sno>(0x17C); } }
			public Sno x180_TreasureClassSno { get { return Read<Sno>(0x180); } }
			public Sno x184_TreasureClassSno { get { return Read<Sno>(0x184); } }
			public Sno x188_TreasureClassSno { get { return Read<Sno>(0x188); } }
			public Sno x18C_StringListSno { get { return Read<Sno>(0x18C); } }
			public Sno x190_StringListSno { get { return Read<Sno>(0x190); } }
			public int[] x194_int { get { return Read<int>(0x194, 4); } }
			public float x1A4 { get { return Read<float>(0x1A4); } }
			public float x1A8 { get { return Read<float>(0x1A8); } }
			public float x1AC { get { return Read<float>(0x1AC); } }
			public float x1B0 { get { return Read<float>(0x1B0); } }
			public float x1B4 { get { return Read<float>(0x1B4); } }
			public float x1B8 { get { return Read<float>(0x1B8); } }
			public float x1BC { get { return Read<float>(0x1BC); } }
			public Sno x1C0_PowerSno { get { return Read<Sno>(0x1C0); } }
			public int x1C4 { get { return Read<int>(0x1C4); } }
			public Sno x1C8_PowerSno { get { return Read<Sno>(0x1C8); } }
			public int x1CC { get { return Read<int>(0x1CC); } }
			public Sno x1D0_PowerSno { get { return Read<Sno>(0x1D0); } }
			public int x1D4 { get { return Read<int>(0x1D4); } }
			public Sno x1D8_PowerSno { get { return Read<Sno>(0x1D8); } }
			public int x1DC { get { return Read<int>(0x1DC); } }
			public Translateable x1E0_Translateable { get { return Read<Translateable>(0x1E0); } } // TranslateFromString = 0x010E3C50, TranslateFromValue = 0x010E3D00
			public AttributeParameter x1E4_AttributeParameter { get { return Read<AttributeParameter>(0x1E4); } }
			public string x1E8_Text { get { return DeserializeString(x1F0_SerializeData); } }
			public SerializeData x1F0_SerializeData { get { return Read<SerializeData>(0x1F0); } }
			public Translateable x1F8_Translateable { get { return Read<Translateable>(0x1F8); } } // TranslateFromString = 0x010E3C50, TranslateFromValue = 0x010E3D00
			public AttributeParameter x1FC_AttributeParameter { get { return Read<AttributeParameter>(0x1FC); } }
			public string x200_Text { get { return DeserializeString(x208_SerializeData); } }
			public SerializeData x208_SerializeData { get { return Read<SerializeData>(0x208); } }
			public Translateable x210_Translateable { get { return Read<Translateable>(0x210); } } // TranslateFromString = 0x010E3C50, TranslateFromValue = 0x010E3D00
			public AttributeParameter x214_AttributeParameter { get { return Read<AttributeParameter>(0x214); } }
			public string x218_Text { get { return DeserializeString(x220_SerializeData); } }
			public SerializeData x220_SerializeData { get { return Read<SerializeData>(0x220); } }
			public Translateable x228_Translateable { get { return Read<Translateable>(0x228); } } // TranslateFromString = 0x010E3C50, TranslateFromValue = 0x010E3D00
			public AttributeParameter x22C_AttributeParameter { get { return Read<AttributeParameter>(0x22C); } }
			public string x230_Text { get { return DeserializeString(x238_SerializeData); } }
			public SerializeData x238_SerializeData { get { return Read<SerializeData>(0x238); } }
			public Translateable x240_Translateable { get { return Read<Translateable>(0x240); } } // TranslateFromString = 0x010E3C50, TranslateFromValue = 0x010E3D00
			public AttributeParameter x244_AttributeParameter { get { return Read<AttributeParameter>(0x244); } }
			public string x248_Text { get { return DeserializeString(x250_SerializeData); } }
			public SerializeData x250_SerializeData { get { return Read<SerializeData>(0x250); } }
			public Translateable x258_Translateable { get { return Read<Translateable>(0x258); } } // TranslateFromString = 0x010E3C50, TranslateFromValue = 0x010E3D00
			public AttributeParameter x25C_AttributeParameter { get { return Read<AttributeParameter>(0x25C); } }
			public string x260_Text { get { return DeserializeString(x268_SerializeData); } }
			public SerializeData x268_SerializeData { get { return Read<SerializeData>(0x268); } }
			public Translateable x270_Translateable { get { return Read<Translateable>(0x270); } } // TranslateFromString = 0x010E3C50, TranslateFromValue = 0x010E3D00
			public AttributeParameter x274_AttributeParameter { get { return Read<AttributeParameter>(0x274); } }
			public string x278_Text { get { return DeserializeString(x280_SerializeData); } }
			public SerializeData x280_SerializeData { get { return Read<SerializeData>(0x280); } }
			public Translateable x288_Translateable { get { return Read<Translateable>(0x288); } } // TranslateFromString = 0x010E3C50, TranslateFromValue = 0x010E3D00
			public AttributeParameter x28C_AttributeParameter { get { return Read<AttributeParameter>(0x28C); } }
			public string x290_Text { get { return DeserializeString(x298_SerializeData); } }
			public SerializeData x298_SerializeData { get { return Read<SerializeData>(0x298); } }
			public Translateable x2A0_Translateable { get { return Read<Translateable>(0x2A0); } } // TranslateFromString = 0x010E3C50, TranslateFromValue = 0x010E3D00
			public AttributeParameter x2A4_AttributeParameter { get { return Read<AttributeParameter>(0x2A4); } }
			public string x2A8_Text { get { return DeserializeString(x2B0_SerializeData); } }
			public SerializeData x2B0_SerializeData { get { return Read<SerializeData>(0x2B0); } }
			public Translateable x2B8_Translateable { get { return Read<Translateable>(0x2B8); } } // TranslateFromString = 0x010E3C50, TranslateFromValue = 0x010E3D00
			public AttributeParameter x2BC_AttributeParameter { get { return Read<AttributeParameter>(0x2BC); } }
			public string x2C0_Text { get { return DeserializeString(x2C8_SerializeData); } }
			public SerializeData x2C8_SerializeData { get { return Read<SerializeData>(0x2C8); } }
			public Translateable x2D0_Translateable { get { return Read<Translateable>(0x2D0); } } // TranslateFromString = 0x010E3C50, TranslateFromValue = 0x010E3D00
			public AttributeParameter x2D4_AttributeParameter { get { return Read<AttributeParameter>(0x2D4); } }
			public string x2D8_Text { get { return DeserializeString(x2E0_SerializeData); } }
			public SerializeData x2E0_SerializeData { get { return Read<SerializeData>(0x2E0); } }
			public Translateable x2E8_Translateable { get { return Read<Translateable>(0x2E8); } } // TranslateFromString = 0x010E3C50, TranslateFromValue = 0x010E3D00
			public AttributeParameter x2EC_AttributeParameter { get { return Read<AttributeParameter>(0x2EC); } }
			public string x2F0_Text { get { return DeserializeString(x2F8_SerializeData); } }
			public SerializeData x2F8_SerializeData { get { return Read<SerializeData>(0x2F8); } }
			public Translateable x300_Translateable { get { return Read<Translateable>(0x300); } } // TranslateFromString = 0x010E3C50, TranslateFromValue = 0x010E3D00
			public AttributeParameter x304_AttributeParameter { get { return Read<AttributeParameter>(0x304); } }
			public string x308_Text { get { return DeserializeString(x310_SerializeData); } }
			public SerializeData x310_SerializeData { get { return Read<SerializeData>(0x310); } }
			public Translateable x318_Translateable { get { return Read<Translateable>(0x318); } } // TranslateFromString = 0x010E3C50, TranslateFromValue = 0x010E3D00
			public AttributeParameter x31C_AttributeParameter { get { return Read<AttributeParameter>(0x31C); } }
			public string x320_Text { get { return DeserializeString(x328_SerializeData); } }
			public SerializeData x328_SerializeData { get { return Read<SerializeData>(0x328); } }
			public Translateable x330_Translateable { get { return Read<Translateable>(0x330); } } // TranslateFromString = 0x010E3C50, TranslateFromValue = 0x010E3D00
			public AttributeParameter x334_AttributeParameter { get { return Read<AttributeParameter>(0x334); } }
			public string x338_Text { get { return DeserializeString(x340_SerializeData); } }
			public SerializeData x340_SerializeData { get { return Read<SerializeData>(0x340); } }
			public Translateable x348_Translateable { get { return Read<Translateable>(0x348); } } // TranslateFromString = 0x010E3C50, TranslateFromValue = 0x010E3D00
			public AttributeParameter x34C_AttributeParameter { get { return Read<AttributeParameter>(0x34C); } }
			public string x350_Text { get { return DeserializeString(x358_SerializeData); } }
			public SerializeData x358_SerializeData { get { return Read<SerializeData>(0x358); } }
			public int x360_Enum { get { return Read<int>(0x360); } } // Invalid = -1, Inferior = 0, Normal = 1, Superior = 2, Magic1 = 3, Magic2 = 4, Magic3 = 5, Rare4 = 6, Rare5 = 7, Rare6 = 8, Legendary = 9, Special = 10, Set = 11
			public GameBalanceId[] x364_GameBalanceIds { get { return Read<GameBalanceId>(0x364, 10); } }
			public GameBalanceId x38C_ItemEnchantmentsGameBalanceId { get { return Read<GameBalanceId>(0x38C); } }
			public GameBalanceId x390_ItemsGameBalanceId { get { return Read<GameBalanceId>(0x390); } }
			public GameBalanceId[] x394_GameBalanceIds { get { return Read<GameBalanceId>(0x394, 8); } }
			public int x3B4 { get { return Read<int>(0x3B4); } }
			public int x3B8 { get { return Read<int>(0x3B8); } }
			public int x3BC { get { return Read<int>(0x3BC); } }
			public int x3C0 { get { return Read<int>(0x3C0); } }
			public int x3C4 { get { return Read<int>(0x3C4); } }
			public int x3C8 { get { return Read<int>(0x3C8); } }
			public int x3CC { get { return Read<int>(0x3CC); } }
			public int x3D0 { get { return Read<int>(0x3D0); } }
			public GameBalanceId x3D4_47GameBalanceId { get { return Read<GameBalanceId>(0x3D4); } }
			public GameBalanceId x3D8_47GameBalanceId { get { return Read<GameBalanceId>(0x3D8); } }
			public GameBalanceId x3DC_47GameBalanceId { get { return Read<GameBalanceId>(0x3DC); } }
			public GameBalanceId x3E0_47GameBalanceId { get { return Read<GameBalanceId>(0x3E0); } }
			public GameBalanceId x3E4_47GameBalanceId { get { return Read<GameBalanceId>(0x3E4); } }
			public GameBalanceId x3E8_47GameBalanceId { get { return Read<GameBalanceId>(0x3E8); } }
			public int x3EC { get { return Read<int>(0x3EC); } }
			public int x3F0 { get { return Read<int>(0x3F0); } }
			public int x3F4 { get { return Read<int>(0x3F4); } }
			public int x3F8 { get { return Read<int>(0x3F8); } }
			public int x3FC { get { return Read<int>(0x3FC); } }
			public int x400 { get { return Read<int>(0x400); } }
			public int x404 { get { return Read<int>(0x404); } }
			public int x408 { get { return Read<int>(0x408); } }
			public int x40C { get { return Read<int>(0x40C); } }
			public int x410 { get { return Read<int>(0x410); } }
			public int x414 { get { return Read<int>(0x414); } }
			public int x418 { get { return Read<int>(0x418); } }
			public GameBalanceId x41C_GameBalanceId { get { return Read<GameBalanceId>(0x41C); } }
			public int x420_Enum { get { return Read<int>(0x420); } } // Amethyst = 1, Emerald = 2, Ruby = 3, Topaz = 4, Diamond = 5
			public int x424 { get { return Read<int>(0x424); } }
			public int x428_Enum { get { return Read<int>(0x428); } } // A = 1, B = 2, C = 3, D = 4
			public Sno x42C_ActorSno { get { return Read<Sno>(0x42C); } }
			public Sno x430_WorldsSno { get { return Read<Sno>(0x430); } }
			public Sno x434_WorldsSno { get { return Read<Sno>(0x434); } }
			public Sno x438_LevelAreaSno { get { return Read<Sno>(0x438); } }
			public int x43C { get { return Read<int>(0x43C); } }
			public int x440 { get { return Read<int>(0x440); } }
			public int x444 { get { return Read<int>(0x444); } }
			public GameBalanceId x448_MadeToOrderTypesGameBalanceId { get { return Read<GameBalanceId>(0x448); } }
			public float x44C { get { return Read<float>(0x44C); } }
			public float x450 { get { return Read<float>(0x450); } }
			public float x454 { get { return Read<float>(0x454); } }
			public float x458 { get { return Read<float>(0x458); } }
			public float x45C { get { return Read<float>(0x45C); } }
			public float x460 { get { return Read<float>(0x460); } }
			public float x464 { get { return Read<float>(0x464); } }
			public float x468 { get { return Read<float>(0x468); } }
			public float x46C { get { return Read<float>(0x46C); } }
			public float x470 { get { return Read<float>(0x470); } }
			public int x474 { get { return Read<int>(0x474); } }
			public RecipeIngredient[] x478_RecipeIngredients { get { return Read<RecipeIngredient>(0x478, 6); } }
			public int x4A8 { get { return Read<int>(0x4A8); } }
			public RecipeIngredient[] x4AC_RecipeIngredients { get { return Read<RecipeIngredient>(0x4AC, 6); } }
			public Sno x4DC_LevelAreaSno { get { return Read<Sno>(0x4DC); } }
			public Sno x4E0_LevelAreaSno { get { return Read<Sno>(0x4E0); } }
			public Sno x4E4_ActorSno { get { return Read<Sno>(0x4E4); } }
			public int x4E8 { get { return Read<int>(0x4E8); } }
			public Translateable x4F0_Translateable { get { return Read<Translateable>(0x4F0); } } // TranslateFromString = 0x010E3C50, TranslateFromValue = 0x010E3D00
			public AttributeParameter x4F4_AttributeParameter { get { return Read<AttributeParameter>(0x4F4); } }
			public string x4F8_Text { get { return DeserializeString(x500_SerializeData); } }
			public SerializeData x500_SerializeData { get { return Read<SerializeData>(0x500); } }
			public Translateable x508_Translateable { get { return Read<Translateable>(0x508); } } // TranslateFromString = 0x010E3C50, TranslateFromValue = 0x010E3D00
			public AttributeParameter x50C_AttributeParameter { get { return Read<AttributeParameter>(0x50C); } }
			public string x510_Text { get { return DeserializeString(x518_SerializeData); } }
			public SerializeData x518_SerializeData { get { return Read<SerializeData>(0x518); } }
			public int x520 { get { return Read<int>(0x520); } }
			public int x524 { get { return Read<int>(0x524); } }
		}
		
		[CompilerGenerated]
		public partial class ExperienceLevel : MemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x1D0; // 464
			
			public long x000 { get { return Read<long>(0x000); } }
			public int x008 { get { return Read<int>(0x008); } }
			public int x00C { get { return Read<int>(0x00C); } }
			public float x010 { get { return Read<float>(0x010); } }
			public float x014 { get { return Read<float>(0x014); } }
			public int x018 { get { return Read<int>(0x018); } }
			public int x01C { get { return Read<int>(0x01C); } }
			public int x020 { get { return Read<int>(0x020); } }
			public int x024 { get { return Read<int>(0x024); } }
			public int x028 { get { return Read<int>(0x028); } }
			public int x02C { get { return Read<int>(0x02C); } }
			public int x030 { get { return Read<int>(0x030); } }
			public int x034 { get { return Read<int>(0x034); } }
			public int x038 { get { return Read<int>(0x038); } }
			public int x03C { get { return Read<int>(0x03C); } }
			public int x040 { get { return Read<int>(0x040); } }
			public int x044 { get { return Read<int>(0x044); } }
			public int x048 { get { return Read<int>(0x048); } }
			public int x04C { get { return Read<int>(0x04C); } }
			public int x050 { get { return Read<int>(0x050); } }
			public int x054 { get { return Read<int>(0x054); } }
			public int x058 { get { return Read<int>(0x058); } }
			public int x05C { get { return Read<int>(0x05C); } }
			public int x060 { get { return Read<int>(0x060); } }
			public int x064 { get { return Read<int>(0x064); } }
			public int x068 { get { return Read<int>(0x068); } }
			public int x06C { get { return Read<int>(0x06C); } }
			public int x070 { get { return Read<int>(0x070); } }
			public int x074 { get { return Read<int>(0x074); } }
			public int x078 { get { return Read<int>(0x078); } }
			public int x07C { get { return Read<int>(0x07C); } }
			public int x080 { get { return Read<int>(0x080); } }
			public int x084 { get { return Read<int>(0x084); } }
			public int x088 { get { return Read<int>(0x088); } }
			public int x08C { get { return Read<int>(0x08C); } }
			public int x090 { get { return Read<int>(0x090); } }
			public int x094 { get { return Read<int>(0x094); } }
			public int x098 { get { return Read<int>(0x098); } }
			public int x09C { get { return Read<int>(0x09C); } }
			public int x0A0 { get { return Read<int>(0x0A0); } }
			public float x0A4 { get { return Read<float>(0x0A4); } }
			public float x0A8 { get { return Read<float>(0x0A8); } }
			public float x0AC { get { return Read<float>(0x0AC); } }
			public int x0B0 { get { return Read<int>(0x0B0); } }
			public int x0B4 { get { return Read<int>(0x0B4); } }
			public int x0B8 { get { return Read<int>(0x0B8); } }
			public int x0BC { get { return Read<int>(0x0BC); } }
			public int x0C0 { get { return Read<int>(0x0C0); } }
			public int x0C4 { get { return Read<int>(0x0C4); } }
			public int x0C8 { get { return Read<int>(0x0C8); } }
			public int x0CC { get { return Read<int>(0x0CC); } }
			public int x0D0 { get { return Read<int>(0x0D0); } }
			public int x0D4 { get { return Read<int>(0x0D4); } }
			public int x0D8 { get { return Read<int>(0x0D8); } }
			public int x0DC { get { return Read<int>(0x0DC); } }
			public int x0E0 { get { return Read<int>(0x0E0); } }
			public int x0E4 { get { return Read<int>(0x0E4); } }
			public int x0E8 { get { return Read<int>(0x0E8); } }
			public int x0EC { get { return Read<int>(0x0EC); } }
			public int x0F0 { get { return Read<int>(0x0F0); } }
			public int x0F4 { get { return Read<int>(0x0F4); } }
			public int x0F8 { get { return Read<int>(0x0F8); } }
			public int x0FC { get { return Read<int>(0x0FC); } }
			public int x100 { get { return Read<int>(0x100); } }
			public int x104 { get { return Read<int>(0x104); } }
			public int x108 { get { return Read<int>(0x108); } }
			public int x10C { get { return Read<int>(0x10C); } }
			public int x120 { get { return Read<int>(0x120); } }
			public int x124 { get { return Read<int>(0x124); } }
			public int x128 { get { return Read<int>(0x128); } }
			public int x12C { get { return Read<int>(0x12C); } }
			public int x130 { get { return Read<int>(0x130); } }
			public int x134 { get { return Read<int>(0x134); } }
			public int x138 { get { return Read<int>(0x138); } }
			public int x13C { get { return Read<int>(0x13C); } }
			public int x140 { get { return Read<int>(0x140); } }
			public int x144 { get { return Read<int>(0x144); } }
			public int x148 { get { return Read<int>(0x148); } }
			public int x14C { get { return Read<int>(0x14C); } }
			public float x154 { get { return Read<float>(0x154); } }
			public float x158 { get { return Read<float>(0x158); } }
			public float x15C { get { return Read<float>(0x15C); } }
			public long x160 { get { return Read<long>(0x160); } }
			public int x168 { get { return Read<int>(0x168); } }
			public int x16C { get { return Read<int>(0x16C); } }
			public int x170 { get { return Read<int>(0x170); } }
			public int x174 { get { return Read<int>(0x174); } }
			public int x178 { get { return Read<int>(0x178); } }
			public int x17C { get { return Read<int>(0x17C); } }
			public int x180 { get { return Read<int>(0x180); } }
			public int x184 { get { return Read<int>(0x184); } }
			public int x188 { get { return Read<int>(0x188); } }
			public int x18C { get { return Read<int>(0x18C); } }
			public int x190 { get { return Read<int>(0x190); } }
			public int x194 { get { return Read<int>(0x194); } }
			public int x198 { get { return Read<int>(0x198); } }
			public int x19C { get { return Read<int>(0x19C); } }
			public int x1A0 { get { return Read<int>(0x1A0); } }
			public int x1A4 { get { return Read<int>(0x1A4); } }
			public int x1A8 { get { return Read<int>(0x1A8); } }
			public int x1AC { get { return Read<int>(0x1AC); } }
			public float x1B0 { get { return Read<float>(0x1B0); } }
			public int x1B4 { get { return Read<int>(0x1B4); } }
			public int x1B8 { get { return Read<int>(0x1B8); } }
			public int x1BC { get { return Read<int>(0x1BC); } }
			public int x1C0 { get { return Read<int>(0x1C0); } }
			public int x1C4 { get { return Read<int>(0x1C4); } }
			public int x1C8 { get { return Read<int>(0x1C8); } }
		}
		
		[CompilerGenerated]
		public partial class ExperienceLevelAlt : MemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x70; // 112
			
			public long x00 { get { return Read<long>(0x00); } }
			public int x08 { get { return Read<int>(0x08); } }
			public int x0C { get { return Read<int>(0x0C); } }
			public int x10 { get { return Read<int>(0x10); } }
			public int x14 { get { return Read<int>(0x14); } }
			public int x18 { get { return Read<int>(0x18); } }
			public int x1C { get { return Read<int>(0x1C); } }
			public int x20 { get { return Read<int>(0x20); } }
			public int x24 { get { return Read<int>(0x24); } }
			public int x28 { get { return Read<int>(0x28); } }
			public int x2C { get { return Read<int>(0x2C); } }
			public int x30 { get { return Read<int>(0x30); } }
			public int x34 { get { return Read<int>(0x34); } }
			public int x38 { get { return Read<int>(0x38); } }
			public int x3C { get { return Read<int>(0x3C); } }
			public int x40 { get { return Read<int>(0x40); } }
			public int x44 { get { return Read<int>(0x44); } }
			public int x48 { get { return Read<int>(0x48); } }
			public int x4C { get { return Read<int>(0x4C); } }
			public int x50 { get { return Read<int>(0x50); } }
			public int x54 { get { return Read<int>(0x54); } }
			public int x58 { get { return Read<int>(0x58); } }
			public int x5C { get { return Read<int>(0x5C); } }
			public int x60 { get { return Read<int>(0x60); } }
			public int x64 { get { return Read<int>(0x64); } }
			public int x68 { get { return Read<int>(0x68); } }
			public int x6C { get { return Read<int>(0x6C); } }
		}
		
		[CompilerGenerated]
		public partial class MonsterLevelDefinition : MemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0xF0; // 240
			
			public int x00 { get { return Read<int>(0x00); } }
			public float x04 { get { return Read<float>(0x04); } }
			public float x08 { get { return Read<float>(0x08); } }
			public float x0C { get { return Read<float>(0x0C); } }
			public float x10 { get { return Read<float>(0x10); } }
			public float x14 { get { return Read<float>(0x14); } }
			public float x18 { get { return Read<float>(0x18); } }
			public float x1C { get { return Read<float>(0x1C); } }
			public float x20 { get { return Read<float>(0x20); } }
			public float x24 { get { return Read<float>(0x24); } }
			public float x28 { get { return Read<float>(0x28); } }
			public float x2C { get { return Read<float>(0x2C); } }
			public float x30 { get { return Read<float>(0x30); } }
			public float x34 { get { return Read<float>(0x34); } }
			public float x38 { get { return Read<float>(0x38); } }
			public float x3C { get { return Read<float>(0x3C); } }
			public float x40 { get { return Read<float>(0x40); } }
			public float x44 { get { return Read<float>(0x44); } }
			public float x48 { get { return Read<float>(0x48); } }
			public float x4C { get { return Read<float>(0x4C); } }
			public float x50 { get { return Read<float>(0x50); } }
			public float x54 { get { return Read<float>(0x54); } }
			public float x58 { get { return Read<float>(0x58); } }
			public float x5C { get { return Read<float>(0x5C); } }
			public float x60 { get { return Read<float>(0x60); } }
			public float x64 { get { return Read<float>(0x64); } }
			public float x68 { get { return Read<float>(0x68); } }
			public float x6C { get { return Read<float>(0x6C); } }
			public float x70 { get { return Read<float>(0x70); } }
			public float x74 { get { return Read<float>(0x74); } }
			public float x78 { get { return Read<float>(0x78); } }
			public float x7C { get { return Read<float>(0x7C); } }
			public float x80 { get { return Read<float>(0x80); } }
			public float x84 { get { return Read<float>(0x84); } }
			public float x88 { get { return Read<float>(0x88); } }
			public float x8C { get { return Read<float>(0x8C); } }
			public float x90 { get { return Read<float>(0x90); } }
			public float x94 { get { return Read<float>(0x94); } }
			public float x98 { get { return Read<float>(0x98); } }
			public float x9C { get { return Read<float>(0x9C); } }
			public float xA0 { get { return Read<float>(0xA0); } }
			public float xA4 { get { return Read<float>(0xA4); } }
			public float xA8 { get { return Read<float>(0xA8); } }
			public float xAC { get { return Read<float>(0xAC); } }
			public float xB0 { get { return Read<float>(0xB0); } }
			public float xB4 { get { return Read<float>(0xB4); } }
			public float xB8 { get { return Read<float>(0xB8); } }
			public float xBC { get { return Read<float>(0xBC); } }
			public float xC0 { get { return Read<float>(0xC0); } }
			public float xC4 { get { return Read<float>(0xC4); } }
			public float xC8 { get { return Read<float>(0xC8); } }
			public float xCC { get { return Read<float>(0xCC); } }
			public float xD0 { get { return Read<float>(0xD0); } }
			public float xD4 { get { return Read<float>(0xD4); } }
			public float xD8 { get { return Read<float>(0xD8); } }
			public float xDC { get { return Read<float>(0xDC); } }
			public float xE0 { get { return Read<float>(0xE0); } }
			public float xE4 { get { return Read<float>(0xE4); } }
			public float xE8 { get { return Read<float>(0xE8); } }
			public int xEC { get { return Read<int>(0xEC); } }
		}
		
		[CompilerGenerated]
		public partial class AffixTableEntry : SerializeMemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x318; // 792
			
			public string x000_Text { get { return ReadString(0x000, 256); } }
			public int x100 { get { return Read<int>(0x100); } }
			public int x104 { get { return Read<int>(0x104); } }
			public int x108 { get { return Read<int>(0x108); } }
			public int x10C { get { return Read<int>(0x10C); } }
			public int x110 { get { return Read<int>(0x110); } }
			public int x114 { get { return Read<int>(0x114); } }
			public int x118 { get { return Read<int>(0x118); } }
			public int x11C { get { return Read<int>(0x11C); } }
			public int x120 { get { return Read<int>(0x120); } }
			public int x124 { get { return Read<int>(0x124); } }
			public int x128 { get { return Read<int>(0x128); } }
			public int x12C { get { return Read<int>(0x12C); } }
			public int x130 { get { return Read<int>(0x130); } }
			public int x134 { get { return Read<int>(0x134); } }
			public int x138 { get { return Read<int>(0x138); } }
			public int x13C { get { return Read<int>(0x13C); } }
			public int x140 { get { return Read<int>(0x140); } }
			public int x144 { get { return Read<int>(0x144); } }
			public int x148 { get { return Read<int>(0x148); } }
			public int x14C { get { return Read<int>(0x14C); } }
			public int x150_Enum { get { return Read<int>(0x150); } } // - None - = 0, Lightning = 1, Cold = 2, Fire = 3, Poison = 4, Arcane = 5, WitchdoctorDamage = 6, LifeSteal = 7, ManaSteal = 8, MagicFind = 9, GoldFind = 10, AttackSpeedBonus = 11, CastSpeedBonus = 12, Holy = 13, WizardDamage = 14
			public int x154 { get { return Read<int>(0x154); } }
			public GameBalanceId x158_AffixListGameBalanceId { get { return Read<GameBalanceId>(0x158); } }
			public GameBalanceId x15C_AffixListGameBalanceId { get { return Read<GameBalanceId>(0x15C); } }
			public Sno x160_StringListSno { get { return Read<Sno>(0x160); } }
			public Sno x164_StringListSno { get { return Read<Sno>(0x164); } }
			public GameBalanceId x168_47GameBalanceId { get { return Read<GameBalanceId>(0x168); } }
			public GameBalanceId x16C_47GameBalanceId { get { return Read<GameBalanceId>(0x16C); } }
			public int x170_Enum { get { return Read<int>(0x170); } } // - None - = -1, DemonHunter = 0, Barbarian = 1, Wizard = 2, Witchdoctor = 3, Monk = 4, Crusader = 5
			public GameBalanceId x174_AffixListGameBalanceId { get { return Read<GameBalanceId>(0x174); } }
			public int[] x178_int { get { return Read<int>(0x178, 6); } }
			public int[] x190_int { get { return Read<int>(0x190, 24); } }
			public int[] x1F0_int { get { return Read<int>(0x1F0, 24); } }
			public int x250 { get { return Read<int>(0x250); } }
			public int x254_Enum { get { return Read<int>(0x254); } } // Prefix = 0, Suffix = 1, Inherent = 2, Title = 5, Quality = 6, Immunity = 7, Random = 9, Enchantment = 10, Socket Enhancement = 11
			public GameBalanceId x258_AffixListGameBalanceId { get { return Read<GameBalanceId>(0x258); } }
			public AttributeSpecifier[] x260_AttributeSpecifiers { get { return Read<AttributeSpecifier>(0x260, 4); } }
			public GameBalanceId x308_MadeToOrderTypesGameBalanceId { get { return Read<GameBalanceId>(0x308); } }
			public int x30C_Enum { get { return Read<int>(0x30C); } } // Major = 0, Minor = 1
		}
		
		[CompilerGenerated]
		public partial class HeroData : MemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x1F8; // 504
			
			public string x000_Text { get { return ReadString(0x000, 256); } }
			public int x100 { get { return Read<int>(0x100); } }
			public int x104 { get { return Read<int>(0x104); } }
			public Sno x108_ActorSno { get { return Read<Sno>(0x108); } }
			public Sno x10C_ActorSno { get { return Read<Sno>(0x10C); } }
			public Sno x110_TreasureClassSno { get { return Read<Sno>(0x110); } }
			public int x114 { get { return Read<int>(0x114); } }
			public Sno x118_PowerSno { get { return Read<Sno>(0x118); } }
			public Sno x11C_PowerSno { get { return Read<Sno>(0x11C); } }
			public Sno x120_SkillKitSno { get { return Read<Sno>(0x120); } }
			public Sno x124_SkillKitSno { get { return Read<Sno>(0x124); } }
			public Sno x128_SkillKitSno { get { return Read<Sno>(0x128); } }
			public Sno x12C_SkillKitSno { get { return Read<Sno>(0x12C); } }
			public int x130_Enum { get { return Read<int>(0x130); } } // Mana = 0, Arcanum = 1, Fury = 2, Spirit = 3, Power = 4, Hatred = 5, Discipline = 6, Faith = 7
			public int x134_Enum { get { return Read<int>(0x134); } } // Mana = 0, Arcanum = 1, Fury = 2, Spirit = 3, Power = 4, Hatred = 5, Discipline = 6, Faith = 7
			public int x138_Enum { get { return Read<int>(0x138); } } // None = -1, Strength = 0, Dexterity = 1, Intelligence = 2
			public float x13C { get { return Read<float>(0x13C); } }
			public int x140 { get { return Read<int>(0x140); } }
			public float x144 { get { return Read<float>(0x144); } }
			public float x148 { get { return Read<float>(0x148); } }
			public float x14C { get { return Read<float>(0x14C); } }
			public float x150 { get { return Read<float>(0x150); } }
			public float x154 { get { return Read<float>(0x154); } }
			public float x158 { get { return Read<float>(0x158); } }
			public float x15C { get { return Read<float>(0x15C); } }
			public float x160 { get { return Read<float>(0x160); } }
			public float x164 { get { return Read<float>(0x164); } }
			public float x168 { get { return Read<float>(0x168); } }
			public float x16C { get { return Read<float>(0x16C); } }
			public float x170 { get { return Read<float>(0x170); } }
			public float x174 { get { return Read<float>(0x174); } }
			public float x178 { get { return Read<float>(0x178); } }
			public float x17C { get { return Read<float>(0x17C); } }
			public float x180 { get { return Read<float>(0x180); } }
			public float x184 { get { return Read<float>(0x184); } }
			public float x188 { get { return Read<float>(0x188); } }
			public float x18C { get { return Read<float>(0x18C); } }
			public float x190 { get { return Read<float>(0x190); } }
			public float x194 { get { return Read<float>(0x194); } }
			public float x198 { get { return Read<float>(0x198); } }
			public float x19C { get { return Read<float>(0x19C); } }
			public float x1A0 { get { return Read<float>(0x1A0); } }
			public float x1A4 { get { return Read<float>(0x1A4); } }
			public float x1A8 { get { return Read<float>(0x1A8); } }
			public float x1AC { get { return Read<float>(0x1AC); } }
			public float x1B0 { get { return Read<float>(0x1B0); } }
			public float x1B4 { get { return Read<float>(0x1B4); } }
			public float x1B8 { get { return Read<float>(0x1B8); } }
			public float x1BC { get { return Read<float>(0x1BC); } }
			public float x1C0 { get { return Read<float>(0x1C0); } }
			public float x1C4 { get { return Read<float>(0x1C4); } }
			public float x1C8 { get { return Read<float>(0x1C8); } }
			public float x1CC { get { return Read<float>(0x1CC); } }
			public float x1D0 { get { return Read<float>(0x1D0); } }
			public float x1D4 { get { return Read<float>(0x1D4); } }
			public float x1D8 { get { return Read<float>(0x1D8); } }
			public float x1DC { get { return Read<float>(0x1DC); } }
			public float x1E0 { get { return Read<float>(0x1E0); } }
			public float x1E4 { get { return Read<float>(0x1E4); } }
			public float x1E8 { get { return Read<float>(0x1E8); } }
			public float x1EC { get { return Read<float>(0x1EC); } }
			public float x1F0 { get { return Read<float>(0x1F0); } }
			public float x1F4 { get { return Read<float>(0x1F4); } }
		}
		
		[CompilerGenerated]
		public partial class MovementStyleDefinition : MemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x188; // 392
			
			public string x000_Text { get { return ReadString(0x000, 256); } }
			public int x100 { get { return Read<int>(0x100); } }
			public int x104 { get { return Read<int>(0x104); } }
			public int x108 { get { return Read<int>(0x108); } }
			public int x10C { get { return Read<int>(0x10C); } }
			public int x110 { get { return Read<int>(0x110); } }
			public int x114 { get { return Read<int>(0x114); } }
			public int x118 { get { return Read<int>(0x118); } }
			public int x11C { get { return Read<int>(0x11C); } }
			public int x120 { get { return Read<int>(0x120); } }
			public int x124 { get { return Read<int>(0x124); } }
			public float x128 { get { return Read<float>(0x128); } }
			public float x12C { get { return Read<float>(0x12C); } }
			public float x130 { get { return Read<float>(0x130); } }
			public float x134 { get { return Read<float>(0x134); } }
			public float x138 { get { return Read<float>(0x138); } }
			public float x13C { get { return Read<float>(0x13C); } }
			public float x140 { get { return Read<float>(0x140); } }
			public float x144 { get { return Read<float>(0x144); } }
			public float x148 { get { return Read<float>(0x148); } }
			public float x14C { get { return Read<float>(0x14C); } }
			public float x150 { get { return Read<float>(0x150); } }
			public float x154 { get { return Read<float>(0x154); } }
			public float x158 { get { return Read<float>(0x158); } }
			public float x15C { get { return Read<float>(0x15C); } }
			public float x160 { get { return Read<float>(0x160); } }
			public float x164 { get { return Read<float>(0x164); } }
			public float x168 { get { return Read<float>(0x168); } }
			public float x16C { get { return Read<float>(0x16C); } }
			public float x170 { get { return Read<float>(0x170); } }
			public float x174 { get { return Read<float>(0x174); } }
			public float x178 { get { return Read<float>(0x178); } }
			public float x17C { get { return Read<float>(0x17C); } }
			public Sno x180_PowerSno { get { return Read<Sno>(0x180); } }
			public int x184 { get { return Read<int>(0x184); } }
		}
		
		[CompilerGenerated]
		public partial class LabelGBID : MemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x110; // 272
			
			public string x000_Text { get { return ReadString(0x000, 256); } }
			public int x100 { get { return Read<int>(0x100); } }
			public int x104 { get { return Read<int>(0x104); } }
			public int x108 { get { return Read<int>(0x108); } }
			public int x10C { get { return Read<int>(0x10C); } }
		}
		
		[CompilerGenerated]
		public partial class LootDistribution : MemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x5C; // 92
			
			public int x00 { get { return Read<int>(0x00); } }
			public int x04 { get { return Read<int>(0x04); } }
			public int x08 { get { return Read<int>(0x08); } }
			public int x0C { get { return Read<int>(0x0C); } }
			public int x10 { get { return Read<int>(0x10); } }
			public int x14 { get { return Read<int>(0x14); } }
			public int x18 { get { return Read<int>(0x18); } }
			public int x1C { get { return Read<int>(0x1C); } }
			public int x20 { get { return Read<int>(0x20); } }
			public int x24 { get { return Read<int>(0x24); } }
			public float x28 { get { return Read<float>(0x28); } }
			public float x2C { get { return Read<float>(0x2C); } }
			public float x30 { get { return Read<float>(0x30); } }
			public float x34 { get { return Read<float>(0x34); } }
			public float x38 { get { return Read<float>(0x38); } }
			public float x3C { get { return Read<float>(0x3C); } }
			public float x40 { get { return Read<float>(0x40); } }
			public float x44 { get { return Read<float>(0x44); } }
			public float x48 { get { return Read<float>(0x48); } }
			public float x4C { get { return Read<float>(0x4C); } }
			public float x50 { get { return Read<float>(0x50); } }
			public int x54 { get { return Read<int>(0x54); } }
			public int x58 { get { return Read<int>(0x58); } }
		}
		
		[CompilerGenerated]
		public partial class RareItemNamesEntry : MemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x118; // 280
			
			public string x000_Text { get { return ReadString(0x000, 256); } }
			public int x100 { get { return Read<int>(0x100); } }
			public int x104 { get { return Read<int>(0x104); } }
			public int x108_Enum { get { return Read<int>(0x108); } } // Item Types = 1, Items = 2, Experience Table = 3, Help Codes = 24, Monster Levels = 5, Heros = 7, Affix List = 8, Movement Styles = 10, Labels = 11, Loot Distribution = 12, Rare Item Names = 16, Monster Affixes = 18, Monster Names = 19, Socketed Effects = 21, Item Enchantments = 23, Item Drop Table = 25, Item Level Modifiers = 26, Quality Classes = 27, Handicaps = 28, Item Salvage Levels = 29, Scenery = 17, Hirelings = 4, Set Item Bonuses = 33, Elite Modifiers = 34, Item Tiers = 35, Power Formula Tables = 36, Recipes = 32, Scripted Achievement Events = 37, Item Durability Cost Scalars = 38, LootRun Quest Tiers = 39, Paragon Bonuses = 40, Made To Order Types = 42, Made To Order Affix Folders = 43, Devil's Hand Redeemable Sets = 44, Legacy Item Conversions = 45, Enchant Item Affix Use Count Cost Scalars = 46, Tiered Loot Run Levels = 49
			public GameBalanceId x10C_GameBalanceId { get { return Read<GameBalanceId>(0x10C); } }
			public int x110_Enum { get { return Read<int>(0x110); } } // Prefix = 0, Suffix = 1, Inherent = 2, Title = 5, Quality = 6, Immunity = 7, Random = 9, Enchantment = 10, Socket Enhancement = 11
			public int x114 { get { return Read<int>(0x114); } }
		}
		
		[CompilerGenerated]
		public partial class MonsterAffixesEntry : SerializeMemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x388; // 904
			
			public string x000_Text { get { return ReadString(0x000, 256); } }
			public int x100 { get { return Read<int>(0x100); } }
			public int x104 { get { return Read<int>(0x104); } }
			public int x108 { get { return Read<int>(0x108); } }
			public int x10C { get { return Read<int>(0x10C); } }
			public int x110 { get { return Read<int>(0x110); } }
			public int x114_Enum { get { return Read<int>(0x114); } } // All = 0, Rares = 1, Shooters = 2, Champions = 3
			public int x118_Enum { get { return Read<int>(0x118); } } // None = -1, Physical = 0, Fire = 1, Lightning = 2, Cold = 3, Poison = 4, Arcane = 5, Holy = 6
			public int x11C_Enum { get { return Read<int>(0x11C); } } // Prefix = 0, Suffix = 1, Inherent = 2, Title = 5, Quality = 6, Immunity = 7, Random = 9, Enchantment = 10, Socket Enhancement = 11
			public int x120 { get { return Read<int>(0x120); } }
			public int x124 { get { return Read<int>(0x124); } }
			public int x128 { get { return Read<int>(0x128); } }
			public int x12C { get { return Read<int>(0x12C); } }
			public Translateable x130_Translateable { get { return Read<Translateable>(0x130); } } // TranslateFromString = 0x010E3C50, TranslateFromValue = 0x010E3D00
			public AttributeParameter x134_AttributeParameter { get { return Read<AttributeParameter>(0x134); } }
			public string x138_Text { get { return DeserializeString(x140_SerializeData); } }
			public SerializeData x140_SerializeData { get { return Read<SerializeData>(0x140); } }
			public Translateable x148_Translateable { get { return Read<Translateable>(0x148); } } // TranslateFromString = 0x010E3C50, TranslateFromValue = 0x010E3D00
			public AttributeParameter x14C_AttributeParameter { get { return Read<AttributeParameter>(0x14C); } }
			public string x150_Text { get { return DeserializeString(x158_SerializeData); } }
			public SerializeData x158_SerializeData { get { return Read<SerializeData>(0x158); } }
			public Translateable x160_Translateable { get { return Read<Translateable>(0x160); } } // TranslateFromString = 0x010E3C50, TranslateFromValue = 0x010E3D00
			public AttributeParameter x164_AttributeParameter { get { return Read<AttributeParameter>(0x164); } }
			public string x168_Text { get { return DeserializeString(x170_SerializeData); } }
			public SerializeData x170_SerializeData { get { return Read<SerializeData>(0x170); } }
			public Translateable x178_Translateable { get { return Read<Translateable>(0x178); } } // TranslateFromString = 0x010E3C50, TranslateFromValue = 0x010E3D00
			public AttributeParameter x17C_AttributeParameter { get { return Read<AttributeParameter>(0x17C); } }
			public string x180_Text { get { return DeserializeString(x188_SerializeData); } }
			public SerializeData x188_SerializeData { get { return Read<SerializeData>(0x188); } }
			public Translateable x190_Translateable { get { return Read<Translateable>(0x190); } } // TranslateFromString = 0x010E3C50, TranslateFromValue = 0x010E3D00
			public AttributeParameter x194_AttributeParameter { get { return Read<AttributeParameter>(0x194); } }
			public string x198_Text { get { return DeserializeString(x1A0_SerializeData); } }
			public SerializeData x1A0_SerializeData { get { return Read<SerializeData>(0x1A0); } }
			public Translateable x1A8_Translateable { get { return Read<Translateable>(0x1A8); } } // TranslateFromString = 0x010E3C50, TranslateFromValue = 0x010E3D00
			public AttributeParameter x1AC_AttributeParameter { get { return Read<AttributeParameter>(0x1AC); } }
			public string x1B0_Text { get { return DeserializeString(x1B8_SerializeData); } }
			public SerializeData x1B8_SerializeData { get { return Read<SerializeData>(0x1B8); } }
			public Translateable x1C0_Translateable { get { return Read<Translateable>(0x1C0); } } // TranslateFromString = 0x010E3C50, TranslateFromValue = 0x010E3D00
			public AttributeParameter x1C4_AttributeParameter { get { return Read<AttributeParameter>(0x1C4); } }
			public string x1C8_Text { get { return DeserializeString(x1D0_SerializeData); } }
			public SerializeData x1D0_SerializeData { get { return Read<SerializeData>(0x1D0); } }
			public Translateable x1D8_Translateable { get { return Read<Translateable>(0x1D8); } } // TranslateFromString = 0x010E3C50, TranslateFromValue = 0x010E3D00
			public AttributeParameter x1DC_AttributeParameter { get { return Read<AttributeParameter>(0x1DC); } }
			public string x1E0_Text { get { return DeserializeString(x1E8_SerializeData); } }
			public SerializeData x1E8_SerializeData { get { return Read<SerializeData>(0x1E8); } }
			public Translateable x1F0_Translateable { get { return Read<Translateable>(0x1F0); } } // TranslateFromString = 0x010E3C50, TranslateFromValue = 0x010E3D00
			public AttributeParameter x1F4_AttributeParameter { get { return Read<AttributeParameter>(0x1F4); } }
			public string x1F8_Text { get { return DeserializeString(x200_SerializeData); } }
			public SerializeData x200_SerializeData { get { return Read<SerializeData>(0x200); } }
			public Translateable x208_Translateable { get { return Read<Translateable>(0x208); } } // TranslateFromString = 0x010E3C50, TranslateFromValue = 0x010E3D00
			public AttributeParameter x20C_AttributeParameter { get { return Read<AttributeParameter>(0x20C); } }
			public string x210_Text { get { return DeserializeString(x218_SerializeData); } }
			public SerializeData x218_SerializeData { get { return Read<SerializeData>(0x218); } }
			public Translateable x220_Translateable { get { return Read<Translateable>(0x220); } } // TranslateFromString = 0x010E3C50, TranslateFromValue = 0x010E3D00
			public AttributeParameter x224_AttributeParameter { get { return Read<AttributeParameter>(0x224); } }
			public string x228_Text { get { return DeserializeString(x230_SerializeData); } }
			public SerializeData x230_SerializeData { get { return Read<SerializeData>(0x230); } }
			public Translateable x238_Translateable { get { return Read<Translateable>(0x238); } } // TranslateFromString = 0x010E3C50, TranslateFromValue = 0x010E3D00
			public AttributeParameter x23C_AttributeParameter { get { return Read<AttributeParameter>(0x23C); } }
			public string x240_Text { get { return DeserializeString(x248_SerializeData); } }
			public SerializeData x248_SerializeData { get { return Read<SerializeData>(0x248); } }
			public Translateable x250_Translateable { get { return Read<Translateable>(0x250); } } // TranslateFromString = 0x010E3C50, TranslateFromValue = 0x010E3D00
			public AttributeParameter x254_AttributeParameter { get { return Read<AttributeParameter>(0x254); } }
			public string x258_Text { get { return DeserializeString(x260_SerializeData); } }
			public SerializeData x260_SerializeData { get { return Read<SerializeData>(0x260); } }
			public Translateable x268_Translateable { get { return Read<Translateable>(0x268); } } // TranslateFromString = 0x010E3C50, TranslateFromValue = 0x010E3D00
			public AttributeParameter x26C_AttributeParameter { get { return Read<AttributeParameter>(0x26C); } }
			public string x270_Text { get { return DeserializeString(x278_SerializeData); } }
			public SerializeData x278_SerializeData { get { return Read<SerializeData>(0x278); } }
			public Translateable x280_Translateable { get { return Read<Translateable>(0x280); } } // TranslateFromString = 0x010E3C50, TranslateFromValue = 0x010E3D00
			public AttributeParameter x284_AttributeParameter { get { return Read<AttributeParameter>(0x284); } }
			public string x288_Text { get { return DeserializeString(x290_SerializeData); } }
			public SerializeData x290_SerializeData { get { return Read<SerializeData>(0x290); } }
			public Translateable x298_Translateable { get { return Read<Translateable>(0x298); } } // TranslateFromString = 0x010E3C50, TranslateFromValue = 0x010E3D00
			public AttributeParameter x29C_AttributeParameter { get { return Read<AttributeParameter>(0x29C); } }
			public string x2A0_Text { get { return DeserializeString(x2A8_SerializeData); } }
			public SerializeData x2A8_SerializeData { get { return Read<SerializeData>(0x2A8); } }
			public Translateable x2B0_Translateable { get { return Read<Translateable>(0x2B0); } } // TranslateFromString = 0x010E3C50, TranslateFromValue = 0x010E3D00
			public AttributeParameter x2B4_AttributeParameter { get { return Read<AttributeParameter>(0x2B4); } }
			public string x2B8_Text { get { return DeserializeString(x2C0_SerializeData); } }
			public SerializeData x2C0_SerializeData { get { return Read<SerializeData>(0x2C0); } }
			public Translateable x2C8_Translateable { get { return Read<Translateable>(0x2C8); } } // TranslateFromString = 0x010E3C50, TranslateFromValue = 0x010E3D00
			public AttributeParameter x2CC_AttributeParameter { get { return Read<AttributeParameter>(0x2CC); } }
			public string x2D0_Text { get { return DeserializeString(x2D8_SerializeData); } }
			public SerializeData x2D8_SerializeData { get { return Read<SerializeData>(0x2D8); } }
			public Translateable x2E0_Translateable { get { return Read<Translateable>(0x2E0); } } // TranslateFromString = 0x010E3C50, TranslateFromValue = 0x010E3D00
			public AttributeParameter x2E4_AttributeParameter { get { return Read<AttributeParameter>(0x2E4); } }
			public string x2E8_Text { get { return DeserializeString(x2F0_SerializeData); } }
			public SerializeData x2F0_SerializeData { get { return Read<SerializeData>(0x2F0); } }
			public Translateable x2F8_Translateable { get { return Read<Translateable>(0x2F8); } } // TranslateFromString = 0x010E3C50, TranslateFromValue = 0x010E3D00
			public AttributeParameter x2FC_AttributeParameter { get { return Read<AttributeParameter>(0x2FC); } }
			public string x300_Text { get { return DeserializeString(x308_SerializeData); } }
			public SerializeData x308_SerializeData { get { return Read<SerializeData>(0x308); } }
			public Sno x314_PowerSno { get { return Read<Sno>(0x314); } }
			public Sno x318_PowerSno { get { return Read<Sno>(0x318); } }
			public Sno x31C_PowerSno { get { return Read<Sno>(0x31C); } }
			public byte x320 { get { return Read<byte>(0x320); } }
			public byte x321 { get { return Read<byte>(0x321); } }
			public byte x322 { get { return Read<byte>(0x322); } }
			public byte x323 { get { return Read<byte>(0x323); } }
			public byte x324 { get { return Read<byte>(0x324); } }
			public byte x325 { get { return Read<byte>(0x325); } }
			public byte x326 { get { return Read<byte>(0x326); } }
			public byte x327 { get { return Read<byte>(0x327); } }
			public byte x328 { get { return Read<byte>(0x328); } }
			public byte x329 { get { return Read<byte>(0x329); } }
			public byte x32A { get { return Read<byte>(0x32A); } }
			public byte x32B { get { return Read<byte>(0x32B); } }
			public byte x32C { get { return Read<byte>(0x32C); } }
			public byte x32D { get { return Read<byte>(0x32D); } }
			public byte x32E { get { return Read<byte>(0x32E); } }
			public byte x32F { get { return Read<byte>(0x32F); } }
			public byte x330 { get { return Read<byte>(0x330); } }
			public byte x331 { get { return Read<byte>(0x331); } }
			public byte x332 { get { return Read<byte>(0x332); } }
			public byte x333 { get { return Read<byte>(0x333); } }
			public byte x334 { get { return Read<byte>(0x334); } }
			public byte x335 { get { return Read<byte>(0x335); } }
			public byte x336 { get { return Read<byte>(0x336); } }
			public byte x337 { get { return Read<byte>(0x337); } }
			public byte x338 { get { return Read<byte>(0x338); } }
			public byte x339 { get { return Read<byte>(0x339); } }
			public byte x33A { get { return Read<byte>(0x33A); } }
			public byte x33B { get { return Read<byte>(0x33B); } }
			public byte x33C { get { return Read<byte>(0x33C); } }
			public byte x33D { get { return Read<byte>(0x33D); } }
			public byte x33E { get { return Read<byte>(0x33E); } }
			public byte x33F { get { return Read<byte>(0x33F); } }
			public byte x340 { get { return Read<byte>(0x340); } }
			public byte x341 { get { return Read<byte>(0x341); } }
			public byte x342 { get { return Read<byte>(0x342); } }
			public byte x343 { get { return Read<byte>(0x343); } }
			public byte x344 { get { return Read<byte>(0x344); } }
			public byte x345 { get { return Read<byte>(0x345); } }
			public byte x346 { get { return Read<byte>(0x346); } }
			public byte x347 { get { return Read<byte>(0x347); } }
			public byte x348 { get { return Read<byte>(0x348); } }
			public byte x349 { get { return Read<byte>(0x349); } }
			public byte x34A { get { return Read<byte>(0x34A); } }
			public byte x34B { get { return Read<byte>(0x34B); } }
			public byte x34C { get { return Read<byte>(0x34C); } }
			public byte x34D { get { return Read<byte>(0x34D); } }
			public byte x34E { get { return Read<byte>(0x34E); } }
			public byte x34F { get { return Read<byte>(0x34F); } }
			public byte x350 { get { return Read<byte>(0x350); } }
			public byte x351 { get { return Read<byte>(0x351); } }
			public byte x352 { get { return Read<byte>(0x352); } }
			public byte x353 { get { return Read<byte>(0x353); } }
			public byte x354 { get { return Read<byte>(0x354); } }
			public byte x355 { get { return Read<byte>(0x355); } }
			public byte x356 { get { return Read<byte>(0x356); } }
			public byte x357 { get { return Read<byte>(0x357); } }
			public byte x358 { get { return Read<byte>(0x358); } }
			public byte x359 { get { return Read<byte>(0x359); } }
			public byte x35A { get { return Read<byte>(0x35A); } }
			public byte x35B { get { return Read<byte>(0x35B); } }
			public byte x35C { get { return Read<byte>(0x35C); } }
			public byte x35D { get { return Read<byte>(0x35D); } }
			public byte x35E { get { return Read<byte>(0x35E); } }
			public byte x35F { get { return Read<byte>(0x35F); } }
			public byte x360 { get { return Read<byte>(0x360); } }
			public byte x361 { get { return Read<byte>(0x361); } }
			public byte x362 { get { return Read<byte>(0x362); } }
			public byte x363 { get { return Read<byte>(0x363); } }
			public byte x364 { get { return Read<byte>(0x364); } }
			public byte x365 { get { return Read<byte>(0x365); } }
			public byte x366 { get { return Read<byte>(0x366); } }
			public byte x367 { get { return Read<byte>(0x367); } }
			public byte x368 { get { return Read<byte>(0x368); } }
			public byte x369 { get { return Read<byte>(0x369); } }
			public byte x36A { get { return Read<byte>(0x36A); } }
			public byte x36B { get { return Read<byte>(0x36B); } }
			public byte x36C { get { return Read<byte>(0x36C); } }
			public byte x36D { get { return Read<byte>(0x36D); } }
			public byte x36E { get { return Read<byte>(0x36E); } }
			public byte x36F { get { return Read<byte>(0x36F); } }
			public byte x370 { get { return Read<byte>(0x370); } }
			public byte x371 { get { return Read<byte>(0x371); } }
			public byte x372 { get { return Read<byte>(0x372); } }
			public byte x373 { get { return Read<byte>(0x373); } }
			public byte x374 { get { return Read<byte>(0x374); } }
			public byte x375 { get { return Read<byte>(0x375); } }
			public byte x376 { get { return Read<byte>(0x376); } }
			public byte x377 { get { return Read<byte>(0x377); } }
			public byte x378 { get { return Read<byte>(0x378); } }
			public byte x379 { get { return Read<byte>(0x379); } }
			public byte x37A { get { return Read<byte>(0x37A); } }
			public byte x37B { get { return Read<byte>(0x37B); } }
			public byte x37C { get { return Read<byte>(0x37C); } }
			public byte x37D { get { return Read<byte>(0x37D); } }
			public byte x37E { get { return Read<byte>(0x37E); } }
			public byte x37F { get { return Read<byte>(0x37F); } }
			public byte x380 { get { return Read<byte>(0x380); } }
			public byte x381 { get { return Read<byte>(0x381); } }
			public byte x382 { get { return Read<byte>(0x382); } }
		}
		
		[CompilerGenerated]
		public partial class RareMonsterNamesEntry : MemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x190; // 400
			
			public string x000_Text { get { return ReadString(0x000, 256); } }
			public int x100 { get { return Read<int>(0x100); } }
			public int x104 { get { return Read<int>(0x104); } }
			public int x108_Enum { get { return Read<int>(0x108); } } // Prefix = 0, Suffix = 1, Inherent = 2, Title = 5, Quality = 6, Immunity = 7, Random = 9, Enchantment = 10, Socket Enhancement = 11
			public string x10C_Text { get { return ReadString(0x10C, 128); } }
			public int x18C { get { return Read<int>(0x18C); } }
		}
		
		[CompilerGenerated]
		public partial class SocketedEffectsTableEntry : SerializeMemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x588; // 1416
			
			public string x000_Text { get { return ReadString(0x000, 256); } }
			public int x100 { get { return Read<int>(0x100); } }
			public int x104 { get { return Read<int>(0x104); } }
			public GameBalanceId x108_ItemsGameBalanceId { get { return Read<GameBalanceId>(0x108); } }
			public GameBalanceId x10C_ItemTypesGameBalanceId { get { return Read<GameBalanceId>(0x10C); } }
			public Translateable x110_Translateable { get { return Read<Translateable>(0x110); } } // TranslateFromString = 0x010E3C50, TranslateFromValue = 0x010E3D00
			public AttributeParameter x114_AttributeParameter { get { return Read<AttributeParameter>(0x114); } }
			public string x118_Text { get { return DeserializeString(x120_SerializeData); } }
			public SerializeData x120_SerializeData { get { return Read<SerializeData>(0x120); } }
			public Translateable x128_Translateable { get { return Read<Translateable>(0x128); } } // TranslateFromString = 0x010E3C50, TranslateFromValue = 0x010E3D00
			public AttributeParameter x12C_AttributeParameter { get { return Read<AttributeParameter>(0x12C); } }
			public string x130_Text { get { return DeserializeString(x138_SerializeData); } }
			public SerializeData x138_SerializeData { get { return Read<SerializeData>(0x138); } }
			public Translateable x140_Translateable { get { return Read<Translateable>(0x140); } } // TranslateFromString = 0x010E3C50, TranslateFromValue = 0x010E3D00
			public AttributeParameter x144_AttributeParameter { get { return Read<AttributeParameter>(0x144); } }
			public string x148_Text { get { return DeserializeString(x150_SerializeData); } }
			public SerializeData x150_SerializeData { get { return Read<SerializeData>(0x150); } }
			public Translateable x158_Translateable { get { return Read<Translateable>(0x158); } } // TranslateFromString = 0x010E3C50, TranslateFromValue = 0x010E3D00
			public AttributeParameter x15C_AttributeParameter { get { return Read<AttributeParameter>(0x15C); } }
			public string x160_Text { get { return DeserializeString(x168_SerializeData); } }
			public SerializeData x168_SerializeData { get { return Read<SerializeData>(0x168); } }
			public Translateable x170_Translateable { get { return Read<Translateable>(0x170); } } // TranslateFromString = 0x010E3C50, TranslateFromValue = 0x010E3D00
			public AttributeParameter x174_AttributeParameter { get { return Read<AttributeParameter>(0x174); } }
			public string x178_Text { get { return DeserializeString(x180_SerializeData); } }
			public SerializeData x180_SerializeData { get { return Read<SerializeData>(0x180); } }
			public string x188_Text { get { return ReadString(0x188, 1024); } }
		}
		
		[CompilerGenerated]
		public partial class ItemEnchantment : SerializeMemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x2C0; // 704
			
			public string x000_Text { get { return ReadString(0x000, 256); } }
			public int x100 { get { return Read<int>(0x100); } }
			public int x104 { get { return Read<int>(0x104); } }
			public int x108 { get { return Read<int>(0x108); } }
			public int x10C { get { return Read<int>(0x10C); } }
			public int x110 { get { return Read<int>(0x110); } }
			public int x114 { get { return Read<int>(0x114); } }
			public int x118 { get { return Read<int>(0x118); } }
			public int x11C { get { return Read<int>(0x11C); } }
			public AttributeSpecifier[] x120_AttributeSpecifiers { get { return Read<AttributeSpecifier>(0x120, 16); } }
			public int x2A0 { get { return Read<int>(0x2A0); } }
			public RecipeIngredient[] x2A4_RecipeIngredients { get { return Read<RecipeIngredient>(0x2A4, 3); } }
			public int x2BC { get { return Read<int>(0x2BC); } }
		}
		
		[CompilerGenerated]
		public partial class ItemDropTableEntry : MemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x478; // 1144
			
			public string x000_Text { get { return ReadString(0x000, 256); } }
			public int x100 { get { return Read<int>(0x100); } }
			public int x104 { get { return Read<int>(0x104); } }
			public int x108 { get { return Read<int>(0x108); } }
			public int x10C { get { return Read<int>(0x10C); } }
			public int x110 { get { return Read<int>(0x110); } }
			public int x114 { get { return Read<int>(0x114); } }
			public int x118 { get { return Read<int>(0x118); } }
			public int x11C { get { return Read<int>(0x11C); } }
			public int x120 { get { return Read<int>(0x120); } }
			public int x124 { get { return Read<int>(0x124); } }
			public int x128 { get { return Read<int>(0x128); } }
			public int x12C { get { return Read<int>(0x12C); } }
			public int x130 { get { return Read<int>(0x130); } }
			public int x134 { get { return Read<int>(0x134); } }
			public int x138 { get { return Read<int>(0x138); } }
			public int x13C { get { return Read<int>(0x13C); } }
			public int x140 { get { return Read<int>(0x140); } }
			public int x144 { get { return Read<int>(0x144); } }
			public int x148 { get { return Read<int>(0x148); } }
			public int x14C { get { return Read<int>(0x14C); } }
			public int x150 { get { return Read<int>(0x150); } }
			public int x154 { get { return Read<int>(0x154); } }
			public int x158 { get { return Read<int>(0x158); } }
			public int x15C { get { return Read<int>(0x15C); } }
			public int x160 { get { return Read<int>(0x160); } }
			public int x164 { get { return Read<int>(0x164); } }
			public int x168 { get { return Read<int>(0x168); } }
			public int x16C { get { return Read<int>(0x16C); } }
			public int x170 { get { return Read<int>(0x170); } }
			public int x174 { get { return Read<int>(0x174); } }
			public int x178 { get { return Read<int>(0x178); } }
			public int x17C { get { return Read<int>(0x17C); } }
			public int x180 { get { return Read<int>(0x180); } }
			public int x184 { get { return Read<int>(0x184); } }
			public int x188 { get { return Read<int>(0x188); } }
			public int x18C { get { return Read<int>(0x18C); } }
			public int x190 { get { return Read<int>(0x190); } }
			public int x194 { get { return Read<int>(0x194); } }
			public int x198 { get { return Read<int>(0x198); } }
			public int x19C { get { return Read<int>(0x19C); } }
			public int x1A0 { get { return Read<int>(0x1A0); } }
			public int x1A4 { get { return Read<int>(0x1A4); } }
			public int x1A8 { get { return Read<int>(0x1A8); } }
			public int x1AC { get { return Read<int>(0x1AC); } }
			public int x1B0 { get { return Read<int>(0x1B0); } }
			public int x1B4 { get { return Read<int>(0x1B4); } }
			public int x1B8 { get { return Read<int>(0x1B8); } }
			public int x1BC { get { return Read<int>(0x1BC); } }
			public int x1C0 { get { return Read<int>(0x1C0); } }
			public int x1C4 { get { return Read<int>(0x1C4); } }
			public int x1C8 { get { return Read<int>(0x1C8); } }
			public int x1CC { get { return Read<int>(0x1CC); } }
			public int x1D0 { get { return Read<int>(0x1D0); } }
			public int x1D4 { get { return Read<int>(0x1D4); } }
			public int x1D8 { get { return Read<int>(0x1D8); } }
			public int x1DC { get { return Read<int>(0x1DC); } }
			public int x1E0 { get { return Read<int>(0x1E0); } }
			public int x1E4 { get { return Read<int>(0x1E4); } }
			public int x1E8 { get { return Read<int>(0x1E8); } }
			public int x1EC { get { return Read<int>(0x1EC); } }
			public int x1F0 { get { return Read<int>(0x1F0); } }
			public int x1F4 { get { return Read<int>(0x1F4); } }
			public int x1F8 { get { return Read<int>(0x1F8); } }
			public int x1FC { get { return Read<int>(0x1FC); } }
			public int x200 { get { return Read<int>(0x200); } }
			public int x204 { get { return Read<int>(0x204); } }
			public int x208 { get { return Read<int>(0x208); } }
			public int x20C { get { return Read<int>(0x20C); } }
			public int x210 { get { return Read<int>(0x210); } }
			public int x214 { get { return Read<int>(0x214); } }
			public int x218 { get { return Read<int>(0x218); } }
			public int x21C { get { return Read<int>(0x21C); } }
			public int x220 { get { return Read<int>(0x220); } }
			public int x224 { get { return Read<int>(0x224); } }
			public int x228 { get { return Read<int>(0x228); } }
			public int x22C { get { return Read<int>(0x22C); } }
			public int x230 { get { return Read<int>(0x230); } }
			public int x234 { get { return Read<int>(0x234); } }
			public int x238 { get { return Read<int>(0x238); } }
			public int x23C { get { return Read<int>(0x23C); } }
			public int x240 { get { return Read<int>(0x240); } }
			public int x244 { get { return Read<int>(0x244); } }
			public int x248 { get { return Read<int>(0x248); } }
			public int x24C { get { return Read<int>(0x24C); } }
			public int x250 { get { return Read<int>(0x250); } }
			public int x254 { get { return Read<int>(0x254); } }
			public int x258 { get { return Read<int>(0x258); } }
			public int x25C { get { return Read<int>(0x25C); } }
			public int x260 { get { return Read<int>(0x260); } }
			public int x264 { get { return Read<int>(0x264); } }
			public int x268 { get { return Read<int>(0x268); } }
			public int x26C { get { return Read<int>(0x26C); } }
			public int x270 { get { return Read<int>(0x270); } }
			public int x274 { get { return Read<int>(0x274); } }
			public int x278 { get { return Read<int>(0x278); } }
			public int x27C { get { return Read<int>(0x27C); } }
			public int x280 { get { return Read<int>(0x280); } }
			public int x284 { get { return Read<int>(0x284); } }
			public int x288 { get { return Read<int>(0x288); } }
			public int x28C { get { return Read<int>(0x28C); } }
			public int x290 { get { return Read<int>(0x290); } }
			public int x294 { get { return Read<int>(0x294); } }
			public int x298 { get { return Read<int>(0x298); } }
			public int x29C { get { return Read<int>(0x29C); } }
			public int x2A0 { get { return Read<int>(0x2A0); } }
			public int x2A4 { get { return Read<int>(0x2A4); } }
			public int x2A8 { get { return Read<int>(0x2A8); } }
			public int x2AC { get { return Read<int>(0x2AC); } }
			public int x2B0 { get { return Read<int>(0x2B0); } }
			public int x2B4 { get { return Read<int>(0x2B4); } }
			public int x2B8 { get { return Read<int>(0x2B8); } }
			public int x2BC { get { return Read<int>(0x2BC); } }
			public int x2C0 { get { return Read<int>(0x2C0); } }
			public int x2C4 { get { return Read<int>(0x2C4); } }
			public int x2C8 { get { return Read<int>(0x2C8); } }
			public int x2CC { get { return Read<int>(0x2CC); } }
			public int x2D0 { get { return Read<int>(0x2D0); } }
			public int x2D4 { get { return Read<int>(0x2D4); } }
			public int x2D8 { get { return Read<int>(0x2D8); } }
			public int x2DC { get { return Read<int>(0x2DC); } }
			public int x2E0 { get { return Read<int>(0x2E0); } }
			public int x2E4 { get { return Read<int>(0x2E4); } }
			public int x2E8 { get { return Read<int>(0x2E8); } }
			public int x2EC { get { return Read<int>(0x2EC); } }
			public int x2F0 { get { return Read<int>(0x2F0); } }
			public int x2F4 { get { return Read<int>(0x2F4); } }
			public int x2F8 { get { return Read<int>(0x2F8); } }
			public int x2FC { get { return Read<int>(0x2FC); } }
			public int x300 { get { return Read<int>(0x300); } }
			public int x304 { get { return Read<int>(0x304); } }
			public int x308 { get { return Read<int>(0x308); } }
			public int x30C { get { return Read<int>(0x30C); } }
			public int x310 { get { return Read<int>(0x310); } }
			public int x314 { get { return Read<int>(0x314); } }
			public int x318 { get { return Read<int>(0x318); } }
			public int x31C { get { return Read<int>(0x31C); } }
			public int x320 { get { return Read<int>(0x320); } }
			public int x324 { get { return Read<int>(0x324); } }
			public int x328 { get { return Read<int>(0x328); } }
			public int x32C { get { return Read<int>(0x32C); } }
			public int x330 { get { return Read<int>(0x330); } }
			public int x334 { get { return Read<int>(0x334); } }
			public int x338 { get { return Read<int>(0x338); } }
			public int x33C { get { return Read<int>(0x33C); } }
			public int x340 { get { return Read<int>(0x340); } }
			public int x344 { get { return Read<int>(0x344); } }
			public int x348 { get { return Read<int>(0x348); } }
			public int x34C { get { return Read<int>(0x34C); } }
			public int x350 { get { return Read<int>(0x350); } }
			public int x354 { get { return Read<int>(0x354); } }
			public int x358 { get { return Read<int>(0x358); } }
			public int x35C { get { return Read<int>(0x35C); } }
			public int x360 { get { return Read<int>(0x360); } }
			public int x364 { get { return Read<int>(0x364); } }
			public int x368 { get { return Read<int>(0x368); } }
			public int x36C { get { return Read<int>(0x36C); } }
			public int x370 { get { return Read<int>(0x370); } }
			public int x374 { get { return Read<int>(0x374); } }
			public int x378 { get { return Read<int>(0x378); } }
			public int x37C { get { return Read<int>(0x37C); } }
			public int x380 { get { return Read<int>(0x380); } }
			public int x384 { get { return Read<int>(0x384); } }
			public int x388 { get { return Read<int>(0x388); } }
			public int x38C { get { return Read<int>(0x38C); } }
			public int x390 { get { return Read<int>(0x390); } }
			public int x394 { get { return Read<int>(0x394); } }
			public int x398 { get { return Read<int>(0x398); } }
			public int x39C { get { return Read<int>(0x39C); } }
			public int x3A0 { get { return Read<int>(0x3A0); } }
			public int x3A4 { get { return Read<int>(0x3A4); } }
			public int x3A8 { get { return Read<int>(0x3A8); } }
			public int x3AC { get { return Read<int>(0x3AC); } }
			public int x3B0 { get { return Read<int>(0x3B0); } }
			public int x3B4 { get { return Read<int>(0x3B4); } }
			public int x3B8 { get { return Read<int>(0x3B8); } }
			public int x3BC { get { return Read<int>(0x3BC); } }
			public int x3C0 { get { return Read<int>(0x3C0); } }
			public int x3C4 { get { return Read<int>(0x3C4); } }
			public int x3C8 { get { return Read<int>(0x3C8); } }
			public int x3CC { get { return Read<int>(0x3CC); } }
			public int x3D0 { get { return Read<int>(0x3D0); } }
			public int x3D4 { get { return Read<int>(0x3D4); } }
			public int x3D8 { get { return Read<int>(0x3D8); } }
			public int x3DC { get { return Read<int>(0x3DC); } }
			public int x3E0 { get { return Read<int>(0x3E0); } }
			public int x3E4 { get { return Read<int>(0x3E4); } }
			public int x3E8 { get { return Read<int>(0x3E8); } }
			public int x3EC { get { return Read<int>(0x3EC); } }
			public int x3F0 { get { return Read<int>(0x3F0); } }
			public int x3F4 { get { return Read<int>(0x3F4); } }
			public int x3F8 { get { return Read<int>(0x3F8); } }
			public int x3FC { get { return Read<int>(0x3FC); } }
			public int x404 { get { return Read<int>(0x404); } }
			public int x408 { get { return Read<int>(0x408); } }
			public int x40C { get { return Read<int>(0x40C); } }
			public int x410 { get { return Read<int>(0x410); } }
			public int x414 { get { return Read<int>(0x414); } }
			public int x418 { get { return Read<int>(0x418); } }
			public int x41C { get { return Read<int>(0x41C); } }
			public int x420 { get { return Read<int>(0x420); } }
			public int x424 { get { return Read<int>(0x424); } }
			public int x428 { get { return Read<int>(0x428); } }
			public int x42C { get { return Read<int>(0x42C); } }
			public int x430 { get { return Read<int>(0x430); } }
			public int x434 { get { return Read<int>(0x434); } }
			public int x438 { get { return Read<int>(0x438); } }
			public int x43C { get { return Read<int>(0x43C); } }
			public int x440 { get { return Read<int>(0x440); } }
			public int x444 { get { return Read<int>(0x444); } }
			public int x448 { get { return Read<int>(0x448); } }
			public int x44C { get { return Read<int>(0x44C); } }
			public int x450 { get { return Read<int>(0x450); } }
			public int x454 { get { return Read<int>(0x454); } }
			public int x458 { get { return Read<int>(0x458); } }
			public int x45C { get { return Read<int>(0x45C); } }
			public int x460 { get { return Read<int>(0x460); } }
			public int x464 { get { return Read<int>(0x464); } }
			public int x468 { get { return Read<int>(0x468); } }
			public int x46C { get { return Read<int>(0x46C); } }
			public int x470 { get { return Read<int>(0x470); } }
			public int x474 { get { return Read<int>(0x474); } }
		}
		
		[CompilerGenerated]
		public partial class QualityClass : MemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x168; // 360
			
			public string x000_Text { get { return ReadString(0x000, 256); } }
			public int x100 { get { return Read<int>(0x100); } }
			public int x104 { get { return Read<int>(0x104); } }
			public float x10C { get { return Read<float>(0x10C); } }
			public float x110 { get { return Read<float>(0x110); } }
			public float x114 { get { return Read<float>(0x114); } }
			public float x118 { get { return Read<float>(0x118); } }
			public float x11C { get { return Read<float>(0x11C); } }
			public float x120 { get { return Read<float>(0x120); } }
			public float x124 { get { return Read<float>(0x124); } }
			public float x128 { get { return Read<float>(0x128); } }
			public float x12C { get { return Read<float>(0x12C); } }
			public float x130 { get { return Read<float>(0x130); } }
			public float x134 { get { return Read<float>(0x134); } }
			public float x138 { get { return Read<float>(0x138); } }
			public float x13C { get { return Read<float>(0x13C); } }
			public float x140 { get { return Read<float>(0x140); } }
			public float x144 { get { return Read<float>(0x144); } }
			public float x148 { get { return Read<float>(0x148); } }
			public float x14C { get { return Read<float>(0x14C); } }
			public float x150 { get { return Read<float>(0x150); } }
			public float x154 { get { return Read<float>(0x154); } }
			public float x158 { get { return Read<float>(0x158); } }
			public float x15C { get { return Read<float>(0x15C); } }
			public float x160 { get { return Read<float>(0x160); } }
			public int x164 { get { return Read<int>(0x164); } }
		}
		
		[CompilerGenerated]
		public partial class HandicapLevel : MemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x120; // 288
			
			public string x000_Text { get { return ReadString(0x000, 256); } }
			public int x100 { get { return Read<int>(0x100); } }
			public int x104 { get { return Read<int>(0x104); } }
			public float x108 { get { return Read<float>(0x108); } }
			public float x10C { get { return Read<float>(0x10C); } }
			public float x110 { get { return Read<float>(0x110); } }
			public float x114 { get { return Read<float>(0x114); } }
			public float x118 { get { return Read<float>(0x118); } }
			public float x11C { get { return Read<float>(0x11C); } }
		}
		
		[CompilerGenerated]
		public partial class ItemSalvageLevel : MemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x118; // 280
			
			public string x000_Text { get { return ReadString(0x000, 256); } }
			public int x100 { get { return Read<int>(0x100); } }
			public int x104 { get { return Read<int>(0x104); } }
			public Sno x108_TreasureClassSno { get { return Read<Sno>(0x108); } }
			public Sno x10C_TreasureClassSno { get { return Read<Sno>(0x10C); } }
			public Sno x110_TreasureClassSno { get { return Read<Sno>(0x110); } }
			public Sno x114_TreasureClassSno { get { return Read<Sno>(0x114); } }
		}
		
		[CompilerGenerated]
		public partial class HirelingEntry : MemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x148; // 328
			
			public string x000_Text { get { return ReadString(0x000, 256); } }
			public int x100 { get { return Read<int>(0x100); } }
			public int x104 { get { return Read<int>(0x104); } }
			public Sno x108_ActorSno { get { return Read<Sno>(0x108); } }
			public Sno x10C_ActorSno { get { return Read<Sno>(0x10C); } }
			public Sno x110_ActorSno { get { return Read<Sno>(0x110); } }
			public Sno x114_TreasureClassSno { get { return Read<Sno>(0x114); } }
			public int x118_Enum { get { return Read<int>(0x118); } } // None = -1, Strength = 0, Dexterity = 1, Intelligence = 2
			public float x11C { get { return Read<float>(0x11C); } }
			public float x120 { get { return Read<float>(0x120); } }
			public float x124 { get { return Read<float>(0x124); } }
			public float x128 { get { return Read<float>(0x128); } }
			public float x12C { get { return Read<float>(0x12C); } }
			public float x130 { get { return Read<float>(0x130); } }
			public float x134 { get { return Read<float>(0x134); } }
			public float x138 { get { return Read<float>(0x138); } }
			public float x13C { get { return Read<float>(0x13C); } }
			public float x140 { get { return Read<float>(0x140); } }
			public float x144 { get { return Read<float>(0x144); } }
		}
		
		[CompilerGenerated]
		public partial class SetItemBonusTableEntry : SerializeMemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x1D0; // 464
			
			public string x000_Text { get { return ReadString(0x000, 256); } }
			public int x100 { get { return Read<int>(0x100); } }
			public int x104 { get { return Read<int>(0x104); } }
			public GameBalanceId x108_SetItemBonusesGameBalanceId { get { return Read<GameBalanceId>(0x108); } }
			public int x10C { get { return Read<int>(0x10C); } }
			public AttributeSpecifier[] x110_AttributeSpecifiers { get { return Read<AttributeSpecifier>(0x110, 8); } }
		}
		
		[CompilerGenerated]
		public partial class EliteModifierData : MemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x160; // 352
			
			public string x000_Text { get { return ReadString(0x000, 256); } }
			public int x100 { get { return Read<int>(0x100); } }
			public int x104 { get { return Read<int>(0x104); } }
			public float x108 { get { return Read<float>(0x108); } }
			public Time x10C_Time { get { return Read<Time>(0x10C); } }
			public float x110 { get { return Read<float>(0x110); } }
			public Time x114_Time { get { return Read<Time>(0x114); } }
			public float x118 { get { return Read<float>(0x118); } }
			public Time x11C_Time { get { return Read<Time>(0x11C); } }
			public float x120 { get { return Read<float>(0x120); } }
			public Time x124_Time { get { return Read<Time>(0x124); } }
			public float x128 { get { return Read<float>(0x128); } }
			public Time x12C_Time { get { return Read<Time>(0x12C); } }
			public float x130 { get { return Read<float>(0x130); } }
			public Time x134_Time { get { return Read<Time>(0x134); } }
			public float x138 { get { return Read<float>(0x138); } }
			public Time x13C_Time { get { return Read<Time>(0x13C); } }
			public float x140 { get { return Read<float>(0x140); } }
			public float x144 { get { return Read<float>(0x144); } }
			public Time x148_Time { get { return Read<Time>(0x148); } }
			public float x14C { get { return Read<float>(0x14C); } }
			public float x150 { get { return Read<float>(0x150); } }
			public float x154 { get { return Read<float>(0x154); } }
			public float x158 { get { return Read<float>(0x158); } }
			public int x15C { get { return Read<int>(0x15C); } }
		}
		
		[CompilerGenerated]
		public partial class ItemTierData : MemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x20; // 32
			
			public GameBalanceId x00_ItemsGameBalanceId { get { return Read<GameBalanceId>(0x00); } }
			public GameBalanceId x04_ItemsGameBalanceId { get { return Read<GameBalanceId>(0x04); } }
			public GameBalanceId x08_ItemsGameBalanceId { get { return Read<GameBalanceId>(0x08); } }
			public GameBalanceId x0C_ItemsGameBalanceId { get { return Read<GameBalanceId>(0x0C); } }
			public GameBalanceId x10_ItemsGameBalanceId { get { return Read<GameBalanceId>(0x10); } }
			public GameBalanceId x14_ItemsGameBalanceId { get { return Read<GameBalanceId>(0x14); } }
			public GameBalanceId x18_ItemsGameBalanceId { get { return Read<GameBalanceId>(0x18); } }
			public GameBalanceId x1C_ItemsGameBalanceId { get { return Read<GameBalanceId>(0x1C); } }
		}
		
		[CompilerGenerated]
		public partial class PowerFormulaTableEntry : MemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x530; // 1328
			
			public string x000_Text { get { return ReadString(0x000, 1024); } }
			public float x400 { get { return Read<float>(0x400); } }
			public float x404 { get { return Read<float>(0x404); } }
			public float x408 { get { return Read<float>(0x408); } }
			public float x40C { get { return Read<float>(0x40C); } }
			public float x410 { get { return Read<float>(0x410); } }
			public float x414 { get { return Read<float>(0x414); } }
			public float x418 { get { return Read<float>(0x418); } }
			public float x41C { get { return Read<float>(0x41C); } }
			public float x420 { get { return Read<float>(0x420); } }
			public float x424 { get { return Read<float>(0x424); } }
			public float x428 { get { return Read<float>(0x428); } }
			public float x42C { get { return Read<float>(0x42C); } }
			public float x430 { get { return Read<float>(0x430); } }
			public float x434 { get { return Read<float>(0x434); } }
			public float x438 { get { return Read<float>(0x438); } }
			public float x43C { get { return Read<float>(0x43C); } }
			public float x440 { get { return Read<float>(0x440); } }
			public float x444 { get { return Read<float>(0x444); } }
			public float x448 { get { return Read<float>(0x448); } }
			public float x44C { get { return Read<float>(0x44C); } }
			public float x450 { get { return Read<float>(0x450); } }
			public float x454 { get { return Read<float>(0x454); } }
			public float x458 { get { return Read<float>(0x458); } }
			public float x45C { get { return Read<float>(0x45C); } }
			public float x460 { get { return Read<float>(0x460); } }
			public float x464 { get { return Read<float>(0x464); } }
			public float x468 { get { return Read<float>(0x468); } }
			public float x46C { get { return Read<float>(0x46C); } }
			public float x470 { get { return Read<float>(0x470); } }
			public float x474 { get { return Read<float>(0x474); } }
			public float x478 { get { return Read<float>(0x478); } }
			public float x47C { get { return Read<float>(0x47C); } }
			public float x480 { get { return Read<float>(0x480); } }
			public float x484 { get { return Read<float>(0x484); } }
			public float x488 { get { return Read<float>(0x488); } }
			public float x48C { get { return Read<float>(0x48C); } }
			public float x490 { get { return Read<float>(0x490); } }
			public float x494 { get { return Read<float>(0x494); } }
			public float x498 { get { return Read<float>(0x498); } }
			public float x49C { get { return Read<float>(0x49C); } }
			public float x4A0 { get { return Read<float>(0x4A0); } }
			public float x4A4 { get { return Read<float>(0x4A4); } }
			public float x4A8 { get { return Read<float>(0x4A8); } }
			public float x4AC { get { return Read<float>(0x4AC); } }
			public float x4B0 { get { return Read<float>(0x4B0); } }
			public float x4B4 { get { return Read<float>(0x4B4); } }
			public float x4B8 { get { return Read<float>(0x4B8); } }
			public float x4BC { get { return Read<float>(0x4BC); } }
			public float x4C0 { get { return Read<float>(0x4C0); } }
			public float x4C4 { get { return Read<float>(0x4C4); } }
			public float x4C8 { get { return Read<float>(0x4C8); } }
			public float x4CC { get { return Read<float>(0x4CC); } }
			public float x4D0 { get { return Read<float>(0x4D0); } }
			public float x4D4 { get { return Read<float>(0x4D4); } }
			public float x4D8 { get { return Read<float>(0x4D8); } }
			public float x4DC { get { return Read<float>(0x4DC); } }
			public float x4E0 { get { return Read<float>(0x4E0); } }
			public float x4E4 { get { return Read<float>(0x4E4); } }
			public float x4E8 { get { return Read<float>(0x4E8); } }
			public float x4EC { get { return Read<float>(0x4EC); } }
			public float x4F0 { get { return Read<float>(0x4F0); } }
			public float x4F4 { get { return Read<float>(0x4F4); } }
			public float x4F8 { get { return Read<float>(0x4F8); } }
			public float x4FC { get { return Read<float>(0x4FC); } }
			public float x500 { get { return Read<float>(0x500); } }
			public float x504 { get { return Read<float>(0x504); } }
			public float x508 { get { return Read<float>(0x508); } }
			public float x50C { get { return Read<float>(0x50C); } }
			public float x510 { get { return Read<float>(0x510); } }
			public float x514 { get { return Read<float>(0x514); } }
			public float x518 { get { return Read<float>(0x518); } }
			public float x51C { get { return Read<float>(0x51C); } }
			public float x520 { get { return Read<float>(0x520); } }
			public float x524 { get { return Read<float>(0x524); } }
			public float x528 { get { return Read<float>(0x528); } }
			public float x52C { get { return Read<float>(0x52C); } }
		}
		
		[CompilerGenerated]
		public partial class RecipeEntry : MemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x150; // 336
			
			public string x000_Text { get { return ReadString(0x000, 256); } }
			public int x100 { get { return Read<int>(0x100); } }
			public int x104 { get { return Read<int>(0x104); } }
			public Sno x108_RecipeSno { get { return Read<Sno>(0x108); } }
			public int x10C_Enum { get { return Read<int>(0x10C); } } // Blacksmith = 0, Jeweler = 1, Mystic = 2, Made To Order = 3, Devil's Hand = 4, Jewel Upgrade = 5, - None - = -1
			public int x110 { get { return Read<int>(0x110); } }
			public int x114 { get { return Read<int>(0x114); } }
			public int x118 { get { return Read<int>(0x118); } }
			public int x11C { get { return Read<int>(0x11C); } }
			public RecipeIngredient[] x120_RecipeIngredients { get { return Read<RecipeIngredient>(0x120, 6); } }
		}
		
		[CompilerGenerated]
		public partial class ScriptedAchievementEvent : MemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x108; // 264
			
			public string x000_Text { get { return ReadString(0x000, 256); } }
			public int x100 { get { return Read<int>(0x100); } }
			public int x104 { get { return Read<int>(0x104); } }
		}
		
		[CompilerGenerated]
		public partial class ItemDurabilityCostScalar : MemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x08; // 8
			
			public float x00 { get { return Read<float>(0x00); } }
			public float x04 { get { return Read<float>(0x04); } }
		}
		
		[CompilerGenerated]
		public partial class LootRunQuestTierEntry : MemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x208; // 520
			
			public string x000_Text { get { return ReadString(0x000, 256); } }
			public int x100 { get { return Read<int>(0x100); } }
			public int x104 { get { return Read<int>(0x104); } }
			public Sno x108_QuestSno { get { return Read<Sno>(0x108); } }
			public float x10C { get { return Read<float>(0x10C); } }
			public GameBalanceId x110_GameBalanceId { get { return Read<GameBalanceId>(0x110); } }
			public GameBalanceId x114_ItemsGameBalanceId { get { return Read<GameBalanceId>(0x114); } }
			public Sno x118_QuestSno { get { return Read<Sno>(0x118); } }
			public float x11C { get { return Read<float>(0x11C); } }
			public GameBalanceId x120_GameBalanceId { get { return Read<GameBalanceId>(0x120); } }
			public GameBalanceId x124_ItemsGameBalanceId { get { return Read<GameBalanceId>(0x124); } }
			public Sno x128_QuestSno { get { return Read<Sno>(0x128); } }
			public float x12C { get { return Read<float>(0x12C); } }
			public GameBalanceId x130_GameBalanceId { get { return Read<GameBalanceId>(0x130); } }
			public GameBalanceId x134_ItemsGameBalanceId { get { return Read<GameBalanceId>(0x134); } }
			public Sno x138_QuestSno { get { return Read<Sno>(0x138); } }
			public float x13C { get { return Read<float>(0x13C); } }
			public GameBalanceId x140_GameBalanceId { get { return Read<GameBalanceId>(0x140); } }
			public GameBalanceId x144_ItemsGameBalanceId { get { return Read<GameBalanceId>(0x144); } }
			public Sno x148_QuestSno { get { return Read<Sno>(0x148); } }
			public float x14C { get { return Read<float>(0x14C); } }
			public GameBalanceId x150_GameBalanceId { get { return Read<GameBalanceId>(0x150); } }
			public GameBalanceId x154_ItemsGameBalanceId { get { return Read<GameBalanceId>(0x154); } }
			public Sno x158_QuestSno { get { return Read<Sno>(0x158); } }
			public float x15C { get { return Read<float>(0x15C); } }
			public GameBalanceId x160_GameBalanceId { get { return Read<GameBalanceId>(0x160); } }
			public GameBalanceId x164_ItemsGameBalanceId { get { return Read<GameBalanceId>(0x164); } }
			public Sno x168_QuestSno { get { return Read<Sno>(0x168); } }
			public float x16C { get { return Read<float>(0x16C); } }
			public GameBalanceId x170_GameBalanceId { get { return Read<GameBalanceId>(0x170); } }
			public GameBalanceId x174_ItemsGameBalanceId { get { return Read<GameBalanceId>(0x174); } }
			public Sno x178_QuestSno { get { return Read<Sno>(0x178); } }
			public float x17C { get { return Read<float>(0x17C); } }
			public GameBalanceId x180_GameBalanceId { get { return Read<GameBalanceId>(0x180); } }
			public GameBalanceId x184_ItemsGameBalanceId { get { return Read<GameBalanceId>(0x184); } }
			public Sno x188_QuestSno { get { return Read<Sno>(0x188); } }
			public float x18C { get { return Read<float>(0x18C); } }
			public GameBalanceId x190_GameBalanceId { get { return Read<GameBalanceId>(0x190); } }
			public GameBalanceId x194_ItemsGameBalanceId { get { return Read<GameBalanceId>(0x194); } }
			public Sno x198_QuestSno { get { return Read<Sno>(0x198); } }
			public float x19C { get { return Read<float>(0x19C); } }
			public GameBalanceId x1A0_GameBalanceId { get { return Read<GameBalanceId>(0x1A0); } }
			public GameBalanceId x1A4_ItemsGameBalanceId { get { return Read<GameBalanceId>(0x1A4); } }
			public Sno x1A8_QuestSno { get { return Read<Sno>(0x1A8); } }
			public float x1AC { get { return Read<float>(0x1AC); } }
			public GameBalanceId x1B0_GameBalanceId { get { return Read<GameBalanceId>(0x1B0); } }
			public GameBalanceId x1B4_ItemsGameBalanceId { get { return Read<GameBalanceId>(0x1B4); } }
			public Sno x1B8_QuestSno { get { return Read<Sno>(0x1B8); } }
			public float x1BC { get { return Read<float>(0x1BC); } }
			public GameBalanceId x1C0_GameBalanceId { get { return Read<GameBalanceId>(0x1C0); } }
			public GameBalanceId x1C4_ItemsGameBalanceId { get { return Read<GameBalanceId>(0x1C4); } }
			public Sno x1C8_QuestSno { get { return Read<Sno>(0x1C8); } }
			public float x1CC { get { return Read<float>(0x1CC); } }
			public GameBalanceId x1D0_GameBalanceId { get { return Read<GameBalanceId>(0x1D0); } }
			public GameBalanceId x1D4_ItemsGameBalanceId { get { return Read<GameBalanceId>(0x1D4); } }
			public Sno x1D8_QuestSno { get { return Read<Sno>(0x1D8); } }
			public float x1DC { get { return Read<float>(0x1DC); } }
			public GameBalanceId x1E0_GameBalanceId { get { return Read<GameBalanceId>(0x1E0); } }
			public GameBalanceId x1E4_ItemsGameBalanceId { get { return Read<GameBalanceId>(0x1E4); } }
			public Sno x1E8_QuestSno { get { return Read<Sno>(0x1E8); } }
			public float x1EC { get { return Read<float>(0x1EC); } }
			public GameBalanceId x1F0_GameBalanceId { get { return Read<GameBalanceId>(0x1F0); } }
			public GameBalanceId x1F4_ItemsGameBalanceId { get { return Read<GameBalanceId>(0x1F4); } }
			public Sno x1F8_QuestSno { get { return Read<Sno>(0x1F8); } }
			public float x1FC { get { return Read<float>(0x1FC); } }
			public GameBalanceId x200_GameBalanceId { get { return Read<GameBalanceId>(0x200); } }
			public GameBalanceId x204_ItemsGameBalanceId { get { return Read<GameBalanceId>(0x204); } }
		}
		
		[CompilerGenerated]
		public partial class ParagonBonus : SerializeMemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x280; // 640
			
			public string x000_Text { get { return ReadString(0x000, 256); } }
			public int x100 { get { return Read<int>(0x100); } }
			public int x104 { get { return Read<int>(0x104); } }
			public int x108 { get { return Read<int>(0x108); } }
			public AttributeSpecifier[] x110_AttributeSpecifiers { get { return Read<AttributeSpecifier>(0x110, 4); } }
			public int x170 { get { return Read<int>(0x170); } }
			public int x174 { get { return Read<int>(0x174); } }
			public int x178_Enum { get { return Read<int>(0x178); } } // - None - = -1, DemonHunter = 0, Barbarian = 1, Wizard = 2, Witchdoctor = 3, Monk = 4, Crusader = 5
			public string x17C_Text { get { return ReadString(0x17C, 256); } }
		}
		
		[CompilerGenerated]
		public partial class MadeToOrderTypesEntry : MemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x130; // 304
			
			public string x000_Text { get { return ReadString(0x000, 256); } }
			public int x100 { get { return Read<int>(0x100); } }
			public int x104 { get { return Read<int>(0x104); } }
			public int x108 { get { return Read<int>(0x108); } }
			public int x10C { get { return Read<int>(0x10C); } }
			public RecipeIngredient[] x110_RecipeIngredients { get { return Read<RecipeIngredient>(0x110, 3); } }
			public int x128 { get { return Read<int>(0x128); } }
			public int x12C { get { return Read<int>(0x12C); } }
		}
		
		[CompilerGenerated]
		public partial class MadeToOrderAffixFoldersEntry : MemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x178; // 376
			
			public string x000_Text { get { return ReadString(0x000, 256); } }
			public int x100 { get { return Read<int>(0x100); } }
			public int x104 { get { return Read<int>(0x104); } }
			public int x108 { get { return Read<int>(0x108); } }
			public GameBalanceId x10C_MadeToOrderAffixFoldersGameBalanceId { get { return Read<GameBalanceId>(0x10C); } }
			public GameBalanceId[] x110_GameBalanceIds { get { return Read<GameBalanceId>(0x110, 24); } }
			public int x170 { get { return Read<int>(0x170); } }
			public int x174 { get { return Read<int>(0x174); } }
		}
		
		[CompilerGenerated]
		public partial class DevilsHandRedeemableSet : MemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x180; // 384
			
			public string x000_Text { get { return ReadString(0x000, 256); } }
			public int x100 { get { return Read<int>(0x100); } }
			public int x104 { get { return Read<int>(0x104); } }
			public int x108 { get { return Read<int>(0x108); } }
			public bool x10C_Bit0 { get { return (Read<int>(0x10C) & 0x00000001) != 0; } }
			public bool x10C_Bit1 { get { return (Read<int>(0x10C) & 0x00000002) != 0; } }
			public DevilsHandRedeemableSetReward[] x110_DevilsHandRedeemableSetRewards { get { return Read<DevilsHandRedeemableSetReward>(0x110, 8); } }
			public int x150 { get { return Read<int>(0x150); } }
			public Sno x154_LoreSno { get { return Read<Sno>(0x154); } }
			public GameBalanceId[] x158_GameBalanceIds { get { return Read<GameBalanceId>(0x158, 8); } }
			public int x178 { get { return Read<int>(0x178); } }
		}
		
		[CompilerGenerated]
		public partial class LegacyItemConversion : MemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x110; // 272
			
			public string x000_Text { get { return ReadString(0x000, 256); } }
			public int x100 { get { return Read<int>(0x100); } }
			public int x104 { get { return Read<int>(0x104); } }
			public GameBalanceId x108_ItemsGameBalanceId { get { return Read<GameBalanceId>(0x108); } }
			public GameBalanceId x10C_ItemsGameBalanceId { get { return Read<GameBalanceId>(0x10C); } }
		}
		
		[CompilerGenerated]
		public partial class EnchantItemAffixUseCountCostScalar : MemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x08; // 8
			
			public int x00 { get { return Read<int>(0x00); } }
			public float x04 { get { return Read<float>(0x04); } }
		}
		
		[CompilerGenerated]
		public partial class TieredLootRunLevel : MemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x128; // 296
			
			public string x000_Text { get { return ReadString(0x000, 256); } }
			public int x100 { get { return Read<int>(0x100); } }
			public int x104 { get { return Read<int>(0x104); } }
			public float x108 { get { return Read<float>(0x108); } }
			public float x10C { get { return Read<float>(0x10C); } }
			public float x110 { get { return Read<float>(0x110); } }
			public float x114 { get { return Read<float>(0x114); } }
			public float x118 { get { return Read<float>(0x118); } }
			public float x11C { get { return Read<float>(0x11C); } }
			public float x120 { get { return Read<float>(0x120); } }
			public int x124 { get { return Read<int>(0x124); } }
		}
		
		[CompilerGenerated]
		public partial class RecipeIngredient : MemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x08; // 8
			
			public GameBalanceId x00_ItemsGameBalanceId { get { return Read<GameBalanceId>(0x00); } }
			public int x04 { get { return Read<int>(0x04); } }
		}
		
		[CompilerGenerated]
		public partial class AttributeSpecifier : SerializeMemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x18; // 24
			
			public Translateable x00_Translateable { get { return Read<Translateable>(0x00); } } // TranslateFromString = 0x010E3C50, TranslateFromValue = 0x010E3D00
			public AttributeParameter x04_AttributeParameter { get { return Read<AttributeParameter>(0x04); } }
			public string x08_Text { get { return DeserializeString(x10_SerializeData); } }
			public SerializeData x10_SerializeData { get { return Read<SerializeData>(0x10); } }
		}
		
		[CompilerGenerated]
		public partial class DevilsHandRedeemableSetReward : MemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x08; // 8
			
			public GameBalanceId x00_GameBalanceId { get { return Read<GameBalanceId>(0x00); } }
			public int x04 { get { return Read<int>(0x04); } }
		}
	}
}
