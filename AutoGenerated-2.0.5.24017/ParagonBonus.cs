public class ParagonBonus : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x280; // 640

	public ParagonBonus(ProcessMemory memory, int address)
		: base(memory, address) { }

	public string x000 { get { return Field(0x000, 256); } }
	public int x100 { get { return Field<int>(0x100); } }
	public int x104 { get { return Field<int>(0x104); } }
	public int x108 { get { return Field<int>(0x108); } }
	public AttributeSpecifier[] x110_Array { get { return Field<AttributeSpecifier>(0x110, 4); } }
	public int x170 { get { return Field<int>(0x170); } }
	public int x174 { get { return Field<int>(0x174); } }
	public int x178_Enum { get { return Field<int>(0x178); } } // -1: - None -, 0: DemonHunter, 1: Barbarian, 2: Wizard, 3: Witchdoctor, 4: Monk, 5: Crusader
	public string x17C { get { return Field(0x17C, 256); } }
}
