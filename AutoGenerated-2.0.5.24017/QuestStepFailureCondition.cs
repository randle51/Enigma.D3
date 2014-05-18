public class QuestStepFailureCondition : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x224; // 548

	public QuestStepFailureCondition(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x000_Enum { get { return Field<int>(0x000); } } // 0: Monster Died, 1: Player Died, 2: Actor Died, 3: Timed Event Expired, 4: Item Used, 5: Game Flag Set, 6: Player Flag Set, 7: Event Received
	public int x004 { get { return Field<int>(0x004); } }
	public int x008 { get { return Field<int>(0x008); } }
	public SNOName x00C { get { return Field<SNOName>(0x00C); } }
	public SNOName x014 { get { return Field<SNOName>(0x014); } }
	public DT_GBID x01C_AxeBadDataGameBalanceId { get { return Field<DT_GBID>(0x01C); } }
	public DT_GBID x020_AxeBadDataGameBalanceId { get { return Field<DT_GBID>(0x020); } }
	public string x024 { get { return Field(0x024, 256); } }
	public string x124 { get { return Field(0x124, 256); } }
}
