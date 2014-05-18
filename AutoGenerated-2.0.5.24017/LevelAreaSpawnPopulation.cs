public class LevelAreaSpawnPopulation : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x98; // 152

	public LevelAreaSpawnPopulation(ProcessMemory memory, int address)
		: base(memory, address) { }

	public string x00 { get { return Field(0x00, 64); } }
	public int x40 { get { return Field<int>(0x40); } }
	public float x44 { get { return Field<float>(0x44); } }
	public float x48 { get { return Field<float>(0x48); } }
	public int[] x4C_Array { get { return Field<int>(0x4C, 4); } }
	public int[] x5C_Array { get { return Field<int>(0x5C, 4); } }
	public int x6C { get { return Field<int>(0x6C); } }
	public int x70_Count { get { return Field<int>(0x70); } }
	public LevelAreaSpawnGroup[] x74_PtrArray { get { return Dereference<LevelAreaSpawnGroup>(0x74, x70_Count); } }
	public SerializeData x78 { get { return Field<SerializeData>(0x78); } }
	public int x80_Count { get { return Field<int>(0x80); } }
	public int[] x84_PtrArray_WeatherSnoId { get { return Dereference<int>(0x84, x80_Count); } }
	public SerializeData x88 { get { return Field<SerializeData>(0x88); } }
	public int x90_EncounterSnoId { get { return Field<int>(0x90); } }
}
