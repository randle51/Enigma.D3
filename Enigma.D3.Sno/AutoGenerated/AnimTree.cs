using System.Runtime.CompilerServices;
using Enigma.D3.Collections;
using Enigma.D3.Memory;

namespace Enigma.D3.Sno
{
	[CompilerGenerated]
	public partial class AnimTree : SerializeMemoryObject
	{
		// 2.0.6.24641
		public const int SizeOf = 0x60; // 96
		
		public int x0C { get { return Field<int>(0x0C); } }
		public int x10 { get { return Field<int>(0x10); } }
		public int x14 { get { return Field<int>(0x14); } }
		public SerializeData x18_SerializeData { get { return Field<SerializeData>(0x18); } }
		public AnimTreeLeaf[] x20_AnimTreeLeafs { get { return Deserialize<AnimTreeLeaf>(x18_SerializeData); } }
		public int x28 { get { return Field<int>(0x28); } }
		public SerializeData x2C_SerializeData { get { return Field<SerializeData>(0x2C); } }
		public AnimTreeNode[] x38_AnimTreeNodes { get { return Deserialize<AnimTreeNode>(x2C_SerializeData); } }
		public int x40 { get { return Field<int>(0x40); } }
		public SerializeData x44_SerializeData { get { return Field<SerializeData>(0x44); } }
		public int[] x50_int { get { return Deserialize<int>(x44_SerializeData); } }
		public int x58 { get { return Field<int>(0x58); } }
		
		[CompilerGenerated]
		public partial class AnimTreeLeaf : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x24; // 36
			
			public int x00_Enum { get { return Field<int>(0x00); } } // Animation = 0, PiecewiseLinearBlend = 1, BoneWeightedBlend = 2, SwitchBlend = 3, Pose = 4, AdditiveBlend = 5, BoneWeightsLinearBlend = 6, BoneWeightsMultiplyBlend = 7
			public Sno x04_AnimSno { get { return Field<Sno>(0x04); } }
			public int x08 { get { return Field<int>(0x08); } }
			public float x0C { get { return Field<float>(0x0C); } }
			public float x10 { get { return Field<float>(0x10); } }
			public int x14 { get { return Field<int>(0x14); } }
			public int x18_Enum { get { return Field<int>(0x18); } } // Continuous = 0, InactiveReset = 1
			public int x1C_Enum { get { return Field<int>(0x1C); } } // Action = 0, GetHit = 1, None = 16
			public AnimTreeLayerName x20_AnimTreeLayerName { get { return Field<AnimTreeLayerName>(0x20); } }
		}
		
		[CompilerGenerated]
		public partial class AnimTreeNode : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x12C; // 300
			
			public int x000_Enum { get { return Field<int>(0x000); } } // Animation = 0, PiecewiseLinearBlend = 1, BoneWeightedBlend = 2, SwitchBlend = 3, Pose = 4, AdditiveBlend = 5, BoneWeightsLinearBlend = 6, BoneWeightsMultiplyBlend = 7
			public int x004 { get { return Field<int>(0x004); } }
			public int[] x008_int { get { return Field<int>(0x008, 16); } }
			public int x048_Enum { get { return Field<int>(0x048); } } // ForwardSpeed = 0, TurnSpeed = 1, IsIdle = 2, WeaponClass = 3, WalkSlowSpeed = 4, WalkSpeed = 5, RunSpeed = 6, SprintSpeed = 7, InTown = 8, IsSpecialMove = 9, AbsTurnSpeed = 10, AimYaw = 11, AimBlend = 12, IsAlive = 13, IsTurning = 14, None = 16
			public AnimTreeBlendCase[] x04C_AnimTreeBlendCases { get { return Field<AnimTreeBlendCase>(0x04C, 16); } }
			public AnimTreeBlendRamp x10C_AnimTreeBlendRamp { get { return Field<AnimTreeBlendRamp>(0x10C); } }
			public int x124 { get { return Field<int>(0x124); } }
			public AnimTreeLayerName x128_AnimTreeLayerName { get { return Field<AnimTreeLayerName>(0x128); } }
		}
		
		[CompilerGenerated]
		public partial class AnimTreeLayerName : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x4; // 4
			
			public int x00 { get { return Field<int>(0x00); } }
		}
		
		[CompilerGenerated]
		public partial class AnimTreeBlendCase : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0xC; // 12
			
			public int x00_Enum { get { return Field<int>(0x00); } } // ForwardSpeed = 0, TurnSpeed = 1, IsIdle = 2, WeaponClass = 3, WalkSlowSpeed = 4, WalkSpeed = 5, RunSpeed = 6, SprintSpeed = 7, InTown = 8, IsSpecialMove = 9, AbsTurnSpeed = 10, AimYaw = 11, AimBlend = 12, IsAlive = 13, IsTurning = 14, None = 16
			public int x04 { get { return Field<int>(0x04); } }
			public float x08 { get { return Field<float>(0x08); } }
		}
		
		[CompilerGenerated]
		public partial class AnimTreeBlendRamp : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x18; // 24
			
			public float x00 { get { return Field<float>(0x00); } }
			public float x04 { get { return Field<float>(0x04); } }
			public float x08 { get { return Field<float>(0x08); } }
			public float x0C { get { return Field<float>(0x0C); } }
			public float x10 { get { return Field<float>(0x10); } }
			public float x14 { get { return Field<float>(0x14); } }
		}
	}
}
