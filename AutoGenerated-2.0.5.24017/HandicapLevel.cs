public class HandicapLevel : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x120; // 288

	public HandicapLevel(ProcessMemory memory, int address)
		: base(memory, address) { }

	public string x000 { get { return Field(0x000, 256); } }
	public int x100 { get { return Field<int>(0x100); } }
	public int x104 { get { return Field<int>(0x104); } }
	public float x108 { get { return Field<float>(0x108); } }
	public float x10C { get { return Field<float>(0x10C); } }
	public float x110 { get { return Field<float>(0x110); } }
	public float x114 { get { return Field<float>(0x114); } }
	public float x118 { get { return Field<float>(0x118); } }
	public float x11C { get { return Field<float>(0x11C); } }
}
