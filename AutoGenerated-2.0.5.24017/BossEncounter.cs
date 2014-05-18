public class BossEncounter : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x68; // 104

	public BossEncounter(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x0C { get { return Field<int>(0x0C); } }
	public int x10 { get { return Field<int>(0x10); } }
	public int x14 { get { return Field<int>(0x14); } }
	public int x18 { get { return Field<int>(0x18); } }
	public int x1C { get { return Field<int>(0x1C); } }
	public int x20 { get { return Field<int>(0x20); } }
	public int x24 { get { return Field<int>(0x24); } }
	public int x28 { get { return Field<int>(0x28); } }
	public int x2C { get { return Field<int>(0x2C); } }
	public int x30 { get { return Field<int>(0x30); } }
	public int x34 { get { return Field<int>(0x34); } }
	public int x38 { get { return Field<int>(0x38); } }
	public float x3C { get { return Field<float>(0x3C); } }
	public int x40_QuestRangeSnoId { get { return Field<int>(0x40); } }
	public int[] x44_Array_WorldsSnoId { get { return Field<int>(0x44, 4); } }
	public int[] x54_Array_35SnoId { get { return Field<int>(0x54, 3); } }
	public int x60_LevelAreaSnoId { get { return Field<int>(0x60); } }
	public int x64_ActorSnoId { get { return Field<int>(0x64); } }
}
