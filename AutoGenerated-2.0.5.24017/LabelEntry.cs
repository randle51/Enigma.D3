public class LabelEntry : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x14; // 20

	public LabelEntry(ProcessMemory memory, int address)
		: base(memory, address) { }

	public DT_GBID x00_LabelsGameBalanceId { get { return Field<DT_GBID>(0x00); } }
	public int x04 { get { return Field<int>(0x04); } }
	public float x08 { get { return Field<float>(0x08); } }
	public int x0C { get { return Field<int>(0x0C); } }
	public int x10 { get { return Field<int>(0x10); } }
}
