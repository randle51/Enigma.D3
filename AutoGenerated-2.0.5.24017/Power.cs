public class Power : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x460; // 1120

	public Power(ProcessMemory memory, int address)
		: base(memory, address) { }

	public string x00C { get { return Field(0x00C, 64); } }
	public PowerDef x050 { get { return Field<PowerDef>(0x050); } }
	public int x328 { get { return Field<int>(0x328); } }
	public int x32C { get { return Field<int>(0x32C); } }
	public string x330 { get { return Field(0x330, 256); } }
	public SerializeData x430 { get { return Field<SerializeData>(0x430); } }
	public int x438_Count { get { return Field<int>(0x438); } }
	public ScriptFormulaDetails[] x43C_PtrArray { get { return Dereference<ScriptFormulaDetails>(0x43C, x438_Count); } }
	public int x440 { get { return Field<int>(0x440); } }
	public int x448_Count { get { return Field<int>(0x448); } }
	public byte[] x44C_PtrArray { get { return Dereference<byte>(0x44C, x448_Count); } }
	public SerializeData x450 { get { return Field<SerializeData>(0x450); } }
	public int x458_QuestSnoId { get { return Field<int>(0x458); } }
}
