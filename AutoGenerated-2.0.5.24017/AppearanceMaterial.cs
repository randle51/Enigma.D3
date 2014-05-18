public class AppearanceMaterial : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x90; // 144

	public AppearanceMaterial(ProcessMemory memory, int address)
		: base(memory, address) { }

	public string x00 { get { return Field(0x00, 128); } }
	public SerializeData x80 { get { return Field<SerializeData>(0x80); } }
	public int x88_Count { get { return Field<int>(0x88); } }
	public SubObjectAppearance[] x8C_PtrArray { get { return Dereference<SubObjectAppearance>(0x8C, x88_Count); } }
}
