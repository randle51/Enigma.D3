public class MadeToOrderAffixFoldersEntry : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x178; // 376

	public MadeToOrderAffixFoldersEntry(ProcessMemory memory, int address)
		: base(memory, address) { }

	public string x000 { get { return Field(0x000, 256); } }
	public int x100 { get { return Field<int>(0x100); } }
	public int x104 { get { return Field<int>(0x104); } }
	public int x108 { get { return Field<int>(0x108); } }
	public DT_GBID x10C_MadeToOrderAffixFoldersGameBalanceId { get { return Field<DT_GBID>(0x10C); } }
	public DT_GBID[] x110_Array_AxeBadDataGameBalanceId { get { return Field<DT_GBID>(0x110, 24); } }
	public int x170 { get { return Field<int>(0x170); } }
	public int x174 { get { return Field<int>(0x174); } }
}
