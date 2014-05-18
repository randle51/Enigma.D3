public class FatVertex : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x2C; // 44

	public FatVertex(ProcessMemory memory, int address)
		: base(memory, address) { }

	public Vector3D x00 { get { return Field<Vector3D>(0x00); } }
	public RGBAColor x0C { get { return Field<RGBAColor>(0x0C); } }
	public RGBAColor[] x10_Array { get { return Field<RGBAColor>(0x10, 2); } }
	public RGBAColor[] x18_Array { get { return Field<RGBAColor>(0x18, 2); } }
	public RGBAColor x20 { get { return Field<RGBAColor>(0x20); } }
	public RGBAColor x24 { get { return Field<RGBAColor>(0x24); } }
	public short x28 { get { return Field<short>(0x28); } }
	public short x2A { get { return Field<short>(0x2A); } }
}
