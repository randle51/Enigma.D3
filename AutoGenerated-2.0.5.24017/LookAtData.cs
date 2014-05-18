public class LookAtData : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x5C; // 92

	public LookAtData(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x00 { get { return Field<int>(0x00); } }
	public string x04 { get { return Field(0x04, 64); } }
	public DT_ANGLE x44 { get { return Field<DT_ANGLE>(0x44); } }
	public DT_ANGLE x48 { get { return Field<DT_ANGLE>(0x48); } }
	public DT_ANGLE x4C { get { return Field<DT_ANGLE>(0x4C); } }
	public DT_ANGLE x50 { get { return Field<DT_ANGLE>(0x50); } }
	public DT_ANGULARVELOCITY x54 { get { return Field<DT_ANGULARVELOCITY>(0x54); } }
	public float x58 { get { return Field<float>(0x58); } }
}
