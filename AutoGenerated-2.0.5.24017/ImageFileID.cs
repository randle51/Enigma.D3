public class ImageFileID : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x04; // 4

	public ImageFileID(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x00 { get { return Field<int>(0x00); } }
}
