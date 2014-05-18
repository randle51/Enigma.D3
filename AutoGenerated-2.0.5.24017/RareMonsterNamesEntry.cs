public class RareMonsterNamesEntry : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x190; // 400

	public RareMonsterNamesEntry(ProcessMemory memory, int address)
		: base(memory, address) { }

	public string x000 { get { return Field(0x000, 256); } }
	public int x100 { get { return Field<int>(0x100); } }
	public int x104 { get { return Field<int>(0x104); } }
	public int x108_Enum { get { return Field<int>(0x108); } } // 0: Prefix, 1: Suffix, 2: Inherent, 5: Title, 6: Quality, 7: Immunity, 9: Random, 10: Enchantment, 11: Socket Enhancement
	public string x10C { get { return Field(0x10C, 128); } }
	public int x18C { get { return Field<int>(0x18C); } }
}
