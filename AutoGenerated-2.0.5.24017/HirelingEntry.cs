public class HirelingEntry : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x368; // 872

	public HirelingEntry(ProcessMemory memory, int address)
		: base(memory, address) { }

	public string x000 { get { return Field(0x000, 256); } }
	public int x100 { get { return Field<int>(0x100); } }
	public int x104 { get { return Field<int>(0x104); } }
	public int x108_ActorSnoId { get { return Field<int>(0x108); } }
	public int x10C_ActorSnoId { get { return Field<int>(0x10C); } }
	public int x110_ActorSnoId { get { return Field<int>(0x110); } }
	public int x114_TreasureClassSnoId { get { return Field<int>(0x114); } }
	public int x118_Enum { get { return Field<int>(0x118); } } // -1: None, 0: Strength, 1: Dexterity, 2: Intelligence
	public float x1BC { get { return Field<float>(0x1BC); } }
	public float x1C0 { get { return Field<float>(0x1C0); } }
	public float x1C4 { get { return Field<float>(0x1C4); } }
	public float x2E0 { get { return Field<float>(0x2E0); } }
	public float x2FC { get { return Field<float>(0x2FC); } }
	public float x300 { get { return Field<float>(0x300); } }
	public float x304 { get { return Field<float>(0x304); } }
	public float x308 { get { return Field<float>(0x308); } }
	public float x314 { get { return Field<float>(0x314); } }
	public float x318 { get { return Field<float>(0x318); } }
	public float x31C { get { return Field<float>(0x31C); } }
	public int x364 { get { return Field<int>(0x364); } }
}
