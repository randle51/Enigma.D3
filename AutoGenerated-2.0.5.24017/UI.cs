public class UI : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0xB8; // 184

	public UI(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x0C { get { return Field<int>(0x0C); } }
	public int x10 { get { return Field<int>(0x10); } }
	public SerializeData x14 { get { return Field<SerializeData>(0x14); } }
	public int x20_Count { get { return Field<int>(0x20); } }
	public UIControlData[] x24_PtrArray { get { return Dereference<UIControlData>(0x24, x20_Count); } }
	public int x28 { get { return Field<int>(0x28); } }
	public SerializeData x2C { get { return Field<SerializeData>(0x2C); } }
	public int x38_Count { get { return Field<int>(0x38); } }
	public UIStyle[] x3C_PtrArray { get { return Dereference<UIStyle>(0x3C, x38_Count); } }
	public DataElements x40 { get { return Field<DataElements>(0x40); } }
}
