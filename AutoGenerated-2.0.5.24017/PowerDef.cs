public class PowerDef : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x2D8; // 728

	public PowerDef(ProcessMemory memory, int address)
		: base(memory, address) { }

	public SerializeData x000 { get { return Field<SerializeData>(0x000); } }
	public DT_TAGMAP x008 { get { return Field<DT_TAGMAP>(0x008); } }
	public SerializeData x010 { get { return Field<SerializeData>(0x010); } }
	public DT_TAGMAP x018 { get { return Field<DT_TAGMAP>(0x018); } }
	public SerializeData x020 { get { return Field<SerializeData>(0x020); } }
	public DT_TAGMAP x028 { get { return Field<DT_TAGMAP>(0x028); } }
	public SerializeData x030 { get { return Field<SerializeData>(0x030); } }
	public SerializeData x038 { get { return Field<SerializeData>(0x038); } }
	public SerializeData x040 { get { return Field<SerializeData>(0x040); } }
	public SerializeData x048 { get { return Field<SerializeData>(0x048); } }
	public DT_TAGMAP x050 { get { return Field<DT_TAGMAP>(0x050); } }
	public DT_TAGMAP x058 { get { return Field<DT_TAGMAP>(0x058); } }
	public DT_TAGMAP x060 { get { return Field<DT_TAGMAP>(0x060); } }
	public DT_TAGMAP x068 { get { return Field<DT_TAGMAP>(0x068); } }
	public SerializeData x070 { get { return Field<SerializeData>(0x070); } }
	public SerializeData x078 { get { return Field<SerializeData>(0x078); } }
	public SerializeData x080 { get { return Field<SerializeData>(0x080); } }
	public SerializeData x088 { get { return Field<SerializeData>(0x088); } }
	public DT_TAGMAP x090 { get { return Field<DT_TAGMAP>(0x090); } }
	public DT_TAGMAP x098 { get { return Field<DT_TAGMAP>(0x098); } }
	public DT_TAGMAP x0A0 { get { return Field<DT_TAGMAP>(0x0A0); } }
	public DT_TAGMAP x0A8 { get { return Field<DT_TAGMAP>(0x0A8); } }
	public int x0B0 { get { return Field<int>(0x0B0); } }
	public ActorCollisionFlags x0B4 { get { return Field<ActorCollisionFlags>(0x0B4); } }
	public ActorCollisionFlags x0C4 { get { return Field<ActorCollisionFlags>(0x0C4); } }
	public BuffDef[] x0D8_Array { get { return Field<BuffDef>(0x0D8, 32); } }
}
