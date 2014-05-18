public class LabelRule : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0xB0; // 176

	public LabelRule(ProcessMemory memory, int address)
		: base(memory, address) { }

	public string x00 { get { return Field(0x00, 128); } }
	public LabelCondition x80 { get { return Field<LabelCondition>(0x80); } }
	public int x98 { get { return Field<int>(0x98); } }
	public int x9C { get { return Field<int>(0x9C); } }
	public int xA0_Count { get { return Field<int>(0xA0); } }
	public LabelEntry[] xA4_PtrArray { get { return Dereference<LabelEntry>(0xA4, xA0_Count); } }
	public SerializeData xA8 { get { return Field<SerializeData>(0xA8); } }
}
