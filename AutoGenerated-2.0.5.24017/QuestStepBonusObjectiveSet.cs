public class QuestStepBonusObjectiveSet : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x28; // 40

	public QuestStepBonusObjectiveSet(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x00 { get { return Field<int>(0x00); } }
	public int x04 { get { return Field<int>(0x04); } }
	public int x08 { get { return Field<int>(0x08); } }
	public int x0C { get { return Field<int>(0x0C); } }
	public int x10 { get { return Field<int>(0x10); } }
	public int x18_Count { get { return Field<int>(0x18); } }
	public QuestStepObjective[] x1C_PtrArray { get { return Dereference<QuestStepObjective>(0x1C, x18_Count); } }
	public SerializeData x20 { get { return Field<SerializeData>(0x20); } }
}
