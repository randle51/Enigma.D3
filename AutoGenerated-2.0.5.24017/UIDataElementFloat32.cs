public class UIDataElementFloat32 : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x10; // 16

	public UIDataElementFloat32(ProcessMemory memory, int address)
		: base(memory, address) { }

	public long x00 { get { return Field<long>(0x00); } }
	public float x08 { get { return Field<float>(0x08); } }
}
