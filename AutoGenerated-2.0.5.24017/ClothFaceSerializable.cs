public class ClothFaceSerializable : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x1C; // 28

	public ClothFaceSerializable(ProcessMemory memory, int address)
		: base(memory, address) { }

	public Vector3D x00 { get { return Field<Vector3D>(0x00); } }
	public float x0C { get { return Field<float>(0x0C); } }
	public int x10 { get { return Field<int>(0x10); } }
	public int x14 { get { return Field<int>(0x14); } }
	public int x18 { get { return Field<int>(0x18); } }
}
