public class Shaders : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x128; // 296

	public Shaders(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x00C { get { return Field<int>(0x00C); } }
	public int x010 { get { return Field<int>(0x010); } }
	public int x014 { get { return Field<int>(0x014); } }
	public SerializeData x018 { get { return Field<SerializeData>(0x018); } }
	public int x020_Count { get { return Field<int>(0x020); } }
	public RenderPass[] x024_PtrArray { get { return Dereference<RenderPass>(0x024, x020_Count); } }
	public string x028 { get { return Field(0x028, 256); } }
}
