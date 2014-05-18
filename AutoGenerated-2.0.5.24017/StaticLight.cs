public class StaticLight : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x5C; // 92

	public StaticLight(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x00 { get { return Field<int>(0x00); } }
	public int x04 { get { return Field<int>(0x04); } }
	public Vector3D x08 { get { return Field<Vector3D>(0x08); } }
	public Vector3D x14 { get { return Field<Vector3D>(0x14); } }
	public float x20 { get { return Field<float>(0x20); } }
	public int x24 { get { return Field<int>(0x24); } }
	public float[] x28_Array { get { return Field<float>(0x28, 3); } }
	public float x34 { get { return Field<float>(0x34); } }
	public float x38 { get { return Field<float>(0x38); } }
	public float x3C { get { return Field<float>(0x3C); } }
	public float x40 { get { return Field<float>(0x40); } }
	public int x44 { get { return Field<int>(0x44); } }
	public int x48 { get { return Field<int>(0x48); } }
	public RGBAColorValue x4C { get { return Field<RGBAColorValue>(0x4C); } }
}
