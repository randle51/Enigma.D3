public class WeightedLook : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x44; // 68

	public WeightedLook(ProcessMemory memory, int address)
		: base(memory, address) { }

	public LookLink x00 { get { return Field<LookLink>(0x00); } }
	public int x40 { get { return Field<int>(0x40); } }
}
