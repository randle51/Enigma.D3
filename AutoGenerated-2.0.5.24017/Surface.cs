public class Surface : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x28; // 40

	public Surface(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x0C { get { return Field<int>(0x0C); } }
	public int x10_ParticleSnoId { get { return Field<int>(0x10); } }
	public int x14 { get { return Field<int>(0x14); } }
	public SerializeData x18 { get { return Field<SerializeData>(0x18); } }
	public DT_TAGMAP x20 { get { return Field<DT_TAGMAP>(0x20); } }
}
