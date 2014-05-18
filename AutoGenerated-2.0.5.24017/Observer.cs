public class Observer : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x58; // 88

	public Observer(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x0C { get { return Field<int>(0x0C); } }
	public DT_ANGLE x10 { get { return Field<DT_ANGLE>(0x10); } }
	public float x14 { get { return Field<float>(0x14); } }
	public float x18 { get { return Field<float>(0x18); } }
	public float x1C { get { return Field<float>(0x1C); } }
	public DT_ANGLE x20 { get { return Field<DT_ANGLE>(0x20); } }
	public DT_ANGLE x24 { get { return Field<DT_ANGLE>(0x24); } }
	public float x28 { get { return Field<float>(0x28); } }
	public Vector3D x2C { get { return Field<Vector3D>(0x2C); } }
	public Vector3D x38 { get { return Field<Vector3D>(0x38); } }
	public float x44 { get { return Field<float>(0x44); } }
	public float x48 { get { return Field<float>(0x48); } }
	public float x4C { get { return Field<float>(0x4C); } }
	public float x50 { get { return Field<float>(0x50); } }
	public float x54 { get { return Field<float>(0x54); } }
}
