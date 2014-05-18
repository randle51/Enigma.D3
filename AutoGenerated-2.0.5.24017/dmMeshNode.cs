public class dmMeshNode : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x10; // 16

	public dmMeshNode(ProcessMemory memory, int address)
		: base(memory, address) { }

	public short x00 { get { return Field<short>(0x00); } }
	public short x02 { get { return Field<short>(0x02); } }
	public short x04 { get { return Field<short>(0x04); } }
	public short x06 { get { return Field<short>(0x06); } }
	public short x08 { get { return Field<short>(0x08); } }
	public short x0A { get { return Field<short>(0x0A); } }
	public int x0C { get { return Field<int>(0x0C); } }
}
