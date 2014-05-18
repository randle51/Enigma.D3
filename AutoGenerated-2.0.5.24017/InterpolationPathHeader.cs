public class InterpolationPathHeader : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x1C; // 28

	public InterpolationPathHeader(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x00 { get { return Field<int>(0x00); } }
	public float x04 { get { return Field<float>(0x04); } }
	public float x08 { get { return Field<float>(0x08); } }
	public int x0C { get { return Field<int>(0x0C); } }
	public InterpolationScalar x10 { get { return Field<InterpolationScalar>(0x10); } }
}
