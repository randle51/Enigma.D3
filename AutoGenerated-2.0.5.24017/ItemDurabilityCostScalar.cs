public class ItemDurabilityCostScalar : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x08; // 8

	public ItemDurabilityCostScalar(ProcessMemory memory, int address)
		: base(memory, address) { }

	public float x00 { get { return Field<float>(0x00); } }
	public float x04 { get { return Field<float>(0x04); } }
}
