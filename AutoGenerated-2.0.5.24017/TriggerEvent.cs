public class TriggerEvent : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x198; // 408

	public TriggerEvent(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x000 { get { return Field<int>(0x000); } }
	public TriggerConditions x004 { get { return Field<TriggerConditions>(0x004); } }
	public int x028 { get { return Field<int>(0x028); } }
	public SNOName x02C { get { return Field<SNOName>(0x02C); } }
	public int x034 { get { return Field<int>(0x034); } }
	public int x038 { get { return Field<int>(0x038); } }
	public int x03C { get { return Field<int>(0x03C); } }
	public int x040 { get { return Field<int>(0x040); } }
	public HardpointLink[] x044_Array { get { return Field<HardpointLink>(0x044, 2); } }
	public LookLink x0CC { get { return Field<LookLink>(0x0CC); } }
	public ConstraintLink x10C { get { return Field<ConstraintLink>(0x10C); } }
	public int x14C { get { return Field<int>(0x14C); } }
	public float x150 { get { return Field<float>(0x150); } }
	public int x154 { get { return Field<int>(0x154); } }
	public int x158 { get { return Field<int>(0x158); } }
	public int x15C { get { return Field<int>(0x15C); } }
	public int x160 { get { return Field<int>(0x160); } }
	public int x164 { get { return Field<int>(0x164); } }
	public float x168 { get { return Field<float>(0x168); } }
	public float x16C { get { return Field<float>(0x16C); } }
	public int x170 { get { return Field<int>(0x170); } }
	public float x174 { get { return Field<float>(0x174); } }
	public int x178 { get { return Field<int>(0x178); } }
	public DT_VELOCITY x17C { get { return Field<DT_VELOCITY>(0x17C); } }
	public int x180 { get { return Field<int>(0x180); } }
	public DT_TIME x184 { get { return Field<DT_TIME>(0x184); } }
	public RGBAColor x188 { get { return Field<RGBAColor>(0x188); } }
	public DT_TIME x18C { get { return Field<DT_TIME>(0x18C); } }
	public RGBAColor x190 { get { return Field<RGBAColor>(0x190); } }
	public DT_TIME x194 { get { return Field<DT_TIME>(0x194); } }
}
