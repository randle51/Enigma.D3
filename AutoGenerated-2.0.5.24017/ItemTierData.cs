public class ItemTierData : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x20; // 32

	public ItemTierData(ProcessMemory memory, int address)
		: base(memory, address) { }

	public DT_GBID x00_ItemsGameBalanceId { get { return Field<DT_GBID>(0x00); } }
	public DT_GBID x04_ItemsGameBalanceId { get { return Field<DT_GBID>(0x04); } }
	public DT_GBID x08_ItemsGameBalanceId { get { return Field<DT_GBID>(0x08); } }
	public DT_GBID x0C_ItemsGameBalanceId { get { return Field<DT_GBID>(0x0C); } }
	public DT_GBID x10_ItemsGameBalanceId { get { return Field<DT_GBID>(0x10); } }
	public DT_GBID x14_ItemsGameBalanceId { get { return Field<DT_GBID>(0x14); } }
	public DT_GBID x18_ItemsGameBalanceId { get { return Field<DT_GBID>(0x18); } }
	public DT_GBID x1C_ItemsGameBalanceId { get { return Field<DT_GBID>(0x1C); } }
}
