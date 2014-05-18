public class SceneCachedValues : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x50; // 80

	public SceneCachedValues(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x00 { get { return Field<int>(0x00); } }
	public int x04 { get { return Field<int>(0x04); } }
	public int x08 { get { return Field<int>(0x08); } }
	public AABB x0C { get { return Field<AABB>(0x0C); } }
	public AABB x24 { get { return Field<AABB>(0x24); } }
	public int[] x3C_Array { get { return Field<int>(0x3C, 4); } }
	public int x4C { get { return Field<int>(0x4C); } }
}
