public class Lore : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x24; // 36

	public Lore(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x0C { get { return Field<int>(0x0C); } }
	public int x10 { get { return Field<int>(0x10); } }
	public int x14 { get { return Field<int>(0x14); } }
	public int x18 { get { return Field<int>(0x18); } }
	public int x1C_ConversationSnoId { get { return Field<int>(0x1C); } }
	public int x20 { get { return Field<int>(0x20); } }
}
