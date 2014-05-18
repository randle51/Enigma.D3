public class BannerColorSet : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x54; // 84

	public BannerColorSet(ProcessMemory memory, int address)
		: base(memory, address) { }

	public RGBAColor[] x00_Array { get { return Field<RGBAColor>(0x00, 2); } }
	public string x08 { get { return Field(0x08, 64); } }
	public int x48 { get { return Field<int>(0x48); } }
	public int x4C { get { return Field<int>(0x4C); } }
}
