public class QuestRange : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x20; // 32

	public QuestRange(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x0C { get { return Field<int>(0x0C); } }
	public int x10_Count { get { return Field<int>(0x10); } }
	public QuestRange[] x14_PtrArray { get { return Dereference<QuestRange>(0x14, x10_Count); } }
	public SerializeData x18 { get { return Field<SerializeData>(0x18); } }
}
