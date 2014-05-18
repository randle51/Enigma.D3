public class Globals : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x280; // 640

	public Globals(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x010_Count { get { return Field<int>(0x010); } }
	public GlobalServerData[] x014_PtrArray { get { return Dereference<GlobalServerData>(0x014, x010_Count); } }
	public SerializeData x018 { get { return Field<SerializeData>(0x018); } }
	public int x020 { get { return Field<int>(0x020); } }
	public int x028_Count { get { return Field<int>(0x028); } }
	public StartLocationName[] x02C_PtrArray { get { return Dereference<StartLocationName>(0x02C, x028_Count); } }
	public SerializeData x030 { get { return Field<SerializeData>(0x030); } }
	public float x038 { get { return Field<float>(0x038); } }
	public float x03C { get { return Field<float>(0x03C); } }
	public float x040 { get { return Field<float>(0x040); } }
	public float x044 { get { return Field<float>(0x044); } }
	public int x048 { get { return Field<int>(0x048); } }
	public int x04C { get { return Field<int>(0x04C); } }
	public float x050 { get { return Field<float>(0x050); } }
	public float x054 { get { return Field<float>(0x054); } }
	public int x058 { get { return Field<int>(0x058); } }
	public float x05C { get { return Field<float>(0x05C); } }
	public float x060 { get { return Field<float>(0x060); } }
	public float x064 { get { return Field<float>(0x064); } }
	public float x068 { get { return Field<float>(0x068); } }
	public float x06C { get { return Field<float>(0x06C); } }
	public float x070 { get { return Field<float>(0x070); } }
	public float x074 { get { return Field<float>(0x074); } }
	public float x078 { get { return Field<float>(0x078); } }
	public float x07C { get { return Field<float>(0x07C); } }
	public int x080 { get { return Field<int>(0x080); } }
	public int[] x084_Array { get { return Field<int>(0x084, 4); } }
	public BannerParams x098 { get { return Field<BannerParams>(0x098); } }
	public int x180 { get { return Field<int>(0x180); } }
	public int x184 { get { return Field<int>(0x184); } }
	public int x188 { get { return Field<int>(0x188); } }
	public int x18C { get { return Field<int>(0x18C); } }
	public float x190 { get { return Field<float>(0x190); } }
	public int x194 { get { return Field<int>(0x194); } }
	public float x198 { get { return Field<float>(0x198); } }
	public float x19C { get { return Field<float>(0x19C); } }
	public float x1A0 { get { return Field<float>(0x1A0); } }
	public float x1A4 { get { return Field<float>(0x1A4); } }
	public float x1A8 { get { return Field<float>(0x1A8); } }
	public float x1AC { get { return Field<float>(0x1AC); } }
	public float x1B0 { get { return Field<float>(0x1B0); } }
	public float x1B4 { get { return Field<float>(0x1B4); } }
	public float x1B8 { get { return Field<float>(0x1B8); } }
	public float x1BC { get { return Field<float>(0x1BC); } }
	public float x1C0 { get { return Field<float>(0x1C0); } }
	public float x1C4 { get { return Field<float>(0x1C4); } }
	public float x1C8 { get { return Field<float>(0x1C8); } }
	public float x1CC { get { return Field<float>(0x1CC); } }
	public float x1D0 { get { return Field<float>(0x1D0); } }
	public float x1D4 { get { return Field<float>(0x1D4); } }
	public float x1D8 { get { return Field<float>(0x1D8); } }
	public float x1DC { get { return Field<float>(0x1DC); } }
	public float x1E0 { get { return Field<float>(0x1E0); } }
	public float x1E4 { get { return Field<float>(0x1E4); } }
	public float x1E8 { get { return Field<float>(0x1E8); } }
	public int x1EC { get { return Field<int>(0x1EC); } }
	public float x1F0 { get { return Field<float>(0x1F0); } }
	public int x1F4 { get { return Field<int>(0x1F4); } }
	public int x1F8 { get { return Field<int>(0x1F8); } }
	public float x1FC { get { return Field<float>(0x1FC); } }
	public float x200 { get { return Field<float>(0x200); } }
	public float x204 { get { return Field<float>(0x204); } }
	public AssetList[] x208_Array { get { return Field<AssetList>(0x208, 7); } }
	public float x278 { get { return Field<float>(0x278); } }
	public float x27C { get { return Field<float>(0x27C); } }
}
