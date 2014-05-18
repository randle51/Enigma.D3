public class Rope : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x460; // 1120

	public Rope(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x00C { get { return Field<int>(0x00C); } }
	public int x010 { get { return Field<int>(0x010); } }
	public float x014 { get { return Field<float>(0x014); } }
	public DT_MASS x018 { get { return Field<DT_MASS>(0x018); } }
	public float x01C { get { return Field<float>(0x01C); } }
	public DT_MASS x020 { get { return Field<DT_MASS>(0x020); } }
	public float x024 { get { return Field<float>(0x024); } }
	public float x028 { get { return Field<float>(0x028); } }
	public UberMaterial x030 { get { return Field<UberMaterial>(0x030); } }
	public int x098_PhysicsSnoId { get { return Field<int>(0x098); } }
	public DT_TIME x09C { get { return Field<DT_TIME>(0x09C); } }
	public DT_TIME x0A0 { get { return Field<DT_TIME>(0x0A0); } }
	public DT_TIME x0A4 { get { return Field<DT_TIME>(0x0A4); } }
	public DT_TIME x0A8 { get { return Field<DT_TIME>(0x0A8); } }
	public ColorPath x0B0 { get { return Field<ColorPath>(0x0B0); } }
	public ColorPath x0E0 { get { return Field<ColorPath>(0x0E0); } }
	public FloatPath x110 { get { return Field<FloatPath>(0x110); } }
	public FloatPath x140 { get { return Field<FloatPath>(0x140); } }
	public FloatPath x170 { get { return Field<FloatPath>(0x170); } }
	public FloatPath x1A0 { get { return Field<FloatPath>(0x1A0); } }
	public FloatPath x1D0 { get { return Field<FloatPath>(0x1D0); } }
	public FloatPath x200 { get { return Field<FloatPath>(0x200); } }
	public FloatPath x230 { get { return Field<FloatPath>(0x230); } }
	public FloatPath x260 { get { return Field<FloatPath>(0x260); } }
	public FloatPath x290 { get { return Field<FloatPath>(0x290); } }
	public FloatPath x2C0 { get { return Field<FloatPath>(0x2C0); } }
	public VectorPath x2F0 { get { return Field<VectorPath>(0x2F0); } }
	public VelocityPath x320 { get { return Field<VelocityPath>(0x320); } }
	public float x350 { get { return Field<float>(0x350); } }
	public float x354 { get { return Field<float>(0x354); } }
	public FloatPath x358 { get { return Field<FloatPath>(0x358); } }
	public FloatPath x388 { get { return Field<FloatPath>(0x388); } }
	public FloatPath x3B8 { get { return Field<FloatPath>(0x3B8); } }
	public FloatPath x3E8 { get { return Field<FloatPath>(0x3E8); } }
	public FloatPath x418 { get { return Field<FloatPath>(0x418); } }
	public SerializeData x448 { get { return Field<SerializeData>(0x448); } }
	public int x450 { get { return Field<int>(0x450); } }
	public int x458_Count { get { return Field<int>(0x458); } }
	public MsgTriggeredEvent[] x45C_PtrArray { get { return Dereference<MsgTriggeredEvent>(0x45C, x458_Count); } }
}
