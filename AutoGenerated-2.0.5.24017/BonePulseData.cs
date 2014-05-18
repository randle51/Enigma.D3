public class BonePulseData : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x4C; // 76

	public BonePulseData(ProcessMemory memory, int address)
		: base(memory, address) { }

	public string x00 { get { return Field(0x00, 64); } }
	public float x40 { get { return Field<float>(0x40); } }
	public float x44 { get { return Field<float>(0x44); } }
	public DT_ANGLE x48 { get { return Field<DT_ANGLE>(0x48); } }
}
