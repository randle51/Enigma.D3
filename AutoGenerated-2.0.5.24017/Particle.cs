public class Particle : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x8F8; // 2296

	public Particle(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x00C { get { return Field<int>(0x00C); } }
	public int x010 { get { return Field<int>(0x010); } }
	public DT_TIME x014 { get { return Field<DT_TIME>(0x014); } }
	public DT_TIME x018 { get { return Field<DT_TIME>(0x018); } }
	public DT_TIME x01C { get { return Field<DT_TIME>(0x01C); } }
	public InterpolationScalar x020 { get { return Field<InterpolationScalar>(0x020); } }
	public int x02C { get { return Field<int>(0x02C); } }
	public FloatPath x030 { get { return Field<FloatPath>(0x030); } }
	public IntPath x060 { get { return Field<IntPath>(0x060); } }
	public FloatPath x090 { get { return Field<FloatPath>(0x090); } }
	public TimePath x0C0 { get { return Field<TimePath>(0x0C0); } }
	public FloatPath x0F0 { get { return Field<FloatPath>(0x0F0); } }
	public AnglePath x120 { get { return Field<AnglePath>(0x120); } }
	public VelocityVectorPath x150 { get { return Field<VelocityVectorPath>(0x150); } }
	public VelocityVectorPath x180 { get { return Field<VelocityVectorPath>(0x180); } }
	public VelocityPath x1B0 { get { return Field<VelocityPath>(0x1B0); } }
	public VelocityPath x1E0 { get { return Field<VelocityPath>(0x1E0); } }
	public VelocityPath x210 { get { return Field<VelocityPath>(0x210); } }
	public VectorPath x240 { get { return Field<VectorPath>(0x240); } }
	public VelocityPath x270 { get { return Field<VelocityPath>(0x270); } }
	public float x2A0 { get { return Field<float>(0x2A0); } }
	public UberMaterial x2A8 { get { return Field<UberMaterial>(0x2A8); } }
	public int x310_PhysicsSnoId { get { return Field<int>(0x310); } }
	public DT_MASS x314 { get { return Field<DT_MASS>(0x314); } }
	public int x318 { get { return Field<int>(0x318); } }
	public float x31C { get { return Field<float>(0x31C); } }
	public float x320 { get { return Field<float>(0x320); } }
	public float x324 { get { return Field<float>(0x324); } }
	public float x328 { get { return Field<float>(0x328); } }
	public float x32C { get { return Field<float>(0x32C); } }
	public float x330 { get { return Field<float>(0x330); } }
	public float x334 { get { return Field<float>(0x334); } }
	public int x338_ActorSnoId { get { return Field<int>(0x338); } }
	public EmitterParams x340 { get { return Field<EmitterParams>(0x340); } }
	public ColorPath x458 { get { return Field<ColorPath>(0x458); } }
	public FloatPath x488 { get { return Field<FloatPath>(0x488); } }
	public FloatPath x4B8 { get { return Field<FloatPath>(0x4B8); } }
	public FloatPath x4E8 { get { return Field<FloatPath>(0x4E8); } }
	public FloatPath x518 { get { return Field<FloatPath>(0x518); } }
	public AnglePath x548 { get { return Field<AnglePath>(0x548); } }
	public AngularVelocityPath x578 { get { return Field<AngularVelocityPath>(0x578); } }
	public AngularVelocityPath x5A8 { get { return Field<AngularVelocityPath>(0x5A8); } }
	public AnglePath x5D8 { get { return Field<AnglePath>(0x5D8); } }
	public VectorPath x608 { get { return Field<VectorPath>(0x608); } }
	public FloatPath x638 { get { return Field<FloatPath>(0x638); } }
	public VelocityPath x668 { get { return Field<VelocityPath>(0x668); } }
	public AngularVelocityPath x698 { get { return Field<AngularVelocityPath>(0x698); } }
	public VectorPath x6C8 { get { return Field<VectorPath>(0x6C8); } }
	public FloatPath x6F8 { get { return Field<FloatPath>(0x6F8); } }
	public VelocityPath x728 { get { return Field<VelocityPath>(0x728); } }
	public VectorPath x758 { get { return Field<VectorPath>(0x758); } }
	public VelocityVectorPath x788 { get { return Field<VelocityVectorPath>(0x788); } }
	public AccelVectorPath x7B8 { get { return Field<AccelVectorPath>(0x7B8); } }
	public VectorPath x7E8 { get { return Field<VectorPath>(0x7E8); } }
	public VelocityVectorPath x818 { get { return Field<VelocityVectorPath>(0x818); } }
	public AccelVectorPath x848 { get { return Field<AccelVectorPath>(0x848); } }
	public VelocityPath x878 { get { return Field<VelocityPath>(0x878); } }
	public FloatPath x8A8 { get { return Field<FloatPath>(0x8A8); } }
	public int x8D8 { get { return Field<int>(0x8D8); } }
	public float x8DC { get { return Field<float>(0x8DC); } }
	public float x8E0 { get { return Field<float>(0x8E0); } }
	public SerializeData x8E4 { get { return Field<SerializeData>(0x8E4); } }
	public int x8EC { get { return Field<int>(0x8EC); } }
	public int x8F0_Count { get { return Field<int>(0x8F0); } }
	public MsgTriggeredEvent[] x8F4_PtrArray { get { return Dereference<MsgTriggeredEvent>(0x8F4, x8F0_Count); } }
}
