public class Vibrations : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x88; // 136

	public Vibrations(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x0C { get { return Field<int>(0x0C); } }
	public DT_TIME x10 { get { return Field<DT_TIME>(0x10); } }
	public DT_TIME x14 { get { return Field<DT_TIME>(0x14); } }
	public float x18 { get { return Field<float>(0x18); } }
	public float x1C { get { return Field<float>(0x1C); } }
	public float x20 { get { return Field<float>(0x20); } }
	public FloatPath x28 { get { return Field<FloatPath>(0x28); } }
	public FloatPath x58 { get { return Field<FloatPath>(0x58); } }
}
