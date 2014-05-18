public class ActStartLocOverride : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x18; // 24

	public ActStartLocOverride(ProcessMemory memory, int address)
		: base(memory, address) { }

	public ResolvedPortalDestination x00 { get { return Field<ResolvedPortalDestination>(0x00); } }
	public int x0C_QuestRangeSnoId { get { return Field<int>(0x0C); } }
	public int x10_WorldsSnoId { get { return Field<int>(0x10); } }
	public int x14 { get { return Field<int>(0x14); } }
}
