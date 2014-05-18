public class DRLGCommand : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x98; // 152

	public DRLGCommand(ProcessMemory memory, int address)
		: base(memory, address) { }

	public string x00 { get { return Field(0x00, 128); } }
	public int x80 { get { return Field<int>(0x80); } }
	public SerializeData x84 { get { return Field<SerializeData>(0x84); } }
	public DT_TAGMAP x90 { get { return Field<DT_TAGMAP>(0x90); } }
}
