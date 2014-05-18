public class AccelVectorNode : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x1C; // 28

	public AccelVectorNode(ProcessMemory memory, int address)
		: base(memory, address) { }

	public AccelVector3D x00 { get { return Field<AccelVector3D>(0x00); } }
	public AccelVector3D x0C { get { return Field<AccelVector3D>(0x0C); } }
	public float x18 { get { return Field<float>(0x18); } }
}
