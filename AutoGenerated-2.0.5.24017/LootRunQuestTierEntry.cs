public class LootRunQuestTierEntry : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x208; // 520

	public LootRunQuestTierEntry(ProcessMemory memory, int address)
		: base(memory, address) { }

	public string x000 { get { return Field(0x000, 256); } }
	public int x100 { get { return Field<int>(0x100); } }
	public int x104 { get { return Field<int>(0x104); } }
	public int x108_QuestSnoId { get { return Field<int>(0x108); } }
	public float x10C { get { return Field<float>(0x10C); } }
	public DT_GBID x110_AxeBadDataGameBalanceId { get { return Field<DT_GBID>(0x110); } }
	public DT_GBID x114_ItemsGameBalanceId { get { return Field<DT_GBID>(0x114); } }
	public int x118_QuestSnoId { get { return Field<int>(0x118); } }
	public float x11C { get { return Field<float>(0x11C); } }
	public DT_GBID x120_AxeBadDataGameBalanceId { get { return Field<DT_GBID>(0x120); } }
	public DT_GBID x124_ItemsGameBalanceId { get { return Field<DT_GBID>(0x124); } }
	public int x128_QuestSnoId { get { return Field<int>(0x128); } }
	public float x12C { get { return Field<float>(0x12C); } }
	public DT_GBID x130_AxeBadDataGameBalanceId { get { return Field<DT_GBID>(0x130); } }
	public DT_GBID x134_ItemsGameBalanceId { get { return Field<DT_GBID>(0x134); } }
	public int x138_QuestSnoId { get { return Field<int>(0x138); } }
	public float x13C { get { return Field<float>(0x13C); } }
	public DT_GBID x140_AxeBadDataGameBalanceId { get { return Field<DT_GBID>(0x140); } }
	public DT_GBID x144_ItemsGameBalanceId { get { return Field<DT_GBID>(0x144); } }
	public int x148_QuestSnoId { get { return Field<int>(0x148); } }
	public float x14C { get { return Field<float>(0x14C); } }
	public DT_GBID x150_AxeBadDataGameBalanceId { get { return Field<DT_GBID>(0x150); } }
	public DT_GBID x154_ItemsGameBalanceId { get { return Field<DT_GBID>(0x154); } }
	public int x158_QuestSnoId { get { return Field<int>(0x158); } }
	public float x15C { get { return Field<float>(0x15C); } }
	public DT_GBID x160_AxeBadDataGameBalanceId { get { return Field<DT_GBID>(0x160); } }
	public DT_GBID x164_ItemsGameBalanceId { get { return Field<DT_GBID>(0x164); } }
	public int x168_QuestSnoId { get { return Field<int>(0x168); } }
	public float x16C { get { return Field<float>(0x16C); } }
	public DT_GBID x170_AxeBadDataGameBalanceId { get { return Field<DT_GBID>(0x170); } }
	public DT_GBID x174_ItemsGameBalanceId { get { return Field<DT_GBID>(0x174); } }
	public int x178_QuestSnoId { get { return Field<int>(0x178); } }
	public float x17C { get { return Field<float>(0x17C); } }
	public DT_GBID x180_AxeBadDataGameBalanceId { get { return Field<DT_GBID>(0x180); } }
	public DT_GBID x184_ItemsGameBalanceId { get { return Field<DT_GBID>(0x184); } }
	public int x188_QuestSnoId { get { return Field<int>(0x188); } }
	public float x18C { get { return Field<float>(0x18C); } }
	public DT_GBID x190_AxeBadDataGameBalanceId { get { return Field<DT_GBID>(0x190); } }
	public DT_GBID x194_ItemsGameBalanceId { get { return Field<DT_GBID>(0x194); } }
	public int x198_QuestSnoId { get { return Field<int>(0x198); } }
	public float x19C { get { return Field<float>(0x19C); } }
	public DT_GBID x1A0_AxeBadDataGameBalanceId { get { return Field<DT_GBID>(0x1A0); } }
	public DT_GBID x1A4_ItemsGameBalanceId { get { return Field<DT_GBID>(0x1A4); } }
	public int x1A8_QuestSnoId { get { return Field<int>(0x1A8); } }
	public float x1AC { get { return Field<float>(0x1AC); } }
	public DT_GBID x1B0_AxeBadDataGameBalanceId { get { return Field<DT_GBID>(0x1B0); } }
	public DT_GBID x1B4_ItemsGameBalanceId { get { return Field<DT_GBID>(0x1B4); } }
	public int x1B8_QuestSnoId { get { return Field<int>(0x1B8); } }
	public float x1BC { get { return Field<float>(0x1BC); } }
	public DT_GBID x1C0_AxeBadDataGameBalanceId { get { return Field<DT_GBID>(0x1C0); } }
	public DT_GBID x1C4_ItemsGameBalanceId { get { return Field<DT_GBID>(0x1C4); } }
	public int x1C8_QuestSnoId { get { return Field<int>(0x1C8); } }
	public float x1CC { get { return Field<float>(0x1CC); } }
	public DT_GBID x1D0_AxeBadDataGameBalanceId { get { return Field<DT_GBID>(0x1D0); } }
	public DT_GBID x1D4_ItemsGameBalanceId { get { return Field<DT_GBID>(0x1D4); } }
	public int x1D8_QuestSnoId { get { return Field<int>(0x1D8); } }
	public float x1DC { get { return Field<float>(0x1DC); } }
	public DT_GBID x1E0_AxeBadDataGameBalanceId { get { return Field<DT_GBID>(0x1E0); } }
	public DT_GBID x1E4_ItemsGameBalanceId { get { return Field<DT_GBID>(0x1E4); } }
	public int x1E8_QuestSnoId { get { return Field<int>(0x1E8); } }
	public float x1EC { get { return Field<float>(0x1EC); } }
	public DT_GBID x1F0_AxeBadDataGameBalanceId { get { return Field<DT_GBID>(0x1F0); } }
	public DT_GBID x1F4_ItemsGameBalanceId { get { return Field<DT_GBID>(0x1F4); } }
	public int x1F8_QuestSnoId { get { return Field<int>(0x1F8); } }
	public float x1FC { get { return Field<float>(0x1FC); } }
	public DT_GBID x200_AxeBadDataGameBalanceId { get { return Field<DT_GBID>(0x200); } }
	public DT_GBID x204_ItemsGameBalanceId { get { return Field<DT_GBID>(0x204); } }
}
