public class ResolvedPortalDestination : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x0C; // 12

	public ResolvedPortalDestination(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x00_WorldsSnoId { get { return Field<int>(0x00); } }
	public int x04 { get { return Field<int>(0x04); } }
	public int x08_LevelAreaSnoId { get { return Field<int>(0x08); } }
}
