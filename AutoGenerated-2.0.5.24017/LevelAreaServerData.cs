public class LevelAreaServerData : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x360; // 864

	public LevelAreaServerData(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x000_LevelAreaSnoId { get { return Field<int>(0x000); } }
	public GizmoLocSet x008 { get { return Field<GizmoLocSet>(0x008); } }
	public int x348_LevelAreaSnoId { get { return Field<int>(0x348); } }
	public int x34C { get { return Field<int>(0x34C); } }
	public int x350_Count { get { return Field<int>(0x350); } }
	public LevelAreaSpawnPopulation[] x354_PtrArray { get { return Dereference<LevelAreaSpawnPopulation>(0x354, x350_Count); } }
	public SerializeData x358 { get { return Field<SerializeData>(0x358); } }
}
