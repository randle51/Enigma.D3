using System.Runtime.CompilerServices;
using Enigma.D3.Collections;
using Enigma.D3.Memory;

namespace Enigma.D3.Sno
{
	[CompilerGenerated]
	public partial class GameBalance : SerializeMemoryObject
	{
		// 2.0.6.24641
		public const int SizeOf = 0x248; // 584
		
		public int x00C { get { return Field<int>(0x00C); } }
		public int x010 { get { return Field<int>(0x010); } }
		public int x014 { get { return Field<int>(0x014); } }
		public ItemTypes x018_ItemTypes { get { return Field<ItemTypes>(0x018); } }
		public Items x028_Items { get { return Field<Items>(0x028); } }
		public ExperienceTable x038_ExperienceTable { get { return Field<ExperienceTable>(0x038); } }
		public HelpCodes x048_HelpCodes { get { return Field<HelpCodes>(0x048); } }
		public MonsterLevelTable x058_MonsterLevelTable { get { return Field<MonsterLevelTable>(0x058); } }
		public AffixTable x068_AffixTable { get { return Field<AffixTable>(0x068); } }
		public Heros x078_Heros { get { return Field<Heros>(0x078); } }
		public MovementStyles x088_MovementStyles { get { return Field<MovementStyles>(0x088); } }
		public Labels x098_Labels { get { return Field<Labels>(0x098); } }
		public LootDistributionTable x0A8_LootDistributionTable { get { return Field<LootDistributionTable>(0x0A8); } }
		public RareItemNamesTable x0B8_RareItemNamesTable { get { return Field<RareItemNamesTable>(0x0B8); } }
		public MonsterAffixesTable x0C8_MonsterAffixesTable { get { return Field<MonsterAffixesTable>(0x0C8); } }
		public RareMonsterNamesTable x0D8_RareMonsterNamesTable { get { return Field<RareMonsterNamesTable>(0x0D8); } }
		public SocketedEffectsTable x0E8_SocketedEffectsTable { get { return Field<SocketedEffectsTable>(0x0E8); } }
		public ItemEnchantmentTable x0F8_ItemEnchantmentTable { get { return Field<ItemEnchantmentTable>(0x0F8); } }
		public ItemDropTable x108_ItemDropTable { get { return Field<ItemDropTable>(0x108); } }
		public ItemLevelModTable x118_ItemLevelModTable { get { return Field<ItemLevelModTable>(0x118); } }
		public QualityClassTable x128_QualityClassTable { get { return Field<QualityClassTable>(0x128); } }
		public HandicapLevelTable x138_HandicapLevelTable { get { return Field<HandicapLevelTable>(0x138); } }
		public ItemSalvageLevelTable x148_ItemSalvageLevelTable { get { return Field<ItemSalvageLevelTable>(0x148); } }
		public Hirelings x158_Hirelings { get { return Field<Hirelings>(0x158); } }
		public SetItemBonusTable x168_SetItemBonusTable { get { return Field<SetItemBonusTable>(0x168); } }
		public EliteModifiers x178_EliteModifiers { get { return Field<EliteModifiers>(0x178); } }
		public ItemTiers x188_ItemTiers { get { return Field<ItemTiers>(0x188); } }
		public PowerFormulaTable x198_PowerFormulaTable { get { return Field<PowerFormulaTable>(0x198); } }
		public RecipesTable x1A8_RecipesTable { get { return Field<RecipesTable>(0x1A8); } }
		public ScriptedAchievementEventsTable x1B8_ScriptedAchievementEventsTable { get { return Field<ScriptedAchievementEventsTable>(0x1B8); } }
		public ItemDurabilityCostScalarsTable x1C8_ItemDurabilityCostScalarsTable { get { return Field<ItemDurabilityCostScalarsTable>(0x1C8); } }
		public LootRunQuestTierTable x1D8_LootRunQuestTierTable { get { return Field<LootRunQuestTierTable>(0x1D8); } }
		public ParagonBonusesTable x1E8_ParagonBonusesTable { get { return Field<ParagonBonusesTable>(0x1E8); } }
		public MadeToOrderTypesTable x1F8_MadeToOrderTypesTable { get { return Field<MadeToOrderTypesTable>(0x1F8); } }
		public MadeToOrderAffixFoldersTable x208_MadeToOrderAffixFoldersTable { get { return Field<MadeToOrderAffixFoldersTable>(0x208); } }
		public DevilsHandRedeemableSetTable x218_DevilsHandRedeemableSetTable { get { return Field<DevilsHandRedeemableSetTable>(0x218); } }
		public LegacyItemConversionTable x228_LegacyItemConversionTable { get { return Field<LegacyItemConversionTable>(0x228); } }
		public EnchantItemAffixUseCountCostScalarsTable x238_EnchantItemAffixUseCountCostScalarsTable { get { return Field<EnchantItemAffixUseCountCostScalarsTable>(0x238); } }
		
		[CompilerGenerated]
		public partial class ItemTypes : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x10; // 16
			
			public SerializeData x00_SerializeData { get { return Field<SerializeData>(0x00); } }
			public ItemType[] x08_ItemTypes { get { return Deserialize<ItemType>(x00_SerializeData); } }
		}
		
		[CompilerGenerated]
		public partial class Items : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x10; // 16
			
