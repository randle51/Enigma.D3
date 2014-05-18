public class LootDropModifier : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x78; // 120

	public LootDropModifier(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x00 { get { return Field<int>(0x00); } }
	public int x04_TreasureClassSnoId { get { return Field<int>(0x04); } }
	public DT_HIGHPRECISIONPERCENT x08 { get { return Field<DT_HIGHPRECISIONPERCENT>(0x08); } }
	public int x0C { get { return Field<int>(0x0C); } }
	public DT_GBID x10_QualityClassesGameBalanceId { get { return Field<DT_GBID>(0x10); } }
	public int x14 { get { return Field<int>(0x14); } }
	public int x18 { get { return Field<int>(0x18); } }
	public int x1C_ConditionSnoId { get { return Field<int>(0x1C); } }
	public ItemSpecifierData x20 { get { return Field<ItemSpecifierData>(0x20); } }
	public int x58 { get { return Field<int>(0x58); } }
	public int x5C { get { return Field<int>(0x5C); } }
	public int[] x60_Array { get { return Field<int>(0x60, 4); } }
	public int x70 { get { return Field<int>(0x70); } }
	public int x74 { get { return Field<int>(0x74); } }
}
