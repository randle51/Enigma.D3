public class MonsterLevelDefinition : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x24C; // 588

	public MonsterLevelDefinition(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x000 { get { return Field<int>(0x000); } }
	public float x014 { get { return Field<float>(0x014); } }
	public float x020 { get { return Field<float>(0x020); } }
	public float x024 { get { return Field<float>(0x024); } }
	public float x028 { get { return Field<float>(0x028); } }
	public float x030 { get { return Field<float>(0x030); } }
	public float x05C { get { return Field<float>(0x05C); } }
	public float x060 { get { return Field<float>(0x060); } }
	public float x064 { get { return Field<float>(0x064); } }
	public float x068 { get { return Field<float>(0x068); } }
	public float x06C { get { return Field<float>(0x06C); } }
	public float x070 { get { return Field<float>(0x070); } }
	public float x074 { get { return Field<float>(0x074); } }
	public float x078 { get { return Field<float>(0x078); } }
	public float x07C { get { return Field<float>(0x07C); } }
	public float x080 { get { return Field<float>(0x080); } }
	public float x084 { get { return Field<float>(0x084); } }
	public float x088 { get { return Field<float>(0x088); } }
	public float x08C { get { return Field<float>(0x08C); } }
	public float x090 { get { return Field<float>(0x090); } }
	public float x094 { get { return Field<float>(0x094); } }
	public float x098 { get { return Field<float>(0x098); } }
	public float x09C { get { return Field<float>(0x09C); } }
	public float x0A0 { get { return Field<float>(0x0A0); } }
	public float x0B0 { get { return Field<float>(0x0B0); } }
	public float x0B4 { get { return Field<float>(0x0B4); } }
	public float x0B8 { get { return Field<float>(0x0B8); } }
	public float x0DC { get { return Field<float>(0x0DC); } }
	public float x0E0 { get { return Field<float>(0x0E0); } }
	public float x0E8 { get { return Field<float>(0x0E8); } }
	public float x0EC { get { return Field<float>(0x0EC); } }
	public float x10C { get { return Field<float>(0x10C); } }
	public float x110 { get { return Field<float>(0x110); } }
	public float x114 { get { return Field<float>(0x114); } }
	public float x118 { get { return Field<float>(0x118); } }
	public float x11C { get { return Field<float>(0x11C); } }
	public float x120 { get { return Field<float>(0x120); } }
	public float x124 { get { return Field<float>(0x124); } }
	public float x128 { get { return Field<float>(0x128); } }
	public float x12C { get { return Field<float>(0x12C); } }
	public float x1B8 { get { return Field<float>(0x1B8); } }
	public float x1BC { get { return Field<float>(0x1BC); } }
	public float x1CC { get { return Field<float>(0x1CC); } }
	public float x1D0 { get { return Field<float>(0x1D0); } }
	public float x1D4 { get { return Field<float>(0x1D4); } }
	public float x1D8 { get { return Field<float>(0x1D8); } }
	public float x1DC { get { return Field<float>(0x1DC); } }
	public float x1E4 { get { return Field<float>(0x1E4); } }
	public float x1E8 { get { return Field<float>(0x1E8); } }
	public float x1EC { get { return Field<float>(0x1EC); } }
	public float x1F0 { get { return Field<float>(0x1F0); } }
	public float x1F8 { get { return Field<float>(0x1F8); } }
	public float x208 { get { return Field<float>(0x208); } }
	public float x234 { get { return Field<float>(0x234); } }
	public float x238 { get { return Field<float>(0x238); } }
	public float x23C { get { return Field<float>(0x23C); } }
	public float x240 { get { return Field<float>(0x240); } }
	public float x244 { get { return Field<float>(0x244); } }
	public float x248 { get { return Field<float>(0x248); } }
}
