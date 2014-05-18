public class LabelCondition : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x18; // 24

	public LabelCondition(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x00_Enum { get { return Field<int>(0x00); } } // 0: Always, 2: Label Already Set, 3: Game Is Open World
	public int x04 { get { return Field<int>(0x04); } }
	public int[] x08_Array { get { return Field<int>(0x08, 4); } }
}
