public class RandomAmbientSoundParams : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x14; // 20

	public RandomAmbientSoundParams(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x00_SoundSnoId { get { return Field<int>(0x00); } }
	public float x04 { get { return Field<float>(0x04); } }
	public float x08 { get { return Field<float>(0x08); } }
	public DT_TIME x0C { get { return Field<DT_TIME>(0x0C); } }
	public DT_TIME x10 { get { return Field<DT_TIME>(0x10); } }
}
