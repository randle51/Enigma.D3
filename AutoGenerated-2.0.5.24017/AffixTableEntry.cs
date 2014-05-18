public class AffixTableEntry : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x318; // 792

	public AffixTableEntry(ProcessMemory memory, int address)
		: base(memory, address) { }

	public string x000 { get { return Field(0x000, 256); } }
	public int x100 { get { return Field<int>(0x100); } }
	public int x104 { get { return Field<int>(0x104); } }
	public int x108 { get { return Field<int>(0x108); } }
	public int x10C { get { return Field<int>(0x10C); } }
	public int x110 { get { return Field<int>(0x110); } }
	public int x114 { get { return Field<int>(0x114); } }
	public int x118 { get { return Field<int>(0x118); } }
	public int x11C { get { return Field<int>(0x11C); } }
	public int x120 { get { return Field<int>(0x120); } }
	public int x124 { get { return Field<int>(0x124); } }
	public int x128 { get { return Field<int>(0x128); } }
	public int x12C { get { return Field<int>(0x12C); } }
	public int x130 { get { return Field<int>(0x130); } }
	public int x134 { get { return Field<int>(0x134); } }
	public int x138 { get { return Field<int>(0x138); } }
	public int x13C { get { return Field<int>(0x13C); } }
	public int x140 { get { return Field<int>(0x140); } }
	public int x144 { get { return Field<int>(0x144); } }
	public int x148 { get { return Field<int>(0x148); } }
	public int x14C { get { return Field<int>(0x14C); } }
	public int x150_Enum { get { return Field<int>(0x150); } } // 0: - None -, 1: Lightning, 2: Cold, 3: Fire, 4: Poison, 5: Arcane, 6: WitchdoctorDamage, 7: LifeSteal, 8: ManaSteal, 9: MagicFind, 10: GoldFind, 11: AttackSpeedBonus, 12: CastSpeedBonus, 13: Holy, 14: WizardDamage
	public int x154 { get { return Field<int>(0x154); } }
	public DT_GBID x158_AffixListGameBalanceId { get { return Field<DT_GBID>(0x158); } }
	public DT_GBID x15C_AffixListGameBalanceId { get { return Field<DT_GBID>(0x15C); } }
	public int x160_StringListSnoId { get { return Field<int>(0x160); } }
	public int x164_StringListSnoId { get { return Field<int>(0x164); } }
	public DT_GBID x168_47GameBalanceId { get { return Field<DT_GBID>(0x168); } }
	public DT_GBID x16C_47GameBalanceId { get { return Field<DT_GBID>(0x16C); } }
	public int x170_Enum { get { return Field<int>(0x170); } } // -1: - None -, 0: DemonHunter, 1: Barbarian, 2: Wizard, 3: Witchdoctor, 4: Monk, 5: Crusader
	public DT_GBID x174_AffixListGameBalanceId { get { return Field<DT_GBID>(0x174); } }
	public int[] x178_Array { get { return Field<int>(0x178, 6); } }
	public int[] x190_Array { get { return Field<int>(0x190, 24); } }
	public int[] x1F0_Array { get { return Field<int>(0x1F0, 24); } }
	public int x250 { get { return Field<int>(0x250); } }
	public int x254_Enum { get { return Field<int>(0x254); } } // 0: Prefix, 1: Suffix, 2: Inherent, 5: Title, 6: Quality, 7: Immunity, 9: Random, 10: Enchantment, 11: Socket Enhancement
	public DT_GBID x258_AffixListGameBalanceId { get { return Field<DT_GBID>(0x258); } }
	public AttributeSpecifier[] x260_Array { get { return Field<AttributeSpecifier>(0x260, 4); } }
	public DT_GBID x308_MadeToOrderTypesGameBalanceId { get { return Field<DT_GBID>(0x308); } }
	public int x30C_Enum { get { return Field<int>(0x30C); } } // 0: Major, 1: Minor
}
