public class Quest : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x110; // 272

	public Quest(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x00C_Enum { get { return Field<int>(0x00C); } } // 0: Main Quest, 2: Event, 4: Challenge, 5: Bounty
	public int x010 { get { return Field<int>(0x010); } }
	public int x014 { get { return Field<int>(0x014); } }
	public int x018 { get { return Field<int>(0x018); } }
	public int x01C { get { return Field<int>(0x01C); } }
	public int x020 { get { return Field<int>(0x020); } }
	public int x024 { get { return Field<int>(0x024); } }
	public QuestUnassignedStep x028 { get { return Field<QuestUnassignedStep>(0x028); } }
	public int x050_Count { get { return Field<int>(0x050); } }
	public QuestStep[] x054_PtrArray { get { return Dereference<QuestStep>(0x054, x050_Count); } }
	public SerializeData x058 { get { return Field<SerializeData>(0x058); } }
	public int x060_Count { get { return Field<int>(0x060); } }
	public QuestCompletionStep[] x064_PtrArray { get { return Dereference<QuestCompletionStep>(0x064, x060_Count); } }
	public SerializeData x068 { get { return Field<SerializeData>(0x068); } }
	public int[] x070_Array_LevelAreaSnoId { get { return Field<int>(0x070, 18); } }
	public int x0B8_WorldsSnoId { get { return Field<int>(0x0B8); } }
	public int x0BC_Enum { get { return Field<int>(0x0BC); } } // -1: - None -, 0: Timed Dungeon, 1: Wave Fight, 2: Horde, 3: Zapper, 4: Goblin Hunt
	public BountyData x0C0 { get { return Field<BountyData>(0x0C0); } }
}
