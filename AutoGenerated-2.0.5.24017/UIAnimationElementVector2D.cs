public class UIAnimationElementVector2D : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x0C; // 12

	public UIAnimationElementVector2D(ProcessMemory memory, int address)
		: base(memory, address) { }

	public float x00 { get { return Field<float>(0x00); } }
	public float[] x04_Array { get { return Field<float>(0x04, 2); } }
}
