public class Physics : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x44; // 68

	public Physics(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x0C { get { return Field<int>(0x0C); } }
	public int x10 { get { return Field<int>(0x10); } }
	public float x14 { get { return Field<float>(0x14); } }
	public float x18 { get { return Field<float>(0x18); } }
	public float x1C { get { return Field<float>(0x1C); } }
	public float x20 { get { return Field<float>(0x20); } }
	public float x24 { get { return Field<float>(0x24); } }
	public short x28 { get { return Field<short>(0x28); } }
	public float x2C { get { return Field<float>(0x2C); } }
	public DT_ACCEL x30 { get { return Field<DT_ACCEL>(0x30); } }
	public DT_ACCEL x34 { get { return Field<DT_ACCEL>(0x34); } }
	public DT_VELOCITY x38 { get { return Field<DT_VELOCITY>(0x38); } }
	public DT_ACCEL x3C { get { return Field<DT_ACCEL>(0x3C); } }
	public DT_ACCEL x40 { get { return Field<DT_ACCEL>(0x40); } }
}
