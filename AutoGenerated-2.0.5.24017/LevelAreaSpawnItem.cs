public class LevelAreaSpawnItem : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x20; // 32

	public LevelAreaSpawnItem(ProcessMemory memory, int address)
		: base(memory, address) { }

	public SNOName x00 { get { return Field<SNOName>(0x00); } }
	public int x08_Enum { get { return Field<int>(0x08); } } // 0: , 1: Champion, 2: Rare, 3: Minion, 4: Unique, 5: Hireling, 7: Boss
	public int x0C { get { return Field<int>(0x0C); } }
	public int x10 { get { return Field<int>(0x10); } }
	public int x14 { get { return Field<int>(0x14); } }
	public int x18 { get { return Field<int>(0x18); } }
	public float x1C { get { return Field<float>(0x1C); } }
}
