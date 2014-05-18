public class BannerParams : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0xE8; // 232

	public BannerParams(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x00_Count { get { return Field<int>(0x00); } }
	public BannerTexturePair[] x04_PtrArray { get { return Dereference<BannerTexturePair>(0x04, x00_Count); } }
	public SerializeData x08 { get { return Field<SerializeData>(0x08); } }
	public int x10 { get { return Field<int>(0x10); } }
	public int x18_Count { get { return Field<int>(0x18); } }
	public BannerTexturePair[] x1C_PtrArray { get { return Dereference<BannerTexturePair>(0x1C, x18_Count); } }
	public SerializeData x20 { get { return Field<SerializeData>(0x20); } }
	public int x28 { get { return Field<int>(0x28); } }
	public int x30_Count { get { return Field<int>(0x30); } }
	public BannerTexturePair[] x34_PtrArray { get { return Dereference<BannerTexturePair>(0x34, x30_Count); } }
	public SerializeData x38 { get { return Field<SerializeData>(0x38); } }
	public int x40_Count { get { return Field<int>(0x40); } }
	public BannerTexturePair[] x44_PtrArray { get { return Dereference<BannerTexturePair>(0x44, x40_Count); } }
	public SerializeData x48 { get { return Field<SerializeData>(0x48); } }
	public int x50 { get { return Field<int>(0x50); } }
	public int x58_Count { get { return Field<int>(0x58); } }
	public BannerTexturePair[] x5C_PtrArray { get { return Dereference<BannerTexturePair>(0x5C, x58_Count); } }
	public SerializeData x60 { get { return Field<SerializeData>(0x60); } }
	public int x68 { get { return Field<int>(0x68); } }
	public int x70_Count { get { return Field<int>(0x70); } }
	public BannerColorSet[] x74_PtrArray { get { return Dereference<BannerColorSet>(0x74, x70_Count); } }
	public SerializeData x78 { get { return Field<SerializeData>(0x78); } }
	public int x80_Count { get { return Field<int>(0x80); } }
	public BannerSigilPlacement[] x84_PtrArray { get { return Dereference<BannerSigilPlacement>(0x84, x80_Count); } }
	public SerializeData x88 { get { return Field<SerializeData>(0x88); } }
	public int x90_Count { get { return Field<int>(0x90); } }
	public int[] x94_PtrArray_ActorSnoId { get { return Dereference<int>(0x94, x90_Count); } }
	public SerializeData x98 { get { return Field<SerializeData>(0x98); } }
	public int xA0_Count { get { return Field<int>(0xA0); } }
	public int[] xA4_PtrArray_ActorSnoId { get { return Dereference<int>(0xA4, xA0_Count); } }
	public SerializeData xA8 { get { return Field<SerializeData>(0xA8); } }
	public int xB0_Count { get { return Field<int>(0xB0); } }
	public int[] xB4_PtrArray_ActorSnoId { get { return Dereference<int>(0xB4, xB0_Count); } }
	public SerializeData xB8 { get { return Field<SerializeData>(0xB8); } }
	public int xC0_Count { get { return Field<int>(0xC0); } }
	public int[] xC4_PtrArray_ActorSnoId { get { return Dereference<int>(0xC4, xC0_Count); } }
	public SerializeData xC8 { get { return Field<SerializeData>(0xC8); } }
	public int xD0_Count { get { return Field<int>(0xD0); } }
	public EpicBannerDescription[] xD4_PtrArray { get { return Dereference<EpicBannerDescription>(0xD4, xD0_Count); } }
	public SerializeData xD8 { get { return Field<SerializeData>(0xD8); } }
}
