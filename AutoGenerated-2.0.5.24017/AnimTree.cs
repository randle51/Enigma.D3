public class AnimTree : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x60; // 96

	public AnimTree(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x0C { get { return Field<int>(0x0C); } }
	public int x10 { get { return Field<int>(0x10); } }
	public int x14 { get { return Field<int>(0x14); } }
	public SerializeData x18 { get { return Field<SerializeData>(0x18); } }
	public int x20_Count { get { return Field<int>(0x20); } }
	public AnimTreeLeaf[] x24_PtrArray { get { return Dereference<AnimTreeLeaf>(0x24, x20_Count); } }
	public int x28 { get { return Field<int>(0x28); } }
	public SerializeData x2C { get { return Field<SerializeData>(0x2C); } }
	public int x38_Count { get { return Field<int>(0x38); } }
	public AnimTreeNode[] x3C_PtrArray { get { return Dereference<AnimTreeNode>(0x3C, x38_Count); } }
	public int x40 { get { return Field<int>(0x40); } }
	public SerializeData x44 { get { return Field<SerializeData>(0x44); } }
	public int x50_Count { get { return Field<int>(0x50); } }
	public int[] x54_PtrArray { get { return Dereference<int>(0x54, x50_Count); } }
	public int x58 { get { return Field<int>(0x58); } }
}
