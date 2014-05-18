public class EffectGroup : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x78; // 120

	public EffectGroup(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x0C { get { return Field<int>(0x0C); } }
	public SerializeData x10 { get { return Field<SerializeData>(0x10); } }
	public int x18 { get { return Field<int>(0x18); } }
	public int x20_Count { get { return Field<int>(0x20); } }
	public EffectItem[] x24_PtrArray { get { return Dereference<EffectItem>(0x24, x20_Count); } }
	public int x28 { get { return Field<int>(0x28); } }
	public int x2C { get { return Field<int>(0x2C); } }
	public int x30 { get { return Field<int>(0x30); } }
	public int x34_PowerSnoId { get { return Field<int>(0x34); } }
	public int[] x38_Array { get { return Field<int>(0x38, 16); } }
}
