public class SceneGroupItem : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x0C; // 12

	public SceneGroupItem(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x00_SceneSnoId { get { return Field<int>(0x00); } }
	public int x04 { get { return Field<int>(0x04); } }
	public DT_GBID x08_LabelsGameBalanceId { get { return Field<DT_GBID>(0x08); } }
}
