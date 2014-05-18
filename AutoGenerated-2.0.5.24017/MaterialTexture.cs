public class MaterialTexture : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x98; // 152

	public MaterialTexture(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x00_TexturesSnoId { get { return Field<int>(0x00); } }
	public TexAnimParams x04 { get { return Field<TexAnimParams>(0x04); } }
	public int x94 { get { return Field<int>(0x94); } }
}
