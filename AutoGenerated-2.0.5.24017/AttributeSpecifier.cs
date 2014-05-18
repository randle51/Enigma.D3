public class AttributeSpecifier : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x18; // 24

	public AttributeSpecifier(ProcessMemory memory, int address)
		: base(memory, address) { }

	public DT_TRANSLATEABLE x00 { get { return Field<DT_TRANSLATEABLE>(0x00); } }
	public DT_ATTRIBUTEPARAM x04 { get { return Field<DT_ATTRIBUTEPARAM>(0x04); } }
	public DT_FORMULA x08 { get { return Field<DT_FORMULA>(0x08); } }
	public SerializeData x10 { get { return Field<SerializeData>(0x10); } }
}
