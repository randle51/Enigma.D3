public class FollowerSubcondition : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x08; // 8

	public FollowerSubcondition(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x00_Enum { get { return Field<int>(0x00); } } // 0: - None -, 1: Templar, 2: Scoundrel, 3: Enchantress
	public int x04 { get { return Field<int>(0x04); } }
}
