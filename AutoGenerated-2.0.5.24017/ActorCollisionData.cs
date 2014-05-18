public class ActorCollisionData : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x44; // 68

	public ActorCollisionData(ProcessMemory memory, int address)
		: base(memory, address) { }

	public ActorCollisionFlags x00 { get { return Field<ActorCollisionFlags>(0x00); } }
	public int x10 { get { return Field<int>(0x10); } }
	public AxialCylinder x14 { get { return Field<AxialCylinder>(0x14); } }
	public AABB x28 { get { return Field<AABB>(0x28); } }
	public float x40 { get { return Field<float>(0x40); } }
}
