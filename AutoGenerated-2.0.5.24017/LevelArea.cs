public class LevelArea : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x28; // 40

	public LevelArea(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x0C { get { return Field<int>(0x0C); } }
	public int x10_LevelAreaSnoId { get { return Field<int>(0x10); } }
	public int x14_LevelAreaSnoId { get { return Field<int>(0x14); } }
	public int x18_Count { get { return Field<int>(0x18); } }
	public LevelAreaServerData[] x1C_PtrArray { get { return Dereference<LevelAreaServerData>(0x1C, x18_Count); } }
	public SerializeData x20 { get { return Field<SerializeData>(0x20); } }
}
