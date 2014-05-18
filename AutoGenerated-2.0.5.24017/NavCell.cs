public class NavCell : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x20; // 32

	public NavCell(ProcessMemory memory, int address)
		: base(memory, address) { }

	public Vector3D x00 { get { return Field<Vector3D>(0x00); } }
	public Vector3D x0C { get { return Field<Vector3D>(0x0C); } }
	public short x18 { get { return Field<short>(0x18); } }
	public short x1A { get { return Field<short>(0x1A); } }
	public int x1C { get { return Field<int>(0x1C); } }
}
