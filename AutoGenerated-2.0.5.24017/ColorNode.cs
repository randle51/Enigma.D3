public class ColorNode : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x0C; // 12

	public ColorNode(ProcessMemory memory, int address)
		: base(memory, address) { }

	public RGBAColor x00 { get { return Field<RGBAColor>(0x00); } }
	public RGBAColor x04 { get { return Field<RGBAColor>(0x04); } }
	public float x08 { get { return Field<float>(0x08); } }
}
