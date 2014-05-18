public class HelpCodes : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x280; // 640

	public HelpCodes(ProcessMemory memory, int address)
		: base(memory, address) { }

	public string x000 { get { return Field(0x000, 256); } }
	public string x100 { get { return Field(0x100, 256); } }
	public string x200 { get { return Field(0x200, 128); } }
}
