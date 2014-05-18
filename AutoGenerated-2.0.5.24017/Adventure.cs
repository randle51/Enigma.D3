public class Adventure : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x24; // 36

	public Adventure(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x0C_ActorSnoId { get { return Field<int>(0x0C); } }
	public float x10 { get { return Field<float>(0x10); } }
	public DT_ANGLE x14 { get { return Field<DT_ANGLE>(0x14); } }
	public DT_ANGLE x18 { get { return Field<DT_ANGLE>(0x18); } }
	public DT_ANGLE x1C { get { return Field<DT_ANGLE>(0x1C); } }
	public int x20_MarkerSetSnoId { get { return Field<int>(0x20); } }
}
