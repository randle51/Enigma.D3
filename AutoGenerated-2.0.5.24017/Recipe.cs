public class Recipe : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x48; // 72

	public Recipe(ProcessMemory memory, int address)
		: base(memory, address) { }

	public ItemSpecifierData x0C { get { return Field<ItemSpecifierData>(0x0C); } }
	public int x44 { get { return Field<int>(0x44); } }
}
