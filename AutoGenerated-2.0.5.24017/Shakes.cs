public class Shakes : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x1A0; // 416

	public Shakes(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x00C { get { return Field<int>(0x00C); } }
	public DT_TIME x010 { get { return Field<DT_TIME>(0x010); } }
	public DT_TIME x014 { get { return Field<DT_TIME>(0x014); } }
	public float x018 { get { return Field<float>(0x018); } }
	public float x01C { get { return Field<float>(0x01C); } }
	public VectorPath x020 { get { return Field<VectorPath>(0x020); } }
	public VectorPath x050 { get { return Field<VectorPath>(0x050); } }
	public AnglePath x080 { get { return Field<AnglePath>(0x080); } }
	public FloatPath x0B0 { get { return Field<FloatPath>(0x0B0); } }
	public AnglePath x0E0 { get { return Field<AnglePath>(0x0E0); } }
	public FloatPath x110 { get { return Field<FloatPath>(0x110); } }
	public AnglePath x140 { get { return Field<AnglePath>(0x140); } }
	public FloatPath x170 { get { return Field<FloatPath>(0x170); } }
}
