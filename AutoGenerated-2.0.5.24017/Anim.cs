public class Anim : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x38; // 56

	public Anim(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x0C { get { return Field<int>(0x0C); } }
	public int x10 { get { return Field<int>(0x10); } }
	public int x14_AppearanceSnoId { get { return Field<int>(0x14); } }
	public SerializeData x18 { get { return Field<SerializeData>(0x18); } }
	public int x20 { get { return Field<int>(0x20); } }
	public int x28_Count { get { return Field<int>(0x28); } }
	public AnimPermutation[] x2C_PtrArray { get { return Dereference<AnimPermutation>(0x2C, x28_Count); } }
	public int x30 { get { return Field<int>(0x30); } }
}
