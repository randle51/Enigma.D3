public class SceneSpecification : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0xDC; // 220

	public SceneSpecification(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x00 { get { return Field<int>(0x00); } }
	public IVector2D x04 { get { return Field<IVector2D>(0x04); } }
	public int[] x0C_Array_LevelAreaSnoId { get { return Field<int>(0x0C, 4); } }
	public int x1C_WorldsSnoId { get { return Field<int>(0x1C); } }
	public int x20 { get { return Field<int>(0x20); } }
	public int x24_LevelAreaSnoId { get { return Field<int>(0x24); } }
	public int x28_WorldsSnoId { get { return Field<int>(0x28); } }
	public int x2C { get { return Field<int>(0x2C); } }
	public int x30_LevelAreaSnoId { get { return Field<int>(0x30); } }
	public int x34_MusicSnoId { get { return Field<int>(0x34); } }
	public int x38_AmbientSoundSnoId { get { return Field<int>(0x38); } }
	public int x3C_ReverbSnoId { get { return Field<int>(0x3C); } }
	public int x40_WeatherSnoId { get { return Field<int>(0x40); } }
	public int x44_WorldsSnoId { get { return Field<int>(0x44); } }
	public int x48 { get { return Field<int>(0x48); } }
	public int x4C { get { return Field<int>(0x4C); } }
	public int x50 { get { return Field<int>(0x50); } }
	public int x88 { get { return Field<int>(0x88); } }
	public SceneCachedValues x8C { get { return Field<SceneCachedValues>(0x8C); } }
}
