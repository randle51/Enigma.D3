public class GizmoLocSpawnEntry : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x28; // 40

	public GizmoLocSpawnEntry(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x00 { get { return Field<int>(0x00); } }
	public int x04 { get { return Field<int>(0x04); } }
	public int x08 { get { return Field<int>(0x08); } }
	public int x0C { get { return Field<int>(0x0C); } }
	public DT_HIGHPRECISIONPERCENT x10 { get { return Field<DT_HIGHPRECISIONPERCENT>(0x10); } }
	public int x14_ConditionSnoId { get { return Field<int>(0x14); } }
	public int x18_Count { get { return Field<int>(0x18); } }
	public GizmoLocSpawnChoice[] x1C_PtrArray { get { return Dereference<GizmoLocSpawnChoice>(0x1C, x18_Count); } }
	public SerializeData x20 { get { return Field<SerializeData>(0x20); } }
}
