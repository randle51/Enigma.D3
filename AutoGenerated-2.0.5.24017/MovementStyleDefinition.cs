public class MovementStyleDefinition : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x188; // 392

	public MovementStyleDefinition(ProcessMemory memory, int address)
		: base(memory, address) { }

	public string x000 { get { return Field(0x000, 256); } }
	public int x100 { get { return Field<int>(0x100); } }
	public int x104 { get { return Field<int>(0x104); } }
	public int x108 { get { return Field<int>(0x108); } }
	public int x10C { get { return Field<int>(0x10C); } }
	public int x110 { get { return Field<int>(0x110); } }
	public int x114 { get { return Field<int>(0x114); } }
	public int x118 { get { return Field<int>(0x118); } }
	public int x11C { get { return Field<int>(0x11C); } }
	public int x120 { get { return Field<int>(0x120); } }
	public int x124 { get { return Field<int>(0x124); } }
	public float x128 { get { return Field<float>(0x128); } }
	public float x12C { get { return Field<float>(0x12C); } }
	public float x130 { get { return Field<float>(0x130); } }
	public float x134 { get { return Field<float>(0x134); } }
	public float x138 { get { return Field<float>(0x138); } }
	public float x13C { get { return Field<float>(0x13C); } }
	public float x140 { get { return Field<float>(0x140); } }
	public float x144 { get { return Field<float>(0x144); } }
	public float x148 { get { return Field<float>(0x148); } }
	public float x14C { get { return Field<float>(0x14C); } }
	public float x150 { get { return Field<float>(0x150); } }
	public float x154 { get { return Field<float>(0x154); } }
	public float x158 { get { return Field<float>(0x158); } }
	public float x15C { get { return Field<float>(0x15C); } }
	public float x160 { get { return Field<float>(0x160); } }
	public float x164 { get { return Field<float>(0x164); } }
	public float x168 { get { return Field<float>(0x168); } }
	public float x16C { get { return Field<float>(0x16C); } }
	public float x170 { get { return Field<float>(0x170); } }
	public float x174 { get { return Field<float>(0x174); } }
	public float x178 { get { return Field<float>(0x178); } }
	public float x17C { get { return Field<float>(0x17C); } }
	public int x180_PowerSnoId { get { return Field<int>(0x180); } }
	public int x184 { get { return Field<int>(0x184); } }
}
