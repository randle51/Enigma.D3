public class Anim2D : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x40; // 64

	public Anim2D(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x0C { get { return Field<int>(0x0C); } }
	public int x10 { get { return Field<int>(0x10); } }
	public FrameAnim x14 { get { return Field<FrameAnim>(0x14); } }
	public int x28_SoundSnoId { get { return Field<int>(0x28); } }
	public int x2C { get { return Field<int>(0x2C); } }
	public SerializeData x30 { get { return Field<SerializeData>(0x30); } }
	public int x38_Count { get { return Field<int>(0x38); } }
	public Anim2DFrame[] x3C_PtrArray { get { return Dereference<Anim2DFrame>(0x3C, x38_Count); } }
}
