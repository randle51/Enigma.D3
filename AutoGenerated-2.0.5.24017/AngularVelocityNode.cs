public class AngularVelocityNode : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x0C; // 12

	public AngularVelocityNode(ProcessMemory memory, int address)
		: base(memory, address) { }

	public DT_ANGULARVELOCITY x00 { get { return Field<DT_ANGULARVELOCITY>(0x00); } }
	public DT_ANGULARVELOCITY x04 { get { return Field<DT_ANGULARVELOCITY>(0x04); } }
	public float x08 { get { return Field<float>(0x08); } }
}
