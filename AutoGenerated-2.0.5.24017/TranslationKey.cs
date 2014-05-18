public class TranslationKey : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x10; // 16

	public TranslationKey(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x00 { get { return Field<int>(0x00); } }
	public Vector3D x04 { get { return Field<Vector3D>(0x04); } }
}
