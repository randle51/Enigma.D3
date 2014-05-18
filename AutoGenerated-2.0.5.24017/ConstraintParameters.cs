public class ConstraintParameters : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x124; // 292

	public ConstraintParameters(ProcessMemory memory, int address)
		: base(memory, address) { }

	public string x000 { get { return Field(0x000, 64); } }
	public int x040 { get { return Field<int>(0x040); } }
	public int x044 { get { return Field<int>(0x044); } }
	public int x048 { get { return Field<int>(0x048); } }
	public int x04C { get { return Field<int>(0x04C); } }
	public PRTransform x050 { get { return Field<PRTransform>(0x050); } }
	public Vector3D x06C { get { return Field<Vector3D>(0x06C); } }
	public PRTransform x078 { get { return Field<PRTransform>(0x078); } }
	public PRTransform x094 { get { return Field<PRTransform>(0x094); } }
	public float x0B0 { get { return Field<float>(0x0B0); } }
	public float x0B4 { get { return Field<float>(0x0B4); } }
	public float x0B8 { get { return Field<float>(0x0B8); } }
	public float x0BC { get { return Field<float>(0x0BC); } }
	public float x0C0 { get { return Field<float>(0x0C0); } }
	public float x0C4 { get { return Field<float>(0x0C4); } }
	public float x0C8 { get { return Field<float>(0x0C8); } }
	public float x0CC { get { return Field<float>(0x0CC); } }
	public float x0D0 { get { return Field<float>(0x0D0); } }
	public float x0D4 { get { return Field<float>(0x0D4); } }
	public float x0D8 { get { return Field<float>(0x0D8); } }
	public float x0DC { get { return Field<float>(0x0DC); } }
	public float x0E0 { get { return Field<float>(0x0E0); } }
	public string x0E4 { get { return Field(0x0E4, 64); } }
}
