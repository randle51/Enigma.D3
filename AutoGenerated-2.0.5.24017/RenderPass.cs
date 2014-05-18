public class RenderPass : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x238; // 568

	public RenderPass(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x000 { get { return Field<int>(0x000); } }
	public int x004 { get { return Field<int>(0x004); } }
	public RenderParams x008 { get { return Field<RenderParams>(0x008); } }
	public int x068 { get { return Field<int>(0x068); } }
	public int x06C { get { return Field<int>(0x06C); } }
	public SerializeData x070 { get { return Field<SerializeData>(0x070); } }
	public int x078_Count { get { return Field<int>(0x078); } }
	public TextureStageParams[] x07C_PtrArray { get { return Dereference<TextureStageParams>(0x07C, x078_Count); } }
	public int x080 { get { return Field<int>(0x080); } }
	public string x084 { get { return Field(0x084, 256); } }
	public string x184 { get { return Field(0x184, 64); } }
	public string x1C4 { get { return Field(0x1C4, 64); } }
	public SerializeData x204 { get { return Field<SerializeData>(0x204); } }
	public DT_TAGMAP x210 { get { return Field<DT_TAGMAP>(0x210); } }
	public int x230 { get { return Field<int>(0x230); } }
	public int x234 { get { return Field<int>(0x234); } }
}
