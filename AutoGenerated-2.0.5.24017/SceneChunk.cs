public class SceneChunk : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x100; // 256

	public SceneChunk(ProcessMemory memory, int address)
		: base(memory, address) { }

	public SNOName x000 { get { return Field<SNOName>(0x000); } }
	public PRTransform x008 { get { return Field<PRTransform>(0x008); } }
	public SceneSpecification x024 { get { return Field<SceneSpecification>(0x024); } }
}
