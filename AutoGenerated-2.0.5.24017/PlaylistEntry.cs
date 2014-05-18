public class PlaylistEntry : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0xCC; // 204

	public PlaylistEntry(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x00_SoundBankSnoId { get { return Field<int>(0x00); } }
	public string x04 { get { return Field(0x04, 132); } }
	public float x88 { get { return Field<float>(0x88); } }
	public int x8C { get { return Field<int>(0x8C); } }
	public int x90 { get { return Field<int>(0x90); } }
	public int x94 { get { return Field<int>(0x94); } }
	public int x98 { get { return Field<int>(0x98); } }
	public int x9C { get { return Field<int>(0x9C); } }
	public int xA0 { get { return Field<int>(0xA0); } }
	public int xA4 { get { return Field<int>(0xA4); } }
	public int xA8 { get { return Field<int>(0xA8); } }
	public int xAC { get { return Field<int>(0xAC); } }
	public int xB0 { get { return Field<int>(0xB0); } }
	public int xB4 { get { return Field<int>(0xB4); } }
	public int xB8 { get { return Field<int>(0xB8); } }
	public float xBC { get { return Field<float>(0xBC); } }
	public float xC0 { get { return Field<float>(0xC0); } }
}
