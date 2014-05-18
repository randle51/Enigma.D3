public class ItemSalvageLevel : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x118; // 280

	public ItemSalvageLevel(ProcessMemory memory, int address)
		: base(memory, address) { }

	public string x000 { get { return Field(0x000, 256); } }
	public int x100 { get { return Field<int>(0x100); } }
	public int x104 { get { return Field<int>(0x104); } }
	public int x108_TreasureClassSnoId { get { return Field<int>(0x108); } }
	public int x10C_TreasureClassSnoId { get { return Field<int>(0x10C); } }
	public int x110_TreasureClassSnoId { get { return Field<int>(0x110); } }
	public int x114_TreasureClassSnoId { get { return Field<int>(0x114); } }
}
