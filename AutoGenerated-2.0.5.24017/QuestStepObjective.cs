public class QuestStepObjective : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x234; // 564

	public QuestStepObjective(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x000 { get { return Field<int>(0x000); } }
	public int x004_Enum { get { return Field<int>(0x004); } } // 0: Had Conversation, 1: Possess Item, 2: Kill Monster, 3: Interact With Actor, 4: Enter Level Area, 5: Enter Scene, 6: Enter World, 7: Enter Trigger, 8: Complete Quest, 9: Player Flag Set, 10: Timed Event Expired, 11: Kill Group, 12: Game Flag Set, 13: Event Received, 14: Kill Monster From Group, 15: Kill Monster From Family, 16: Kill Elite Pack In Level Area, 17: Kill Any Monster In Level Area, 18: Kill All Monsters In World
	public int x008 { get { return Field<int>(0x008); } }
	public int x00C { get { return Field<int>(0x00C); } }
	public SNOName x010 { get { return Field<SNOName>(0x010); } }
	public SNOName x018 { get { return Field<SNOName>(0x018); } }
	public DT_GBID x020_AxeBadDataGameBalanceId { get { return Field<DT_GBID>(0x020); } }
	public DT_GBID x024_AxeBadDataGameBalanceId { get { return Field<DT_GBID>(0x024); } }
	public string x028 { get { return Field(0x028, 256); } }
	public string x128 { get { return Field(0x128, 256); } }
	public int x228 { get { return Field<int>(0x228); } }
	public int x22C { get { return Field<int>(0x22C); } }
	public DT_GBID x230_ItemsGameBalanceId { get { return Field<DT_GBID>(0x230); } }
}
