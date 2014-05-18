public class AnimSetTagMap : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x10; // 16

	public AnimSetTagMap(ProcessMemory memory, int address)
		: base(memory, address) { }

	public SerializeData x00 { get { return Field<SerializeData>(0x00); } }
	public DT_TAGMAP x08 { get { return Field<DT_TAGMAP>(0x08); } }
}
