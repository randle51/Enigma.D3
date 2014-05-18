public class StringTableEntry : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x28; // 40

	public StringTableEntry(ProcessMemory memory, int address)
		: base(memory, address) { }

	public DT_CSTRING x00 { get { return Field<DT_CSTRING>(0x00); } }
	public SerializeData x08 { get { return Field<SerializeData>(0x08); } }
	public DT_CSTRING x10 { get { return Field<DT_CSTRING>(0x10); } }
	public SerializeData x18 { get { return Field<SerializeData>(0x18); } }
	public int x20 { get { return Field<int>(0x20); } }
	public int x24 { get { return Field<int>(0x24); } }
}
