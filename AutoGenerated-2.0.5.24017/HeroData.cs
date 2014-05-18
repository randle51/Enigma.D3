public class HeroData : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x390; // 912

	public HeroData(ProcessMemory memory, int address)
		: base(memory, address) { }

	public string x000 { get { return Field(0x000, 256); } }
	public int x100 { get { return Field<int>(0x100); } }
	public int x104 { get { return Field<int>(0x104); } }
	public int x108_ActorSnoId { get { return Field<int>(0x108); } }
	public int x10C_ActorSnoId { get { return Field<int>(0x10C); } }
	public int x110_TreasureClassSnoId { get { return Field<int>(0x110); } }
	public int x114 { get { return Field<int>(0x114); } }
	public int x118_PowerSnoId { get { return Field<int>(0x118); } }
	public int x11C_PowerSnoId { get { return Field<int>(0x11C); } }
	public int x120_SkillKitSnoId { get { return Field<int>(0x120); } }
	public int x124_SkillKitSnoId { get { return Field<int>(0x124); } }
	public int x128_SkillKitSnoId { get { return Field<int>(0x128); } }
	public int x12C_SkillKitSnoId { get { return Field<int>(0x12C); } }
	public int x130_Enum { get { return Field<int>(0x130); } } // 0: Mana, 1: Arcanum, 2: Fury, 3: Spirit, 4: Power, 5: Hatred, 6: Discipline, 7: Faith
	public int x134_Enum { get { return Field<int>(0x134); } } // 0: Mana, 1: Arcanum, 2: Fury, 3: Spirit, 4: Power, 5: Hatred, 6: Discipline, 7: Faith
	public int x138_Enum { get { return Field<int>(0x138); } } // -1: None, 0: Strength, 1: Dexterity, 2: Intelligence
	public float x13C { get { return Field<float>(0x13C); } }
	public int x140 { get { return Field<int>(0x140); } }
	public float x154 { get { return Field<float>(0x154); } }
	public float x158 { get { return Field<float>(0x158); } }
	public float x164 { get { return Field<float>(0x164); } }
	public float x168 { get { return Field<float>(0x168); } }
	public float x16C { get { return Field<float>(0x16C); } }
	public float x170 { get { return Field<float>(0x170); } }
	public float x178 { get { return Field<float>(0x178); } }
	public float x17C { get { return Field<float>(0x17C); } }
	public float x180 { get { return Field<float>(0x180); } }
	public float x19C { get { return Field<float>(0x19C); } }
	public float x1E4 { get { return Field<float>(0x1E4); } }
	public float x1E8 { get { return Field<float>(0x1E8); } }
	public float x1EC { get { return Field<float>(0x1EC); } }
	public float x1F0 { get { return Field<float>(0x1F0); } }
	public float x1F8 { get { return Field<float>(0x1F8); } }
	public float x21C { get { return Field<float>(0x21C); } }
	public float x220 { get { return Field<float>(0x220); } }
	public float x228 { get { return Field<float>(0x228); } }
	public float x24C { get { return Field<float>(0x24C); } }
	public float x250 { get { return Field<float>(0x250); } }
	public float x254 { get { return Field<float>(0x254); } }
	public float x258 { get { return Field<float>(0x258); } }
	public float x25C { get { return Field<float>(0x25C); } }
	public float x260 { get { return Field<float>(0x260); } }
	public float x268 { get { return Field<float>(0x268); } }
	public float x26C { get { return Field<float>(0x26C); } }
	public float x2AC { get { return Field<float>(0x2AC); } }
	public float x2B8 { get { return Field<float>(0x2B8); } }
	public float x2BC { get { return Field<float>(0x2BC); } }
	public float x2C0 { get { return Field<float>(0x2C0); } }
	public float x2C4 { get { return Field<float>(0x2C4); } }
	public float x2D4 { get { return Field<float>(0x2D4); } }
	public float x2D8 { get { return Field<float>(0x2D8); } }
	public float x2DC { get { return Field<float>(0x2DC); } }
	public float x308 { get { return Field<float>(0x308); } }
	public float x324 { get { return Field<float>(0x324); } }
	public float x328 { get { return Field<float>(0x328); } }
	public float x32C { get { return Field<float>(0x32C); } }
	public float x330 { get { return Field<float>(0x330); } }
	public float x35C { get { return Field<float>(0x35C); } }
	public float x360 { get { return Field<float>(0x360); } }
	public float x364 { get { return Field<float>(0x364); } }
	public float x368 { get { return Field<float>(0x368); } }
	public float x36C { get { return Field<float>(0x36C); } }
	public float x370 { get { return Field<float>(0x370); } }
	public int x38C { get { return Field<int>(0x38C); } }
}
