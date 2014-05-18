public class Circle : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x0C; // 12

	public Circle(ProcessMemory memory, int address)
		: base(memory, address) { }

	public Vector2D x00 { get { return Field<Vector2D>(0x00); } }
	public float x08 { get { return Field<float>(0x08); } }
}
