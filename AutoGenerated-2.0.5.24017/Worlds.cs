public class Worlds : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0xB8; // 184

	public Worlds(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x0C { get { return Field<int>(0x0C); } }
	public SerializeData x10 { get { return Field<SerializeData>(0x10); } }
	public int x18_Count { get { return Field<int>(0x18); } }
	public WorldServerData[] x1C_PtrArray { get { return Dereference<WorldServerData>(0x1C, x18_Count); } }
	public SerializeData x20 { get { return Field<SerializeData>(0x20); } }
	public int x28_Count { get { return Field<int>(0x28); } }
	public int[] x2C_PtrArray_MarkerSetSnoId { get { return Dereference<int>(0x2C, x28_Count); } }
	public Environment x60 { get { return Field<Environment>(0x60); } }
	public float xAC { get { return Field<float>(0xAC); } }
	public int xB0 { get { return Field<int>(0xB0); } }
	public float xB4 { get { return Field<float>(0xB4); } }
}
