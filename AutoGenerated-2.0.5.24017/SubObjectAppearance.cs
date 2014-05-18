public class SubObjectAppearance : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0xF8; // 248

	public SubObjectAppearance(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x00 { get { return Field<int>(0x00); } }
	public int x04_ClothSnoId { get { return Field<int>(0x04); } }
	public SerializeData x08 { get { return Field<SerializeData>(0x08); } }
	public DT_TAGMAP x10 { get { return Field<DT_TAGMAP>(0x10); } }
	public UberMaterial x18 { get { return Field<UberMaterial>(0x18); } }
	public int x80_MaterialSnoId { get { return Field<int>(0x80); } }
	public UberMaterial x88 { get { return Field<UberMaterial>(0x88); } }
}
