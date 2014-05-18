public class BoneStructure : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x138; // 312

	public BoneStructure(ProcessMemory memory, int address)
		: base(memory, address) { }

	public string x000 { get { return Field(0x000, 64); } }
	public int x040 { get { return Field<int>(0x040); } }
	public AABB x044 { get { return Field<AABB>(0x044); } }
	public Sphere x05C { get { return Field<Sphere>(0x05C); } }
	public PRSTransform x06C { get { return Field<PRSTransform>(0x06C); } }
	public PRSTransform x08C { get { return Field<PRSTransform>(0x08C); } }
	public PRSTransform x0AC { get { return Field<PRSTransform>(0x0AC); } }
	public PRSTransform x0CC { get { return Field<PRSTransform>(0x0CC); } }
	public PRSTransform x0EC { get { return Field<PRSTransform>(0x0EC); } }
	public int x10C { get { return Field<int>(0x10C); } }
	public SerializeData x110 { get { return Field<SerializeData>(0x110); } }
	public int x118_Count { get { return Field<int>(0x118); } }
	public CollisionShape[] x11C_PtrArray { get { return Dereference<CollisionShape>(0x11C, x118_Count); } }
	public SerializeData x120 { get { return Field<SerializeData>(0x120); } }
	public int x128_Count { get { return Field<int>(0x128); } }
	public ConstraintParameters[] x12C_PtrArray { get { return Dereference<ConstraintParameters>(0x12C, x128_Count); } }
	public int x130_ParticleSnoId { get { return Field<int>(0x130); } }
}
