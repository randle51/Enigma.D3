public class ActiveSkillEntry : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x40; // 64

	public ActiveSkillEntry(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x00_PowerSnoId { get { return Field<int>(0x00); } }
	public int x04 { get { return Field<int>(0x04); } }
	public int x08 { get { return Field<int>(0x08); } }
	public int x0C { get { return Field<int>(0x0C); } }
	public int x10 { get { return Field<int>(0x10); } }
	public int x14 { get { return Field<int>(0x14); } }
	public int x18 { get { return Field<int>(0x18); } }
	public int x1C { get { return Field<int>(0x1C); } }
	public int x20 { get { return Field<int>(0x20); } }
	public int x24 { get { return Field<int>(0x24); } }
	public int x28 { get { return Field<int>(0x28); } }
	public int[] x2C_Array { get { return Field<int>(0x2C, 5); } }
}
