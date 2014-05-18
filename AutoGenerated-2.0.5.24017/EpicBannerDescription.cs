public class EpicBannerDescription : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x94; // 148

	public EpicBannerDescription(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x00_TexturesSnoId { get { return Field<int>(0x00); } }
	public int x04_ActorSnoId { get { return Field<int>(0x04); } }
	public int x08_ActorSnoId { get { return Field<int>(0x08); } }
	public int x0C { get { return Field<int>(0x0C); } }
	public string x10 { get { return Field(0x10, 128); } }
}
