public class OctreeNode : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x30; // 48

	public OctreeNode(ProcessMemory memory, int address)
		: base(memory, address) { }

	public OctreeCube x00 { get { return Field<OctreeCube>(0x00); } }
	public int[] x10_Array { get { return Field<int>(0x10, 8); } }
}
