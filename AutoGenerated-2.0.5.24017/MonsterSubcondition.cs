public class MonsterSubcondition : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x04; // 4

	public MonsterSubcondition(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x00_ActorSnoId { get { return Field<int>(0x00); } }
}
