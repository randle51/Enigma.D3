public class SoundSample : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0xA8; // 168

	public SoundSample(ProcessMemory memory, int address)
		: base(memory, address) { }

	public string x00 { get { return Field(0x00, 128); } }
	public int x80 { get { return Field<int>(0x80); } }
	public int x84 { get { return Field<int>(0x84); } }
	public int x88 { get { return Field<int>(0x88); } }
	public int x8C { get { return Field<int>(0x8C); } }
	public int x90 { get { return Field<int>(0x90); } }
	public int x94 { get { return Field<int>(0x94); } }
	public SerializeData x98 { get { return Field<SerializeData>(0x98); } }
}
