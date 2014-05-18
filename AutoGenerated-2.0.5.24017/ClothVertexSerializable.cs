public class ClothVertexSerializable : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x54; // 84

	public ClothVertexSerializable(ProcessMemory memory, int address)
		: base(memory, address) { }

	public Vector3D x00 { get { return Field<Vector3D>(0x00); } }
	public Vector3D x0C { get { return Field<Vector3D>(0x0C); } }
	public Vector3D x18 { get { return Field<Vector3D>(0x18); } }
	public Vector3D x24 { get { return Field<Vector3D>(0x24); } }
	public float x30 { get { return Field<float>(0x30); } }
	public int x34 { get { return Field<int>(0x34); } }
	public int x38 { get { return Field<int>(0x38); } }
	public int x3C { get { return Field<int>(0x3C); } }
	public int x40 { get { return Field<int>(0x40); } }
	public Vector3D x44 { get { return Field<Vector3D>(0x44); } }
	public int x50 { get { return Field<int>(0x50); } }
}
