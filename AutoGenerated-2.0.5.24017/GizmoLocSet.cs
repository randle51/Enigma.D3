public class GizmoLocSet : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x340; // 832

	public GizmoLocSet(ProcessMemory memory, int address)
		: base(memory, address) { }

	public GizmoLocSpawnType[] x000_Array { get { return Field<GizmoLocSpawnType>(0x000, 52); } }
}
