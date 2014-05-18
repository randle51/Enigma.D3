public class UIAnimationElements : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x78; // 120

	public UIAnimationElements(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x00 { get { return Field<int>(0x00); } }
	public SerializeData x04 { get { return Field<SerializeData>(0x04); } }
	public int x10_Count { get { return Field<int>(0x10); } }
	public UIAnimationElementInt32[] x14_PtrArray { get { return Dereference<UIAnimationElementInt32>(0x14, x10_Count); } }
	public int x18 { get { return Field<int>(0x18); } }
	public SerializeData x1C { get { return Field<SerializeData>(0x1C); } }
	public int x28_Count { get { return Field<int>(0x28); } }
	public UIAnimationElementFloat[] x2C_PtrArray { get { return Dereference<UIAnimationElementFloat>(0x2C, x28_Count); } }
	public int x30 { get { return Field<int>(0x30); } }
	public SerializeData x34 { get { return Field<SerializeData>(0x34); } }
	public int x40_Count { get { return Field<int>(0x40); } }
	public UIAnimationElementVector2D[] x44_PtrArray { get { return Dereference<UIAnimationElementVector2D>(0x44, x40_Count); } }
	public int x48 { get { return Field<int>(0x48); } }
	public SerializeData x4C { get { return Field<SerializeData>(0x4C); } }
	public int x58_Count { get { return Field<int>(0x58); } }
	public UIAnimationDescription[] x5C_PtrArray { get { return Dereference<UIAnimationDescription>(0x5C, x58_Count); } }
	public int x60 { get { return Field<int>(0x60); } }
	public SerializeData x64 { get { return Field<SerializeData>(0x64); } }
	public int x70_Count { get { return Field<int>(0x70); } }
	public UIControlAnimationBinding[] x74_PtrArray { get { return Dereference<UIControlAnimationBinding>(0x74, x70_Count); } }
}
