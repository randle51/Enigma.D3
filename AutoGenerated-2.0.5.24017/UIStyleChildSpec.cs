public class UIStyleChildSpec : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x260; // 608

	public UIStyleChildSpec(ProcessMemory memory, int address)
		: base(memory, address) { }

	public string x000 { get { return Field(0x000, 512); } }
	public DataElements x200 { get { return Field<DataElements>(0x200); } }
}
