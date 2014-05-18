public class QuestSubcondition : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x10; // 16

	public QuestSubcondition(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x00_QuestSnoId { get { return Field<int>(0x00); } }
	public int x04 { get { return Field<int>(0x04); } }
	public int x08 { get { return Field<int>(0x08); } }
	public int x0C { get { return Field<int>(0x0C); } }
}
