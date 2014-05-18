public class MarkerLink : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x100; // 256

	public MarkerLink(ProcessMemory memory, int address)
		: base(memory, address) { }

	public string x000 { get { return Field(0x000, 128); } }
	public string x080 { get { return Field(0x080, 128); } }
}
