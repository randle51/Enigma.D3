public class LevelAreaSpawnGroup : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x38; // 56

	public LevelAreaSpawnGroup(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x00_Enum { get { return Field<int>(0x00); } } // 0: Count per 100 sq ft, 1: Exactly
	public float x04 { get { return Field<float>(0x04); } }
	public float x08 { get { return Field<float>(0x08); } }
	public int x0C { get { return Field<int>(0x0C); } }
	public int x10 { get { return Field<int>(0x10); } }
	public int x18_Count { get { return Field<int>(0x18); } }
	public LevelAreaSpawnItem[] x1C_PtrArray { get { return Dereference<LevelAreaSpawnItem>(0x1C, x18_Count); } }
	public SerializeData x20 { get { return Field<SerializeData>(0x20); } }
	public int x28 { get { return Field<int>(0x28); } }
	public int x2C { get { return Field<int>(0x2C); } }
	public int x30_ConditionSnoId { get { return Field<int>(0x30); } }
}
