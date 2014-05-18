public class Textures : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x270; // 624

	public Textures(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x010 { get { return Field<int>(0x010); } }
	public int x014 { get { return Field<int>(0x014); } }
	public int x018 { get { return Field<int>(0x018); } }
	public int x01C { get { return Field<int>(0x01C); } }
	public int x020 { get { return Field<int>(0x020); } }
	public int x024 { get { return Field<int>(0x024); } }
	public SerializeData[] x028_Array { get { return Field<SerializeData>(0x028, 60); } }
	public int x208 { get { return Field<int>(0x208); } }
	public SerializeData x20C { get { return Field<SerializeData>(0x20C); } }
	public int x218_Count { get { return Field<int>(0x218); } }
	public TexFrame[] x21C_PtrArray { get { return Dereference<TexFrame>(0x21C, x218_Count); } }
	public IVector2D x220 { get { return Field<IVector2D>(0x220); } }
	public int x228 { get { return Field<int>(0x228); } }
	public int x22C { get { return Field<int>(0x22C); } }
	public int x230 { get { return Field<int>(0x230); } }
	public int x234 { get { return Field<int>(0x234); } }
	public long x238 { get { return Field<long>(0x238); } }
	public int x240 { get { return Field<int>(0x240); } }
	public int x248 { get { return Field<int>(0x248); } }
	public int x24C { get { return Field<int>(0x24C); } }
	public int x250_Count { get { return Field<int>(0x250); } }
	public ImageFileID[] x254_PtrArray { get { return Dereference<ImageFileID>(0x254, x250_Count); } }
	public SerializeData x258 { get { return Field<SerializeData>(0x258); } }
	public int x260 { get { return Field<int>(0x260); } }
	public int x264 { get { return Field<int>(0x264); } }
	public int x268 { get { return Field<int>(0x268); } }
}
