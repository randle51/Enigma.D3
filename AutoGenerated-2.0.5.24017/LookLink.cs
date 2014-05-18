public class LookLink : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x40; // 64

	public LookLink(ProcessMemory memory, int address)
		: base(memory, address) { }

	public string x00 { get { return Field(0x00, 64); } }
}
