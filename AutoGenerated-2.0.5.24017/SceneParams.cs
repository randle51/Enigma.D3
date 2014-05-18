public class SceneParams : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x18; // 24

	public SceneParams(ProcessMemory memory, int address)
		: base(memory, address) { }

	public SerializeData x00 { get { return Field<SerializeData>(0x00); } }
	public int x08 { get { return Field<int>(0x08); } }
	public int x10_Count { get { return Field<int>(0x10); } }
	public SceneChunk[] x14_PtrArray { get { return Dereference<SceneChunk>(0x14, x10_Count); } }
}
