public class Tutorial : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x30; // 48

	public Tutorial(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x0C { get { return Field<int>(0x0C); } }
	public int x10 { get { return Field<int>(0x10); } }
	public DT_TIME x14 { get { return Field<DT_TIME>(0x14); } }
	public DT_TIME x18 { get { return Field<DT_TIME>(0x18); } }
	public int x1C { get { return Field<int>(0x1C); } }
	public int x20 { get { return Field<int>(0x20); } }
	public IVector2D x24 { get { return Field<IVector2D>(0x24); } }
	public int x2C { get { return Field<int>(0x2C); } }
}
