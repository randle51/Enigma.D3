public class LegacyItemConversion : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x110; // 272

	public LegacyItemConversion(ProcessMemory memory, int address)
		: base(memory, address) { }

	public string x000 { get { return Field(0x000, 256); } }
	public int x100 { get { return Field<int>(0x100); } }
	public int x104 { get { return Field<int>(0x104); } }
	public DT_GBID x108_ItemsGameBalanceId { get { return Field<DT_GBID>(0x108); } }
	public DT_GBID x10C_ItemsGameBalanceId { get { return Field<DT_GBID>(0x10C); } }
}
