public class NavCellLookup : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x04; // 4

	public NavCellLookup(ProcessMemory memory, int address)
		: base(memory, address) { }

	public short x00 { get { return Field<short>(0x00); } }
	public short x02 { get { return Field<short>(0x02); } }
}
