public class SubObject : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x190; // 400

	public SubObject(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x000 { get { return Field<int>(0x000); } }
	public int x004 { get { return Field<int>(0x004); } }
	public SerializeData x008 { get { return Field<SerializeData>(0x008); } }
	public int x010_Count { get { return Field<int>(0x010); } }
	public FatVertex[] x014_PtrArray { get { return Dereference<FatVertex>(0x014, x010_Count); } }
	public SerializeData x018 { get { return Field<SerializeData>(0x018); } }
	public int x020_Count { get { return Field<int>(0x020); } }
	public VertInfluences[] x024_PtrArray { get { return Dereference<VertInfluences>(0x024, x020_Count); } }
	public int x028 { get { return Field<int>(0x028); } }
	public SerializeData x02C { get { return Field<SerializeData>(0x02C); } }
	public int x038_Count { get { return Field<int>(0x038); } }
	public short[] x03C_PtrArray { get { return Dereference<short>(0x03C, x038_Count); } }
	public SerializeData x040 { get { return Field<SerializeData>(0x040); } }
	public int x048_Count { get { return Field<int>(0x048); } }
	public ClothStructure[] x04C_PtrArray { get { return Dereference<ClothStructure>(0x04C, x048_Count); } }
	public int x050_SurfaceSnoId { get { return Field<int>(0x050); } }
	public int x054 { get { return Field<int>(0x054); } }
	public float x058 { get { return Field<float>(0x058); } }
	public string x05C { get { return Field(0x05C, 128); } }
	public string x0DC { get { return Field(0x0DC, 128); } }
	public AABB x15C { get { return Field<AABB>(0x15C); } }
	public int x174 { get { return Field<int>(0x174); } }
	public SerializeData x178 { get { return Field<SerializeData>(0x178); } }
	public int x180_Count { get { return Field<int>(0x180); } }
	public CollisionShape[] x184_PtrArray { get { return Dereference<CollisionShape>(0x184, x180_Count); } }
	public long x188 { get { return Field<long>(0x188); } }
}
