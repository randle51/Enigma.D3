public class HealthDropInfo : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x0C; // 12

	public HealthDropInfo(ProcessMemory memory, int address)
		: base(memory, address) { }

	public float x00 { get { return Field<float>(0x00); } }
	public DT_GBID x04_ItemsGameBalanceId { get { return Field<DT_GBID>(0x04); } }
	public int x08 { get { return Field<int>(0x08); } }
}
