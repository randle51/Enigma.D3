public class NavZoneDefinition : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x88; // 136

	public NavZoneDefinition(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x00 { get { return Field<int>(0x00); } }
	public int x08_Count { get { return Field<int>(0x08); } }
	public NavCell[] x0C_PtrArray { get { return Dereference<NavCell>(0x0C, x08_Count); } }
	public SerializeData x10 { get { return Field<SerializeData>(0x10); } }
	public int x18 { get { return Field<int>(0x18); } }
	public int x20_Count { get { return Field<int>(0x20); } }
	public NavCellLookup[] x24_PtrArray { get { return Dereference<NavCellLookup>(0x24, x20_Count); } }
	public SerializeData x28 { get { return Field<SerializeData>(0x28); } }
	public float x30 { get { return Field<float>(0x30); } }
	public float x34 { get { return Field<float>(0x34); } }
	public int x38 { get { return Field<int>(0x38); } }
	public IVector2D x3C { get { return Field<IVector2D>(0x3C); } }
	public int x48_Count { get { return Field<int>(0x48); } }
	public NavGridSquare[] x4C_PtrArray { get { return Dereference<NavGridSquare>(0x4C, x48_Count); } }
	public SerializeData x50 { get { return Field<SerializeData>(0x50); } }
	public int x58 { get { return Field<int>(0x58); } }
	public int x60_Count { get { return Field<int>(0x60); } }
	public NavCellLookup[] x64_PtrArray { get { return Dereference<NavCellLookup>(0x64, x60_Count); } }
	public SerializeData x68 { get { return Field<SerializeData>(0x68); } }
	public int x70 { get { return Field<int>(0x70); } }
	public int x78_Count { get { return Field<int>(0x78); } }
	public NavCellBorderData[] x7C_PtrArray { get { return Dereference<NavCellBorderData>(0x7C, x78_Count); } }
	public SerializeData x80 { get { return Field<SerializeData>(0x80); } }
}
