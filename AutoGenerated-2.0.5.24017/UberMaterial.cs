public class UberMaterial : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x68; // 104

	public UberMaterial(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x00_ShaderMapSnoId { get { return Field<int>(0x00); } }
	public Material x04 { get { return Field<Material>(0x04); } }
	public SerializeData x4C { get { return Field<SerializeData>(0x4C); } }
	public int x58_Count { get { return Field<int>(0x58); } }
	public MaterialTextureEntry[] x5C_PtrArray { get { return Dereference<MaterialTextureEntry>(0x5C, x58_Count); } }
}
