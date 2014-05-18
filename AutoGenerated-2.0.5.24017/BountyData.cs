public class BountyData : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x4C; // 76

	public BountyData(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x00_Enum { get { return Field<int>(0x00); } } // -1: Invalid, 0: A1, 100: A2, 200: A3, 300: A4, 400: A5, 3000: OpenWorld, 1000: Test
	public int x04_Enum { get { return Field<int>(0x04); } } // -1: - None -, 0: Kill Unique, 1: Kill Boss, 2: Complete Event, 3: Clear Dungeon
	public int x08_LevelAreaSnoId { get { return Field<int>(0x08); } }
	public int x0C_WorldsSnoId { get { return Field<int>(0x0C); } }
	public int x10_QuestSnoId { get { return Field<int>(0x10); } }
	public int x14_WorldsSnoId { get { return Field<int>(0x14); } }
	public int x18_ActorSnoId { get { return Field<int>(0x18); } }
	public int x1C_WorldsSnoId { get { return Field<int>(0x1C); } }
	public int x20_LevelAreaSnoId { get { return Field<int>(0x20); } }
	public int x24_SceneSnoId { get { return Field<int>(0x24); } }
	public int x28_WorldsSnoId { get { return Field<int>(0x28); } }
	public DT_GBID x2C_LabelsGameBalanceId { get { return Field<DT_GBID>(0x2C); } }
	public int x30_AdventureSnoId { get { return Field<int>(0x30); } }
	public int x34_WorldsSnoId { get { return Field<int>(0x34); } }
	public int x38_LevelAreaSnoId { get { return Field<int>(0x38); } }
	public int x3C_EncounterSnoId { get { return Field<int>(0x3C); } }
	public int x40_SceneSnoId { get { return Field<int>(0x40); } }
	public int x44_WorldsSnoId { get { return Field<int>(0x44); } }
	public DT_GBID x48_LabelsGameBalanceId { get { return Field<DT_GBID>(0x48); } }
}
