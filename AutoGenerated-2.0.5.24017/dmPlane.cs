public class dmPlane : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x10; // 16

	public dmPlane(ProcessMemory memory, int address)
		: base(memory, address) { }

	public dmFloat3 x00 { get { return Field<dmFloat3>(0x00); } }
	public float x0C { get { return Field<float>(0x0C); } }
}
