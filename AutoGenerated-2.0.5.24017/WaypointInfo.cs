public class WaypointInfo : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x28; // 40

	public WaypointInfo(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x00 { get { return Field<int>(0x00); } }
	public int x04_WorldsSnoId { get { return Field<int>(0x04); } }
	public int x08_LevelAreaSnoId { get { return Field<int>(0x08); } }
	public int x0C { get { return Field<int>(0x0C); } }
	public int x10 { get { return Field<int>(0x10); } }
	public int x14 { get { return Field<int>(0x14); } }
	public int x18_QuestRangeSnoId { get { return Field<int>(0x18); } }
	public int x1C { get { return Field<int>(0x1C); } }
	public IVector2D x20 { get { return Field<IVector2D>(0x20); } }
}
