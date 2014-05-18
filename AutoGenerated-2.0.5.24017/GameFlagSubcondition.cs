public class GameFlagSubcondition : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x80; // 128

	public GameFlagSubcondition(ProcessMemory memory, int address)
		: base(memory, address) { }

	public string x00 { get { return Field(0x00, 128); } }
}
