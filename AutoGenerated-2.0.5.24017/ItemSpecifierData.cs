public class ItemSpecifierData : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x38; // 56

	public ItemSpecifierData(ProcessMemory memory, int address)
		: base(memory, address) { }

	public DT_GBID x00_ItemsGameBalanceId { get { return Field<DT_GBID>(0x00); } }
	public int x04 { get { return Field<int>(0x04); } }
	public DT_GBID[] x08_Array_AffixListGameBalanceId { get { return Field<DT_GBID>(0x08, 6); } }
	public int x20 { get { return Field<int>(0x20); } }
	public int x24 { get { return Field<int>(0x24); } }
	public int x28 { get { return Field<int>(0x28); } }
	public int x2C { get { return Field<int>(0x2C); } }
	public int x30 { get { return Field<int>(0x30); } }
	public int x34 { get { return Field<int>(0x34); } }
}
