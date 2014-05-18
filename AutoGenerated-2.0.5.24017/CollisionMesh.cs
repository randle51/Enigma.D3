public class CollisionMesh : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x70; // 112

	public CollisionMesh(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x00_Count { get { return Field<int>(0x00); } }
	public dmMeshNode[] x04_PtrArray { get { return Dereference<dmMeshNode>(0x04, x00_Count); } }
	public int x08_Count { get { return Field<int>(0x08); } }
	public dmFloat4[] x0C_PtrArray { get { return Dereference<dmFloat4>(0x0C, x08_Count); } }
	public int x10_Count { get { return Field<int>(0x10); } }
	public dmMeshTriangle[] x14_PtrArray { get { return Dereference<dmMeshTriangle>(0x14, x10_Count); } }
	public dmFloat3 x18 { get { return Field<dmFloat3>(0x18); } }
	public dmFloat3 x24 { get { return Field<dmFloat3>(0x24); } }
	public dmFloat3 x30 { get { return Field<dmFloat3>(0x30); } }
	public int x3C { get { return Field<int>(0x3C); } }
	public int x40 { get { return Field<int>(0x40); } }
	public int x44 { get { return Field<int>(0x44); } }
	public int x48 { get { return Field<int>(0x48); } }
	public SerializeData x50 { get { return Field<SerializeData>(0x50); } }
	public SerializeData x58 { get { return Field<SerializeData>(0x58); } }
	public SerializeData x60 { get { return Field<SerializeData>(0x60); } }
	public int x68 { get { return Field<int>(0x68); } }
	public int x6C { get { return Field<int>(0x6C); } }
}
