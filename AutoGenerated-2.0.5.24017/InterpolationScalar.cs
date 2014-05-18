public class InterpolationScalar : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x0C; // 12

	public InterpolationScalar(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x00 { get { return Field<int>(0x00); } }
	public float x04 { get { return Field<float>(0x04); } }
	public float x08 { get { return Field<float>(0x08); } }
}
