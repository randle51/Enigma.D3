public class OctreeLeaf : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x18; // 24

	public OctreeLeaf(ProcessMemory memory, int address)
		: base(memory, address) { }

	public OctreeCube x00 { get { return Field<OctreeCube>(0x00); } }
	public int x10 { get { return Field<int>(0x10); } }
	public int x14 { get { return Field<int>(0x14); } }
}
