public class VelocityVectorNode : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x1C; // 28

	public VelocityVectorNode(ProcessMemory memory, int address)
		: base(memory, address) { }

	public VelocityVector3D x00 { get { return Field<VelocityVector3D>(0x00); } }
	public VelocityVector3D x0C { get { return Field<VelocityVector3D>(0x0C); } }
	public float x18 { get { return Field<float>(0x18); } }
}
