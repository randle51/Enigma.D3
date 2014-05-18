public class Music : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x50; // 80

	public Music(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x0C { get { return Field<int>(0x0C); } }
	public float x10 { get { return Field<float>(0x10); } }
	public DT_TIME x14 { get { return Field<DT_TIME>(0x14); } }
	public DT_TIME x18 { get { return Field<DT_TIME>(0x18); } }
	public SerializeData x1C { get { return Field<SerializeData>(0x1C); } }
	public int x24 { get { return Field<int>(0x24); } }
	public int x28_Count { get { return Field<int>(0x28); } }
	public PlaylistEntry[] x2C_PtrArray { get { return Dereference<PlaylistEntry>(0x2C, x28_Count); } }
	public RandomMusicSoundParams[] x30_Array { get { return Field<RandomMusicSoundParams>(0x30, 2); } }
}
