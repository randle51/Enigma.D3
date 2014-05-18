public class QuestRange : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x10; // 16

	public QuestRange(ProcessMemory memory, int address)
		: base(memory, address) { }

	public QuestTime x00 { get { return Field<QuestTime>(0x00); } }
	public QuestTime x08 { get { return Field<QuestTime>(0x08); } }
}
