public class Act : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x1060; // 4192

	public Act(ProcessMemory memory, int address)
		: base(memory, address) { }

	public SerializeData x000C { get { return Field<SerializeData>(0x000C); } }
	public int x0018_Count { get { return Field<int>(0x0018); } }
	public ActQuestInfo[] x001C_PtrArray { get { return Dereference<ActQuestInfo>(0x001C, x0018_Count); } }
	public WaypointInfo[] x0020_Array { get { return Field<WaypointInfo>(0x0020, 100); } }
	public ResolvedPortalDestination x0FC0 { get { return Field<ResolvedPortalDestination>(0x0FC0); } }
	public ActStartLocOverride[] x0FCC_Array { get { return Field<ActStartLocOverride>(0x0FCC, 6); } }
}
