public class UIStyle : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x290; // 656

	public UIStyle(ProcessMemory memory, int address)
		: base(memory, address) { }

	public long x000 { get { return Field<long>(0x000); } }
	public string x008 { get { return Field(0x008, 512); } }
	public DataElements x208 { get { return Field<DataElements>(0x208); } }
	public int x250 { get { return Field<int>(0x250); } }
	public SerializeData x254 { get { return Field<SerializeData>(0x254); } }
	public int x260_Count { get { return Field<int>(0x260); } }
	public UIStyleChildSpec[] x264_PtrArray { get { return Dereference<UIStyleChildSpec>(0x264, x260_Count); } }
}
