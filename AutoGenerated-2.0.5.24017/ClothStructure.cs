public class ClothStructure : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x80; // 128

	public ClothStructure(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x00 { get { return Field<int>(0x00); } }
	public SerializeData x04 { get { return Field<SerializeData>(0x04); } }
	public int x10_Count { get { return Field<int>(0x10); } }
	public ClothVertexSerializable[] x14_PtrArray { get { return Dereference<ClothVertexSerializable>(0x14, x10_Count); } }
	public int x18 { get { return Field<int>(0x18); } }
	public SerializeData x1C { get { return Field<SerializeData>(0x1C); } }
	public int x28_Count { get { return Field<int>(0x28); } }
	public ClothFaceSerializable[] x2C_PtrArray { get { return Dereference<ClothFaceSerializable>(0x2C, x28_Count); } }
	public int x30 { get { return Field<int>(0x30); } }
	public SerializeData x34 { get { return Field<SerializeData>(0x34); } }
	public int x40_Count { get { return Field<int>(0x40); } }
	public ClothStaple[] x44_PtrArray { get { return Dereference<ClothStaple>(0x44, x40_Count); } }
	public int x48 { get { return Field<int>(0x48); } }
	public SerializeData x4C { get { return Field<SerializeData>(0x4C); } }
	public int x58_Count { get { return Field<int>(0x58); } }
	public ClothConstraintSerializable[] x5C_PtrArray { get { return Dereference<ClothConstraintSerializable>(0x5C, x58_Count); } }
	public int x60 { get { return Field<int>(0x60); } }
	public SerializeData x64 { get { return Field<SerializeData>(0x64); } }
	public int x70_Count { get { return Field<int>(0x70); } }
	public ClothConstraintSerializable[] x74_PtrArray { get { return Dereference<ClothConstraintSerializable>(0x74, x70_Count); } }
	public int x78 { get { return Field<int>(0x78); } }
	public float x7C { get { return Field<float>(0x7C); } }
}
