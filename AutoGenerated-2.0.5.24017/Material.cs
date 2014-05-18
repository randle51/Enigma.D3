public class Material : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x48; // 72

	public Material(ProcessMemory memory, int address)
		: base(memory, address) { }

	public RGBAColorValue x00 { get { return Field<RGBAColorValue>(0x00); } }
	public RGBAColorValue x10 { get { return Field<RGBAColorValue>(0x10); } }
	public RGBAColorValue x20 { get { return Field<RGBAColorValue>(0x20); } }
	public RGBAColorValue x30 { get { return Field<RGBAColorValue>(0x30); } }
	public float x40 { get { return Field<float>(0x40); } }
	public int x44 { get { return Field<int>(0x44); } }
}
