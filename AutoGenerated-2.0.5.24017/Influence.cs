public class Influence : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x08; // 8

	public Influence(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x00 { get { return Field<int>(0x00); } }
	public float x04 { get { return Field<float>(0x04); } }
}
