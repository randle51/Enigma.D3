public class CustomTileInfo : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x28; // 40

	public CustomTileInfo(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x00 { get { return Field<int>(0x00); } }
	public int x04 { get { return Field<int>(0x04); } }
	public int x08 { get { return Field<int>(0x08); } }
	public IVector2D x0C { get { return Field<IVector2D>(0x0C); } }
	public SerializeData x14 { get { return Field<SerializeData>(0x14); } }
	public int x20_Count { get { return Field<int>(0x20); } }
	public CustomTileCell[] x24_PtrArray { get { return Dereference<CustomTileCell>(0x24, x20_Count); } }
}
