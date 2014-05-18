public class GizmoLocSpawnChoice : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x14; // 20

	public GizmoLocSpawnChoice(ProcessMemory memory, int address)
		: base(memory, address) { }

	public SNOName x00 { get { return Field<SNOName>(0x00); } }
	public int x08 { get { return Field<int>(0x08); } }
	public float x0C { get { return Field<float>(0x0C); } }
	public int x10 { get { return Field<int>(0x10); } }
}
