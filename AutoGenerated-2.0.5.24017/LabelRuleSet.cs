public class LabelRuleSet : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x18; // 24

	public LabelRuleSet(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x00 { get { return Field<int>(0x00); } }
	public int x08_Count { get { return Field<int>(0x08); } }
	public LabelRule[] x0C_PtrArray { get { return Dereference<LabelRule>(0x0C, x08_Count); } }
	public SerializeData x10 { get { return Field<SerializeData>(0x10); } }
}
