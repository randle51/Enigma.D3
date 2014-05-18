public class Structure : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x190; // 400

	public Structure(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x000 { get { return Field<int>(0x000); } }
	public int x004 { get { return Field<int>(0x004); } }
	public SerializeData x008 { get { return Field<SerializeData>(0x008); } }
	public int x010_Count { get { return Field<int>(0x010); } }
	public BoneStructure[] x014_PtrArray { get { return Dereference<BoneStructure>(0x014, x010_Count); } }
	public LookAtData x018 { get { return Field<LookAtData>(0x018); } }
	public int x074 { get { return Field<int>(0x074); } }
	public int x078_Count { get { return Field<int>(0x078); } }
	public BonePulseData[] x07C_PtrArray { get { return Dereference<BonePulseData>(0x07C, x078_Count); } }
	public SerializeData x080 { get { return Field<SerializeData>(0x080); } }
	public GeoSet[] x088_Array { get { return Field<GeoSet>(0x088, 2); } }
	public Sphere x0B8 { get { return Field<Sphere>(0x0B8); } }
	public int x0C8 { get { return Field<int>(0x0C8); } }
	public SerializeData x0CC { get { return Field<SerializeData>(0x0CC); } }
	public int x0D8_Count { get { return Field<int>(0x0D8); } }
	public CollisionCapsule[] x0DC_PtrArray { get { return Dereference<CollisionCapsule>(0x0DC, x0D8_Count); } }
	public int x0E0 { get { return Field<int>(0x0E0); } }
	public SerializeData x0E4 { get { return Field<SerializeData>(0x0E4); } }
	public int x0F0_Count { get { return Field<int>(0x0F0); } }
	public Hardpoint[] x0F4_PtrArray { get { return Dereference<Hardpoint>(0x0F4, x0F0_Count); } }
	public Vector3D x0F8 { get { return Field<Vector3D>(0x0F8); } }
	public Octree x108 { get { return Field<Octree>(0x108); } }
	public AABB x150 { get { return Field<AABB>(0x150); } }
	public int x168 { get { return Field<int>(0x168); } }
	public SerializeData x16C { get { return Field<SerializeData>(0x16C); } }
	public int x178_Count { get { return Field<int>(0x178); } }
	public ConstraintParameters[] x17C_PtrArray { get { return Dereference<ConstraintParameters>(0x17C, x178_Count); } }
	public int x180 { get { return Field<int>(0x180); } }
	public long x188 { get { return Field<long>(0x188); } }
}
