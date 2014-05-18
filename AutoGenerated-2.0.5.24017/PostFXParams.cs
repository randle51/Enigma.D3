public class PostFXParams : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x20; // 32

	public PostFXParams(ProcessMemory memory, int address)
		: base(memory, address) { }

	public float[] x00_Array { get { return Field<float>(0x00, 4); } }
	public float[] x10_Array { get { return Field<float>(0x10, 4); } }
}
