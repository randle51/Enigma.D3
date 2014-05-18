public class ConvLocaleDisplayTimes : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x30; // 48

	public ConvLocaleDisplayTimes(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int[] x00_Array { get { return Field<int>(0x00, 12); } }
}
