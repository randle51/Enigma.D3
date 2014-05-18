public class AmbientSound : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x9C; // 156

	public AmbientSound(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x0C { get { return Field<int>(0x0C); } }
	public int x10_SoundSnoId { get { return Field<int>(0x10); } }
	public RandomAmbientSoundParams[] x14_Array { get { return Field<RandomAmbientSoundParams>(0x14, 2); } }
	public int x3C_SoundSnoId { get { return Field<int>(0x3C); } }
	public DT_TIME x40 { get { return Field<DT_TIME>(0x40); } }
	public DT_TIME x44 { get { return Field<DT_TIME>(0x44); } }
	public string x48 { get { return Field(0x48, 64); } }
	public float x88 { get { return Field<float>(0x88); } }
	public float x8C { get { return Field<float>(0x8C); } }
	public float x90 { get { return Field<float>(0x90); } }
	public float x94 { get { return Field<float>(0x94); } }
	public float x98 { get { return Field<float>(0x98); } }
}
