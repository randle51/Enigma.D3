public class VelocityVector3D : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x0C; // 12

	public VelocityVector3D(ProcessMemory memory, int address)
		: base(memory, address) { }

	public DT_VELOCITY x00 { get { return Field<DT_VELOCITY>(0x00); } }
	public DT_VELOCITY x04 { get { return Field<DT_VELOCITY>(0x04); } }
	public DT_VELOCITY x08 { get { return Field<DT_VELOCITY>(0x08); } }
}
