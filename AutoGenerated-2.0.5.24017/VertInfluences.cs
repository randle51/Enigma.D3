public class VertInfluences : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x18; // 24

	public VertInfluences(ProcessMemory memory, int address)
		: base(memory, address) { }

	public Influence[] x00_Array { get { return Field<Influence>(0x00, 3); } }
}
