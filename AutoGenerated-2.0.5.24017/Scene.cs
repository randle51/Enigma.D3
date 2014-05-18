public class Scene : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x210; // 528

	public Scene(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x00C { get { return Field<int>(0x00C); } }
	public AABB x010 { get { return Field<AABB>(0x010); } }
	public AABB x028 { get { return Field<AABB>(0x028); } }
	public NavMeshDef x040 { get { return Field<NavMeshDef>(0x040); } }
	public SerializeData x068 { get { return Field<SerializeData>(0x068); } }
	public int x070_Count { get { return Field<int>(0x070); } }
	public int[] x074_PtrArray_SceneSnoId { get { return Dereference<int>(0x074, x070_Count); } }
	public SerializeData x0A8 { get { return Field<SerializeData>(0x0A8); } }
	public int x0B0_Count { get { return Field<int>(0x0B0); } }
	public int[] x0B4_PtrArray_SceneSnoId { get { return Dereference<int>(0x0B4, x0B0_Count); } }
	public SerializeData x0E8 { get { return Field<SerializeData>(0x0E8); } }
	public int x0F0_Count { get { return Field<int>(0x0F0); } }
	public int[] x0F4_PtrArray_MarkerSetSnoId { get { return Dereference<int>(0x0F4, x0F0_Count); } }
	public LookLink x128 { get { return Field<LookLink>(0x128); } }
	public SerializeData x168 { get { return Field<SerializeData>(0x168); } }
	public int x170 { get { return Field<int>(0x170); } }
	public int x178_Count { get { return Field<int>(0x178); } }
	public MsgTriggeredEvent[] x17C_PtrArray { get { return Dereference<MsgTriggeredEvent>(0x17C, x178_Count); } }
	public NavZoneDefinition x180 { get { return Field<NavZoneDefinition>(0x180); } }
	public int x208_AppearanceSnoId { get { return Field<int>(0x208); } }
	public int x20C_PhysMeshSnoId { get { return Field<int>(0x20C); } }
}
