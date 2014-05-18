public class RenderParams : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x60; // 96

	public RenderParams(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x00 { get { return Field<int>(0x00); } }
	public int x04 { get { return Field<int>(0x04); } }
	public int x08 { get { return Field<int>(0x08); } }
	public float x0C { get { return Field<float>(0x0C); } }
	public float x10 { get { return Field<float>(0x10); } }
	public int x14 { get { return Field<int>(0x14); } }
	public int x18 { get { return Field<int>(0x18); } }
	public int x1C { get { return Field<int>(0x1C); } }
	public int x20 { get { return Field<int>(0x20); } }
	public int x24 { get { return Field<int>(0x24); } }
	public int x28 { get { return Field<int>(0x28); } }
	public int x2C { get { return Field<int>(0x2C); } }
	public int x30 { get { return Field<int>(0x30); } }
	public byte x34 { get { return Field<byte>(0x34); } }
	public int x38 { get { return Field<int>(0x38); } }
	public int x3C { get { return Field<int>(0x3C); } }
	public int x40 { get { return Field<int>(0x40); } }
	public int x44 { get { return Field<int>(0x44); } }
	public int x48 { get { return Field<int>(0x48); } }
	public int x4C { get { return Field<int>(0x4C); } }
	public int x50 { get { return Field<int>(0x50); } }
	public int x54 { get { return Field<int>(0x54); } }
	public int x58 { get { return Field<int>(0x58); } }
	public RGBAColor x5C { get { return Field<RGBAColor>(0x5C); } }
}
