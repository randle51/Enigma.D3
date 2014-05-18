public class Quaternion16 : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x08; // 8

	public Quaternion16(ProcessMemory memory, int address)
		: base(memory, address) { }

	public short x00 { get { return Field<short>(0x00); } }
	public short x02 { get { return Field<short>(0x02); } }
	public short x04 { get { return Field<short>(0x04); } }
	public short x06 { get { return Field<short>(0x06); } }
}
