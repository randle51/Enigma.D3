public class PRTransform : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x1C; // 28

	public PRTransform(ProcessMemory memory, int address)
		: base(memory, address) { }

	public Quaternion x00 { get { return Field<Quaternion>(0x00); } }
	public Vector3D x10 { get { return Field<Vector3D>(0x10); } }
}
