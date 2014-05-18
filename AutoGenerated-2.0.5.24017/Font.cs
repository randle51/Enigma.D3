public class Font : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0xC8; // 200

	public Font(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x0C { get { return Field<int>(0x0C); } }
	public string x10 { get { return Field(0x10, 64); } }
	public string x50 { get { return Field(0x50, 64); } }
	public int x90 { get { return Field<int>(0x90); } }
	public int x94_Enum { get { return Field<int>(0x94); } } // 1: Disabled, 0: Native, 2: Auto
	public int x98_Enum { get { return Field<int>(0x98); } } // 0: Normal, 1: Light, 2: LCD, 3: LCD Vertical
	public int x9C { get { return Field<int>(0x9C); } }
	public float xA0 { get { return Field<float>(0xA0); } }
	public float xA4 { get { return Field<float>(0xA4); } }
	public SerializeData xA8 { get { return Field<SerializeData>(0xA8); } }
	public int xB0_Count { get { return Field<int>(0xB0); } }
	public byte[] xB4_PtrArray { get { return Dereference<byte>(0xB4, xB0_Count); } }
	public int xB8 { get { return Field<int>(0xB8); } }
	public int xBC { get { return Field<int>(0xBC); } }
	public long xC0 { get { return Field<long>(0xC0); } }
}
