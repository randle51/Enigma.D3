public class EliteModifierData : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x160; // 352

	public EliteModifierData(ProcessMemory memory, int address)
		: base(memory, address) { }

	public string x000 { get { return Field(0x000, 256); } }
	public int x100 { get { return Field<int>(0x100); } }
	public int x104 { get { return Field<int>(0x104); } }
	public float x108 { get { return Field<float>(0x108); } }
	public DT_TIME x10C { get { return Field<DT_TIME>(0x10C); } }
	public float x110 { get { return Field<float>(0x110); } }
	public DT_TIME x114 { get { return Field<DT_TIME>(0x114); } }
	public float x118 { get { return Field<float>(0x118); } }
	public DT_TIME x11C { get { return Field<DT_TIME>(0x11C); } }
	public float x120 { get { return Field<float>(0x120); } }
	public DT_TIME x124 { get { return Field<DT_TIME>(0x124); } }
	public float x128 { get { return Field<float>(0x128); } }
	public DT_TIME x12C { get { return Field<DT_TIME>(0x12C); } }
	public float x130 { get { return Field<float>(0x130); } }
	public DT_TIME x134 { get { return Field<DT_TIME>(0x134); } }
	public float x138 { get { return Field<float>(0x138); } }
	public DT_TIME x13C { get { return Field<DT_TIME>(0x13C); } }
	public float x140 { get { return Field<float>(0x140); } }
	public float x144 { get { return Field<float>(0x144); } }
	public DT_TIME x148 { get { return Field<DT_TIME>(0x148); } }
	public float x14C { get { return Field<float>(0x14C); } }
	public float x150 { get { return Field<float>(0x150); } }
	public float x154 { get { return Field<float>(0x154); } }
	public float x158 { get { return Field<float>(0x158); } }
	public int x15C { get { return Field<int>(0x15C); } }
}
