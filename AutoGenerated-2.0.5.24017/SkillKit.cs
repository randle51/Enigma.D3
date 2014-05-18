public class SkillKit : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x40; // 64

	public SkillKit(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x10_Count { get { return Field<int>(0x10); } }
	public TraitEntry[] x14_PtrArray { get { return Dereference<TraitEntry>(0x14, x10_Count); } }
	public SerializeData x18 { get { return Field<SerializeData>(0x18); } }
	public int x20_Count { get { return Field<int>(0x20); } }
	public ActiveSkillEntry[] x24_PtrArray { get { return Dereference<ActiveSkillEntry>(0x24, x20_Count); } }
	public SerializeData x28 { get { return Field<SerializeData>(0x28); } }
	public int x30_Count { get { return Field<int>(0x30); } }
	public int[] x34_PtrArray { get { return Dereference<int>(0x34, x30_Count); } }
	public SerializeData x38 { get { return Field<SerializeData>(0x38); } }
}
