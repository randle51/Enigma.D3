public class SoundPermutation : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0xC0; // 192

	public SoundPermutation(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x00_SoundBankSnoId { get { return Field<int>(0x00); } }
	public string x04 { get { return Field(0x04, 132); } }
	public int x88 { get { return Field<int>(0x88); } }
	public float x8C { get { return Field<float>(0x8C); } }
	public float x90 { get { return Field<float>(0x90); } }
	public float x94 { get { return Field<float>(0x94); } }
	public float x98 { get { return Field<float>(0x98); } }
	public DT_TIME x9C { get { return Field<DT_TIME>(0x9C); } }
	public DT_TIME xA0 { get { return Field<DT_TIME>(0xA0); } }
	public int xA4 { get { return Field<int>(0xA4); } }
	public int xA8 { get { return Field<int>(0xA8); } }
	public float xAC { get { return Field<float>(0xAC); } }
	public float xB0 { get { return Field<float>(0xB0); } }
	public DT_TIME xB4 { get { return Field<DT_TIME>(0xB4); } }
}
