public class Marker : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0xD0; // 208

	public Marker(ProcessMemory memory, int address)
		: base(memory, address) { }

	public string x00 { get { return Field(0x00, 128); } }
	public int x80 { get { return Field<int>(0x80); } }
	public PRTransform x84 { get { return Field<PRTransform>(0x84); } }
	public SNOName xA0 { get { return Field<SNOName>(0xA0); } }
	public SerializeData xA8 { get { return Field<SerializeData>(0xA8); } }
	public DT_TAGMAP xB0 { get { return Field<DT_TAGMAP>(0xB0); } }
	public int xB8 { get { return Field<int>(0xB8); } }
	public SerializeData xBC { get { return Field<SerializeData>(0xBC); } }
	public int xC8_Count { get { return Field<int>(0xC8); } }
	public MarkerLink[] xCC_PtrArray { get { return Dereference<MarkerLink>(0xCC, xC8_Count); } }
}
