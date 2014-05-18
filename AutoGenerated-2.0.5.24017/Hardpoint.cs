public class Hardpoint : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x60; // 96

	public Hardpoint(ProcessMemory memory, int address)
		: base(memory, address) { }

	public string x00 { get { return Field(0x00, 64); } }
	public int x40 { get { return Field<int>(0x40); } }
	public PRTransform x44 { get { return Field<PRTransform>(0x44); } }
}
