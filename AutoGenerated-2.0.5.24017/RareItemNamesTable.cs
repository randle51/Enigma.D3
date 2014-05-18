public class RareItemNamesTable : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x10; // 16

	public RareItemNamesTable(ProcessMemory memory, int address)
		: base(memory, address) { }

	public SerializeData x00 { get { return Field<SerializeData>(0x00); } }
	public int x08_Count { get { return Field<int>(0x08); } }
	public RareItemNamesEntry[] x0C_PtrArray { get { return Dereference<RareItemNamesEntry>(0x0C, x08_Count); } }
}
