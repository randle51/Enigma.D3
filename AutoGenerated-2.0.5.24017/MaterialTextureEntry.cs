public class MaterialTextureEntry : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0xA0; // 160

	public MaterialTextureEntry(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x00 { get { return Field<int>(0x00); } }
	public int x04 { get { return Field<int>(0x04); } }
	public MaterialTexture x08 { get { return Field<MaterialTexture>(0x08); } }
}
