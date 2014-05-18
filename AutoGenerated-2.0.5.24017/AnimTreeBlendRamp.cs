public class AnimTreeBlendRamp : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x18; // 24

	public AnimTreeBlendRamp(ProcessMemory memory, int address)
		: base(memory, address) { }

	public float x00 { get { return Field<float>(0x00); } }
	public float x04 { get { return Field<float>(0x04); } }
	public float x08 { get { return Field<float>(0x08); } }
	public float x0C { get { return Field<float>(0x0C); } }
	public float x10 { get { return Field<float>(0x10); } }
	public float x14 { get { return Field<float>(0x14); } }
}
