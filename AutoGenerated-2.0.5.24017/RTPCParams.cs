public class RTPCParams : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x18; // 24

	public RTPCParams(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x00 { get { return Field<int>(0x00); } }
	public InterpolationScalar x04 { get { return Field<InterpolationScalar>(0x04); } }
	public int x10 { get { return Field<int>(0x10); } }
	public float x14 { get { return Field<float>(0x14); } }
}
