public class WorldServerData : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x90; // 144

	public WorldServerData(ProcessMemory memory, int address)
		: base(memory, address) { }

	public SerializeData x00 { get { return Field<SerializeData>(0x00); } }
	public int x08_Count { get { return Field<int>(0x08); } }
	public DRLGParams[] x0C_PtrArray { get { return Dereference<DRLGParams>(0x0C, x08_Count); } }
	public SerializeData x10 { get { return Field<SerializeData>(0x10); } }
	public int x18_Count { get { return Field<int>(0x18); } }
	public SceneParams[] x1C_PtrArray { get { return Dereference<SceneParams>(0x1C, x18_Count); } }
	public LabelRuleSet x20 { get { return Field<LabelRuleSet>(0x20); } }
	public int x38 { get { return Field<int>(0x38); } }
	public SceneClusterSet x40 { get { return Field<SceneClusterSet>(0x40); } }
	public int[] x58_Array_PowerSnoId { get { return Field<int>(0x58, 4); } }
	public DT_GBID[] x68_Array_AxeBadDataGameBalanceId { get { return Field<DT_GBID>(0x68, 3); } }
	public int x74_35SnoId { get { return Field<int>(0x74); } }
	public int x78 { get { return Field<int>(0x78); } }
	public int x80_Count { get { return Field<int>(0x80); } }
	public int[] x84_PtrArray_WeatherSnoId { get { return Dereference<int>(0x84, x80_Count); } }
	public SerializeData x88 { get { return Field<SerializeData>(0x88); } }
}
