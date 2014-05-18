public class Quaternion : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x10; // 16

	public Quaternion(ProcessMemory memory, int address)
		: base(memory, address) { }

	public Vector3D x00 { get { return Field<Vector3D>(0x00); } }
	public float x0C { get { return Field<float>(0x0C); } }
}
