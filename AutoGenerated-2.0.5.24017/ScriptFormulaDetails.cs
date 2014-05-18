public class ScriptFormulaDetails : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x308; // 776

	public ScriptFormulaDetails(ProcessMemory memory, int address)
		: base(memory, address) { }

	public string x000 { get { return Field(0x000, 256); } }
	public string x100 { get { return Field(0x100, 512); } }
	public int x300 { get { return Field<int>(0x300); } }
	public int x304 { get { return Field<int>(0x304); } }
}
