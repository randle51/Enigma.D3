public class FlagLookup : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x184; // 388

	public FlagLookup(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x000 { get { return Field<int>(0x000); } }
	public string x004 { get { return Field(0x004, 128); } }
	public string x084 { get { return Field(0x084, 256); } }
}
