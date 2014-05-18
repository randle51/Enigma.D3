public class PhysMesh : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x30; // 48

	public PhysMesh(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x0C { get { return Field<int>(0x0C); } }
	public int x10 { get { return Field<int>(0x10); } }
	public SerializeData x14 { get { return Field<SerializeData>(0x14); } }
	public int x20_Count { get { return Field<int>(0x20); } }
	public CollisionMesh[] x24_PtrArray { get { return Dereference<CollisionMesh>(0x24, x20_Count); } }
	public int x28 { get { return Field<int>(0x28); } }
}
