public class AnimSet : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x1E0; // 480

	public AnimSet(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x00C_AnimSetSnoId { get { return Field<int>(0x00C); } }
	public SerializeData x010 { get { return Field<SerializeData>(0x010); } }
	public DT_TAGMAP x018 { get { return Field<DT_TAGMAP>(0x018); } }
	public AnimSetTagMap[] x020_Array { get { return Field<AnimSetTagMap>(0x020, 28); } }
}
