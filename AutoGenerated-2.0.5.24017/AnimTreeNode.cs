public class AnimTreeNode : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x12C; // 300

	public AnimTreeNode(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x000_Enum { get { return Field<int>(0x000); } } // 0: Animation, 1: PiecewiseLinearBlend, 2: BoneWeightedBlend, 3: SwitchBlend, 4: Pose, 5: AdditiveBlend, 6: BoneWeightsLinearBlend, 7: BoneWeightsMultiplyBlend
	public int x004 { get { return Field<int>(0x004); } }
	public int[] x008_Array { get { return Field<int>(0x008, 16); } }
	public int x048_Enum { get { return Field<int>(0x048); } } // 0: ForwardSpeed, 1: TurnSpeed, 2: IsIdle, 3: WeaponClass, 4: WalkSlowSpeed, 5: WalkSpeed, 6: RunSpeed, 7: SprintSpeed, 8: InTown, 9: IsSpecialMove, 10: AbsTurnSpeed, 11: AimYaw, 12: AimBlend, 13: IsAlive, 14: IsTurning, 16: None
	public AnimTreeBlendCase[] x04C_Array { get { return Field<AnimTreeBlendCase>(0x04C, 16); } }
	public AnimTreeBlendRamp x10C { get { return Field<AnimTreeBlendRamp>(0x10C); } }
	public int x124 { get { return Field<int>(0x124); } }
	public AnimTreeLayerName x128 { get { return Field<AnimTreeLayerName>(0x128); } }
}
