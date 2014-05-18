public class TimeNode : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x0C; // 12

	public TimeNode(ProcessMemory memory, int address)
		: base(memory, address) { }

	public DT_TIME x00 { get { return Field<DT_TIME>(0x00); } }
	public DT_TIME x04 { get { return Field<DT_TIME>(0x04); } }
	public float x08 { get { return Field<float>(0x08); } }
}
