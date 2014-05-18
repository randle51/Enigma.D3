public class EmitterParams : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x118; // 280

	public EmitterParams(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x000 { get { return Field<int>(0x000); } }
	public FloatPath x008 { get { return Field<FloatPath>(0x008); } }
	public FloatPath x038 { get { return Field<FloatPath>(0x038); } }
	public VectorPath x068 { get { return Field<VectorPath>(0x068); } }
	public string x098 { get { return Field(0x098, 128); } }
}
