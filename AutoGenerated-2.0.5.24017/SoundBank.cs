public class SoundBank : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x40; // 64

	public SoundBank(ProcessMemory memory, int address)
		: base(memory, address) { }

	public SerializeData x0C { get { return Field<SerializeData>(0x0C); } }
	public int x18_Count { get { return Field<int>(0x18); } }
	public SoundSample[] x1C_PtrArray { get { return Dereference<SoundSample>(0x1C, x18_Count); } }
	public int x20 { get { return Field<int>(0x20); } }
	public int x24 { get { return Field<int>(0x24); } }
	public SerializeData x28 { get { return Field<SerializeData>(0x28); } }
	public int x30_Count { get { return Field<int>(0x30); } }
	public long[] x34_PtrArray { get { return Dereference<long>(0x34, x30_Count); } }
	public int x38 { get { return Field<int>(0x38); } }
	public int x3C { get { return Field<int>(0x3C); } }
}
