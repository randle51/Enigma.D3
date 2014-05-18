public class Appearance : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x218; // 536

	public Appearance(ProcessMemory memory, int address)
		: base(memory, address) { }

	public Structure x010 { get { return Field<Structure>(0x010); } }
	public int x1A0 { get { return Field<int>(0x1A0); } }
	public int x1A4 { get { return Field<int>(0x1A4); } }
	public SerializeData x1A8 { get { return Field<SerializeData>(0x1A8); } }
	public int x1B0_Count { get { return Field<int>(0x1B0); } }
	public AppearanceMaterial[] x1B4_PtrArray { get { return Dereference<AppearanceMaterial>(0x1B4, x1B0_Count); } }
	public SerializeData x1B8 { get { return Field<SerializeData>(0x1B8); } }
	public int x1C0_Count { get { return Field<int>(0x1C0); } }
	public AppearanceLook[] x1C4_PtrArray { get { return Dereference<AppearanceLook>(0x1C4, x1C0_Count); } }
	public int x1C8 { get { return Field<int>(0x1C8); } }
	public SerializeData x1CC { get { return Field<SerializeData>(0x1CC); } }
	public int x1D8_Count { get { return Field<int>(0x1D8); } }
	public StaticLight[] x1DC_PtrArray { get { return Dereference<StaticLight>(0x1DC, x1D8_Count); } }
	public int x1E0 { get { return Field<int>(0x1E0); } }
	public DT_TIME x1E4 { get { return Field<DT_TIME>(0x1E4); } }
	public DT_TIME x1E8 { get { return Field<DT_TIME>(0x1E8); } }
	public DT_TIME x1EC { get { return Field<DT_TIME>(0x1EC); } }
	public DT_TIME x1F0 { get { return Field<DT_TIME>(0x1F0); } }
	public DT_TIME x1F4 { get { return Field<DT_TIME>(0x1F4); } }
	public int x1F8 { get { return Field<int>(0x1F8); } }
	public float x1FC { get { return Field<float>(0x1FC); } }
	public int x200 { get { return Field<int>(0x200); } }
	public int x204 { get { return Field<int>(0x204); } }
	public long x208 { get { return Field<long>(0x208); } }
	public int x210 { get { return Field<int>(0x210); } }
}
