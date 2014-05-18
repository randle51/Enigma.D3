public class SocketedEffectsTableEntry : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x588; // 1416

	public SocketedEffectsTableEntry(ProcessMemory memory, int address)
		: base(memory, address) { }

	public string x000 { get { return Field(0x000, 256); } }
	public int x100 { get { return Field<int>(0x100); } }
	public int x104 { get { return Field<int>(0x104); } }
	public DT_GBID x108_ItemsGameBalanceId { get { return Field<DT_GBID>(0x108); } }
	public DT_GBID x10C_ItemTypesGameBalanceId { get { return Field<DT_GBID>(0x10C); } }
	public DT_TRANSLATEABLE x110 { get { return Field<DT_TRANSLATEABLE>(0x110); } }
	public DT_ATTRIBUTEPARAM x114 { get { return Field<DT_ATTRIBUTEPARAM>(0x114); } }
	public DT_FORMULA x118 { get { return Field<DT_FORMULA>(0x118); } }
	public SerializeData x120 { get { return Field<SerializeData>(0x120); } }
	public DT_TRANSLATEABLE x128 { get { return Field<DT_TRANSLATEABLE>(0x128); } }
	public DT_ATTRIBUTEPARAM x12C { get { return Field<DT_ATTRIBUTEPARAM>(0x12C); } }
	public DT_FORMULA x130 { get { return Field<DT_FORMULA>(0x130); } }
	public SerializeData x138 { get { return Field<SerializeData>(0x138); } }
	public DT_TRANSLATEABLE x140 { get { return Field<DT_TRANSLATEABLE>(0x140); } }
	public DT_ATTRIBUTEPARAM x144 { get { return Field<DT_ATTRIBUTEPARAM>(0x144); } }
	public DT_FORMULA x148 { get { return Field<DT_FORMULA>(0x148); } }
	public SerializeData x150 { get { return Field<SerializeData>(0x150); } }
	public DT_TRANSLATEABLE x158 { get { return Field<DT_TRANSLATEABLE>(0x158); } }
	public DT_ATTRIBUTEPARAM x15C { get { return Field<DT_ATTRIBUTEPARAM>(0x15C); } }
	public DT_FORMULA x160 { get { return Field<DT_FORMULA>(0x160); } }
	public SerializeData x168 { get { return Field<SerializeData>(0x168); } }
	public DT_TRANSLATEABLE x170 { get { return Field<DT_TRANSLATEABLE>(0x170); } }
	public DT_ATTRIBUTEPARAM x174 { get { return Field<DT_ATTRIBUTEPARAM>(0x174); } }
	public DT_FORMULA x178 { get { return Field<DT_FORMULA>(0x178); } }
	public SerializeData x180 { get { return Field<SerializeData>(0x180); } }
	public string x188 { get { return Field(0x188, 1024); } }
}
