public class ConversationListEntry : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x14C; // 332

	public ConversationListEntry(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x000_ConversationSnoId { get { return Field<int>(0x000); } }
	public int x004 { get { return Field<int>(0x004); } }
	public int x008 { get { return Field<int>(0x008); } }
	public int x00C { get { return Field<int>(0x00C); } }
	public DT_GBID x010_ItemsGameBalanceId { get { return Field<DT_GBID>(0x010); } }
	public string x014 { get { return Field(0x014, 128); } }
	public string x094 { get { return Field(0x094, 128); } }
	public int x114_QuestSnoId { get { return Field<int>(0x114); } }
	public int x118 { get { return Field<int>(0x118); } }
	public int x11C_QuestSnoId { get { return Field<int>(0x11C); } }
	public int x120_QuestSnoId { get { return Field<int>(0x120); } }
	public int x124_QuestSnoId { get { return Field<int>(0x124); } }
	public int x128_QuestRangeSnoId { get { return Field<int>(0x128); } }
	public int[] x12C_Array_LevelAreaSnoId { get { return Field<int>(0x12C, 6); } }
	public int x144 { get { return Field<int>(0x144); } }
	public int x148 { get { return Field<int>(0x148); } }
}
