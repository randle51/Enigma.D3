public class Condition : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x4A4; // 1188

	public Condition(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x00C { get { return Field<int>(0x00C); } }
	public int x010 { get { return Field<int>(0x010); } }
	public int[] x014_Array { get { return Field<int>(0x014, 6); } }
	public int[] x014_Array { get { return Field<int>(0x014, 6); } }
	public int x02C { get { return Field<int>(0x02C); } }
	public int x030 { get { return Field<int>(0x030); } }
	public int x034 { get { return Field<int>(0x034); } }
	public int x038 { get { return Field<int>(0x038); } }
	public LoreSubcondition[] x03C_Array { get { return Field<LoreSubcondition>(0x03C, 3); } }
	public QuestSubcondition[] x054_Array { get { return Field<QuestSubcondition>(0x054, 3); } }
	public ItemSubcondition[] x084_Array { get { return Field<ItemSubcondition>(0x084, 3); } }
	public int x0B4 { get { return Field<int>(0x0B4); } }
	public int x0B8 { get { return Field<int>(0x0B8); } }
	public int x0BC { get { return Field<int>(0x0BC); } }
	public int x0C0 { get { return Field<int>(0x0C0); } }
	public int x0C4 { get { return Field<int>(0x0C4); } }
	public int x0C8 { get { return Field<int>(0x0C8); } }
	public int x0D0 { get { return Field<int>(0x0D0); } }
	public int x0D4 { get { return Field<int>(0x0D4); } }
	public int x0D8 { get { return Field<int>(0x0D8); } }
	public int x0DC { get { return Field<int>(0x0DC); } }
	public int x0E0_WorldsSnoId { get { return Field<int>(0x0E0); } }
	public int x0E4_LevelAreaSnoId { get { return Field<int>(0x0E4); } }
	public int x0E8_QuestRangeSnoId { get { return Field<int>(0x0E8); } }
	public FollowerSubcondition x0EC { get { return Field<FollowerSubcondition>(0x0EC); } }
	public LabelSubcondition[] x0F4_Array { get { return Field<LabelSubcondition>(0x0F4, 3); } }
	public SkillSubcondition[] x10C_Array { get { return Field<SkillSubcondition>(0x10C, 3); } }
	public int x130 { get { return Field<int>(0x130); } }
	public int x134 { get { return Field<int>(0x134); } }
	public int x138 { get { return Field<int>(0x138); } }
	public int x13C { get { return Field<int>(0x13C); } }
	public int x140 { get { return Field<int>(0x140); } }
	public MonsterSubcondition[] x144_Array { get { return Field<MonsterSubcondition>(0x144, 15); } }
	public GameFlagSubcondition[] x180_Array { get { return Field<GameFlagSubcondition>(0x180, 3); } }
	public PlayerFlagSubcondition[] x300_Array { get { return Field<PlayerFlagSubcondition>(0x300, 3); } }
	public BuffSubcondition[] x480_Array { get { return Field<BuffSubcondition>(0x480, 3); } }
}
