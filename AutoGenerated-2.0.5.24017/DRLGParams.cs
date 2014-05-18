public class DRLGParams : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x78; // 120

	public DRLGParams(ProcessMemory memory, int address)
		: base(memory, address) { }

	public SerializeData x00 { get { return Field<SerializeData>(0x00); } }
	public int x08_Count { get { return Field<int>(0x08); } }
	public TileInfo[] x0C_PtrArray { get { return Dereference<TileInfo>(0x0C, x08_Count); } }
	public int x40 { get { return Field<int>(0x40); } }
	public SerializeData x44 { get { return Field<SerializeData>(0x44); } }
	public int x50_Count { get { return Field<int>(0x50); } }
	public DRLGCommand[] x54_PtrArray { get { return Dereference<DRLGCommand>(0x54, x50_Count); } }
	public SerializeData x58 { get { return Field<SerializeData>(0x58); } }
	public int x60_Count { get { return Field<int>(0x60); } }
	public int[] x64_PtrArray { get { return Dereference<int>(0x64, x60_Count); } }
	public SerializeData x68 { get { return Field<SerializeData>(0x68); } }
	public DT_TAGMAP x70 { get { return Field<DT_TAGMAP>(0x70); } }
}
