public class PRSTransform : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x20; // 32

	public PRSTransform(ProcessMemory memory, int address)
		: base(memory, address) { }

	public Quaternion x00 { get { return Field<Quaternion>(0x00); } }
	public Vector3D x10 { get { return Field<Vector3D>(0x10); } }
	public float x1C { get { return Field<float>(0x1C); } }
}
