public class StartLocationName : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x44; // 68

	public StartLocationName(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x00 { get { return Field<int>(0x00); } }
	public string x04 { get { return Field(0x04, 64); } }
}
