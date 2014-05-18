public class Account : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x20; // 32

	public Account(ProcessMemory memory, int address)
		: base(memory, address) { }

	public SerializeData x0C { get { return Field<SerializeData>(0x0C); } }
	public int x18_Count { get { return Field<int>(0x18); } }
	public byte[] x1C_PtrArray { get { return Dereference<byte>(0x1C, x18_Count); } }
}
