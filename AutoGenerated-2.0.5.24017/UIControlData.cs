public class UIControlData : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x740; // 1856

	public UIControlData(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x000 { get { return Field<int>(0x000); } }
	public long x008 { get { return Field<long>(0x008); } }
	public string x010 { get { return Field(0x010, 512); } }
	public long x210 { get { return Field<long>(0x210); } }
	public string x218 { get { return Field(0x218, 512); } }
	public int x418 { get { return Field<int>(0x418); } }
	public UIStyle x420 { get { return Field<UIStyle>(0x420); } }
	public UIAnimationElements x6B0 { get { return Field<UIAnimationElements>(0x6B0); } }
}
