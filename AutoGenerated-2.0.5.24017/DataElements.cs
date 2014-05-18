public class DataElements : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x48; // 72

	public DataElements(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x00 { get { return Field<int>(0x00); } }
	public SerializeData x04 { get { return Field<SerializeData>(0x04); } }
	public int x10_Count { get { return Field<int>(0x10); } }
	public UIControlElement[] x14_PtrArray { get { return Dereference<UIControlElement>(0x14, x10_Count); } }
	public int x18 { get { return Field<int>(0x18); } }
	public SerializeData x1C { get { return Field<SerializeData>(0x1C); } }
	public int x28_Count { get { return Field<int>(0x28); } }
	public UIDataElementInt32[] x2C_PtrArray { get { return Dereference<UIDataElementInt32>(0x2C, x28_Count); } }
	public int x30 { get { return Field<int>(0x30); } }
	public SerializeData x34 { get { return Field<SerializeData>(0x34); } }
	public int x40_Count { get { return Field<int>(0x40); } }
	public UIDataElementFloat32[] x44_PtrArray { get { return Dereference<UIDataElementFloat32>(0x44, x40_Count); } }
}
