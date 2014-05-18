public class Reverb : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x68; // 104

	public Reverb(ProcessMemory memory, int address)
		: base(memory, address) { }

	public ReverbParams x0C { get { return Field<ReverbParams>(0x0C); } }
	public int x64 { get { return Field<int>(0x64); } }
}
