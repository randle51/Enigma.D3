public class SNOName : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x08; // 8

	public SNOName(ProcessMemory memory, int address)
		: base(memory, address) { }

	public DT_SNO_GROUP x00 { get { return Field<DT_SNO_GROUP>(0x00); } }
	public DT_SNONAME_HANDLE x04 { get { return Field<DT_SNONAME_HANDLE>(0x04); } }
}
