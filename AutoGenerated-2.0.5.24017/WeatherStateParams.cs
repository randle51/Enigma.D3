public class WeatherStateParams : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x40; // 64

	public WeatherStateParams(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x00 { get { return Field<int>(0x00); } }
	public RGBAColor x04 { get { return Field<RGBAColor>(0x04); } }
	public float x08 { get { return Field<float>(0x08); } }
	public float x0C { get { return Field<float>(0x0C); } }
	public float x10 { get { return Field<float>(0x10); } }
	public float x14 { get { return Field<float>(0x14); } }
	public RGBAColor x18 { get { return Field<RGBAColor>(0x18); } }
	public float x1C { get { return Field<float>(0x1C); } }
	public float x20 { get { return Field<float>(0x20); } }
	public int x24_LightSnoId { get { return Field<int>(0x24); } }
	public int x28_LightSnoId { get { return Field<int>(0x28); } }
	public float x2C { get { return Field<float>(0x2C); } }
	public float x30 { get { return Field<float>(0x30); } }
	public int x34_LightSnoId { get { return Field<int>(0x34); } }
	public int x38_LightSnoId { get { return Field<int>(0x38); } }
	public int x3C_LightSnoId { get { return Field<int>(0x3C); } }
}
