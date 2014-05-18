public class CollisionShape : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x50; // 80

	public CollisionShape(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x00 { get { return Field<int>(0x00); } }
	public int x04 { get { return Field<int>(0x04); } }
	public int x08 { get { return Field<int>(0x08); } }
	public int x0C { get { return Field<int>(0x0C); } }
	public float x10 { get { return Field<float>(0x10); } }
	public float x14 { get { return Field<float>(0x14); } }
	public float x18 { get { return Field<float>(0x18); } }
	public SerializeData x1C { get { return Field<SerializeData>(0x1C); } }
	public int x28_Count { get { return Field<int>(0x28); } }
	public PolytopeData[] x2C_PtrArray { get { return Dereference<PolytopeData>(0x2C, x28_Count); } }
	public Vector3D x30 { get { return Field<Vector3D>(0x30); } }
	public Vector3D x3C { get { return Field<Vector3D>(0x3C); } }
	public float x48 { get { return Field<float>(0x48); } }
}
