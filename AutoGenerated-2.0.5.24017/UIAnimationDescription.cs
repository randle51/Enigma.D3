public class UIAnimationDescription : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x218; // 536

	public UIAnimationDescription(ProcessMemory memory, int address)
		: base(memory, address) { }

	public long x000 { get { return Field<long>(0x000); } }
	public string x008 { get { return Field(0x008, 512); } }
	public int x208 { get { return Field<int>(0x208); } }
	public int[] x20C_Array { get { return Field<int>(0x20C, 2); } }
}
