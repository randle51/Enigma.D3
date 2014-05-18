public class Trail : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x158; // 344

	public Trail(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x00C { get { return Field<int>(0x00C); } }
	public int x010 { get { return Field<int>(0x010); } }
	public int x014 { get { return Field<int>(0x014); } }
	public DT_TIME x018 { get { return Field<DT_TIME>(0x018); } }
	public DT_TIME x01C { get { return Field<DT_TIME>(0x01C); } }
	public DT_TIME x020 { get { return Field<DT_TIME>(0x020); } }
	public DT_TIME x024 { get { return Field<DT_TIME>(0x024); } }
	public ColorPath x028 { get { return Field<ColorPath>(0x028); } }
	public ColorPath x058 { get { return Field<ColorPath>(0x058); } }
	public FloatPath x088 { get { return Field<FloatPath>(0x088); } }
	public FloatPath x0B8 { get { return Field<FloatPath>(0x0B8); } }
	public int x0E8_Enum { get { return Field<int>(0x0E8); } } // 0: Line, 1: Cross, 2: Circle
	public int x0EC { get { return Field<int>(0x0EC); } }
	public UberMaterial x0F0 { get { return Field<UberMaterial>(0x0F0); } }
}
