public class Monster : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x14; // 20

	public Monster(ProcessMemory memory, int address)
		: base(memory, address) { }

	public float x00 { get { return Field<float>(0x00); } }
	public float x04 { get { return Field<float>(0x04); } }
	public float x08 { get { return Field<float>(0x08); } }
	public float x0C { get { return Field<float>(0x0C); } }
	public int x10 { get { return Field<int>(0x10); } }
}
