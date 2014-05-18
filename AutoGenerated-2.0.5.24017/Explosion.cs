public class Explosion : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x40; // 64

	public Explosion(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x0C { get { return Field<int>(0x0C); } }
	public int x10 { get { return Field<int>(0x10); } }
	public Vector3D x14 { get { return Field<Vector3D>(0x14); } }
	public DT_IMPULSE x20 { get { return Field<DT_IMPULSE>(0x20); } }
	public float x24 { get { return Field<float>(0x24); } }
	public float x28 { get { return Field<float>(0x28); } }
	public float x2C { get { return Field<float>(0x2C); } }
	public float x30 { get { return Field<float>(0x30); } }
	public int x34 { get { return Field<int>(0x34); } }
	public float x38 { get { return Field<float>(0x38); } }
	public int x3C { get { return Field<int>(0x3C); } }
}
