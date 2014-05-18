public class NavMeshDef : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x28; // 40

	public NavMeshDef(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x00 { get { return Field<int>(0x00); } }
	public int x04 { get { return Field<int>(0x04); } }
	public int x08 { get { return Field<int>(0x08); } }
	public int x0C { get { return Field<int>(0x0C); } }
	public float x10 { get { return Field<float>(0x10); } }
	public SerializeData x14 { get { return Field<SerializeData>(0x14); } }
	public int x1C { get { return Field<int>(0x1C); } }
	public int x20_Count { get { return Field<int>(0x20); } }
	public NavMeshSquare[] x24_PtrArray { get { return Dereference<NavMeshSquare>(0x24, x20_Count); } }
}
