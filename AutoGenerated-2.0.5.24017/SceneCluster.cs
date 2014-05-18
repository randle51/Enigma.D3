public class SceneCluster : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0xB8; // 184

	public SceneCluster(ProcessMemory memory, int address)
		: base(memory, address) { }

	public string x00 { get { return Field(0x00, 128); } }
	public int x80 { get { return Field<int>(0x80); } }
	public int x84 { get { return Field<int>(0x84); } }
	public int x88_Count { get { return Field<int>(0x88); } }
	public SubSceneGroup[] x8C_PtrArray { get { return Dereference<SubSceneGroup>(0x8C, x88_Count); } }
	public SerializeData x90 { get { return Field<SerializeData>(0x90); } }
	public SubSceneGroup x98 { get { return Field<SubSceneGroup>(0x98); } }
}
