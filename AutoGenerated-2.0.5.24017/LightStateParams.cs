public class LightStateParams : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x270; // 624

	public LightStateParams(ProcessMemory memory, int address)
		: base(memory, address) { }

	public FloatPath x000 { get { return Field<FloatPath>(0x000); } }
	public FloatPath x030 { get { return Field<FloatPath>(0x030); } }
	public FloatPath[] x060_Array { get { return Field<FloatPath>(0x060, 3); } }
	public AnglePath x0F0 { get { return Field<AnglePath>(0x0F0); } }
	public AnglePath x120 { get { return Field<AnglePath>(0x120); } }
	public ColorPath x150 { get { return Field<ColorPath>(0x150); } }
	public FloatPath x180 { get { return Field<FloatPath>(0x180); } }
	public ColorPath x1B0 { get { return Field<ColorPath>(0x1B0); } }
	public FloatPath x1E0 { get { return Field<FloatPath>(0x1E0); } }
	public ColorPath x210 { get { return Field<ColorPath>(0x210); } }
	public FloatPath x240 { get { return Field<FloatPath>(0x240); } }
}
