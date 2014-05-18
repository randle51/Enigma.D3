public class AABB : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x18; // 24

	public AABB(ProcessMemory memory, int address)
		: base(memory, address) { }

	public Vector3D x00 { get { return Field<Vector3D>(0x00); } }
	public Vector3D x0C { get { return Field<Vector3D>(0x0C); } }
}
