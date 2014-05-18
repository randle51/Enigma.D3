public class CollisionCapsule : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x68; // 104

	public CollisionCapsule(ProcessMemory memory, int address)
		: base(memory, address) { }

	public float x00 { get { return Field<float>(0x00); } }
	public float x04 { get { return Field<float>(0x04); } }
	public Hardpoint x08 { get { return Field<Hardpoint>(0x08); } }
}
