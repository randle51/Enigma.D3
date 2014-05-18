public class AngleNode : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x0C; // 12

	public AngleNode(ProcessMemory memory, int address)
		: base(memory, address) { }

	public DT_ANGLE x00 { get { return Field<DT_ANGLE>(0x00); } }
	public DT_ANGLE x04 { get { return Field<DT_ANGLE>(0x04); } }
	public float x08 { get { return Field<float>(0x08); } }
}
