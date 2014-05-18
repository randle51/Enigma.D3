public class RotationCurve : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x18; // 24

	public RotationCurve(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x00 { get { return Field<int>(0x00); } }
	public SerializeData x04 { get { return Field<SerializeData>(0x04); } }
	public int x0C { get { return Field<int>(0x0C); } }
	public int x10_Count { get { return Field<int>(0x10); } }
	public RotationKey[] x14_PtrArray { get { return Dereference<RotationKey>(0x14, x10_Count); } }
}
