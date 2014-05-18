public class TriggerConditions : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x24; // 36

	public TriggerConditions(ProcessMemory memory, int address)
		: base(memory, address) { }

	public DT_PERCENT x00 { get { return Field<DT_PERCENT>(0x00); } }
	public DT_TIME x04 { get { return Field<DT_TIME>(0x04); } }
	public DT_TIME x08 { get { return Field<DT_TIME>(0x08); } }
	public DT_TIME x0C { get { return Field<DT_TIME>(0x0C); } }
	public DT_TIME x10 { get { return Field<DT_TIME>(0x10); } }
	public DT_IMPULSE x14 { get { return Field<DT_IMPULSE>(0x14); } }
	public DT_IMPULSE x18 { get { return Field<DT_IMPULSE>(0x18); } }
	public int x1C { get { return Field<int>(0x1C); } }
	public int x20 { get { return Field<int>(0x20); } }
}
