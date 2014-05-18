public class GeoSet : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x18; // 24

	public GeoSet(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x00 { get { return Field<int>(0x00); } }
	public SerializeData x04 { get { return Field<SerializeData>(0x04); } }
	public int x10_Count { get { return Field<int>(0x10); } }
	public SubObject[] x14_PtrArray { get { return Dereference<SubObject>(0x14, x10_Count); } }
}
