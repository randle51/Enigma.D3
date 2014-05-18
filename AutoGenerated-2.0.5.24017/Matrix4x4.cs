public class Matrix4x4 : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x40; // 64

	public Matrix4x4(ProcessMemory memory, int address)
		: base(memory, address) { }

	public float x00 { get { return Field<float>(0x00); } }
	public float x04 { get { return Field<float>(0x04); } }
	public float x08 { get { return Field<float>(0x08); } }
	public float x0C { get { return Field<float>(0x0C); } }
	public float x10 { get { return Field<float>(0x10); } }
	public float x14 { get { return Field<float>(0x14); } }
	public float x18 { get { return Field<float>(0x18); } }
	public float x1C { get { return Field<float>(0x1C); } }
	public float x20 { get { return Field<float>(0x20); } }
	public float x24 { get { return Field<float>(0x24); } }
	public float x28 { get { return Field<float>(0x28); } }
	public float x2C { get { return Field<float>(0x2C); } }
	public float x30 { get { return Field<float>(0x30); } }
	public float x34 { get { return Field<float>(0x34); } }
	public float x38 { get { return Field<float>(0x38); } }
	public float x3C { get { return Field<float>(0x3C); } }
}
