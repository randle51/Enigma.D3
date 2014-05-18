public class TreasureClass : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x28; // 40

	public TreasureClass(ProcessMemory memory, int address)
		: base(memory, address) { }

	public DT_HIGHPRECISIONPERCENT x0C { get { return Field<DT_HIGHPRECISIONPERCENT>(0x0C); } }
	public int x10 { get { return Field<int>(0x10); } }
	public int x14 { get { return Field<int>(0x14); } }
	public int x18_Count { get { return Field<int>(0x18); } }
	public LootDropModifier[] x1C_PtrArray { get { return Dereference<LootDropModifier>(0x1C, x18_Count); } }
	public SerializeData x20 { get { return Field<SerializeData>(0x20); } }
}
