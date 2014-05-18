public class UIDataElementInt32 : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x10; // 16

	public UIDataElementInt32(ProcessMemory memory, int address)
		: base(memory, address) { }

	public long x00 { get { return Field<long>(0x00); } }
	public int x08 { get { return Field<int>(0x08); } }
}
