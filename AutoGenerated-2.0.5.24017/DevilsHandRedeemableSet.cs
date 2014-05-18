public class DevilsHandRedeemableSet : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x180; // 384

	public DevilsHandRedeemableSet(ProcessMemory memory, int address)
		: base(memory, address) { }

	public string x000 { get { return Field(0x000, 256); } }
	public int x100 { get { return Field<int>(0x100); } }
	public int x104 { get { return Field<int>(0x104); } }
	public int x108 { get { return Field<int>(0x108); } }
	public DT_FLAG x10C_00 { get { return (Field<int>(0x10C) >> 0) & 1; } }
	public DT_FLAG x10C_01 { get { return (Field<int>(0x10C) >> 1) & 1; } }
	public DevilsHandRedeemableSetReward[] x110_Array { get { return Field<DevilsHandRedeemableSetReward>(0x110, 8); } }
	public int x150 { get { return Field<int>(0x150); } }
	public int x154_LoreSnoId { get { return Field<int>(0x154); } }
	public DT_GBID[] x158_Array_AxeBadDataGameBalanceId { get { return Field<DT_GBID>(0x158, 8); } }
	public int x178 { get { return Field<int>(0x178); } }
}
