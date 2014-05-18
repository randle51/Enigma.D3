public class Actor : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x368; // 872

	public Actor(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x00C { get { return Field<int>(0x00C); } }
	public int x010_Enum { get { return Field<int>(0x010); } } // 0: Invalid, 1: Monster, 2: Gizmo, 3: Client Effect, 4: Server Prop, 5: Environment, 6: Critter, 7: Player, 8: Item, 9: Axe Symbol, 10: Projectile, 11: Custom Brain
	public int x014_AppearanceSnoId { get { return Field<int>(0x014); } }
	public int x018_PhysMeshSnoId { get { return Field<int>(0x018); } }
	public AxialCylinder x01C { get { return Field<AxialCylinder>(0x01C); } }
	public Sphere x030 { get { return Field<Sphere>(0x030); } }
	public AABB x040 { get { return Field<AABB>(0x040); } }
	public SerializeData x058 { get { return Field<SerializeData>(0x058); } }
	public DT_TAGMAP x060 { get { return Field<DT_TAGMAP>(0x060); } }
	public int x068_AnimSetSnoId { get { return Field<int>(0x068); } }
	public int x06C_MonsterSnoId { get { return Field<int>(0x06C); } }
	public SerializeData x070 { get { return Field<SerializeData>(0x070); } }
	public int x078 { get { return Field<int>(0x078); } }
	public int x080_Count { get { return Field<int>(0x080); } }
	public MsgTriggeredEvent[] x084_PtrArray { get { return Dereference<MsgTriggeredEvent>(0x084, x080_Count); } }
	public Vector3D x088 { get { return Field<Vector3D>(0x088); } }
	public WeightedLook[] x094_Array { get { return Field<WeightedLook>(0x094, 8); } }
	public int x2B4_PhysicsSnoId { get { return Field<int>(0x2B4); } }
	public int x2B8 { get { return Field<int>(0x2B8); } }
	public int x2BC { get { return Field<int>(0x2BC); } }
	public float x2C0 { get { return Field<float>(0x2C0); } }
	public float x2C4 { get { return Field<float>(0x2C4); } }
	public float x2C8 { get { return Field<float>(0x2C8); } }
	public ActorCollisionData x2CC { get { return Field<ActorCollisionData>(0x2CC); } }
	public InventoryImages[] x310_Array { get { return Field<InventoryImages>(0x310, 6); } }
	public int x340 { get { return Field<int>(0x340); } }
	public DT_CSTRING x348 { get { return Field<DT_CSTRING>(0x348); } }
	public SerializeData x350 { get { return Field<SerializeData>(0x350); } }
	public DT_CSTRING x358 { get { return Field<DT_CSTRING>(0x358); } }
	public SerializeData x360 { get { return Field<SerializeData>(0x360); } }
}
