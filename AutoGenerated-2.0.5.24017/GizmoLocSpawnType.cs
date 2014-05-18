public class GizmoLocSpawnType : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x10; // 16

	public GizmoLocSpawnType(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x00_Count { get { return Field<int>(0x00); } }
	public GizmoLocSpawnEntry[] x04_PtrArray { get { return Dereference<GizmoLocSpawnEntry>(0x04, x00_Count); } }
	public SerializeData x08 { get { return Field<SerializeData>(0x08); } }
}
