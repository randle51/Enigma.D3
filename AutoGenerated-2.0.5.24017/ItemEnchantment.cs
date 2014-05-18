public class ItemEnchantment : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x2C0; // 704

	public ItemEnchantment(ProcessMemory memory, int address)
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
	public AttributeSpecifier[] x120_Array { get { return Field<AttributeSpecifier>(0x120, 16); } }
	public int x2A0 { get { return Field<int>(0x2A0); } }
	public RecipeIngredient[] x2A4_Array { get { return Field<RecipeIngredient>(0x2A4, 3); } }
	public int x2BC { get { return Field<int>(0x2BC); } }
}
