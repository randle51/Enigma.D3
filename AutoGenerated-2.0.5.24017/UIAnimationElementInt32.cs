public class UIAnimationElementInt32 : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x08; // 8

	public UIAnimationElementInt32(ProcessMemory memory, int address)
		: base(memory, address) { }

	public float x00 { get { return Field<float>(0x00); } }
	public int x04 { get { return Field<int>(0x04); } }
}
