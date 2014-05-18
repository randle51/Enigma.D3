public class UIControlAnimationBinding : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x208; // 520

	public UIControlAnimationBinding(ProcessMemory memory, int address)
		: base(memory, address) { }

	public string x000 { get { return Field(0x000, 512); } }
	public int x200 { get { return Field<int>(0x200); } }
	public float x204 { get { return Field<float>(0x204); } }
}
