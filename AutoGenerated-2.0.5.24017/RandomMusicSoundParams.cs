public class RandomMusicSoundParams : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x10; // 16

	public RandomMusicSoundParams(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x00_SoundSnoId { get { return Field<int>(0x00); } }
	public DT_TIME x04 { get { return Field<DT_TIME>(0x04); } }
	public DT_TIME x08 { get { return Field<DT_TIME>(0x08); } }
	public DT_TIME x0C { get { return Field<DT_TIME>(0x0C); } }
}
