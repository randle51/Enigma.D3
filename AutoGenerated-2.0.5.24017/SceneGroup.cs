public class SceneGroup : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x28; // 40

	public SceneGroup(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x0C { get { return Field<int>(0x0C); } }
	public SerializeData x10 { get { return Field<SerializeData>(0x10); } }
	public int x18_Count { get { return Field<int>(0x18); } }
	public SceneGroupItem[] x1C_PtrArray { get { return Dereference<SceneGroupItem>(0x1C, x18_Count); } }
	public int x20 { get { return Field<int>(0x20); } }
}
