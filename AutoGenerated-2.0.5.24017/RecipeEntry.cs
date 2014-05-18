public class RecipeEntry : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x150; // 336

	public RecipeEntry(ProcessMemory memory, int address)
		: base(memory, address) { }

	public string x000 { get { return Field(0x000, 256); } }
	public int x100 { get { return Field<int>(0x100); } }
	public int x104 { get { return Field<int>(0x104); } }
	public int x108_RecipeSnoId { get { return Field<int>(0x108); } }
	public int x10C_Enum { get { return Field<int>(0x10C); } } // 0: Blacksmith, 1: Jeweler, 2: Mystic, 3: Made To Order, 4: Devil's Hand, -1: - None -
	public int x110 { get { return Field<int>(0x110); } }
	public int x114 { get { return Field<int>(0x114); } }
	public int x118 { get { return Field<int>(0x118); } }
	public int x11C { get { return Field<int>(0x11C); } }
	public RecipeIngredient[] x120_Array { get { return Field<RecipeIngredient>(0x120, 6); } }
}
