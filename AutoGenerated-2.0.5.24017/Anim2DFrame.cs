public class Anim2DFrame : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x44; // 68

	public Anim2DFrame(ProcessMemory memory, int address)
		: base(memory, address) { }

	public string x00 { get { return Field(0x00, 64); } }
	public RGBAColor x40 { get { return Field<RGBAColor>(0x40); } }
}
