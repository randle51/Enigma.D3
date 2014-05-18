public class UIControlElement : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x108; // 264

	public UIControlElement(ProcessMemory memory, int address)
		: base(memory, address) { }

	public long x000 { get { return Field<long>(0x000); } }
	public string x008 { get { return Field(0x008, 256); } }
}
