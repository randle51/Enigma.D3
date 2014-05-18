public class AnimTreeLeaf : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x24; // 36

	public AnimTreeLeaf(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x00_Enum { get { return Field<int>(0x00); } } // 0: Animation, 1: PiecewiseLinearBlend, 2: BoneWeightedBlend, 3: SwitchBlend, 4: Pose, 5: AdditiveBlend, 6: BoneWeightsLinearBlend, 7: BoneWeightsMultiplyBlend
	public int x04_AnimSnoId { get { return Field<int>(0x04); } }
	public int x08 { get { return Field<int>(0x08); } }
	public float x0C { get { return Field<float>(0x0C); } }
	public float x10 { get { return Field<float>(0x10); } }
	public int x14 { get { return Field<int>(0x14); } }
	public int x18_Enum { get { return Field<int>(0x18); } } // 0: Continuous, 1: InactiveReset
	public int x1C_Enum { get { return Field<int>(0x1C); } } // 0: Action, 1: GetHit, 16: None
	public AnimTreeLayerName x20 { get { return Field<AnimTreeLayerName>(0x20); } }
}
