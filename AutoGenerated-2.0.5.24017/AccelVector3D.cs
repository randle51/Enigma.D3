public class AccelVector3D : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x0C; // 12

	public AccelVector3D(ProcessMemory memory, int address)
		: base(memory, address) { }

	public DT_ACCEL x00 { get { return Field<DT_ACCEL>(0x00); } }
	public DT_ACCEL x04 { get { return Field<DT_ACCEL>(0x04); } }
	public DT_ACCEL x08 { get { return Field<DT_ACCEL>(0x08); } }
}
