public class Weather : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x190; // 400

	public Weather(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x00C { get { return Field<int>(0x00C); } }
	public DT_TIME x010 { get { return Field<DT_TIME>(0x010); } }
	public VelocityVectorPath x018 { get { return Field<VelocityVectorPath>(0x018); } }
	public VelocityVectorPath x048 { get { return Field<VelocityVectorPath>(0x048); } }
	public DT_TIME x078 { get { return Field<DT_TIME>(0x078); } }
	public FloatPath x080 { get { return Field<FloatPath>(0x080); } }
	public int x0B0_ParticleSnoId { get { return Field<int>(0x0B0); } }
	public int x0B4_ParticleSnoId { get { return Field<int>(0x0B4); } }
	public int x0B8_SoundSnoId { get { return Field<int>(0x0B8); } }
	public int x0BC_ActorSnoId { get { return Field<int>(0x0BC); } }
	public float x0C0 { get { return Field<float>(0x0C0); } }
	public DT_TIME x0C4 { get { return Field<DT_TIME>(0x0C4); } }
	public DT_TIME x0C8 { get { return Field<DT_TIME>(0x0C8); } }
	public DT_TIME x0CC { get { return Field<DT_TIME>(0x0CC); } }
	public int x0D0_LightSnoId { get { return Field<int>(0x0D0); } }
	public int x0D4_EffectGroupSnoId { get { return Field<int>(0x0D4); } }
	public int x0D8_SoundSnoId { get { return Field<int>(0x0D8); } }
	public float x0DC { get { return Field<float>(0x0DC); } }
	public float x0E0 { get { return Field<float>(0x0E0); } }
	public float x0E4 { get { return Field<float>(0x0E4); } }
	public WeatherStateParams x0E8 { get { return Field<WeatherStateParams>(0x0E8); } }
	public WeatherStateParams x128 { get { return Field<WeatherStateParams>(0x128); } }
	public float x168 { get { return Field<float>(0x168); } }
	public ColorCorrectionParams x16C { get { return Field<ColorCorrectionParams>(0x16C); } }
	public int x178_Count { get { return Field<int>(0x178); } }
	public int[] x17C_PtrArray_WeatherSnoId { get { return Dereference<int>(0x17C, x178_Count); } }
	public SerializeData x180 { get { return Field<SerializeData>(0x180); } }
	public int x188 { get { return Field<int>(0x188); } }
	public int x18C { get { return Field<int>(0x18C); } }
}
