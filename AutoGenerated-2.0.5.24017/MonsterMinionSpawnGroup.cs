public class MonsterMinionSpawnGroup : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x18; // 24

	public MonsterMinionSpawnGroup(ProcessMemory memory, int address)
		: base(memory, address) { }

	public float x00 { get { return Field<float>(0x00); } }
	public int x04 { get { return Field<int>(0x04); } }
	public int x08_Count { get { return Field<int>(0x08); } }
	public MonsterMinionSpawnItem[] x0C_PtrArray { get { return Dereference<MonsterMinionSpawnItem>(0x0C, x08_Count); } }
	public SerializeData x10 { get { return Field<SerializeData>(0x10); } }
}
