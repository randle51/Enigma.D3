public class Cloth : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x64; // 100

	public Cloth(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x0C { get { return Field<int>(0x0C); } }
	public int x10 { get { return Field<int>(0x10); } }
	public float x14 { get { return Field<float>(0x14); } }
	public float x18 { get { return Field<float>(0x18); } }
	public float x1C { get { return Field<float>(0x1C); } }
	public float x20 { get { return Field<float>(0x20); } }
	public float x24 { get { return Field<float>(0x24); } }
	public float x28 { get { return Field<float>(0x28); } }
	public float x2C { get { return Field<float>(0x2C); } }
	public DT_ACCEL x30 { get { return Field<DT_ACCEL>(0x30); } }
	public float x34 { get { return Field<float>(0x34); } }
	public float x38 { get { return Field<float>(0x38); } }
	public float x3C { get { return Field<float>(0x3C); } }
	public int[] x40_Array { get { return Field<int>(0x40, 4); } }
	public int x50_AmbientSoundSnoId { get { return Field<int>(0x50); } }
	public int x54 { get { return Field<int>(0x54); } }
	public Vector3D x58 { get { return Field<Vector3D>(0x58); } }
}
