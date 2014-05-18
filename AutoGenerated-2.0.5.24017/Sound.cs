public class Sound : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0xA8; // 168

	public Sound(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x0C { get { return Field<int>(0x0C); } }
	public int x10 { get { return Field<int>(0x10); } }
	public float x14 { get { return Field<float>(0x14); } }
	public float x18 { get { return Field<float>(0x18); } }
	public float x1C { get { return Field<float>(0x1C); } }
	public int x20 { get { return Field<int>(0x20); } }
	public float x24 { get { return Field<float>(0x24); } }
	public float x28 { get { return Field<float>(0x28); } }
	public float x2C { get { return Field<float>(0x2C); } }
	public float x30 { get { return Field<float>(0x30); } }
	public DT_IMPULSE x34 { get { return Field<DT_IMPULSE>(0x34); } }
	public DT_IMPULSE x38 { get { return Field<DT_IMPULSE>(0x38); } }
	public float x3C { get { return Field<float>(0x3C); } }
	public float x40 { get { return Field<float>(0x40); } }
	public SerializeData x44 { get { return Field<SerializeData>(0x44); } }
	public int x4C { get { return Field<int>(0x4C); } }
	public int x50_Count { get { return Field<int>(0x50); } }
	public SoundPermutation[] x54_PtrArray { get { return Dereference<SoundPermutation>(0x54, x50_Count); } }
	public int x58 { get { return Field<int>(0x58); } }
	public int x5C { get { return Field<int>(0x5C); } }
	public int x60 { get { return Field<int>(0x60); } }
	public int x68_Count { get { return Field<int>(0x68); } }
	public DspEffect[] x6C_PtrArray { get { return Dereference<DspEffect>(0x6C, x68_Count); } }
	public SerializeData x70 { get { return Field<SerializeData>(0x70); } }
	public int x78_Count { get { return Field<int>(0x78); } }
	public RTPCParams[] x7C_PtrArray { get { return Dereference<RTPCParams>(0x7C, x78_Count); } }
	public SerializeData x80 { get { return Field<SerializeData>(0x80); } }
	public DT_TIME x88 { get { return Field<DT_TIME>(0x88); } }
	public DT_TIME x8C { get { return Field<DT_TIME>(0x8C); } }
}
