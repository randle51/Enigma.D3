public class Environment : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x4C; // 76

	public Environment(ProcessMemory memory, int address)
		: base(memory, address) { }

	public RGBAColor x00 { get { return Field<RGBAColor>(0x00); } }
	public PostFXParams x04 { get { return Field<PostFXParams>(0x04); } }
	public int x24_ActorSnoId { get { return Field<int>(0x24); } }
	public int x28_MusicSnoId { get { return Field<int>(0x28); } }
	public int x2C_MusicSnoId { get { return Field<int>(0x2C); } }
	public float x30 { get { return Field<float>(0x30); } }
	public float x34 { get { return Field<float>(0x34); } }
	public int x38_AmbientSoundSnoId { get { return Field<int>(0x38); } }
	public int x3C_ReverbSnoId { get { return Field<int>(0x3C); } }
	public int x40_WeatherSnoId { get { return Field<int>(0x40); } }
	public int x44_TexturesSnoId { get { return Field<int>(0x44); } }
	public int x48_TexturesSnoId { get { return Field<int>(0x48); } }
}
