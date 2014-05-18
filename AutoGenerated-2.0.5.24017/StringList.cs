public class StringList : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x28; // 40

	public StringList(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x10_Count { get { return Field<int>(0x10); } }
	public StringTableEntry[] x14_PtrArray { get { return Dereference<StringTableEntry>(0x14, x10_Count); } }
	public SerializeData x18 { get { return Field<SerializeData>(0x18); } }
}
