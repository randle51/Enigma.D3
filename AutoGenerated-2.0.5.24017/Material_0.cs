public class Material : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x88; // 136

	public Material(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x0C { get { return Field<int>(0x0C); } }
	public SerializeData x10 { get { return Field<SerializeData>(0x10); } }
	public DT_TAGMAP x18 { get { return Field<DT_TAGMAP>(0x18); } }
	public UberMaterial x20 { get { return Field<UberMaterial>(0x20); } }
}
