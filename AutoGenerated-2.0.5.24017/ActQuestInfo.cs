public class ActQuestInfo : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x04; // 4

	public ActQuestInfo(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x00_QuestSnoId { get { return Field<int>(0x00); } }
}
