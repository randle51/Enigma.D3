public class Accolade : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x10; // 16

	public Accolade(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x0C { get { return Field<int>(0x0C); } }
}
