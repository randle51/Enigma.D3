public class AnimTreeBlendCase : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x0C; // 12

	public AnimTreeBlendCase(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x00_Enum { get { return Field<int>(0x00); } } // 0: ForwardSpeed, 1: TurnSpeed, 2: IsIdle, 3: WeaponClass, 4: WalkSlowSpeed, 5: WalkSpeed, 6: RunSpeed, 7: SprintSpeed, 8: InTown, 9: IsSpecialMove, 10: AbsTurnSpeed, 11: AimYaw, 12: AimBlend, 13: IsAlive, 14: IsTurning, 16: None
	public int x04 { get { return Field<int>(0x04); } }
	public float x08 { get { return Field<float>(0x08); } }
}
