public class AnimPermutation : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x198; // 408

	public AnimPermutation(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x000 { get { return Field<int>(0x000); } }
	public string x004 { get { return Field(0x004, 68); } }
	public DT_VELOCITY x048 { get { return Field<DT_VELOCITY>(0x048); } }
	public float x04C { get { return Field<float>(0x04C); } }
	public float x050 { get { return Field<float>(0x050); } }
	public float x054 { get { return Field<float>(0x054); } }
	public float x058 { get { return Field<float>(0x058); } }
	public DT_TIME x05C { get { return Field<DT_TIME>(0x05C); } }
	public DT_TIME x060 { get { return Field<DT_TIME>(0x060); } }
	public int x064 { get { return Field<int>(0x064); } }
	public float x068 { get { return Field<float>(0x068); } }
	public float x06C { get { return Field<float>(0x06C); } }
	public float x070 { get { return Field<float>(0x070); } }
	public float x074 { get { return Field<float>(0x074); } }
	public int x078 { get { return Field<int>(0x078); } }
	public SerializeData x07C { get { return Field<SerializeData>(0x07C); } }
	public int x088_Count { get { return Field<int>(0x088); } }
	public BoneName[] x08C_PtrArray { get { return Dereference<BoneName>(0x08C, x088_Count); } }
	public int x090 { get { return Field<int>(0x090); } }
	public SerializeData x094 { get { return Field<SerializeData>(0x094); } }
	public int x0A0_Count { get { return Field<int>(0x0A0); } }
	public TranslationCurve[] x0A4_PtrArray { get { return Dereference<TranslationCurve>(0x0A4, x0A0_Count); } }
	public SerializeData x0A8 { get { return Field<SerializeData>(0x0A8); } }
	public int x0B0_Count { get { return Field<int>(0x0B0); } }
	public RotationCurve[] x0B4_PtrArray { get { return Dereference<RotationCurve>(0x0B4, x0B0_Count); } }
	public SerializeData x0B8 { get { return Field<SerializeData>(0x0B8); } }
	public int x0C0_Count { get { return Field<int>(0x0C0); } }
	public ScaleCurve[] x0C4_PtrArray { get { return Dereference<ScaleCurve>(0x0C4, x0C0_Count); } }
	public float x0C8 { get { return Field<float>(0x0C8); } }
	public float x0CC { get { return Field<float>(0x0CC); } }
	public float x0D0 { get { return Field<float>(0x0D0); } }
	public float x0D4 { get { return Field<float>(0x0D4); } }
	public Vector3D x0D8 { get { return Field<Vector3D>(0x0D8); } }
	public Vector3D x0E4 { get { return Field<Vector3D>(0x0E4); } }
	public Vector3D x0F0 { get { return Field<Vector3D>(0x0F0); } }
	public Vector3D x0FC { get { return Field<Vector3D>(0x0FC); } }
	public float x108 { get { return Field<float>(0x108); } }
	public SerializeData x10C { get { return Field<SerializeData>(0x10C); } }
	public int x114 { get { return Field<int>(0x114); } }
	public int x118_Count { get { return Field<int>(0x118); } }
	public KeyframedAttachment[] x11C_PtrArray { get { return Dereference<KeyframedAttachment>(0x11C, x118_Count); } }
	public SerializeData x120 { get { return Field<SerializeData>(0x120); } }
	public int x128_Count { get { return Field<int>(0x128); } }
	public Vector3D[] x12C_PtrArray { get { return Dereference<Vector3D>(0x12C, x128_Count); } }
	public SerializeData x130 { get { return Field<SerializeData>(0x130); } }
	public int x138_Count { get { return Field<int>(0x138); } }
	public Vector3D[] x13C_PtrArray { get { return Dereference<Vector3D>(0x13C, x138_Count); } }
	public VelocityVector3D x140 { get { return Field<VelocityVector3D>(0x140); } }
	public HardpointLink x14C { get { return Field<HardpointLink>(0x14C); } }
}
