public class GameBalance : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x248; // 584

	public GameBalance(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x00C { get { return Field<int>(0x00C); } }
	public int x010 { get { return Field<int>(0x010); } }
	public int x014 { get { return Field<int>(0x014); } }
	public Items x018 { get { return Field<Items>(0x018); } }
	public Items x028 { get { return Field<Items>(0x028); } }
	public ExperienceTable x038 { get { return Field<ExperienceTable>(0x038); } }
	public HelpCodes x048 { get { return Field<HelpCodes>(0x048); } }
	public MonsterLevelTable x058 { get { return Field<MonsterLevelTable>(0x058); } }
	public AffixTable x068 { get { return Field<AffixTable>(0x068); } }
	public Heros x078 { get { return Field<Heros>(0x078); } }
	public MovementStyles x088 { get { return Field<MovementStyles>(0x088); } }
	public Labels x098 { get { return Field<Labels>(0x098); } }
	public LootDistributionTable x0A8 { get { return Field<LootDistributionTable>(0x0A8); } }
	public RareItemNamesTable x0B8 { get { return Field<RareItemNamesTable>(0x0B8); } }
	public MonsterAffixesTable x0C8 { get { return Field<MonsterAffixesTable>(0x0C8); } }
	public RareMonsterNamesTable x0D8 { get { return Field<RareMonsterNamesTable>(0x0D8); } }
	public SocketedEffectsTable x0E8 { get { return Field<SocketedEffectsTable>(0x0E8); } }
	public ItemEnchantmentTable x0F8 { get { return Field<ItemEnchantmentTable>(0x0F8); } }
	public ItemDropTable x108 { get { return Field<ItemDropTable>(0x108); } }
	public ItemLevelModTable x118 { get { return Field<ItemLevelModTable>(0x118); } }
	public QualityClassTable x128 { get { return Field<QualityClassTable>(0x128); } }
	public HandicapLevelTable x138 { get { return Field<HandicapLevelTable>(0x138); } }
	public ItemSalvageLevelTable x148 { get { return Field<ItemSalvageLevelTable>(0x148); } }
	public Hirelings x158 { get { return Field<Hirelings>(0x158); } }
	public SetItemBonusTable x168 { get { return Field<SetItemBonusTable>(0x168); } }
	public EliteModifiers x178 { get { return Field<EliteModifiers>(0x178); } }
	public ItemTiers x188 { get { return Field<ItemTiers>(0x188); } }
	public PowerFormulaTable x198 { get { return Field<PowerFormulaTable>(0x198); } }
	public RecipesTable x1A8 { get { return Field<RecipesTable>(0x1A8); } }
	public ScriptedAchievementEventsTable x1B8 { get { return Field<ScriptedAchievementEventsTable>(0x1B8); } }
	public ItemDurabilityCostScalarsTable x1C8 { get { return Field<ItemDurabilityCostScalarsTable>(0x1C8); } }
	public LootRunQuestTierTable x1D8 { get { return Field<LootRunQuestTierTable>(0x1D8); } }
	public ParagonBonusesTable x1E8 { get { return Field<ParagonBonusesTable>(0x1E8); } }
	public MadeToOrderTypesTable x1F8 { get { return Field<MadeToOrderTypesTable>(0x1F8); } }
	public MadeToOrderAffixFoldersTable x208 { get { return Field<MadeToOrderAffixFoldersTable>(0x208); } }
	public DevilsHandRedeemableSetTable x218 { get { return Field<DevilsHandRedeemableSetTable>(0x218); } }
	public LegacyItemConversionTable x228 { get { return Field<LegacyItemConversionTable>(0x228); } }
	public EnchantItemAffixUseCountCostScalarsTable x238 { get { return Field<EnchantItemAffixUseCountCostScalarsTable>(0x238); } }
}
