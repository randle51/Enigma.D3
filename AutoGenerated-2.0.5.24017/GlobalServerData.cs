public class GlobalServerData : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x290; // 656

	public GlobalServerData(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x000_Count { get { return Field<int>(0x000); } }
	public ActorGroup[] x004_PtrArray { get { return Dereference<ActorGroup>(0x004, x000_Count); } }
	public SerializeData x008 { get { return Field<SerializeData>(0x008); } }
	public int x010_Count { get { return Field<int>(0x010); } }
	public GlobalScriptVariable[] x014_PtrArray { get { return Dereference<GlobalScriptVariable>(0x014, x010_Count); } }
	public SerializeData x018 { get { return Field<SerializeData>(0x018); } }
	public DifficultyTuningParams[] x020_Array { get { return Field<DifficultyTuningParams>(0x020, 6); } }
	public float x158 { get { return Field<float>(0x158); } }
	public float x15C { get { return Field<float>(0x15C); } }
	public float x160 { get { return Field<float>(0x160); } }
	public float x164 { get { return Field<float>(0x164); } }
	public float x168 { get { return Field<float>(0x168); } }
	public float x16C { get { return Field<float>(0x16C); } }
	public float x170 { get { return Field<float>(0x170); } }
	public float x174 { get { return Field<float>(0x174); } }
	public int x178 { get { return Field<int>(0x178); } }
	public float x17C { get { return Field<float>(0x17C); } }
	public float x180 { get { return Field<float>(0x180); } }
	public float x184 { get { return Field<float>(0x184); } }
	public float x188 { get { return Field<float>(0x188); } }
	public float x18C { get { return Field<float>(0x18C); } }
	public float x190 { get { return Field<float>(0x190); } }
	public float x194 { get { return Field<float>(0x194); } }
	public float x198 { get { return Field<float>(0x198); } }
	public float x19C { get { return Field<float>(0x19C); } }
	public float x1A0 { get { return Field<float>(0x1A0); } }
	public int x1A4 { get { return Field<int>(0x1A4); } }
	public int x1A8 { get { return Field<int>(0x1A8); } }
	public int x1AC { get { return Field<int>(0x1AC); } }
	public float x1B0 { get { return Field<float>(0x1B0); } }
	public float x1B4 { get { return Field<float>(0x1B4); } }
	public float x1B8 { get { return Field<float>(0x1B8); } }
	public float x1BC { get { return Field<float>(0x1BC); } }
	public float x1C0 { get { return Field<float>(0x1C0); } }
	public float x1C4 { get { return Field<float>(0x1C4); } }
	public float x1C8 { get { return Field<float>(0x1C8); } }
	public int x1CC { get { return Field<int>(0x1CC); } }
	public float x1D0 { get { return Field<float>(0x1D0); } }
	public int x1D4 { get { return Field<int>(0x1D4); } }
	public int x1D8 { get { return Field<int>(0x1D8); } }
	public int x1DC { get { return Field<int>(0x1DC); } }
	public int x1E0 { get { return Field<int>(0x1E0); } }
	public int x1E4 { get { return Field<int>(0x1E4); } }
	public int x1E8 { get { return Field<int>(0x1E8); } }
	public int x1EC { get { return Field<int>(0x1EC); } }
	public int x1F0 { get { return Field<int>(0x1F0); } }
	public int x1F4 { get { return Field<int>(0x1F4); } }
	public float x1F8 { get { return Field<float>(0x1F8); } }
	public float x1FC { get { return Field<float>(0x1FC); } }
	public float[] x200_Array { get { return Field<float>(0x200, 10); } }
	public float x228 { get { return Field<float>(0x228); } }
	public float x22C { get { return Field<float>(0x22C); } }
	public int x230 { get { return Field<int>(0x230); } }
	public int x234 { get { return Field<int>(0x234); } }
	public int x238 { get { return Field<int>(0x238); } }
	public float x23C { get { return Field<float>(0x23C); } }
	public int x240 { get { return Field<int>(0x240); } }
	public float x244 { get { return Field<float>(0x244); } }
	public float x248 { get { return Field<float>(0x248); } }
	public float x24C { get { return Field<float>(0x24C); } }
	public float x250 { get { return Field<float>(0x250); } }
	public float x254 { get { return Field<float>(0x254); } }
	public float x258 { get { return Field<float>(0x258); } }
	public float x25C { get { return Field<float>(0x25C); } }
	public float x260 { get { return Field<float>(0x260); } }
	public float x264 { get { return Field<float>(0x264); } }
	public float[] x268_Array { get { return Field<float>(0x268, 2); } }
	public float x270 { get { return Field<float>(0x270); } }
	public float x274 { get { return Field<float>(0x274); } }
	public float x278 { get { return Field<float>(0x278); } }
	public float x27C { get { return Field<float>(0x27C); } }
	public float x280 { get { return Field<float>(0x280); } }
	public float x284 { get { return Field<float>(0x284); } }
	public float x288 { get { return Field<float>(0x288); } }
}
