public class RotationKey : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x0C; // 12

	public RotationKey(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x00 { get { return Field<int>(0x00); } }
	public Quaternion16 x04 { get { return Field<Quaternion16>(0x04); } }
}
