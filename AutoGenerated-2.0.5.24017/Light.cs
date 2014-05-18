public class Light : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x5A0; // 1440

	public Light(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x00C { get { return Field<int>(0x00C); } }
	public int x010 { get { return Field<int>(0x010); } }
	public int x014 { get { return Field<int>(0x014); } }
	public MaterialTexture x018 { get { return Field<MaterialTexture>(0x018); } }
	public DT_TIME x0B0 { get { return Field<DT_TIME>(0x0B0); } }
	public int x0B4 { get { return Field<int>(0x0B4); } }
	public float x0B8 { get { return Field<float>(0x0B8); } }
	public LightStateParams x0C0 { get { return Field<LightStateParams>(0x0C0); } }
	public LightStateParams x330 { get { return Field<LightStateParams>(0x330); } }
}
