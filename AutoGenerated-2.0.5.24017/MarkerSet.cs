public class MarkerSet : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0xC8; // 200

	public MarkerSet(ProcessMemory memory, int address)
		: base(memory, address) { }

	public SerializeData x0C { get { return Field<SerializeData>(0x0C); } }
	public int x18_Count { get { return Field<int>(0x18); } }
	public Marker[] x1C_PtrArray { get { return Dereference<Marker>(0x1C, x18_Count); } }
	public SerializeData x50 { get { return Field<SerializeData>(0x50); } }
	public int x58_Count { get { return Field<int>(0x58); } }
	public Circle[] x5C_PtrArray { get { return Dereference<Circle>(0x5C, x58_Count); } }
	public AABB x90 { get { return Field<AABB>(0x90); } }
	public int xA8 { get { return Field<int>(0xA8); } }
	public DT_GBID xAC_LabelsGameBalanceId { get { return Field<DT_GBID>(0xAC); } }
	public int xB0 { get { return Field<int>(0xB0); } }
	public SerializeData xB4 { get { return Field<SerializeData>(0xB4); } }
	public int xC0_Count { get { return Field<int>(0xC0); } }
	public short[] xC4_PtrArray { get { return Dereference<short>(0xC4, xC0_Count); } }
}
