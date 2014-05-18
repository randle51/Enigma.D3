public class TexAnimParams : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x90; // 144

	public TexAnimParams(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x00 { get { return Field<int>(0x00); } }
	public Matrix4x4 x04 { get { return Field<Matrix4x4>(0x04); } }
	public float x44 { get { return Field<float>(0x44); } }
	public DT_VELOCITY x48 { get { return Field<DT_VELOCITY>(0x48); } }
	public DT_VELOCITY x4C { get { return Field<DT_VELOCITY>(0x4C); } }
	public float x50 { get { return Field<float>(0x50); } }
	public DT_VELOCITY x54 { get { return Field<DT_VELOCITY>(0x54); } }
	public DT_VELOCITY x58 { get { return Field<DT_VELOCITY>(0x58); } }
	public DT_ANGLE x5C { get { return Field<DT_ANGLE>(0x5C); } }
	public DT_ANGULARVELOCITY x60 { get { return Field<DT_ANGULARVELOCITY>(0x60); } }
	public DT_ANGULARVELOCITY x64 { get { return Field<DT_ANGULARVELOCITY>(0x64); } }
	public int x68 { get { return Field<int>(0x68); } }
	public int x6C { get { return Field<int>(0x6C); } }
	public int x70 { get { return Field<int>(0x70); } }
	public int x74 { get { return Field<int>(0x74); } }
	public FrameAnim x78 { get { return Field<FrameAnim>(0x78); } }
	public int x8C { get { return Field<int>(0x8C); } }
}
