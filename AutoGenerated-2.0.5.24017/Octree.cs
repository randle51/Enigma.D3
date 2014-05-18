public class Octree : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x48; // 72

	public Octree(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x00 { get { return Field<int>(0x00); } }
	public int x04 { get { return Field<int>(0x04); } }
	public int x08 { get { return Field<int>(0x08); } }
	public int x0C { get { return Field<int>(0x0C); } }
	public int x10 { get { return Field<int>(0x10); } }
	public int x14 { get { return Field<int>(0x14); } }
	public SerializeData x18 { get { return Field<SerializeData>(0x18); } }
	public int x20_Count { get { return Field<int>(0x20); } }
	public OctreeNode[] x24_PtrArray { get { return Dereference<OctreeNode>(0x24, x20_Count); } }
	public SerializeData x28 { get { return Field<SerializeData>(0x28); } }
	public int x30_Count { get { return Field<int>(0x30); } }
	public OctreeLeaf[] x34_PtrArray { get { return Dereference<OctreeLeaf>(0x34, x30_Count); } }
	public SerializeData x38 { get { return Field<SerializeData>(0x38); } }
	public int x40_Count { get { return Field<int>(0x40); } }
	public OctreePrimitive[] x44_PtrArray { get { return Dereference<OctreePrimitive>(0x44, x40_Count); } }
}
