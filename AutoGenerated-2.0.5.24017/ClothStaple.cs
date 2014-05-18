public class ClothStaple : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x1C; // 28

	public ClothStaple(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x00 { get { return Field<int>(0x00); } }
	public int[] x04_Array { get { return Field<int>(0x04, 3); } }
	public float[] x10_Array { get { return Field<float>(0x10, 3); } }
}
