public class FrameAnim : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x14; // 20

	public FrameAnim(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x00 { get { return Field<int>(0x00); } }
	public DT_VELOCITY x04 { get { return Field<DT_VELOCITY>(0x04); } }
	public DT_VELOCITY x08 { get { return Field<DT_VELOCITY>(0x08); } }
	public int x0C { get { return Field<int>(0x0C); } }
	public int x10 { get { return Field<int>(0x10); } }
}