			public SerializeData x00_SerializeData { get { return Field<SerializeData>(0x00); } }
			public Item[] x08_Items { get { return Deserialize<Item>(x00_SerializeData); } }
		}
		
		[CompilerGenerated]
		public partial class ExperienceTable : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x10; // 16
			
			public SerializeData x00_SerializeData { get { return Field<SerializeData>(0x00); } }
			public ExperienceLevel[] x08_ExperienceLevels { get { return Deserialize<ExperienceLevel>(x00_SerializeData); } }
		}
		
		[CompilerGenerated]
		public partial class HelpCodes : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x10; // 16
			
			public SerializeData x00_SerializeData { get { return Field<SerializeData>(0x00); } }
			public HelpCodes[] x08_HelpCodes { get { return Deserialize<HelpCodes>(x00_SerializeData); } }
		}
		
		[CompilerGenerated]
		public partial class MonsterLevelTable : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x10; // 16
			
			public SerializeData x00_SerializeData { get { return Field<SerializeData>(0x00); } }
			public MonsterLevelDefinition[] x08_MonsterLevelDefinitions { get { return Deserialize<MonsterLevelDefinition>(x00_SerializeData); } }
		}
		
		[CompilerGenerated]
		public partial class AffixTable : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x10; // 16
			
			public SerializeData x00_SerializeData { get { return Field<SerializeData>(0x00); } }
			public AffixTableEntry[] x08_AffixTableEntries { get { return Deserialize<AffixTableEntry>(x00_SerializeData); } }
		}
		
		[CompilerGenerated]
		public partial class Heros : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x10; // 16
			
			public SerializeData x00_SerializeData { get { return Field<SerializeData>(0x00); } }
			public HeroData[] x08_HeroDatas { get { return Deserialize<HeroData>(x00_SerializeData); } }
		}
		
		[CompilerGenerated]
		public partial class MovementStyles : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x10; // 16
			
			public SerializeData x00_SerializeData { get { return Field<SerializeData>(0x00); } }
			public MovementStyleDefinition[] x08_MovementStyleDefinitions { get { return Deserialize<MovementStyleDefinition>(x00_SerializeData); } }
		}
		
		[CompilerGenerated]
		public partial class Labels : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x10; // 16
			
			public SerializeData x00_SerializeData { get { return Field<SerializeData>(0x00); } }
			public LabelGBID[] x08_LabelGBIDs { get { return Deserialize<LabelGBID>(x00_SerializeData); } }
		}
		
		[CompilerGenerated]
		public partial class LootDistributionTable : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x10; // 16
			
			public SerializeData x00_SerializeData { get { return Field<SerializeData>(0x00); } }
			public LootDistribution[] x08_LootDistributions { get { return Deserialize<LootDistribution>(x00_SerializeData); } }
		}
		
		[CompilerGenerated]
		public partial class RareItemNamesTable : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x10; // 16
			
			public SerializeData x00_SerializeData { get { return Field<SerializeData>(0x00); } }
			public RareItemNamesEntry[] x08_RareItemNamesEntries { get { return Deserialize<RareItemNamesEntry>(x00_SerializeData); } }
		}
		
		[CompilerGenerated]
		public partial class MonsterAffixesTable : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x10; // 16
			
			public SerializeData x00_SerializeData { get { return Field<SerializeData>(0x00); } }
			public MonsterAffixesEntry[] x08_MonsterAffixesEntries { get { return Deserialize<MonsterAffixesEntry>(x00_SerializeData); } }
		}
		
		[CompilerGenerated]
		public partial class RareMonsterNamesTable : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x10; // 16
			
			public SerializeData x00_SerializeData { get { return Field<SerializeData>(0x00); } }
			public RareMonsterNamesEntry[] x08_RareMonsterNamesEntries { get { return Deserialize<RareMonsterNamesEntry>(x00_SerializeData); } }
		}
		
		[CompilerGenerated]
		public partial class SocketedEffectsTable : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x10; // 16
			
			public SerializeData x00_SerializeData { get { return Field<SerializeData>(0x00); } }
			public SocketedEffectsTableEntry[] x08_SocketedEffectsTableEntries { get { return Deserialize<SocketedEffectsTableEntry>(x00_SerializeData); } }
		}
		
		[CompilerGenerated]
		public partial class ItemEnchantmentTable : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x10; // 16
			
			public SerializeData x00_SerializeData { get { return Field<SerializeData>(0x00); } }
			public ItemEnchantment[] x08_ItemEnchantments { get { return Deserialize<ItemEnchantment>(x00_SerializeData); } }
		}
		
		[CompilerGenerated]
		public partial class ItemDropTable : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x10; // 16
			
			public SerializeData x00_SerializeData { get { return Field<SerializeData>(0x00); } }
			public ItemDropTableEntry[] x08_ItemDropTableEntries { get { return Deserialize<ItemDropTableEntry>(x00_SerializeData); } }
		}
		
		[CompilerGenerated]
		public partial class ItemLevelModTable : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x10; // 16
			
			public SerializeData x00_SerializeData { get { return Field<SerializeData>(0x00); } }
			public LootDistribution[] x08_LootDistributions { get { return Deserialize<LootDistribution>(x00_SerializeData); } }
		}
		
		[CompilerGenerated]
		public partial class QualityClassTable : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x10; // 16
			
			public SerializeData x00_SerializeData { get { return Field<SerializeData>(0x00); } }
			public QualityClass[] x08_QualityClass { get { return Deserialize<QualityClass>(x00_SerializeData); } }
		}
		
		[CompilerGenerated]
		public partial class HandicapLevelTable : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x10; // 16
			
			public SerializeData x00_SerializeData { get { return Field<SerializeData>(0x00); } }
			public HandicapLevel[] x08_HandicapLevels { get { return Deserialize<HandicapLevel>(x00_SerializeData); } }
		}
		
		[CompilerGenerated]
		public partial class ItemSalvageLevelTable : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x10; // 16
			
			public SerializeData x00_SerializeData { get { return Field<SerializeData>(0x00); } }
			public ItemSalvageLevel[] x08_ItemSalvageLevels { get { return Deserialize<ItemSalvageLevel>(x00_SerializeData); } }
		}
		
		[CompilerGenerated]
		public partial class Hirelings : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x10; // 16
			
			public SerializeData x00_SerializeData { get { return Field<SerializeData>(0x00); } }
			public HirelingEntry[] x08_HirelingEntries { get { return Deserialize<HirelingEntry>(x00_SerializeData); } }
		}
		
		[CompilerGenerated]
		public partial class SetItemBonusTable : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x10; // 16
			
			public SerializeData x00_SerializeData { get { return Field<SerializeData>(0x00); } }
			public SetItemBonusTableEntry[] x08_SetItemBonusTableEntries { get { return Deserialize<SetItemBonusTableEntry>(x00_SerializeData); } }
		}
		
		[CompilerGenerated]
		public partial class EliteModifiers : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x10; // 16
			
			public SerializeData x00_SerializeData { get { return Field<SerializeData>(0x00); } }
			public EliteModifierData[] x08_EliteModifierDatas { get { return Deserialize<EliteModifierData>(x00_SerializeData); } }
		}
		
		[CompilerGenerated]
		public partial class ItemTiers : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x10; // 16
			
			public SerializeData x00_SerializeData { get { return Field<SerializeData>(0x00); } }
			public ItemTierData[] x08_ItemTierDatas { get { return Deserialize<ItemTierData>(x00_SerializeData); } }
		}
		
		[CompilerGenerated]
		public partial class PowerFormulaTable : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x10; // 16
			
			public SerializeData x00_SerializeData { get { return Field<SerializeData>(0x00); } }
			public PowerFormulaTableEntry[] x08_PowerFormulaTableEntries { get { return Deserialize<PowerFormulaTableEntry>(x00_SerializeData); } }
		}
		
		[CompilerGenerated]
		public partial class RecipesTable : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x10; // 16
			
			public SerializeData x00_SerializeData { get { return Field<SerializeData>(0x00); } }
			public RecipeEntry[] x08_RecipeEntries { get { return Deserialize<RecipeEntry>(x00_SerializeData); } }
		}
		
		[CompilerGenerated]
		public partial class ScriptedAchievementEventsTable : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x10; // 16
			
			public SerializeData x00_SerializeData { get { return Field<SerializeData>(0x00); } }
			public ScriptedAchievementEvent[] x08_ScriptedAchievementEvents { get { return Deserialize<ScriptedAchievementEvent>(x00_SerializeData); } }
		}
		
		[CompilerGenerated]
		public partial class ItemDurabilityCostScalarsTable : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x10; // 16
			
			public SerializeData x00_SerializeData { get { return Field<SerializeData>(0x00); } }
			public ItemDurabilityCostScalar[] x08_ItemDurabilityCostScalars { get { return Deserialize<ItemDurabilityCostScalar>(x00_SerializeData); } }
		}
		
		[CompilerGenerated]
		public partial class LootRunQuestTierTable : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x10; // 16
			
			public SerializeData x00_SerializeData { get { return Field<SerializeData>(0x00); } }
			public LootRunQuestTierEntry[] x08_LootRunQuestTierEntries { get { return Deserialize<LootRunQuestTierEntry>(x00_SerializeData); } }
		}
		
		[CompilerGenerated]
		public partial class ParagonBonusesTable : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x10; // 16
			
			public SerializeData x00_SerializeData { get { return Field<SerializeData>(0x00); } }
			public ParagonBonus[] x08_ParagonBonus { get { return Deserialize<ParagonBonus>(x00_SerializeData); } }
		}
		
		[CompilerGenerated]
		public partial class MadeToOrderTypesTable : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x10; // 16
			
			public SerializeData x00_SerializeData { get { return Field<SerializeData>(0x00); } }
			public MadeToOrderTypesEntry[] x08_MadeToOrderTypesEntries { get { return Deserialize<MadeToOrderTypesEntry>(x00_SerializeData); } }
		}
		
		[CompilerGenerated]
		public partial class MadeToOrderAffixFoldersTable : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x10; // 16
			
			public SerializeData x00_SerializeData { get { return Field<SerializeData>(0x00); } }
			public MadeToOrderAffixFoldersEntry[] x08_MadeToOrderAffixFoldersEntries { get { return Deserialize<MadeToOrderAffixFoldersEntry>(x00_SerializeData); } }
		}
		
		[CompilerGenerated]
		public partial class DevilsHandRedeemableSetTable : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x10; // 16
			
			public SerializeData x00_SerializeData { get { return Field<SerializeData>(0x00); } }
			public DevilsHandRedeemableSet[] x08_DevilsHandRedeemableSets { get { return Deserialize<DevilsHandRedeemableSet>(x00_SerializeData); } }
		}
		
		[CompilerGenerated]
		public partial class LegacyItemConversionTable : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x10; // 16
			
			public SerializeData x00_SerializeData { get { return Field<SerializeData>(0x00); } }
			public LegacyItemConversion[] x08_LegacyItemConversions { get { return Deserialize<LegacyItemConversion>(x00_SerializeData); } }
		}
		
		[CompilerGenerated]
		public partial class EnchantItemAffixUseCountCostScalarsTable : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x10; // 16
			
			public SerializeData x00_SerializeData { get { return Field<SerializeData>(0x00); } }
			public EnchantItemAffixUseCountCostScalar[] x08_EnchantItemAffixUseCountCostScalars { get { return Deserialize<EnchantItemAffixUseCountCostScalar>(x00_SerializeData); } }
		}
		
		[CompilerGenerated]
		public partial class ItemType : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x148; // 328
			
			public string x000_Text { get { return Field(0x000, 256); } }
			public int x100 { get { return Field<int>(0x100); } }
			public int x104 { get { return Field<int>(0x104); } }
			public GameBalanceId x108_ItemTypesGameBalanceId { get { return Field<GameBalanceId>(0x108); } }
			public int x10C { get { return Field<int>(0x10C); } }
			public int x110 { get { return Field<int>(0x110); } }
			public bool x114_Bit0 { get { return (Field<int>(0x114) & 0x00000001) != 0; } }
			public bool x114_Bit1 { get { return (Field<int>(0x114) & 0x00000002) != 0; } }
			public bool x114_Bit3 { get { return (Field<int>(0x114) & 0x00000008) != 0; } }
			public bool x114_Bit6 { get { return (Field<int>(0x114) & 0x00000040) != 0; } }
			public bool x114_Bit7 { get { return (Field<int>(0x114) & 0x00000080) != 0; } }
			public bool x114_Bit8 { get { return (Field<int>(0x114) & 0x00000100) != 0; } }
			public bool x114_Bit9 { get { return (Field<int>(0x114) & 0x00000200) != 0; } }
			public bool x114_Bit10 { get { return (Field<int>(0x114) & 0x00000400) != 0; } }
			public bool x114_Bit11 { get { return (Field<int>(0x114) & 0x00000800) != 0; } }
			public bool x114_Bit12 { get { return (Field<int>(0x114) & 0x00001000) != 0; } }
			public bool x114_Bit13 { get { return (Field<int>(0x114) & 0x00002000) != 0; } }
			public bool x114_Bit14 { get { return (Field<int>(0x114) & 0x00004000) != 0; } }
			public bool x114_Bit15 { get { return (Field<int>(0x114) & 0x00008000) != 0; } }
			public bool x114_Bit16 { get { return (Field<int>(0x114) & 0x00010000) != 0; } }
			public bool x114_Bit17 { get { return (Field<int>(0x114) & 0x00020000) != 0; } }
			public bool x114_Bit18 { get { return (Field<int>(0x114) & 0x00040000) != 0; } }
			public int x118_Enum { get { return Field<int>(0x118); } } // Player:Backpack = 0, Player:Head = 1, Player:Torso = 2, Player:RightHand = 3, Player:LeftHand = 4, Player:Hands = 5, Player:Waist = 6, Player:Feet = 7, Player:Shoulders = 8, Player:Legs = 9, Player:Bracers = 10, Player:LeftFinger = 12, Player:RightFinger = 11, Player:Neck = 13, Merchant = 18, Pet:RightHand = 21, Pet:LeftHand = 22, Pet:Special = 23, Pet:LeftFinger = 26, Pet:RightFinger = 25, Pet:Neck = 24
			public int x11C_Enum { get { return Field<int>(0x11C); } } // Player:Backpack = 0, Player:Head = 1, Player:Torso = 2, Player:RightHand = 3, Player:LeftHand = 4, Player:Hands = 5, Player:Waist = 6, Player:Feet = 7, Player:Shoulders = 8, Player:Legs = 9, Player:Bracers = 10, Player:LeftFinger = 12, Player:RightFinger = 11, Player:Neck = 13, Merchant = 18, Pet:RightHand = 21, Pet:LeftHand = 22, Pet:Special = 23, Pet:LeftFinger = 26, Pet:RightFinger = 25, Pet:Neck = 24
			public int x120_Enum { get { return Field<int>(0x120); } } // Player:Backpack = 0, Player:Head = 1, Player:Torso = 2, Player:RightHand = 3, Player:LeftHand = 4, Player:Hands = 5, Player:Waist = 6, Player:Feet = 7, Player:Shoulders = 8, Player:Legs = 9, Player:Bracers = 10, Player:LeftFinger = 12, Player:RightFinger = 11, Player:Neck = 13, Merchant = 18, Pet:RightHand = 21, Pet:LeftHand = 22, Pet:Special = 23, Pet:LeftFinger = 26, Pet:RightFinger = 25, Pet:Neck = 24
			public int x124_Enum { get { return Field<int>(0x124); } } // Player:Backpack = 0, Player:Head = 1, Player:Torso = 2, Player:RightHand = 3, Player:LeftHand = 4, Player:Hands = 5, Player:Waist = 6, Player:Feet = 7, Player:Shoulders = 8, Player:Legs = 9, Player:Bracers = 10, Player:LeftFinger = 12, Player:RightFinger = 11, Player:Neck = 13, Merchant = 18, Pet:RightHand = 21, Pet:LeftHand = 22, Pet:Special = 23, Pet:LeftFinger = 26, Pet:RightFinger = 25, Pet:Neck = 24
			public GameBalanceId x128_AffixListGameBalanceId { get { return Field<GameBalanceId>(0x128); } }
			public GameBalanceId x12C_AffixListGameBalanceId { get { return Field<GameBalanceId>(0x12C); } }
			public GameBalanceId x130_AffixListGameBalanceId { get { return Field<GameBalanceId>(0x130); } }
			public GameBalanceId x134_47GameBalanceId { get { return Field<GameBalanceId>(0x134); } }
			public int[] x138_int { get { return Field<int>(0x138, 4); } }
		}
		
		[CompilerGenerated]
		public partial class Item : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x740; // 1856
			
			public string x000_Text { get { return Field(0x000, 256); } }
			public int x100 { get { return Field<int>(0x100); } }
			public int x104 { get { return Field<int>(0x104); } }
			public Sno x108_ActorSno { get { return Field<Sno>(0x108); } }
			public GameBalanceId x10C_ItemTypesGameBalanceId { get { return Field<GameBalanceId>(0x10C); } }
			public bool x110_Bit0 { get { return (Field<int>(0x110) & 0x00000001) != 0; } }
			public bool x110_Bit1 { get { return (Field<int>(0x110) & 0x00000002) != 0; } }
			public bool x110_Bit2 { get { return (Field<int>(0x110) & 0x00000004) != 0; } }
			public bool x110_Bit3 { get { return (Field<int>(0x110) & 0x00000008) != 0; } }
			public bool x110_Bit4 { get { return (Field<int>(0x110) & 0x00000010) != 0; } }
			public bool x110_Bit5 { get { return (Field<int>(0x110) & 0x00000020) != 0; } }
			public bool x110_Bit6 { get { return (Field<int>(0x110) & 0x00000040) != 0; } }
			public bool x110_Bit7 { get { return (Field<int>(0x110) & 0x00000080) != 0; } }
			public bool x110_Bit8 { get { return (Field<int>(0x110) & 0x00000100) != 0; } }
			public bool x110_Bit9 { get { return (Field<int>(0x110) & 0x00000200) != 0; } }
			public bool x110_Bit10 { get { return (Field<int>(0x110) & 0x00000400) != 0; } }
			public bool x110_Bit11 { get { return (Field<int>(0x110) & 0x00000800) != 0; } }
			public bool x110_Bit12 { get { return (Field<int>(0x110) & 0x00001000) != 0; } }
			public bool x110_Bit13 { get { return (Field<int>(0x110) & 0x00002000) != 0; } }
			public bool x110_Bit14 { get { return (Field<int>(0x110) & 0x00004000) != 0; } }
			public bool x110_Bit15 { get { return (Field<int>(0x110) & 0x00008000) != 0; } }
			public bool x110_Bit16 { get { return (Field<int>(0x110) & 0x00010000) != 0; } }
			public bool x110_Bit17 { get { return (Field<int>(0x110) & 0x00020000) != 0; } }
			public bool x110_Bit18 { get { return (Field<int>(0x110) & 0x00040000) != 0; } }
			public bool x110_Bit19 { get { return (Field<int>(0x110) & 0x00080000) != 0; } }
			public bool x110_Bit20 { get { return (Field<int>(0x110) & 0x00100000) != 0; } }
			public bool x110_Bit21 { get { return (Field<int>(0x110) & 0x00200000) != 0; } }
			public int x114 { get { return Field<int>(0x114); } }
			public int x118 { get { return Field<int>(0x118); } }
			public int x11C_Enum { get { return Field<int>(0x11C); } } // Invalid = -1, A1 = 0, A2 = 100, A3 = 200, A4 = 300, A5 = 400, OpenWorld = 3000, Test = 1000
			public int x120 { get { return Field<int>(0x120); } }
			public int x124 { get { return Field<int>(0x124); } }
			public int x128 { get { return Field<int>(0x128); } }
			public int x12C { get { return Field<int>(0x12C); } }
			public int x130 { get { return Field<int>(0x130); } }
			public int x134 { get { return Field<int>(0x134); } }
			public int x138 { get { return Field<int>(0x138); } }
			public int x13C { get { return Field<int>(0x13C); } }
			public int x140 { get { return Field<int>(0x140); } }
			public int x144 { get { return Field<int>(0x144); } }
			public int x148 { get { return Field<int>(0x148); } }
			public int x14C { get { return Field<int>(0x14C); } }
			public int x150 { get { return Field<int>(0x150); } }
			public int x154 { get { return Field<int>(0x154); } }
			public int x158 { get { return Field<int>(0x158); } }
			public int x15C { get { return Field<int>(0x15C); } }
			public int x160 { get { return Field<int>(0x160); } }
			public int x164 { get { return Field<int>(0x164); } }
			public int x168 { get { return Field<int>(0x168); } }
			public int x16C { get { return Field<int>(0x16C); } }
			public GameBalanceId x170_ItemsGameBalanceId { get { return Field<GameBalanceId>(0x170); } }
			public GameBalanceId x174_SetItemBonusesGameBalanceId { get { return Field<GameBalanceId>(0x174); } }
			public Sno x178_TreasureClassSno { get { return Field<Sno>(0x178); } }
			public Sno x17C_TreasureClassSno { get { return Field<Sno>(0x17C); } }
			public Sno x180_TreasureClassSno { get { return Field<Sno>(0x180); } }
			public Sno x184_TreasureClassSno { get { return Field<Sno>(0x184); } }
			public Sno x188_StringListSno { get { return Field<Sno>(0x188); } }
			public Sno x18C_StringListSno { get { return Field<Sno>(0x18C); } }
			public int[] x190_int { get { return Field<int>(0x190, 4); } }
			public float x1F8 { get { return Field<float>(0x1F8); } }
			public float x1FC { get { return Field<float>(0x1FC); } }
			public float x254 { get { return Field<float>(0x254); } }
			public float x258 { get { return Field<float>(0x258); } }
			public float x304 { get { return Field<float>(0x304); } }
			public float x35C { get { return Field<float>(0x35C); } }
			public float x360 { get { return Field<float>(0x360); } }
			public Sno x3E8_PowerSno { get { return Field<Sno>(0x3E8); } }
			public int x3EC { get { return Field<int>(0x3EC); } }
			public Sno x3F0_PowerSno { get { return Field<Sno>(0x3F0); } }
			public int x3F4 { get { return Field<int>(0x3F4); } }
			public Sno x3F8_PowerSno { get { return Field<Sno>(0x3F8); } }
			public int x3FC { get { return Field<int>(0x3FC); } }
			public Sno x400_PowerSno { get { return Field<Sno>(0x400); } }
			public int x404 { get { return Field<int>(0x404); } }
			public Translateable x438_Translateable { get { return Field<Translateable>(0x438); } } // TranslateFromString = 0x01144690, TranslateFromValue = 0x01144740
			public AttributeParameter x43C_AttributeParameter { get { return Field<AttributeParameter>(0x43C); } }
			public string x440_Text { get { return Deserialize(x448_SerializeData); } }
			public SerializeData x448_SerializeData { get { return Field<SerializeData>(0x448); } }
			public Translateable x450_Translateable { get { return Field<Translateable>(0x450); } } // TranslateFromString = 0x01144690, TranslateFromValue = 0x01144740
			public AttributeParameter x454_AttributeParameter { get { return Field<AttributeParameter>(0x454); } }
			public string x458_Text { get { return Deserialize(x460_SerializeData); } }
			public SerializeData x460_SerializeData { get { return Field<SerializeData>(0x460); } }
			public Translateable x468_Translateable { get { return Field<Translateable>(0x468); } } // TranslateFromString = 0x01144690, TranslateFromValue = 0x01144740
			public AttributeParameter x46C_AttributeParameter { get { return Field<AttributeParameter>(0x46C); } }
			public string x470_Text { get { return Deserialize(x478_SerializeData); } }
			public SerializeData x478_SerializeData { get { return Field<SerializeData>(0x478); } }
			public Translateable x480_Translateable { get { return Field<Translateable>(0x480); } } // TranslateFromString = 0x01144690, TranslateFromValue = 0x01144740
			public AttributeParameter x484_AttributeParameter { get { return Field<AttributeParameter>(0x484); } }
			public string x488_Text { get { return Deserialize(x490_SerializeData); } }
			public SerializeData x490_SerializeData { get { return Field<SerializeData>(0x490); } }
			public Translateable x498_Translateable { get { return Field<Translateable>(0x498); } } // TranslateFromString = 0x01144690, TranslateFromValue = 0x01144740
			public AttributeParameter x49C_AttributeParameter { get { return Field<AttributeParameter>(0x49C); } }
			public string x4A0_Text { get { return Deserialize(x4A8_SerializeData); } }
			public SerializeData x4A8_SerializeData { get { return Field<SerializeData>(0x4A8); } }
			public Translateable x4B0_Translateable { get { return Field<Translateable>(0x4B0); } } // TranslateFromString = 0x01144690, TranslateFromValue = 0x01144740
			public AttributeParameter x4B4_AttributeParameter { get { return Field<AttributeParameter>(0x4B4); } }
			public string x4B8_Text { get { return Deserialize(x4C0_SerializeData); } }
			public SerializeData x4C0_SerializeData { get { return Field<SerializeData>(0x4C0); } }
			public Translateable x4C8_Translateable { get { return Field<Translateable>(0x4C8); } } // TranslateFromString = 0x01144690, TranslateFromValue = 0x01144740
			public AttributeParameter x4CC_AttributeParameter { get { return Field<AttributeParameter>(0x4CC); } }
			public string x4D0_Text { get { return Deserialize(x4D8_SerializeData); } }
			public SerializeData x4D8_SerializeData { get { return Field<SerializeData>(0x4D8); } }
			public Translateable x4E0_Translateable { get { return Field<Translateable>(0x4E0); } } // TranslateFromString = 0x01144690, TranslateFromValue = 0x01144740
			public AttributeParameter x4E4_AttributeParameter { get { return Field<AttributeParameter>(0x4E4); } }
			public string x4E8_Text { get { return Deserialize(x4F0_SerializeData); } }
			public SerializeData x4F0_SerializeData { get { return Field<SerializeData>(0x4F0); } }
			public Translateable x4F8_Translateable { get { return Field<Translateable>(0x4F8); } } // TranslateFromString = 0x01144690, TranslateFromValue = 0x01144740
			public AttributeParameter x4FC_AttributeParameter { get { return Field<AttributeParameter>(0x4FC); } }
			public string x500_Text { get { return Deserialize(x508_SerializeData); } }
			public SerializeData x508_SerializeData { get { return Field<SerializeData>(0x508); } }
			public Translateable x510_Translateable { get { return Field<Translateable>(0x510); } } // TranslateFromString = 0x01144690, TranslateFromValue = 0x01144740
			public AttributeParameter x514_AttributeParameter { get { return Field<AttributeParameter>(0x514); } }
			public string x518_Text { get { return Deserialize(x520_SerializeData); } }
			public SerializeData x520_SerializeData { get { return Field<SerializeData>(0x520); } }
			public Translateable x528_Translateable { get { return Field<Translateable>(0x528); } } // TranslateFromString = 0x01144690, TranslateFromValue = 0x01144740
			public AttributeParameter x52C_AttributeParameter { get { return Field<AttributeParameter>(0x52C); } }
			public string x530_Text { get { return Deserialize(x538_SerializeData); } }
			public SerializeData x538_SerializeData { get { return Field<SerializeData>(0x538); } }
			public Translateable x540_Translateable { get { return Field<Translateable>(0x540); } } // TranslateFromString = 0x01144690, TranslateFromValue = 0x01144740
			public AttributeParameter x544_AttributeParameter { get { return Field<AttributeParameter>(0x544); } }
			public string x548_Text { get { return Deserialize(x550_SerializeData); } }
			public SerializeData x550_SerializeData { get { return Field<SerializeData>(0x550); } }
			public Translateable x558_Translateable { get { return Field<Translateable>(0x558); } } // TranslateFromString = 0x01144690, TranslateFromValue = 0x01144740
			public AttributeParameter x55C_AttributeParameter { get { return Field<AttributeParameter>(0x55C); } }
			public string x560_Text { get { return Deserialize(x568_SerializeData); } }
			public SerializeData x568_SerializeData { get { return Field<SerializeData>(0x568); } }
			public Translateable x570_Translateable { get { return Field<Translateable>(0x570); } } // TranslateFromString = 0x01144690, TranslateFromValue = 0x01144740
			public AttributeParameter x574_AttributeParameter { get { return Field<AttributeParameter>(0x574); } }
			public string x578_Text { get { return Deserialize(x580_SerializeData); } }
			public SerializeData x580_SerializeData { get { return Field<SerializeData>(0x580); } }
			public Translateable x588_Translateable { get { return Field<Translateable>(0x588); } } // TranslateFromString = 0x01144690, TranslateFromValue = 0x01144740
			public AttributeParameter x58C_AttributeParameter { get { return Field<AttributeParameter>(0x58C); } }
			public string x590_Text { get { return Deserialize(x598_SerializeData); } }
			public SerializeData x598_SerializeData { get { return Field<SerializeData>(0x598); } }
			public Translateable x5A0_Translateable { get { return Field<Translateable>(0x5A0); } } // TranslateFromString = 0x01144690, TranslateFromValue = 0x01144740
			public AttributeParameter x5A4_AttributeParameter { get { return Field<AttributeParameter>(0x5A4); } }
			public string x5A8_Text { get { return Deserialize(x5B0_SerializeData); } }
			public SerializeData x5B0_SerializeData { get { return Field<SerializeData>(0x5B0); } }
			public int x5B8_Enum { get { return Field<int>(0x5B8); } } // Invalid = -1, Inferior = 0, Normal = 1, Superior = 2, Magic1 = 3, Magic2 = 4, Magic3 = 5, Rare4 = 6, Rare5 = 7, Rare6 = 8, Legendary = 9, Special = 10, Set = 11
			public GameBalanceId[] x5BC_GameBalanceIds { get { return Field<GameBalanceId>(0x5BC, 10); } }
			public GameBalanceId x5E4_ItemEnchantmentsGameBalanceId { get { return Field<GameBalanceId>(0x5E4); } }
			public GameBalanceId x5E8_ItemsGameBalanceId { get { return Field<GameBalanceId>(0x5E8); } }
			public GameBalanceId[] x5EC_GameBalanceIds { get { return Field<GameBalanceId>(0x5EC, 8); } }
			public int x60C { get { return Field<int>(0x60C); } }
			public int x610 { get { return Field<int>(0x610); } }
			public int x614 { get { return Field<int>(0x614); } }
			public int x618 { get { return Field<int>(0x618); } }
			public int x61C { get { return Field<int>(0x61C); } }
			public int x620 { get { return Field<int>(0x620); } }
			public int x624 { get { return Field<int>(0x624); } }
			public int x628 { get { return Field<int>(0x628); } }
			public GameBalanceId x62C_47GameBalanceId { get { return Field<GameBalanceId>(0x62C); } }
			public GameBalanceId x630_47GameBalanceId { get { return Field<GameBalanceId>(0x630); } }
			public GameBalanceId x634_47GameBalanceId { get { return Field<GameBalanceId>(0x634); } }
			public GameBalanceId x638_47GameBalanceId { get { return Field<GameBalanceId>(0x638); } }
			public GameBalanceId x63C_47GameBalanceId { get { return Field<GameBalanceId>(0x63C); } }
			public GameBalanceId x640_47GameBalanceId { get { return Field<GameBalanceId>(0x640); } }
			public int x644 { get { return Field<int>(0x644); } }
			public int x648 { get { return Field<int>(0x648); } }
			public int x64C { get { return Field<int>(0x64C); } }
			public int x650 { get { return Field<int>(0x650); } }
			public int x654 { get { return Field<int>(0x654); } }
			public int x658 { get { return Field<int>(0x658); } }
			public int x65C { get { return Field<int>(0x65C); } }
			public int x660 { get { return Field<int>(0x660); } }
			public int x664 { get { return Field<int>(0x664); } }
			public int x668 { get { return Field<int>(0x668); } }
			public int x66C { get { return Field<int>(0x66C); } }
			public int x670 { get { return Field<int>(0x670); } }
			public GameBalanceId x674_GameBalanceId { get { return Field<GameBalanceId>(0x674); } }
			public int x678_Enum { get { return Field<int>(0x678); } } // Amethyst = 1, Emerald = 2, Ruby = 3, Topaz = 4, Diamond = 5
			public int x67C { get { return Field<int>(0x67C); } }
			public int x680_Enum { get { return Field<int>(0x680); } } // A = 1, B = 2, C = 3, D = 4
			public Sno x684_ActorSno { get { return Field<Sno>(0x684); } }
			public Sno x688_WorldsSno { get { return Field<Sno>(0x688); } }
			public Sno x68C_WorldsSno { get { return Field<Sno>(0x68C); } }
			public Sno x690_LevelAreaSno { get { return Field<Sno>(0x690); } }
			public int x694 { get { return Field<int>(0x694); } }
			public int x698 { get { return Field<int>(0x698); } }
			public int x69C { get { return Field<int>(0x69C); } }
			public GameBalanceId x6A0_MadeToOrderTypesGameBalanceId { get { return Field<GameBalanceId>(0x6A0); } }
			public float x6A4 { get { return Field<float>(0x6A4); } }
			public float x6A8 { get { return Field<float>(0x6A8); } }
			public float x6AC { get { return Field<float>(0x6AC); } }
			public float x6B0 { get { return Field<float>(0x6B0); } }
			public float x6B4 { get { return Field<float>(0x6B4); } }
			public float x6B8 { get { return Field<float>(0x6B8); } }
			public float x6BC { get { return Field<float>(0x6BC); } }
			public float x6C0 { get { return Field<float>(0x6C0); } }
			public float x6C4 { get { return Field<float>(0x6C4); } }
			public float x6C8 { get { return Field<float>(0x6C8); } }
			public int x6CC { get { return Field<int>(0x6CC); } }
			public RecipeIngredient[] x6D0_RecipeIngredients { get { return Field<RecipeIngredient>(0x6D0, 6); } }
			public int x700 { get { return Field<int>(0x700); } }
			public RecipeIngredient[] x704_RecipeIngredients { get { return Field<RecipeIngredient>(0x704, 6); } }
			public Sno x734_LevelAreaSno { get { return Field<Sno>(0x734); } }
			public Sno x738_LevelAreaSno { get { return Field<Sno>(0x738); } }
			public Sno x73C_ActorSno { get { return Field<Sno>(0x73C); } }
		}
		
		[CompilerGenerated]
		public partial class ExperienceLevel : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x1D0; // 464
			
			public long x000 { get { return Field<long>(0x000); } }
			public int x008 { get { return Field<int>(0x008); } }
			public int x00C { get { return Field<int>(0x00C); } }
			public float x010 { get { return Field<float>(0x010); } }
			public float x014 { get { return Field<float>(0x014); } }
			public int x018 { get { return Field<int>(0x018); } }
			public int x01C { get { return Field<int>(0x01C); } }
			public int x020 { get { return Field<int>(0x020); } }
			public int x024 { get { return Field<int>(0x024); } }
			public int x028 { get { return Field<int>(0x028); } }
			public int x02C { get { return Field<int>(0x02C); } }
			public int x030 { get { return Field<int>(0x030); } }
			public int x034 { get { return Field<int>(0x034); } }
			public int x038 { get { return Field<int>(0x038); } }
			public int x03C { get { return Field<int>(0x03C); } }
			public int x040 { get { return Field<int>(0x040); } }
			public int x044 { get { return Field<int>(0x044); } }
			public int x048 { get { return Field<int>(0x048); } }
			public int x04C { get { return Field<int>(0x04C); } }
			public int x050 { get { return Field<int>(0x050); } }
			public int x054 { get { return Field<int>(0x054); } }
			public int x058 { get { return Field<int>(0x058); } }
			public int x05C { get { return Field<int>(0x05C); } }
			public int x060 { get { return Field<int>(0x060); } }
			public int x064 { get { return Field<int>(0x064); } }
			public int x068 { get { return Field<int>(0x068); } }
			public int x06C { get { return Field<int>(0x06C); } }
			public int x070 { get { return Field<int>(0x070); } }
			public int x074 { get { return Field<int>(0x074); } }
			public int x078 { get { return Field<int>(0x078); } }
			public int x07C { get { return Field<int>(0x07C); } }
			public int x080 { get { return Field<int>(0x080); } }
			public int x084 { get { return Field<int>(0x084); } }
			public int x088 { get { return Field<int>(0x088); } }
			public int x08C { get { return Field<int>(0x08C); } }
			public int x090 { get { return Field<int>(0x090); } }
			public int x094 { get { return Field<int>(0x094); } }
			public int x098 { get { return Field<int>(0x098); } }
			public int x09C { get { return Field<int>(0x09C); } }
			public int x0A0 { get { return Field<int>(0x0A0); } }
			public float x0A4 { get { return Field<float>(0x0A4); } }
			public float x0A8 { get { return Field<float>(0x0A8); } }
			public float x0AC { get { return Field<float>(0x0AC); } }
			public int x0B0 { get { return Field<int>(0x0B0); } }
			public int x0B4 { get { return Field<int>(0x0B4); } }
			public int x0B8 { get { return Field<int>(0x0B8); } }
			public int x0BC { get { return Field<int>(0x0BC); } }
			public int x0C0 { get { return Field<int>(0x0C0); } }
			public int x0C4 { get { return Field<int>(0x0C4); } }
			public int x0C8 { get { return Field<int>(0x0C8); } }
			public int x0CC { get { return Field<int>(0x0CC); } }
			public int x0D0 { get { return Field<int>(0x0D0); } }
			public int x0D4 { get { return Field<int>(0x0D4); } }
			public int x0D8 { get { return Field<int>(0x0D8); } }
			public int x0DC { get { return Field<int>(0x0DC); } }
			public int x0E0 { get { return Field<int>(0x0E0); } }
			public int x0E4 { get { return Field<int>(0x0E4); } }
			public int x0E8 { get { return Field<int>(0x0E8); } }
			public int x0EC { get { return Field<int>(0x0EC); } }
			public int x0F0 { get { return Field<int>(0x0F0); } }
			public int x0F4 { get { return Field<int>(0x0F4); } }
			public int x0F8 { get { return Field<int>(0x0F8); } }
			public int x0FC { get { return Field<int>(0x0FC); } }
			public int x100 { get { return Field<int>(0x100); } }
			public int x104 { get { return Field<int>(0x104); } }
			public int x108 { get { return Field<int>(0x108); } }
			public int x10C { get { return Field<int>(0x10C); } }
			public int x120 { get { return Field<int>(0x120); } }
			public int x124 { get { return Field<int>(0x124); } }
			public int x128 { get { return Field<int>(0x128); } }
			public int x12C { get { return Field<int>(0x12C); } }
			public int x130 { get { return Field<int>(0x130); } }
			public int x134 { get { return Field<int>(0x134); } }
			public int x138 { get { return Field<int>(0x138); } }
			public int x13C { get { return Field<int>(0x13C); } }
			public int x140 { get { return Field<int>(0x140); } }
			public int x144 { get { return Field<int>(0x144); } }
			public int x148 { get { return Field<int>(0x148); } }
			public int x14C { get { return Field<int>(0x14C); } }
			public float x154 { get { return Field<float>(0x154); } }
			public float x158 { get { return Field<float>(0x158); } }
			public float x15C { get { return Field<float>(0x15C); } }
			public long x160 { get { return Field<long>(0x160); } }
			public int x168 { get { return Field<int>(0x168); } }
			public int x16C { get { return Field<int>(0x16C); } }
			public int x170 { get { return Field<int>(0x170); } }
			public int x174 { get { return Field<int>(0x174); } }
			public int x178 { get { return Field<int>(0x178); } }
			public int x17C { get { return Field<int>(0x17C); } }
			public int x180 { get { return Field<int>(0x180); } }
			public int x184 { get { return Field<int>(0x184); } }
			public int x188 { get { return Field<int>(0x188); } }
			public int x18C { get { return Field<int>(0x18C); } }
			public int x190 { get { return Field<int>(0x190); } }
			public int x194 { get { return Field<int>(0x194); } }
			public int x198 { get { return Field<int>(0x198); } }
			public int x19C { get { return Field<int>(0x19C); } }
			public int x1A0 { get { return Field<int>(0x1A0); } }
			public int x1A4 { get { return Field<int>(0x1A4); } }
			public int x1A8 { get { return Field<int>(0x1A8); } }
			public int x1AC { get { return Field<int>(0x1AC); } }
			public float x1B0 { get { return Field<float>(0x1B0); } }
			public int x1B4 { get { return Field<int>(0x1B4); } }
			public int x1B8 { get { return Field<int>(0x1B8); } }
			public int x1BC { get { return Field<int>(0x1BC); } }
			public int x1C0 { get { return Field<int>(0x1C0); } }
			public int x1C4 { get { return Field<int>(0x1C4); } }
			public int x1C8 { get { return Field<int>(0x1C8); } }
		}
		
		[CompilerGenerated]
		public partial class MonsterLevelDefinition : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x24C; // 588
			
			public int x000 { get { return Field<int>(0x000); } }
			public float x014 { get { return Field<float>(0x014); } }
			public float x020 { get { return Field<float>(0x020); } }
			public float x024 { get { return Field<float>(0x024); } }
			public float x028 { get { return Field<float>(0x028); } }
			public float x030 { get { return Field<float>(0x030); } }
			public float x05C { get { return Field<float>(0x05C); } }
			public float x060 { get { return Field<float>(0x060); } }
			public float x064 { get { return Field<float>(0x064); } }
			public float x068 { get { return Field<float>(0x068); } }
			public float x06C { get { return Field<float>(0x06C); } }
			public float x070 { get { return Field<float>(0x070); } }
			public float x074 { get { return Field<float>(0x074); } }
			public float x078 { get { return Field<float>(0x078); } }
			public float x07C { get { return Field<float>(0x07C); } }
			public float x080 { get { return Field<float>(0x080); } }
			public float x084 { get { return Field<float>(0x084); } }
			public float x088 { get { return Field<float>(0x088); } }
			public float x08C { get { return Field<float>(0x08C); } }
			public float x090 { get { return Field<float>(0x090); } }
			public float x094 { get { return Field<float>(0x094); } }
			public float x098 { get { return Field<float>(0x098); } }
			public float x09C { get { return Field<float>(0x09C); } }
			public float x0A0 { get { return Field<float>(0x0A0); } }
			public float x0B0 { get { return Field<float>(0x0B0); } }
			public float x0B4 { get { return Field<float>(0x0B4); } }
			public float x0B8 { get { return Field<float>(0x0B8); } }
			public float x0DC { get { return Field<float>(0x0DC); } }
			public float x0E0 { get { return Field<float>(0x0E0); } }
			public float x0E8 { get { return Field<float>(0x0E8); } }
			public float x0EC { get { return Field<float>(0x0EC); } }
			public float x10C { get { return Field<float>(0x10C); } }
			public float x110 { get { return Field<float>(0x110); } }
			public float x114 { get { return Field<float>(0x114); } }
			public float x118 { get { return Field<float>(0x118); } }
			public float x11C { get { return Field<float>(0x11C); } }
			public float x120 { get { return Field<float>(0x120); } }
			public float x124 { get { return Field<float>(0x124); } }
			public float x128 { get { return Field<float>(0x128); } }
			public float x12C { get { return Field<float>(0x12C); } }
			public float x1B8 { get { return Field<float>(0x1B8); } }
			public float x1BC { get { return Field<float>(0x1BC); } }
			public float x1CC { get { return Field<float>(0x1CC); } }
			public float x1D0 { get { return Field<float>(0x1D0); } }
			public float x1D4 { get { return Field<float>(0x1D4); } }
			public float x1D8 { get { return Field<float>(0x1D8); } }
			public float x1DC { get { return Field<float>(0x1DC); } }
			public float x1E4 { get { return Field<float>(0x1E4); } }
			public float x1E8 { get { return Field<float>(0x1E8); } }
			public float x1EC { get { return Field<float>(0x1EC); } }
			public float x1F0 { get { return Field<float>(0x1F0); } }
			public float x1F8 { get { return Field<float>(0x1F8); } }
			public float x208 { get { return Field<float>(0x208); } }
			public float x234 { get { return Field<float>(0x234); } }
			public float x238 { get { return Field<float>(0x238); } }
			public float x23C { get { return Field<float>(0x23C); } }
			public float x240 { get { return Field<float>(0x240); } }
			public float x244 { get { return Field<float>(0x244); } }
			public float x248 { get { return Field<float>(0x248); } }
		}
		
		[CompilerGenerated]
		public partial class AffixTableEntry : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x318; // 792
			
			public string x000_Text { get { return Field(0x000, 256); } }
			public int x100 { get { return Field<int>(0x100); } }
			public int x104 { get { return Field<int>(0x104); } }
			public int x108 { get { return Field<int>(0x108); } }
			public int x10C { get { return Field<int>(0x10C); } }
			public int x110 { get { return Field<int>(0x110); } }
			public int x114 { get { return Field<int>(0x114); } }
			public int x118 { get { return Field<int>(0x118); } }
			public int x11C { get { return Field<int>(0x11C); } }
			public int x120 { get { return Field<int>(0x120); } }
			public int x124 { get { return Field<int>(0x124); } }
			public int x128 { get { return Field<int>(0x128); } }
			public int x12C { get { return Field<int>(0x12C); } }
			public int x130 { get { return Field<int>(0x130); } }
			public int x134 { get { return Field<int>(0x134); } }
			public int x138 { get { return Field<int>(0x138); } }
			public int x13C { get { return Field<int>(0x13C); } }
			public int x140 { get { return Field<int>(0x140); } }
			public int x144 { get { return Field<int>(0x144); } }
			public int x148 { get { return Field<int>(0x148); } }
			public int x14C { get { return Field<int>(0x14C); } }
			public int x150_Enum { get { return Field<int>(0x150); } } // - None - = 0, Lightning = 1, Cold = 2, Fire = 3, Poison = 4, Arcane = 5, WitchdoctorDamage = 6, LifeSteal = 7, ManaSteal = 8, MagicFind = 9, GoldFind = 10, AttackSpeedBonus = 11, CastSpeedBonus = 12, Holy = 13, WizardDamage = 14
			public int x154 { get { return Field<int>(0x154); } }
			public GameBalanceId x158_AffixListGameBalanceId { get { return Field<GameBalanceId>(0x158); } }
			public GameBalanceId x15C_AffixListGameBalanceId { get { return Field<GameBalanceId>(0x15C); } }
			public Sno x160_StringListSno { get { return Field<Sno>(0x160); } }
			public Sno x164_StringListSno { get { return Field<Sno>(0x164); } }
			public GameBalanceId x168_47GameBalanceId { get { return Field<GameBalanceId>(0x168); } }
			public GameBalanceId x16C_47GameBalanceId { get { return Field<GameBalanceId>(0x16C); } }
			public int x170_Enum { get { return Field<int>(0x170); } } // - None - = -1, DemonHunter = 0, Barbarian = 1, Wizard = 2, Witchdoctor = 3, Monk = 4, Crusader = 5
			public GameBalanceId x174_AffixListGameBalanceId { get { return Field<GameBalanceId>(0x174); } }
			public int[] x178_int { get { return Field<int>(0x178, 6); } }
			public int[] x190_int { get { return Field<int>(0x190, 24); } }
			public int[] x1F0_int { get { return Field<int>(0x1F0, 24); } }
			public int x250 { get { return Field<int>(0x250); } }
			public int x254_Enum { get { return Field<int>(0x254); } } // Prefix = 0, Suffix = 1, Inherent = 2, Title = 5, Quality = 6, Immunity = 7, Random = 9, Enchantment = 10, Socket Enhancement = 11
			public GameBalanceId x258_AffixListGameBalanceId { get { return Field<GameBalanceId>(0x258); } }
			public AttributeSpecifier[] x260_AttributeSpecifiers { get { return Field<AttributeSpecifier>(0x260, 4); } }
			public GameBalanceId x308_MadeToOrderTypesGameBalanceId { get { return Field<GameBalanceId>(0x308); } }
			public int x30C_Enum { get { return Field<int>(0x30C); } } // Major = 0, Minor = 1
		}
		
		[CompilerGenerated]
		public partial class HeroData : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x390; // 912
			
			public string x000_Text { get { return Field(0x000, 256); } }
			public int x100 { get { return Field<int>(0x100); } }
			public int x104 { get { return Field<int>(0x104); } }
			public Sno x108_ActorSno { get { return Field<Sno>(0x108); } }
			public Sno x10C_ActorSno { get { return Field<Sno>(0x10C); } }
			public Sno x110_TreasureClassSno { get { return Field<Sno>(0x110); } }
			public int x114 { get { return Field<int>(0x114); } }
			public Sno x118_PowerSno { get { return Field<Sno>(0x118); } }
			public Sno x11C_PowerSno { get { return Field<Sno>(0x11C); } }
			public Sno x120_SkillKitSno { get { return Field<Sno>(0x120); } }
			public Sno x124_SkillKitSno { get { return Field<Sno>(0x124); } }
			public Sno x128_SkillKitSno { get { return Field<Sno>(0x128); } }
			public Sno x12C_SkillKitSno { get { return Field<Sno>(0x12C); } }
			public int x130_Enum { get { return Field<int>(0x130); } } // Mana = 0, Arcanum = 1, Fury = 2, Spirit = 3, Power = 4, Hatred = 5, Discipline = 6, Faith = 7
			public int x134_Enum { get { return Field<int>(0x134); } } // Mana = 0, Arcanum = 1, Fury = 2, Spirit = 3, Power = 4, Hatred = 5, Discipline = 6, Faith = 7
			public int x138_Enum { get { return Field<int>(0x138); } } // None = -1, Strength = 0, Dexterity = 1, Intelligence = 2
			public float x13C { get { return Field<float>(0x13C); } }
			public int x140 { get { return Field<int>(0x140); } }
			public float x154 { get { return Field<float>(0x154); } }
			public float x158 { get { return Field<float>(0x158); } }
			public float x164 { get { return Field<float>(0x164); } }
			public float x168 { get { return Field<float>(0x168); } }
			public float x16C { get { return Field<float>(0x16C); } }
			public float x170 { get { return Field<float>(0x170); } }
			public float x178 { get { return Field<float>(0x178); } }
			public float x17C { get { return Field<float>(0x17C); } }
			public float x180 { get { return Field<float>(0x180); } }
			public float x19C { get { return Field<float>(0x19C); } }
			public float x1E4 { get { return Field<float>(0x1E4); } }
			public float x1E8 { get { return Field<float>(0x1E8); } }
			public float x1EC { get { return Field<float>(0x1EC); } }
			public float x1F0 { get { return Field<float>(0x1F0); } }
			public float x1F8 { get { return Field<float>(0x1F8); } }
			public float x21C { get { return Field<float>(0x21C); } }
			public float x220 { get { return Field<float>(0x220); } }
			public float x228 { get { return Field<float>(0x228); } }
			public float x24C { get { return Field<float>(0x24C); } }
			public float x250 { get { return Field<float>(0x250); } }
			public float x254 { get { return Field<float>(0x254); } }
			public float x258 { get { return Field<float>(0x258); } }
			public float x25C { get { return Field<float>(0x25C); } }
			public float x260 { get { return Field<float>(0x260); } }
			public float x268 { get { return Field<float>(0x268); } }
			public float x26C { get { return Field<float>(0x26C); } }
			public float x2AC { get { return Field<float>(0x2AC); } }
			public float x2B8 { get { return Field<float>(0x2B8); } }
			public float x2BC { get { return Field<float>(0x2BC); } }
			public float x2C0 { get { return Field<float>(0x2C0); } }
			public float x2C4 { get { return Field<float>(0x2C4); } }
			public float x2D4 { get { return Field<float>(0x2D4); } }
			public float x2D8 { get { return Field<float>(0x2D8); } }
			public float x2DC { get { return Field<float>(0x2DC); } }
			public float x308 { get { return Field<float>(0x308); } }
			public float x324 { get { return Field<float>(0x324); } }
			public float x328 { get { return Field<float>(0x328); } }
			public float x32C { get { return Field<float>(0x32C); } }
			public float x330 { get { return Field<float>(0x330); } }
			public float x35C { get { return Field<float>(0x35C); } }
			public float x360 { get { return Field<float>(0x360); } }
			public float x364 { get { return Field<float>(0x364); } }
			public float x368 { get { return Field<float>(0x368); } }
			public float x36C { get { return Field<float>(0x36C); } }
			public float x370 { get { return Field<float>(0x370); } }
			public int x38C { get { return Field<int>(0x38C); } }
		}
		
		[CompilerGenerated]
		public partial class MovementStyleDefinition : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x188; // 392
			
			public string x000_Text { get { return Field(0x000, 256); } }
			public int x100 { get { return Field<int>(0x100); } }
			public int x104 { get { return Field<int>(0x104); } }
			public int x108 { get { return Field<int>(0x108); } }
			public int x10C { get { return Field<int>(0x10C); } }
			public int x110 { get { return Field<int>(0x110); } }
			public int x114 { get { return Field<int>(0x114); } }
			public int x118 { get { return Field<int>(0x118); } }
			public int x11C { get { return Field<int>(0x11C); } }
			public int x120 { get { return Field<int>(0x120); } }
			public int x124 { get { return Field<int>(0x124); } }
			public float x128 { get { return Field<float>(0x128); } }
			public float x12C { get { return Field<float>(0x12C); } }
			public float x130 { get { return Field<float>(0x130); } }
			public float x134 { get { return Field<float>(0x134); } }
			public float x138 { get { return Field<float>(0x138); } }
			public float x13C { get { return Field<float>(0x13C); } }
			public float x140 { get { return Field<float>(0x140); } }
			public float x144 { get { return Field<float>(0x144); } }
			public float x148 { get { return Field<float>(0x148); } }
			public float x14C { get { return Field<float>(0x14C); } }
			public float x150 { get { return Field<float>(0x150); } }
			public float x154 { get { return Field<float>(0x154); } }
			public float x158 { get { return Field<float>(0x158); } }
			public float x15C { get { return Field<float>(0x15C); } }
			public float x160 { get { return Field<float>(0x160); } }
			public float x164 { get { return Field<float>(0x164); } }
			public float x168 { get { return Field<float>(0x168); } }
			public float x16C { get { return Field<float>(0x16C); } }
			public float x170 { get { return Field<float>(0x170); } }
			public float x174 { get { return Field<float>(0x174); } }
			public float x178 { get { return Field<float>(0x178); } }
			public float x17C { get { return Field<float>(0x17C); } }
			public Sno x180_PowerSno { get { return Field<Sno>(0x180); } }
			public int x184 { get { return Field<int>(0x184); } }
		}
		
		[CompilerGenerated]
		public partial class LabelGBID : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x110; // 272
			
			public string x000_Text { get { return Field(0x000, 256); } }
			public int x100 { get { return Field<int>(0x100); } }
			public int x104 { get { return Field<int>(0x104); } }
			public int x108 { get { return Field<int>(0x108); } }
			public int x10C { get { return Field<int>(0x10C); } }
		}
		
		[CompilerGenerated]
		public partial class LootDistribution : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x5C; // 92
			
			public int x00 { get { return Field<int>(0x00); } }
			public int x04 { get { return Field<int>(0x04); } }
			public int x08 { get { return Field<int>(0x08); } }
			public int x0C { get { return Field<int>(0x0C); } }
			public int x10 { get { return Field<int>(0x10); } }
			public int x14 { get { return Field<int>(0x14); } }
			public int x18 { get { return Field<int>(0x18); } }
			public int x1C { get { return Field<int>(0x1C); } }
			public int x20 { get { return Field<int>(0x20); } }
			public int x24 { get { return Field<int>(0x24); } }
			public float x28 { get { return Field<float>(0x28); } }
			public float x2C { get { return Field<float>(0x2C); } }
			public float x30 { get { return Field<float>(0x30); } }
			public float x34 { get { return Field<float>(0x34); } }
			public float x38 { get { return Field<float>(0x38); } }
			public float x3C { get { return Field<float>(0x3C); } }
			public float x40 { get { return Field<float>(0x40); } }
			public float x44 { get { return Field<float>(0x44); } }
			public float x48 { get { return Field<float>(0x48); } }
			public float x4C { get { return Field<float>(0x4C); } }
			public float x50 { get { return Field<float>(0x50); } }
			public int x54 { get { return Field<int>(0x54); } }
			public int x58 { get { return Field<int>(0x58); } }
		}
		
		[CompilerGenerated]
		public partial class RareItemNamesEntry : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x118; // 280
			
			public string x000_Text { get { return Field(0x000, 256); } }
			public int x100 { get { return Field<int>(0x100); } }
			public int x104 { get { return Field<int>(0x104); } }
			public int x108_Enum { get { return Field<int>(0x108); } } // Item Types = 1, Items = 2, Experience Table = 3, Help Codes = 24, Monster Levels = 5, Heros = 7, Affix List = 8, Movement Styles = 10, Labels = 11, Loot Distribution = 12, Rare Item Names = 16, Monster Affixes = 18, Monster Names = 19, Socketed Effects = 21, Item Enchantments = 23, Item Drop Table = 25, Item Level Modifiers = 26, Quality Classes = 27, Handicaps = 28, Item Salvage Levels = 29, Scenery = 17, Hirelings = 4, Set Item Bonuses = 33, Elite Modifiers = 34, Item Tiers = 35, Power Formula Tables = 36, Recipes = 32, Scripted Achievement Events = 37, Item Durability Cost Scalars = 38, LootRun Quest Tiers = 39, Paragon Bonuses = 40, Made To Order Types = 42, Made To Order Affix Folders = 43, Devil's Hand Redeemable Sets = 44, Legacy Item Conversions = 45, Enchant Item Affix Use Count Cost Scalars = 46
			public GameBalanceId x10C_GameBalanceId { get { return Field<GameBalanceId>(0x10C); } }
			public int x110_Enum { get { return Field<int>(0x110); } } // Prefix = 0, Suffix = 1, Inherent = 2, Title = 5, Quality = 6, Immunity = 7, Random = 9, Enchantment = 10, Socket Enhancement = 11
			public int x114 { get { return Field<int>(0x114); } }
		}
		
		[CompilerGenerated]
		public partial class MonsterAffixesEntry : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x388; // 904
			
			public string x000_Text { get { return Field(0x000, 256); } }
			public int x100 { get { return Field<int>(0x100); } }
			public int x104 { get { return Field<int>(0x104); } }
			public int x108 { get { return Field<int>(0x108); } }
			public int x10C { get { return Field<int>(0x10C); } }
			public int x110 { get { return Field<int>(0x110); } }
			public int x114_Enum { get { return Field<int>(0x114); } } // All = 0, Rares = 1, Shooters = 2, Champions = 3
			public int x118_Enum { get { return Field<int>(0x118); } } // None = -1, Physical = 0, Fire = 1, Lightning = 2, Cold = 3, Poison = 4, Arcane = 5, Holy = 6
			public int x11C_Enum { get { return Field<int>(0x11C); } } // Prefix = 0, Suffix = 1, Inherent = 2, Title = 5, Quality = 6, Immunity = 7, Random = 9, Enchantment = 10, Socket Enhancement = 11
			public int x120 { get { return Field<int>(0x120); } }
			public int x124 { get { return Field<int>(0x124); } }
			public int x128 { get { return Field<int>(0x128); } }
			public int x12C { get { return Field<int>(0x12C); } }
			public Translateable x130_Translateable { get { return Field<Translateable>(0x130); } } // TranslateFromString = 0x01144690, TranslateFromValue = 0x01144740
			public AttributeParameter x134_AttributeParameter { get { return Field<AttributeParameter>(0x134); } }
			public string x138_Text { get { return Deserialize(x140_SerializeData); } }
			public SerializeData x140_SerializeData { get { return Field<SerializeData>(0x140); } }
			public Translateable x148_Translateable { get { return Field<Translateable>(0x148); } } // TranslateFromString = 0x01144690, TranslateFromValue = 0x01144740
			public AttributeParameter x14C_AttributeParameter { get { return Field<AttributeParameter>(0x14C); } }
			public string x150_Text { get { return Deserialize(x158_SerializeData); } }
			public SerializeData x158_SerializeData { get { return Field<SerializeData>(0x158); } }
			public Translateable x160_Translateable { get { return Field<Translateable>(0x160); } } // TranslateFromString = 0x01144690, TranslateFromValue = 0x01144740
			public AttributeParameter x164_AttributeParameter { get { return Field<AttributeParameter>(0x164); } }
			public string x168_Text { get { return Deserialize(x170_SerializeData); } }
			public SerializeData x170_SerializeData { get { return Field<SerializeData>(0x170); } }
			public Translateable x178_Translateable { get { return Field<Translateable>(0x178); } } // TranslateFromString = 0x01144690, TranslateFromValue = 0x01144740
			public AttributeParameter x17C_AttributeParameter { get { return Field<AttributeParameter>(0x17C); } }
			public string x180_Text { get { return Deserialize(x188_SerializeData); } }
			public SerializeData x188_SerializeData { get { return Field<SerializeData>(0x188); } }
			public Translateable x190_Translateable { get { return Field<Translateable>(0x190); } } // TranslateFromString = 0x01144690, TranslateFromValue = 0x01144740
			public AttributeParameter x194_AttributeParameter { get { return Field<AttributeParameter>(0x194); } }
			public string x198_Text { get { return Deserialize(x1A0_SerializeData); } }
			public SerializeData x1A0_SerializeData { get { return Field<SerializeData>(0x1A0); } }
			public Translateable x1A8_Translateable { get { return Field<Translateable>(0x1A8); } } // TranslateFromString = 0x01144690, TranslateFromValue = 0x01144740
			public AttributeParameter x1AC_AttributeParameter { get { return Field<AttributeParameter>(0x1AC); } }
			public string x1B0_Text { get { return Deserialize(x1B8_SerializeData); } }
			public SerializeData x1B8_SerializeData { get { return Field<SerializeData>(0x1B8); } }
			public Translateable x1C0_Translateable { get { return Field<Translateable>(0x1C0); } } // TranslateFromString = 0x01144690, TranslateFromValue = 0x01144740
			public AttributeParameter x1C4_AttributeParameter { get { return Field<AttributeParameter>(0x1C4); } }
			public string x1C8_Text { get { return Deserialize(x1D0_SerializeData); } }
			public SerializeData x1D0_SerializeData { get { return Field<SerializeData>(0x1D0); } }
			public Translateable x1D8_Translateable { get { return Field<Translateable>(0x1D8); } } // TranslateFromString = 0x01144690, TranslateFromValue = 0x01144740
			public AttributeParameter x1DC_AttributeParameter { get { return Field<AttributeParameter>(0x1DC); } }
			public string x1E0_Text { get { return Deserialize(x1E8_SerializeData); } }
			public SerializeData x1E8_SerializeData { get { return Field<SerializeData>(0x1E8); } }
			public Translateable x1F0_Translateable { get { return Field<Translateable>(0x1F0); } } // TranslateFromString = 0x01144690, TranslateFromValue = 0x01144740
			public AttributeParameter x1F4_AttributeParameter { get { return Field<AttributeParameter>(0x1F4); } }
			public string x1F8_Text { get { return Deserialize(x200_SerializeData); } }
			public SerializeData x200_SerializeData { get { return Field<SerializeData>(0x200); } }
			public Translateable x208_Translateable { get { return Field<Translateable>(0x208); } } // TranslateFromString = 0x01144690, TranslateFromValue = 0x01144740
			public AttributeParameter x20C_AttributeParameter { get { return Field<AttributeParameter>(0x20C); } }
			public string x210_Text { get { return Deserialize(x218_SerializeData); } }
			public SerializeData x218_SerializeData { get { return Field<SerializeData>(0x218); } }
			public Translateable x220_Translateable { get { return Field<Translateable>(0x220); } } // TranslateFromString = 0x01144690, TranslateFromValue = 0x01144740
			public AttributeParameter x224_AttributeParameter { get { return Field<AttributeParameter>(0x224); } }
			public string x228_Text { get { return Deserialize(x230_SerializeData); } }
			public SerializeData x230_SerializeData { get { return Field<SerializeData>(0x230); } }
			public Translateable x238_Translateable { get { return Field<Translateable>(0x238); } } // TranslateFromString = 0x01144690, TranslateFromValue = 0x01144740
			public AttributeParameter x23C_AttributeParameter { get { return Field<AttributeParameter>(0x23C); } }
			public string x240_Text { get { return Deserialize(x248_SerializeData); } }
			public SerializeData x248_SerializeData { get { return Field<SerializeData>(0x248); } }
			public Translateable x250_Translateable { get { return Field<Translateable>(0x250); } } // TranslateFromString = 0x01144690, TranslateFromValue = 0x01144740
			public AttributeParameter x254_AttributeParameter { get { return Field<AttributeParameter>(0x254); } }
			public string x258_Text { get { return Deserialize(x260_SerializeData); } }
			public SerializeData x260_SerializeData { get { return Field<SerializeData>(0x260); } }
			public Translateable x268_Translateable { get { return Field<Translateable>(0x268); } } // TranslateFromString = 0x01144690, TranslateFromValue = 0x01144740
			public AttributeParameter x26C_AttributeParameter { get { return Field<AttributeParameter>(0x26C); } }
			public string x270_Text { get { return Deserialize(x278_SerializeData); } }
			public SerializeData x278_SerializeData { get { return Field<SerializeData>(0x278); } }
			public Translateable x280_Translateable { get { return Field<Translateable>(0x280); } } // TranslateFromString = 0x01144690, TranslateFromValue = 0x01144740
			public AttributeParameter x284_AttributeParameter { get { return Field<AttributeParameter>(0x284); } }
			public string x288_Text { get { return Deserialize(x290_SerializeData); } }
			public SerializeData x290_SerializeData { get { return Field<SerializeData>(0x290); } }
			public Translateable x298_Translateable { get { return Field<Translateable>(0x298); } } // TranslateFromString = 0x01144690, TranslateFromValue = 0x01144740
			public AttributeParameter x29C_AttributeParameter { get { return Field<AttributeParameter>(0x29C); } }
			public string x2A0_Text { get { return Deserialize(x2A8_SerializeData); } }
			public SerializeData x2A8_SerializeData { get { return Field<SerializeData>(0x2A8); } }
			public Translateable x2B0_Translateable { get { return Field<Translateable>(0x2B0); } } // TranslateFromString = 0x01144690, TranslateFromValue = 0x01144740
			public AttributeParameter x2B4_AttributeParameter { get { return Field<AttributeParameter>(0x2B4); } }
			public string x2B8_Text { get { return Deserialize(x2C0_SerializeData); } }
			public SerializeData x2C0_SerializeData { get { return Field<SerializeData>(0x2C0); } }
			public Translateable x2C8_Translateable { get { return Field<Translateable>(0x2C8); } } // TranslateFromString = 0x01144690, TranslateFromValue = 0x01144740
			public AttributeParameter x2CC_AttributeParameter { get { return Field<AttributeParameter>(0x2CC); } }
			public string x2D0_Text { get { return Deserialize(x2D8_SerializeData); } }
			public SerializeData x2D8_SerializeData { get { return Field<SerializeData>(0x2D8); } }
			public Translateable x2E0_Translateable { get { return Field<Translateable>(0x2E0); } } // TranslateFromString = 0x01144690, TranslateFromValue = 0x01144740
			public AttributeParameter x2E4_AttributeParameter { get { return Field<AttributeParameter>(0x2E4); } }
			public string x2E8_Text { get { return Deserialize(x2F0_SerializeData); } }
			public SerializeData x2F0_SerializeData { get { return Field<SerializeData>(0x2F0); } }
			public Translateable x2F8_Translateable { get { return Field<Translateable>(0x2F8); } } // TranslateFromString = 0x01144690, TranslateFromValue = 0x01144740
			public AttributeParameter x2FC_AttributeParameter { get { return Field<AttributeParameter>(0x2FC); } }
			public string x300_Text { get { return Deserialize(x308_SerializeData); } }
			public SerializeData x308_SerializeData { get { return Field<SerializeData>(0x308); } }
			public Sno x314_PowerSno { get { return Field<Sno>(0x314); } }
			public Sno x318_PowerSno { get { return Field<Sno>(0x318); } }
			public Sno x31C_PowerSno { get { return Field<Sno>(0x31C); } }
			public int x320 { get { return Field<int>(0x320); } }
			public int x321 { get { return Field<int>(0x321); } }
			public int x322 { get { return Field<int>(0x322); } }
			public int x323 { get { return Field<int>(0x323); } }
			public int x324 { get { return Field<int>(0x324); } }
			public int x325 { get { return Field<int>(0x325); } }
			public int x326 { get { return Field<int>(0x326); } }
			public int x327 { get { return Field<int>(0x327); } }
			public int x328 { get { return Field<int>(0x328); } }
			public int x329 { get { return Field<int>(0x329); } }
			public int x32A { get { return Field<int>(0x32A); } }
			public int x32B { get { return Field<int>(0x32B); } }
			public int x32C { get { return Field<int>(0x32C); } }
			public int x32D { get { return Field<int>(0x32D); } }
			public int x32E { get { return Field<int>(0x32E); } }
			public int x32F { get { return Field<int>(0x32F); } }
			public int x330 { get { return Field<int>(0x330); } }
			public int x331 { get { return Field<int>(0x331); } }
			public int x332 { get { return Field<int>(0x332); } }
			public int x333 { get { return Field<int>(0x333); } }
			public int x334 { get { return Field<int>(0x334); } }
			public int x335 { get { return Field<int>(0x335); } }
			public int x336 { get { return Field<int>(0x336); } }
			public int x337 { get { return Field<int>(0x337); } }
			public int x338 { get { return Field<int>(0x338); } }
			public int x339 { get { return Field<int>(0x339); } }
			public int x33A { get { return Field<int>(0x33A); } }
			public int x33B { get { return Field<int>(0x33B); } }
			public int x33C { get { return Field<int>(0x33C); } }
			public int x33D { get { return Field<int>(0x33D); } }
			public int x33E { get { return Field<int>(0x33E); } }
			public int x33F { get { return Field<int>(0x33F); } }
			public int x340 { get { return Field<int>(0x340); } }
			public int x341 { get { return Field<int>(0x341); } }
			public int x342 { get { return Field<int>(0x342); } }
			public int x343 { get { return Field<int>(0x343); } }
			public int x344 { get { return Field<int>(0x344); } }
			public int x345 { get { return Field<int>(0x345); } }
			public int x346 { get { return Field<int>(0x346); } }
			public int x347 { get { return Field<int>(0x347); } }
			public int x348 { get { return Field<int>(0x348); } }
			public int x349 { get { return Field<int>(0x349); } }
			public int x34A { get { return Field<int>(0x34A); } }
			public int x34B { get { return Field<int>(0x34B); } }
			public int x34C { get { return Field<int>(0x34C); } }
			public int x34D { get { return Field<int>(0x34D); } }
			public int x34E { get { return Field<int>(0x34E); } }
			public int x34F { get { return Field<int>(0x34F); } }
			public int x350 { get { return Field<int>(0x350); } }
			public int x351 { get { return Field<int>(0x351); } }
			public int x352 { get { return Field<int>(0x352); } }
			public int x353 { get { return Field<int>(0x353); } }
			public int x354 { get { return Field<int>(0x354); } }
			public int x355 { get { return Field<int>(0x355); } }
			public int x356 { get { return Field<int>(0x356); } }
			public int x357 { get { return Field<int>(0x357); } }
			public int x358 { get { return Field<int>(0x358); } }
			public int x359 { get { return Field<int>(0x359); } }
			public int x35A { get { return Field<int>(0x35A); } }
			public int x35B { get { return Field<int>(0x35B); } }
			public int x35C { get { return Field<int>(0x35C); } }
			public int x35D { get { return Field<int>(0x35D); } }
			public int x35E { get { return Field<int>(0x35E); } }
			public int x35F { get { return Field<int>(0x35F); } }
			public int x360 { get { return Field<int>(0x360); } }
			public int x361 { get { return Field<int>(0x361); } }
			public int x362 { get { return Field<int>(0x362); } }
			public int x363 { get { return Field<int>(0x363); } }
			public int x364 { get { return Field<int>(0x364); } }
			public int x365 { get { return Field<int>(0x365); } }
			public int x366 { get { return Field<int>(0x366); } }
			public int x367 { get { return Field<int>(0x367); } }
			public int x368 { get { return Field<int>(0x368); } }
			public int x369 { get { return Field<int>(0x369); } }
			public int x36A { get { return Field<int>(0x36A); } }
			public int x36B { get { return Field<int>(0x36B); } }
			public int x36C { get { return Field<int>(0x36C); } }
			public int x36D { get { return Field<int>(0x36D); } }
			public int x36E { get { return Field<int>(0x36E); } }
			public int x36F { get { return Field<int>(0x36F); } }
			public int x370 { get { return Field<int>(0x370); } }
			public int x371 { get { return Field<int>(0x371); } }
			public int x372 { get { return Field<int>(0x372); } }
			public int x373 { get { return Field<int>(0x373); } }
			public int x374 { get { return Field<int>(0x374); } }
			public int x375 { get { return Field<int>(0x375); } }
			public int x376 { get { return Field<int>(0x376); } }
			public int x377 { get { return Field<int>(0x377); } }
			public int x378 { get { return Field<int>(0x378); } }
			public int x379 { get { return Field<int>(0x379); } }
			public int x37A { get { return Field<int>(0x37A); } }
			public int x37B { get { return Field<int>(0x37B); } }
			public int x37C { get { return Field<int>(0x37C); } }
			public int x37D { get { return Field<int>(0x37D); } }
			public int x37E { get { return Field<int>(0x37E); } }
			public int x37F { get { return Field<int>(0x37F); } }
			public int x380 { get { return Field<int>(0x380); } }
			public int x381 { get { return Field<int>(0x381); } }
			public int x382 { get { return Field<int>(0x382); } }
		}
		
		[CompilerGenerated]
		public partial class RareMonsterNamesEntry : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x190; // 400
			
			public string x000_Text { get { return Field(0x000, 256); } }
			public int x100 { get { return Field<int>(0x100); } }
			public int x104 { get { return Field<int>(0x104); } }
			public int x108_Enum { get { return Field<int>(0x108); } } // Prefix = 0, Suffix = 1, Inherent = 2, Title = 5, Quality = 6, Immunity = 7, Random = 9, Enchantment = 10, Socket Enhancement = 11
			public string x10C_Text { get { return Field(0x10C, 128); } }
			public int x18C { get { return Field<int>(0x18C); } }
		}
		
		[CompilerGenerated]
		public partial class SocketedEffectsTableEntry : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x588; // 1416
			
			public string x000_Text { get { return Field(0x000, 256); } }
			public int x100 { get { return Field<int>(0x100); } }
			public int x104 { get { return Field<int>(0x104); } }
			public GameBalanceId x108_ItemsGameBalanceId { get { return Field<GameBalanceId>(0x108); } }
			public GameBalanceId x10C_ItemTypesGameBalanceId { get { return Field<GameBalanceId>(0x10C); } }
			public Translateable x110_Translateable { get { return Field<Translateable>(0x110); } } // TranslateFromString = 0x01144690, TranslateFromValue = 0x01144740
			public AttributeParameter x114_AttributeParameter { get { return Field<AttributeParameter>(0x114); } }
			public string x118_Text { get { return Deserialize(x120_SerializeData); } }
			public SerializeData x120_SerializeData { get { return Field<SerializeData>(0x120); } }
			public Translateable x128_Translateable { get { return Field<Translateable>(0x128); } } // TranslateFromString = 0x01144690, TranslateFromValue = 0x01144740
			public AttributeParameter x12C_AttributeParameter { get { return Field<AttributeParameter>(0x12C); } }
			public string x130_Text { get { return Deserialize(x138_SerializeData); } }
			public SerializeData x138_SerializeData { get { return Field<SerializeData>(0x138); } }
			public Translateable x140_Translateable { get { return Field<Translateable>(0x140); } } // TranslateFromString = 0x01144690, TranslateFromValue = 0x01144740
			public AttributeParameter x144_AttributeParameter { get { return Field<AttributeParameter>(0x144); } }
			public string x148_Text { get { return Deserialize(x150_SerializeData); } }
			public SerializeData x150_SerializeData { get { return Field<SerializeData>(0x150); } }
			public Translateable x158_Translateable { get { return Field<Translateable>(0x158); } } // TranslateFromString = 0x01144690, TranslateFromValue = 0x01144740
			public AttributeParameter x15C_AttributeParameter { get { return Field<AttributeParameter>(0x15C); } }
			public string x160_Text { get { return Deserialize(x168_SerializeData); } }
			public SerializeData x168_SerializeData { get { return Field<SerializeData>(0x168); } }
			public Translateable x170_Translateable { get { return Field<Translateable>(0x170); } } // TranslateFromString = 0x01144690, TranslateFromValue = 0x01144740
			public AttributeParameter x174_AttributeParameter { get { return Field<AttributeParameter>(0x174); } }
			public string x178_Text { get { return Deserialize(x180_SerializeData); } }
			public SerializeData x180_SerializeData { get { return Field<SerializeData>(0x180); } }
			public string x188_Text { get { return Field(0x188, 1024); } }
		}
		
		[CompilerGenerated]
		public partial class ItemEnchantment : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x2C0; // 704
			
			public string x000_Text { get { return Field(0x000, 256); } }
			public int x100 { get { return Field<int>(0x100); } }
			public int x104 { get { return Field<int>(0x104); } }
			public int x108 { get { return Field<int>(0x108); } }
			public int x10C { get { return Field<int>(0x10C); } }
			public int x110 { get { return Field<int>(0x110); } }
			public int x114 { get { return Field<int>(0x114); } }
			public int x118 { get { return Field<int>(0x118); } }
			public int x11C { get { return Field<int>(0x11C); } }
			public AttributeSpecifier[] x120_AttributeSpecifiers { get { return Field<AttributeSpecifier>(0x120, 16); } }
			public int x2A0 { get { return Field<int>(0x2A0); } }
			public RecipeIngredient[] x2A4_RecipeIngredients { get { return Field<RecipeIngredient>(0x2A4, 3); } }
			public int x2BC { get { return Field<int>(0x2BC); } }
		}
		
		[CompilerGenerated]
		public partial class ItemDropTableEntry : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x478; // 1144
			
			public string x000_Text { get { return Field(0x000, 256); } }
			public int x100 { get { return Field<int>(0x100); } }
			public int x104 { get { return Field<int>(0x104); } }
			public int x108 { get { return Field<int>(0x108); } }
			public int x10C { get { return Field<int>(0x10C); } }
			public int x110 { get { return Field<int>(0x110); } }
			public int x114 { get { return Field<int>(0x114); } }
			public int x118 { get { return Field<int>(0x118); } }
			public int x11C { get { return Field<int>(0x11C); } }
			public int x120 { get { return Field<int>(0x120); } }
			public int x124 { get { return Field<int>(0x124); } }
			public int x128 { get { return Field<int>(0x128); } }
			public int x12C { get { return Field<int>(0x12C); } }
			public int x130 { get { return Field<int>(0x130); } }
			public int x134 { get { return Field<int>(0x134); } }
			public int x138 { get { return Field<int>(0x138); } }
			public int x13C { get { return Field<int>(0x13C); } }
			public int x140 { get { return Field<int>(0x140); } }
			public int x144 { get { return Field<int>(0x144); } }
			public int x148 { get { return Field<int>(0x148); } }
			public int x14C { get { return Field<int>(0x14C); } }
			public int x150 { get { return Field<int>(0x150); } }
			public int x154 { get { return Field<int>(0x154); } }
			public int x158 { get { return Field<int>(0x158); } }
			public int x15C { get { return Field<int>(0x15C); } }
			public int x160 { get { return Field<int>(0x160); } }
			public int x164 { get { return Field<int>(0x164); } }
			public int x168 { get { return Field<int>(0x168); } }
			public int x16C { get { return Field<int>(0x16C); } }
			public int x170 { get { return Field<int>(0x170); } }
			public int x174 { get { return Field<int>(0x174); } }
			public int x178 { get { return Field<int>(0x178); } }
			public int x17C { get { return Field<int>(0x17C); } }
			public int x180 { get { return Field<int>(0x180); } }
			public int x184 { get { return Field<int>(0x184); } }
			public int x188 { get { return Field<int>(0x188); } }
			public int x18C { get { return Field<int>(0x18C); } }
			public int x190 { get { return Field<int>(0x190); } }
			public int x194 { get { return Field<int>(0x194); } }
			public int x198 { get { return Field<int>(0x198); } }
			public int x19C { get { return Field<int>(0x19C); } }
			public int x1A0 { get { return Field<int>(0x1A0); } }
			public int x1A4 { get { return Field<int>(0x1A4); } }
			public int x1A8 { get { return Field<int>(0x1A8); } }
			public int x1AC { get { return Field<int>(0x1AC); } }
			public int x1B0 { get { return Field<int>(0x1B0); } }
			public int x1B4 { get { return Field<int>(0x1B4); } }
			public int x1B8 { get { return Field<int>(0x1B8); } }
			public int x1BC { get { return Field<int>(0x1BC); } }
			public int x1C0 { get { return Field<int>(0x1C0); } }
			public int x1C4 { get { return Field<int>(0x1C4); } }
			public int x1C8 { get { return Field<int>(0x1C8); } }
			public int x1CC { get { return Field<int>(0x1CC); } }
			public int x1D0 { get { return Field<int>(0x1D0); } }
			public int x1D4 { get { return Field<int>(0x1D4); } }
			public int x1D8 { get { return Field<int>(0x1D8); } }
			public int x1DC { get { return Field<int>(0x1DC); } }
			public int x1E0 { get { return Field<int>(0x1E0); } }
			public int x1E4 { get { return Field<int>(0x1E4); } }
			public int x1E8 { get { return Field<int>(0x1E8); } }
			public int x1EC { get { return Field<int>(0x1EC); } }
			public int x1F0 { get { return Field<int>(0x1F0); } }
			public int x1F4 { get { return Field<int>(0x1F4); } }
			public int x1F8 { get { return Field<int>(0x1F8); } }
			public int x1FC { get { return Field<int>(0x1FC); } }
			public int x200 { get { return Field<int>(0x200); } }
			public int x204 { get { return Field<int>(0x204); } }
			public int x208 { get { return Field<int>(0x208); } }
			public int x20C { get { return Field<int>(0x20C); } }
			public int x210 { get { return Field<int>(0x210); } }
			public int x214 { get { return Field<int>(0x214); } }
			public int x218 { get { return Field<int>(0x218); } }
			public int x21C { get { return Field<int>(0x21C); } }
			public int x220 { get { return Field<int>(0x220); } }
			public int x224 { get { return Field<int>(0x224); } }
			public int x228 { get { return Field<int>(0x228); } }
			public int x22C { get { return Field<int>(0x22C); } }
			public int x230 { get { return Field<int>(0x230); } }
			public int x234 { get { return Field<int>(0x234); } }
			public int x238 { get { return Field<int>(0x238); } }
			public int x23C { get { return Field<int>(0x23C); } }
			public int x240 { get { return Field<int>(0x240); } }
			public int x244 { get { return Field<int>(0x244); } }
			public int x248 { get { return Field<int>(0x248); } }
			public int x24C { get { return Field<int>(0x24C); } }
			public int x250 { get { return Field<int>(0x250); } }
			public int x254 { get { return Field<int>(0x254); } }
			public int x258 { get { return Field<int>(0x258); } }
			public int x25C { get { return Field<int>(0x25C); } }
			public int x260 { get { return Field<int>(0x260); } }
			public int x264 { get { return Field<int>(0x264); } }
			public int x268 { get { return Field<int>(0x268); } }
			public int x26C { get { return Field<int>(0x26C); } }
			public int x270 { get { return Field<int>(0x270); } }
			public int x274 { get { return Field<int>(0x274); } }
			public int x278 { get { return Field<int>(0x278); } }
			public int x27C { get { return Field<int>(0x27C); } }
			public int x280 { get { return Field<int>(0x280); } }
			public int x284 { get { return Field<int>(0x284); } }
			public int x288 { get { return Field<int>(0x288); } }
			public int x28C { get { return Field<int>(0x28C); } }
			public int x290 { get { return Field<int>(0x290); } }
			public int x294 { get { return Field<int>(0x294); } }
			public int x298 { get { return Field<int>(0x298); } }
			public int x29C { get { return Field<int>(0x29C); } }
			public int x2A0 { get { return Field<int>(0x2A0); } }
			public int x2A4 { get { return Field<int>(0x2A4); } }
			public int x2A8 { get { return Field<int>(0x2A8); } }
			public int x2AC { get { return Field<int>(0x2AC); } }
			public int x2B0 { get { return Field<int>(0x2B0); } }
			public int x2B4 { get { return Field<int>(0x2B4); } }
			public int x2B8 { get { return Field<int>(0x2B8); } }
			public int x2BC { get { return Field<int>(0x2BC); } }
			public int x2C0 { get { return Field<int>(0x2C0); } }
			public int x2C4 { get { return Field<int>(0x2C4); } }
			public int x2C8 { get { return Field<int>(0x2C8); } }
			public int x2CC { get { return Field<int>(0x2CC); } }
			public int x2D0 { get { return Field<int>(0x2D0); } }
			public int x2D4 { get { return Field<int>(0x2D4); } }
			public int x2D8 { get { return Field<int>(0x2D8); } }
			public int x2DC { get { return Field<int>(0x2DC); } }
			public int x2E0 { get { return Field<int>(0x2E0); } }
			public int x2E4 { get { return Field<int>(0x2E4); } }
			public int x2E8 { get { return Field<int>(0x2E8); } }
			public int x2EC { get { return Field<int>(0x2EC); } }
			public int x2F0 { get { return Field<int>(0x2F0); } }
			public int x2F4 { get { return Field<int>(0x2F4); } }
			public int x2F8 { get { return Field<int>(0x2F8); } }
			public int x2FC { get { return Field<int>(0x2FC); } }
			public int x300 { get { return Field<int>(0x300); } }
			public int x304 { get { return Field<int>(0x304); } }
			public int x308 { get { return Field<int>(0x308); } }
			public int x30C { get { return Field<int>(0x30C); } }
			public int x310 { get { return Field<int>(0x310); } }
			public int x314 { get { return Field<int>(0x314); } }
			public int x318 { get { return Field<int>(0x318); } }
			public int x31C { get { return Field<int>(0x31C); } }
			public int x320 { get { return Field<int>(0x320); } }
			public int x324 { get { return Field<int>(0x324); } }
			public int x328 { get { return Field<int>(0x328); } }
			public int x32C { get { return Field<int>(0x32C); } }
			public int x330 { get { return Field<int>(0x330); } }
			public int x334 { get { return Field<int>(0x334); } }
			public int x338 { get { return Field<int>(0x338); } }
			public int x33C { get { return Field<int>(0x33C); } }
			public int x340 { get { return Field<int>(0x340); } }
			public int x344 { get { return Field<int>(0x344); } }
			public int x348 { get { return Field<int>(0x348); } }
			public int x34C { get { return Field<int>(0x34C); } }
			public int x350 { get { return Field<int>(0x350); } }
			public int x354 { get { return Field<int>(0x354); } }
			public int x358 { get { return Field<int>(0x358); } }
			public int x35C { get { return Field<int>(0x35C); } }
			public int x360 { get { return Field<int>(0x360); } }
			public int x364 { get { return Field<int>(0x364); } }
			public int x368 { get { return Field<int>(0x368); } }
			public int x36C { get { return Field<int>(0x36C); } }
			public int x370 { get { return Field<int>(0x370); } }
			public int x374 { get { return Field<int>(0x374); } }
			public int x378 { get { return Field<int>(0x378); } }
			public int x37C { get { return Field<int>(0x37C); } }
			public int x380 { get { return Field<int>(0x380); } }
			public int x384 { get { return Field<int>(0x384); } }
			public int x388 { get { return Field<int>(0x388); } }
			public int x38C { get { return Field<int>(0x38C); } }
			public int x390 { get { return Field<int>(0x390); } }
			public int x394 { get { return Field<int>(0x394); } }
			public int x398 { get { return Field<int>(0x398); } }
			public int x39C { get { return Field<int>(0x39C); } }
			public int x3A0 { get { return Field<int>(0x3A0); } }
			public int x3A4 { get { return Field<int>(0x3A4); } }
			public int x3A8 { get { return Field<int>(0x3A8); } }
			public int x3AC { get { return Field<int>(0x3AC); } }
			public int x3B0 { get { return Field<int>(0x3B0); } }
			public int x3B4 { get { return Field<int>(0x3B4); } }
			public int x3B8 { get { return Field<int>(0x3B8); } }
			public int x3BC { get { return Field<int>(0x3BC); } }
			public int x3C0 { get { return Field<int>(0x3C0); } }
			public int x3C4 { get { return Field<int>(0x3C4); } }
			public int x3C8 { get { return Field<int>(0x3C8); } }
			public int x3CC { get { return Field<int>(0x3CC); } }
			public int x3D0 { get { return Field<int>(0x3D0); } }
			public int x3D4 { get { return Field<int>(0x3D4); } }
			public int x3D8 { get { return Field<int>(0x3D8); } }
			public int x3DC { get { return Field<int>(0x3DC); } }
			public int x3E0 { get { return Field<int>(0x3E0); } }
			public int x3E4 { get { return Field<int>(0x3E4); } }
			public int x3E8 { get { return Field<int>(0x3E8); } }
			public int x3EC { get { return Field<int>(0x3EC); } }
			public int x3F0 { get { return Field<int>(0x3F0); } }
			public int x3F4 { get { return Field<int>(0x3F4); } }
			public int x3F8 { get { return Field<int>(0x3F8); } }
			public int x3FC { get { return Field<int>(0x3FC); } }
			public int x404 { get { return Field<int>(0x404); } }
			public int x408 { get { return Field<int>(0x408); } }
			public int x40C { get { return Field<int>(0x40C); } }
			public int x410 { get { return Field<int>(0x410); } }
			public int x414 { get { return Field<int>(0x414); } }
			public int x418 { get { return Field<int>(0x418); } }
			public int x41C { get { return Field<int>(0x41C); } }
			public int x420 { get { return Field<int>(0x420); } }
			public int x424 { get { return Field<int>(0x424); } }
			public int x428 { get { return Field<int>(0x428); } }
			public int x42C { get { return Field<int>(0x42C); } }
			public int x430 { get { return Field<int>(0x430); } }
			public int x434 { get { return Field<int>(0x434); } }
			public int x438 { get { return Field<int>(0x438); } }
			public int x43C { get { return Field<int>(0x43C); } }
			public int x440 { get { return Field<int>(0x440); } }
			public int x444 { get { return Field<int>(0x444); } }
			public int x448 { get { return Field<int>(0x448); } }
			public int x44C { get { return Field<int>(0x44C); } }
			public int x450 { get { return Field<int>(0x450); } }
			public int x454 { get { return Field<int>(0x454); } }
			public int x458 { get { return Field<int>(0x458); } }
			public int x45C { get { return Field<int>(0x45C); } }
			public int x460 { get { return Field<int>(0x460); } }
			public int x464 { get { return Field<int>(0x464); } }
			public int x468 { get { return Field<int>(0x468); } }
			public int x46C { get { return Field<int>(0x46C); } }
			public int x470 { get { return Field<int>(0x470); } }
			public int x474 { get { return Field<int>(0x474); } }
		}
		
		[CompilerGenerated]
		public partial class QualityClass : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x168; // 360
			
			public string x000_Text { get { return Field(0x000, 256); } }
			public int x100 { get { return Field<int>(0x100); } }
			public int x104 { get { return Field<int>(0x104); } }
			public float x10C { get { return Field<float>(0x10C); } }
			public float x110 { get { return Field<float>(0x110); } }
			public float x114 { get { return Field<float>(0x114); } }
			public float x118 { get { return Field<float>(0x118); } }
			public float x11C { get { return Field<float>(0x11C); } }
			public float x120 { get { return Field<float>(0x120); } }
			public float x124 { get { return Field<float>(0x124); } }
			public float x128 { get { return Field<float>(0x128); } }
			public float x12C { get { return Field<float>(0x12C); } }
			public float x130 { get { return Field<float>(0x130); } }
			public float x134 { get { return Field<float>(0x134); } }
			public float x138 { get { return Field<float>(0x138); } }
			public float x13C { get { return Field<float>(0x13C); } }
			public float x140 { get { return Field<float>(0x140); } }
			public float x144 { get { return Field<float>(0x144); } }
			public float x148 { get { return Field<float>(0x148); } }
			public float x14C { get { return Field<float>(0x14C); } }
			public float x150 { get { return Field<float>(0x150); } }
			public float x154 { get { return Field<float>(0x154); } }
			public float x158 { get { return Field<float>(0x158); } }
			public float x15C { get { return Field<float>(0x15C); } }
			public float x160 { get { return Field<float>(0x160); } }
			public int x164 { get { return Field<int>(0x164); } }
		}
		
		[CompilerGenerated]
		public partial class HandicapLevel : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x120; // 288
			
			public string x000_Text { get { return Field(0x000, 256); } }
			public int x100 { get { return Field<int>(0x100); } }
			public int x104 { get { return Field<int>(0x104); } }
			public float x108 { get { return Field<float>(0x108); } }
			public float x10C { get { return Field<float>(0x10C); } }
			public float x110 { get { return Field<float>(0x110); } }
			public float x114 { get { return Field<float>(0x114); } }
			public float x118 { get { return Field<float>(0x118); } }
			public float x11C { get { return Field<float>(0x11C); } }
		}
		
		[CompilerGenerated]
		public partial class ItemSalvageLevel : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x118; // 280
			
			public string x000_Text { get { return Field(0x000, 256); } }
			public int x100 { get { return Field<int>(0x100); } }
			public int x104 { get { return Field<int>(0x104); } }
			public Sno x108_TreasureClassSno { get { return Field<Sno>(0x108); } }
			public Sno x10C_TreasureClassSno { get { return Field<Sno>(0x10C); } }
			public Sno x110_TreasureClassSno { get { return Field<Sno>(0x110); } }
			public Sno x114_TreasureClassSno { get { return Field<Sno>(0x114); } }
		}
		
		[CompilerGenerated]
		public partial class HirelingEntry : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x368; // 872
			
			public string x000_Text { get { return Field(0x000, 256); } }
			public int x100 { get { return Field<int>(0x100); } }
			public int x104 { get { return Field<int>(0x104); } }
			public Sno x108_ActorSno { get { return Field<Sno>(0x108); } }
			public Sno x10C_ActorSno { get { return Field<Sno>(0x10C); } }
			public Sno x110_ActorSno { get { return Field<Sno>(0x110); } }
			public Sno x114_TreasureClassSno { get { return Field<Sno>(0x114); } }
			public int x118_Enum { get { return Field<int>(0x118); } } // None = -1, Strength = 0, Dexterity = 1, Intelligence = 2
			public float x1BC { get { return Field<float>(0x1BC); } }
			public float x1C0 { get { return Field<float>(0x1C0); } }
			public float x1C4 { get { return Field<float>(0x1C4); } }
			public float x2E0 { get { return Field<float>(0x2E0); } }
			public float x2FC { get { return Field<float>(0x2FC); } }
			public float x300 { get { return Field<float>(0x300); } }
			public float x304 { get { return Field<float>(0x304); } }
			public float x308 { get { return Field<float>(0x308); } }
			public float x314 { get { return Field<float>(0x314); } }
			public float x318 { get { return Field<float>(0x318); } }
			public float x31C { get { return Field<float>(0x31C); } }
			public int x364 { get { return Field<int>(0x364); } }
		}
		
		[CompilerGenerated]
		public partial class SetItemBonusTableEntry : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x1D0; // 464
			
			public string x000_Text { get { return Field(0x000, 256); } }
			public int x100 { get { return Field<int>(0x100); } }
			public int x104 { get { return Field<int>(0x104); } }
			public GameBalanceId x108_SetItemBonusesGameBalanceId { get { return Field<GameBalanceId>(0x108); } }
			public int x10C { get { return Field<int>(0x10C); } }
			public AttributeSpecifier[] x110_AttributeSpecifiers { get { return Field<AttributeSpecifier>(0x110, 8); } }
		}
		
		[CompilerGenerated]
		public partial class EliteModifierData : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x160; // 352
			
			public string x000_Text { get { return Field(0x000, 256); } }
			public int x100 { get { return Field<int>(0x100); } }
			public int x104 { get { return Field<int>(0x104); } }
			public float x108 { get { return Field<float>(0x108); } }
			public Time x10C_Time { get { return Field<Time>(0x10C); } }
			public float x110 { get { return Field<float>(0x110); } }
			public Time x114_Time { get { return Field<Time>(0x114); } }
			public float x118 { get { return Field<float>(0x118); } }
			public Time x11C_Time { get { return Field<Time>(0x11C); } }
			public float x120 { get { return Field<float>(0x120); } }
			public Time x124_Time { get { return Field<Time>(0x124); } }
			public float x128 { get { return Field<float>(0x128); } }
			public Time x12C_Time { get { return Field<Time>(0x12C); } }
			public float x130 { get { return Field<float>(0x130); } }
			public Time x134_Time { get { return Field<Time>(0x134); } }
			public float x138 { get { return Field<float>(0x138); } }
			public Time x13C_Time { get { return Field<Time>(0x13C); } }
			public float x140 { get { return Field<float>(0x140); } }
			public float x144 { get { return Field<float>(0x144); } }
			public Time x148_Time { get { return Field<Time>(0x148); } }
			public float x14C { get { return Field<float>(0x14C); } }
			public float x150 { get { return Field<float>(0x150); } }
			public float x154 { get { return Field<float>(0x154); } }
			public float x158 { get { return Field<float>(0x158); } }
			public int x15C { get { return Field<int>(0x15C); } }
		}
		
		[CompilerGenerated]
		public partial class ItemTierData : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x20; // 32
			
			public GameBalanceId x00_ItemsGameBalanceId { get { return Field<GameBalanceId>(0x00); } }
			public GameBalanceId x04_ItemsGameBalanceId { get { return Field<GameBalanceId>(0x04); } }
			public GameBalanceId x08_ItemsGameBalanceId { get { return Field<GameBalanceId>(0x08); } }
			public GameBalanceId x0C_ItemsGameBalanceId { get { return Field<GameBalanceId>(0x0C); } }
			public GameBalanceId x10_ItemsGameBalanceId { get { return Field<GameBalanceId>(0x10); } }
			public GameBalanceId x14_ItemsGameBalanceId { get { return Field<GameBalanceId>(0x14); } }
			public GameBalanceId x18_ItemsGameBalanceId { get { return Field<GameBalanceId>(0x18); } }
			public GameBalanceId x1C_ItemsGameBalanceId { get { return Field<GameBalanceId>(0x1C); } }
		}
		
		[CompilerGenerated]
		public partial class PowerFormulaTableEntry : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x530; // 1328
			
			public string x000_Text { get { return Field(0x000, 1024); } }
			public float x400 { get { return Field<float>(0x400); } }
			public float x404 { get { return Field<float>(0x404); } }
			public float x408 { get { return Field<float>(0x408); } }
			public float x40C { get { return Field<float>(0x40C); } }
			public float x410 { get { return Field<float>(0x410); } }
			public float x414 { get { return Field<float>(0x414); } }
			public float x418 { get { return Field<float>(0x418); } }
			public float x41C { get { return Field<float>(0x41C); } }
			public float x420 { get { return Field<float>(0x420); } }
			public float x424 { get { return Field<float>(0x424); } }
			public float x428 { get { return Field<float>(0x428); } }
			public float x42C { get { return Field<float>(0x42C); } }
			public float x430 { get { return Field<float>(0x430); } }
			public float x434 { get { return Field<float>(0x434); } }
			public float x438 { get { return Field<float>(0x438); } }
			public float x43C { get { return Field<float>(0x43C); } }
			public float x440 { get { return Field<float>(0x440); } }
			public float x444 { get { return Field<float>(0x444); } }
			public float x448 { get { return Field<float>(0x448); } }
			public float x44C { get { return Field<float>(0x44C); } }
			public float x450 { get { return Field<float>(0x450); } }
			public float x454 { get { return Field<float>(0x454); } }
			public float x458 { get { return Field<float>(0x458); } }
			public float x45C { get { return Field<float>(0x45C); } }
			public float x460 { get { return Field<float>(0x460); } }
			public float x464 { get { return Field<float>(0x464); } }
			public float x468 { get { return Field<float>(0x468); } }
			public float x46C { get { return Field<float>(0x46C); } }
			public float x470 { get { return Field<float>(0x470); } }
			public float x474 { get { return Field<float>(0x474); } }
			public float x478 { get { return Field<float>(0x478); } }
			public float x47C { get { return Field<float>(0x47C); } }
			public float x480 { get { return Field<float>(0x480); } }
			public float x484 { get { return Field<float>(0x484); } }
			public float x488 { get { return Field<float>(0x488); } }
			public float x48C { get { return Field<float>(0x48C); } }
			public float x490 { get { return Field<float>(0x490); } }
			public float x494 { get { return Field<float>(0x494); } }
			public float x498 { get { return Field<float>(0x498); } }
			public float x49C { get { return Field<float>(0x49C); } }
			public float x4A0 { get { return Field<float>(0x4A0); } }
			public float x4A4 { get { return Field<float>(0x4A4); } }
			public float x4A8 { get { return Field<float>(0x4A8); } }
			public float x4AC { get { return Field<float>(0x4AC); } }
			public float x4B0 { get { return Field<float>(0x4B0); } }
			public float x4B4 { get { return Field<float>(0x4B4); } }
			public float x4B8 { get { return Field<float>(0x4B8); } }
			public float x4BC { get { return Field<float>(0x4BC); } }
			public float x4C0 { get { return Field<float>(0x4C0); } }
			public float x4C4 { get { return Field<float>(0x4C4); } }
			public float x4C8 { get { return Field<float>(0x4C8); } }
			public float x4CC { get { return Field<float>(0x4CC); } }
			public float x4D0 { get { return Field<float>(0x4D0); } }
			public float x4D4 { get { return Field<float>(0x4D4); } }
			public float x4D8 { get { return Field<float>(0x4D8); } }
			public float x4DC { get { return Field<float>(0x4DC); } }
			public float x4E0 { get { return Field<float>(0x4E0); } }
			public float x4E4 { get { return Field<float>(0x4E4); } }
			public float x4E8 { get { return Field<float>(0x4E8); } }
			public float x4EC { get { return Field<float>(0x4EC); } }
			public float x4F0 { get { return Field<float>(0x4F0); } }
			public float x4F4 { get { return Field<float>(0x4F4); } }
			public float x4F8 { get { return Field<float>(0x4F8); } }
			public float x4FC { get { return Field<float>(0x4FC); } }
			public float x500 { get { return Field<float>(0x500); } }
			public float x504 { get { return Field<float>(0x504); } }
			public float x508 { get { return Field<float>(0x508); } }
			public float x50C { get { return Field<float>(0x50C); } }
			public float x510 { get { return Field<float>(0x510); } }
			public float x514 { get { return Field<float>(0x514); } }
			public float x518 { get { return Field<float>(0x518); } }
			public float x51C { get { return Field<float>(0x51C); } }
			public float x520 { get { return Field<float>(0x520); } }
			public float x524 { get { return Field<float>(0x524); } }
			public float x528 { get { return Field<float>(0x528); } }
			public float x52C { get { return Field<float>(0x52C); } }
		}
		
		[CompilerGenerated]
		public partial class RecipeEntry : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x150; // 336
			
			public string x000_Text { get { return Field(0x000, 256); } }
			public int x100 { get { return Field<int>(0x100); } }
			public int x104 { get { return Field<int>(0x104); } }
			public Sno x108_RecipeSno { get { return Field<Sno>(0x108); } }
			public int x10C_Enum { get { return Field<int>(0x10C); } } // Blacksmith = 0, Jeweler = 1, Mystic = 2, Made To Order = 3, Devil's Hand = 4, - None - = -1
			public int x110 { get { return Field<int>(0x110); } }
			public int x114 { get { return Field<int>(0x114); } }
			public int x118 { get { return Field<int>(0x118); } }
			public int x11C { get { return Field<int>(0x11C); } }
			public RecipeIngredient[] x120_RecipeIngredients { get { return Field<RecipeIngredient>(0x120, 6); } }
		}
		
		[CompilerGenerated]
		public partial class ScriptedAchievementEvent : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x108; // 264
			
			public string x000_Text { get { return Field(0x000, 256); } }
			public int x100 { get { return Field<int>(0x100); } }
			public int x104 { get { return Field<int>(0x104); } }
		}
		
		[CompilerGenerated]
		public partial class ItemDurabilityCostScalar : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x8; // 8
			
			public float x00 { get { return Field<float>(0x00); } }
			public float x04 { get { return Field<float>(0x04); } }
		}
		
		[CompilerGenerated]
		public partial class LootRunQuestTierEntry : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x208; // 520
			
			public string x000_Text { get { return Field(0x000, 256); } }
			public int x100 { get { return Field<int>(0x100); } }
			public int x104 { get { return Field<int>(0x104); } }
			public Sno x108_QuestSno { get { return Field<Sno>(0x108); } }
			public float x10C { get { return Field<float>(0x10C); } }
			public GameBalanceId x110_GameBalanceId { get { return Field<GameBalanceId>(0x110); } }
			public GameBalanceId x114_ItemsGameBalanceId { get { return Field<GameBalanceId>(0x114); } }
			public Sno x118_QuestSno { get { return Field<Sno>(0x118); } }
			public float x11C { get { return Field<float>(0x11C); } }
			public GameBalanceId x120_GameBalanceId { get { return Field<GameBalanceId>(0x120); } }
			public GameBalanceId x124_ItemsGameBalanceId { get { return Field<GameBalanceId>(0x124); } }
			public Sno x128_QuestSno { get { return Field<Sno>(0x128); } }
			public float x12C { get { return Field<float>(0x12C); } }
			public GameBalanceId x130_GameBalanceId { get { return Field<GameBalanceId>(0x130); } }
			public GameBalanceId x134_ItemsGameBalanceId { get { return Field<GameBalanceId>(0x134); } }
			public Sno x138_QuestSno { get { return Field<Sno>(0x138); } }
			public float x13C { get { return Field<float>(0x13C); } }
			public GameBalanceId x140_GameBalanceId { get { return Field<GameBalanceId>(0x140); } }
			public GameBalanceId x144_ItemsGameBalanceId { get { return Field<GameBalanceId>(0x144); } }
			public Sno x148_QuestSno { get { return Field<Sno>(0x148); } }
			public float x14C { get { return Field<float>(0x14C); } }
			public GameBalanceId x150_GameBalanceId { get { return Field<GameBalanceId>(0x150); } }
			public GameBalanceId x154_ItemsGameBalanceId { get { return Field<GameBalanceId>(0x154); } }
			public Sno x158_QuestSno { get { return Field<Sno>(0x158); } }
			public float x15C { get { return Field<float>(0x15C); } }
			public GameBalanceId x160_GameBalanceId { get { return Field<GameBalanceId>(0x160); } }
			public GameBalanceId x164_ItemsGameBalanceId { get { return Field<GameBalanceId>(0x164); } }
			public Sno x168_QuestSno { get { return Field<Sno>(0x168); } }
			public float x16C { get { return Field<float>(0x16C); } }
			public GameBalanceId x170_GameBalanceId { get { return Field<GameBalanceId>(0x170); } }
			public GameBalanceId x174_ItemsGameBalanceId { get { return Field<GameBalanceId>(0x174); } }
			public Sno x178_QuestSno { get { return Field<Sno>(0x178); } }
			public float x17C { get { return Field<float>(0x17C); } }
			public GameBalanceId x180_GameBalanceId { get { return Field<GameBalanceId>(0x180); } }
			public GameBalanceId x184_ItemsGameBalanceId { get { return Field<GameBalanceId>(0x184); } }
			public Sno x188_QuestSno { get { return Field<Sno>(0x188); } }
			public float x18C { get { return Field<float>(0x18C); } }
			public GameBalanceId x190_GameBalanceId { get { return Field<GameBalanceId>(0x190); } }
			public GameBalanceId x194_ItemsGameBalanceId { get { return Field<GameBalanceId>(0x194); } }
			public Sno x198_QuestSno { get { return Field<Sno>(0x198); } }
			public float x19C { get { return Field<float>(0x19C); } }
			public GameBalanceId x1A0_GameBalanceId { get { return Field<GameBalanceId>(0x1A0); } }
			public GameBalanceId x1A4_ItemsGameBalanceId { get { return Field<GameBalanceId>(0x1A4); } }
			public Sno x1A8_QuestSno { get { return Field<Sno>(0x1A8); } }
			public float x1AC { get { return Field<float>(0x1AC); } }
			public GameBalanceId x1B0_GameBalanceId { get { return Field<GameBalanceId>(0x1B0); } }
			public GameBalanceId x1B4_ItemsGameBalanceId { get { return Field<GameBalanceId>(0x1B4); } }
			public Sno x1B8_QuestSno { get { return Field<Sno>(0x1B8); } }
			public float x1BC { get { return Field<float>(0x1BC); } }
			public GameBalanceId x1C0_GameBalanceId { get { return Field<GameBalanceId>(0x1C0); } }
			public GameBalanceId x1C4_ItemsGameBalanceId { get { return Field<GameBalanceId>(0x1C4); } }
			public Sno x1C8_QuestSno { get { return Field<Sno>(0x1C8); } }
			public float x1CC { get { return Field<float>(0x1CC); } }
			public GameBalanceId x1D0_GameBalanceId { get { return Field<GameBalanceId>(0x1D0); } }
			public GameBalanceId x1D4_ItemsGameBalanceId { get { return Field<GameBalanceId>(0x1D4); } }
			public Sno x1D8_QuestSno { get { return Field<Sno>(0x1D8); } }
			public float x1DC { get { return Field<float>(0x1DC); } }
			public GameBalanceId x1E0_GameBalanceId { get { return Field<GameBalanceId>(0x1E0); } }
			public GameBalanceId x1E4_ItemsGameBalanceId { get { return Field<GameBalanceId>(0x1E4); } }
			public Sno x1E8_QuestSno { get { return Field<Sno>(0x1E8); } }
			public float x1EC { get { return Field<float>(0x1EC); } }
			public GameBalanceId x1F0_GameBalanceId { get { return Field<GameBalanceId>(0x1F0); } }
			public GameBalanceId x1F4_ItemsGameBalanceId { get { return Field<GameBalanceId>(0x1F4); } }
			public Sno x1F8_QuestSno { get { return Field<Sno>(0x1F8); } }
			public float x1FC { get { return Field<float>(0x1FC); } }
			public GameBalanceId x200_GameBalanceId { get { return Field<GameBalanceId>(0x200); } }
			public GameBalanceId x204_ItemsGameBalanceId { get { return Field<GameBalanceId>(0x204); } }
		}
		
		[CompilerGenerated]
		public partial class ParagonBonus : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x280; // 640
			
			public string x000_Text { get { return Field(0x000, 256); } }
			public int x100 { get { return Field<int>(0x100); } }
			public int x104 { get { return Field<int>(0x104); } }
			public int x108 { get { return Field<int>(0x108); } }
			public AttributeSpecifier[] x110_AttributeSpecifiers { get { return Field<AttributeSpecifier>(0x110, 4); } }
			public int x170 { get { return Field<int>(0x170); } }
			public int x174 { get { return Field<int>(0x174); } }
			public int x178_Enum { get { return Field<int>(0x178); } } // - None - = -1, DemonHunter = 0, Barbarian = 1, Wizard = 2, Witchdoctor = 3, Monk = 4, Crusader = 5
			public string x17C_Text { get { return Field(0x17C, 256); } }
		}
		
		[CompilerGenerated]
		public partial class MadeToOrderTypesEntry : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x130; // 304
			
			public string x000_Text { get { return Field(0x000, 256); } }
			public int x100 { get { return Field<int>(0x100); } }
			public int x104 { get { return Field<int>(0x104); } }
			public int x108 { get { return Field<int>(0x108); } }
			public int x10C { get { return Field<int>(0x10C); } }
			public RecipeIngredient[] x110_RecipeIngredients { get { return Field<RecipeIngredient>(0x110, 3); } }
			public int x128 { get { return Field<int>(0x128); } }
			public int x12C { get { return Field<int>(0x12C); } }
		}
		
		[CompilerGenerated]
		public partial class MadeToOrderAffixFoldersEntry : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x178; // 376
			
			public string x000_Text { get { return Field(0x000, 256); } }
			public int x100 { get { return Field<int>(0x100); } }
			public int x104 { get { return Field<int>(0x104); } }
			public int x108 { get { return Field<int>(0x108); } }
			public GameBalanceId x10C_MadeToOrderAffixFoldersGameBalanceId { get { return Field<GameBalanceId>(0x10C); } }
			public GameBalanceId[] x110_GameBalanceIds { get { return Field<GameBalanceId>(0x110, 24); } }
			public int x170 { get { return Field<int>(0x170); } }
			public int x174 { get { return Field<int>(0x174); } }
		}
		
		[CompilerGenerated]
		public partial class DevilsHandRedeemableSet : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x180; // 384
			
			public string x000_Text { get { return Field(0x000, 256); } }
			public int x100 { get { return Field<int>(0x100); } }
			public int x104 { get { return Field<int>(0x104); } }
			public int x108 { get { return Field<int>(0x108); } }
			public bool x10C_Bit0 { get { return (Field<int>(0x10C) & 0x00000001) != 0; } }
			public bool x10C_Bit1 { get { return (Field<int>(0x10C) & 0x00000002) != 0; } }
			public DevilsHandRedeemableSetReward[] x110_DevilsHandRedeemableSetRewards { get { return Field<DevilsHandRedeemableSetReward>(0x110, 8); } }
			public int x150 { get { return Field<int>(0x150); } }
			public Sno x154_LoreSno { get { return Field<Sno>(0x154); } }
			public GameBalanceId[] x158_GameBalanceIds { get { return Field<GameBalanceId>(0x158, 8); } }
			public int x178 { get { return Field<int>(0x178); } }
		}
		
		[CompilerGenerated]
		public partial class LegacyItemConversion : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x110; // 272
			
			public string x000_Text { get { return Field(0x000, 256); } }
			public int x100 { get { return Field<int>(0x100); } }
			public int x104 { get { return Field<int>(0x104); } }
			public GameBalanceId x108_ItemsGameBalanceId { get { return Field<GameBalanceId>(0x108); } }
			public GameBalanceId x10C_ItemsGameBalanceId { get { return Field<GameBalanceId>(0x10C); } }
		}
		
		[CompilerGenerated]
		public partial class EnchantItemAffixUseCountCostScalar : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x8; // 8
			
			public int x00 { get { return Field<int>(0x00); } }
			public float x04 { get { return Field<float>(0x04); } }
		}
		
		[CompilerGenerated]
		public partial class RecipeIngredient : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x8; // 8
			
			public GameBalanceId x00_ItemsGameBalanceId { get { return Field<GameBalanceId>(0x00); } }
			public int x04 { get { return Field<int>(0x04); } }
		}
		
		[CompilerGenerated]
		public partial class AttributeSpecifier : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x18; // 24
			
			public Translateable x00_Translateable { get { return Field<Translateable>(0x00); } } // TranslateFromString = 0x01144690, TranslateFromValue = 0x01144740
			public AttributeParameter x04_AttributeParameter { get { return Field<AttributeParameter>(0x04); } }
			public string x08_Text { get { return Deserialize(x10_SerializeData); } }
			public SerializeData x10_SerializeData { get { return Field<SerializeData>(0x10); } }
		}
		
		[CompilerGenerated]
		public partial class DevilsHandRedeemableSetReward : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x8; // 8
			
			public GameBalanceId x00_GameBalanceId { get { return Field<GameBalanceId>(0x00); } }
			public int x04 { get { return Field<int>(0x04); } }
		}
	}
}
