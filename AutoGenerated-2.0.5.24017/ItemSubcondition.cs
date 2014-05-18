public class ItemSubcondition : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x10; // 16

	public ItemSubcondition(ProcessMemory memory, int address)
		: base(memory, address) { }

	public DT_GBID x00_ItemsGameBalanceId { get { return Field<DT_GBID>(0x00); } }
	public int x04 { get { return Field<int>(0x04); } }
	public int x08 { get { return Field<int>(0x08); } }
	public int x0C { get { return Field<int>(0x0C); } }
}
