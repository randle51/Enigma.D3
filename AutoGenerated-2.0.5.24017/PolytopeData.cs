public class PolytopeData : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x60; // 96

	public PolytopeData(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x00_Count { get { return Field<int>(0x00); } }
	public dmFloat3[] x04_PtrArray { get { return Dereference<dmFloat3>(0x04, x00_Count); } }
	public int x08_Count { get { return Field<int>(0x08); } }
	public dmPlane[] x0C_PtrArray { get { return Dereference<dmPlane>(0x0C, x08_Count); } }
	public int x10_Count { get { return Field<int>(0x10); } }
	public dmSubEdge[] x14_PtrArray { get { return Dereference<dmSubEdge>(0x14, x10_Count); } }
	public int x18_Count { get { return Field<int>(0x18); } }
	public byte[] x1C_PtrArray { get { return Dereference<byte>(0x1C, x18_Count); } }
	public dmFloat3 x20 { get { return Field<dmFloat3>(0x20); } }
	public int x2C { get { return Field<int>(0x2C); } }
	public int x30 { get { return Field<int>(0x30); } }
	public int x34 { get { return Field<int>(0x34); } }
	public float x38 { get { return Field<float>(0x38); } }
	public float x3C { get { return Field<float>(0x3C); } }
	public SerializeData x40 { get { return Field<SerializeData>(0x40); } }
	public SerializeData x48 { get { return Field<SerializeData>(0x48); } }
	public SerializeData x50 { get { return Field<SerializeData>(0x50); } }
	public SerializeData x58 { get { return Field<SerializeData>(0x58); } }
}
