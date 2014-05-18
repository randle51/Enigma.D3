public class CustomTileCell : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x24; // 36

	public CustomTileCell(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x00 { get { return Field<int>(0x00); } }
	public int x04 { get { return Field<int>(0x04); } }
	public int x08 { get { return Field<int>(0x08); } }
	public int x0C_SceneSnoId { get { return Field<int>(0x0C); } }
	public int x10 { get { return Field<int>(0x10); } }
	public int[] x14_Array { get { return Field<int>(0x14, 4); } }
}
