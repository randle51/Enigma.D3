public class dmSubEdge : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x04; // 4

	public dmSubEdge(ProcessMemory memory, int address)
		: base(memory, address) { }

	public byte x00 { get { return Field<byte>(0x00); } }
	public byte x01 { get { return Field<byte>(0x01); } }
	public byte x02 { get { return Field<byte>(0x02); } }
	public byte x03 { get { return Field<byte>(0x03); } }
}
