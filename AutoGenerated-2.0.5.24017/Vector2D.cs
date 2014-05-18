public class Vector2D : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x08; // 8

	public Vector2D(ProcessMemory memory, int address)
		: base(memory, address) { }

	public float x00 { get { return Field<float>(0x00); } }
	public float x04 { get { return Field<float>(0x04); } }
}
