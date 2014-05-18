public class TileInfo : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x50; // 80

	public TileInfo(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x00 { get { return Field<int>(0x00); } }
	public int x04 { get { return Field<int>(0x04); } }
	public int x08_SceneSnoId { get { return Field<int>(0x08); } }
	public int x0C { get { return Field<int>(0x0C); } }
	public SerializeData x10 { get { return Field<SerializeData>(0x10); } }
	public DT_TAGMAP x18 { get { return Field<DT_TAGMAP>(0x18); } }
	public CustomTileInfo x20 { get { return Field<CustomTileInfo>(0x20); } }
	public int x48 { get { return Field<int>(0x48); } }
}
