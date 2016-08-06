using System.Runtime.CompilerServices;
using Enigma.D3.DataTypes;
using Enigma.Memory;

namespace Enigma.D3.Assets
{
	[CompilerGenerated]
	public partial class AnimTree : SerializeMemoryObject
	{
		public const int SizeOf = 0x60; // 96
		
		public SNOHeader x00_Header { get { return Read<SNOHeader>(0x00); } }
		public int x0C { get { return Read<int>(0x0C); } }
		public int x10 { get { return Read<int>(0x10); } }
		public int x14 { get { return Read<int>(0x14); } }
		public SerializeData x18_SerializeData { get { return Read<SerializeData>(0x18); } }
		public AnimTreeLeaf[] x20_AnimTreeLeafs { get { return Deserialize<AnimTreeLeaf>(x18_SerializeData); } }
		public int x28 { get { return Read<int>(0x28); } }
		public SerializeData x2C_SerializeData { get { return Read<SerializeData>(0x2C); } }
		public AnimTreeNode[] x38_AnimTreeNodes { get { return Deserialize<AnimTreeNode>(x2C_SerializeData); } }
		public int x40 { get { return Read<int>(0x40); } }
		public SerializeData x44_SerializeData { get { return Read<SerializeData>(0x44); } }
		public int[] x50_int { get { return Deserialize<int>(x44_SerializeData); } }
		public int x58 { get { return Read<int>(0x58); } }
		
		[CompilerGenerated]
		public partial class AnimTreeLeaf : MemoryObject
		{
			public const int SizeOf = 0x24; // 36
			
			public int x00_Enum { get { return Read<int>(0x00); } } // Animation = 0, PiecewiseLinearBlend = 1, BoneWeightedBlend = 2, SwitchBlend = 3, Pose = 4, AdditiveBlend = 5, BoneWeightsLinearBlend = 6, BoneWeightsMultiplyBlend = 7
			public SNO x04_AnimSNO { get { return Read<SNO>(0x04); } }
			public int x08 { get { return Read<int>(0x08); } }
			public float x0C { get { return Read<float>(0x0C); } }
			public float x10 { get { return Read<float>(0x10); } }
			public int x14 { get { return Read<int>(0x14); } }
			public int x18_Enum { get { return Read<int>(0x18); } } // Continuous = 0, InactiveReset = 1
			public int x1C_Enum { get { return Read<int>(0x1C); } } // Action = 0, GetHit = 1, None = 16
			public AnimTreeLayerName x20_AnimTreeLayerName { get { return Read<AnimTreeLayerName>(0x20); } }
		}
		
		[CompilerGenerated]
		public partial class AnimTreeNode : MemoryObject
		{
			public const int SizeOf = 0x12C; // 300
			
			public int x000_Enum { get { return Read<int>(0x000); } } // Animation = 0, PiecewiseLinearBlend = 1, BoneWeightedBlend = 2, SwitchBlend = 3, Pose = 4, AdditiveBlend = 5, BoneWeightsLinearBlend = 6, BoneWeightsMultiplyBlend = 7
			public int x004 { get { return Read<int>(0x004); } }
			public int[] x008_int { get { return Read<int>(0x008, 16); } }
			public int x048_Enum { get { return Read<int>(0x048); } } // ForwardSpeed = 0, TurnSpeed = 1, IsIdle = 2, WeaponClass = 3, WalkSlowSpeed = 4, WalkSpeed = 5, RunSpeed = 6, SprintSpeed = 7, InTown = 8, IsSpecialMove = 9, AbsTurnSpeed = 10, AimYaw = 11, AimBlend = 12, IsAlive = 13, IsTurning = 14, None = 16
			public AnimTreeBlendCase[] x04C_AnimTreeBlendCases { get { return Read<AnimTreeBlendCase>(0x04C, 16); } }
			public AnimTreeBlendRamp x10C_AnimTreeBlendRamp { get { return Read<AnimTreeBlendRamp>(0x10C); } }
			public int x124 { get { return Read<int>(0x124); } }
			public AnimTreeLayerName x128_AnimTreeLayerName { get { return Read<AnimTreeLayerName>(0x128); } }
		}
		
		[CompilerGenerated]
		public partial class AnimTreeLayerName : MemoryObject
		{
			public const int SizeOf = 0x04; // 4
			
			public int x00 { get { return Read<int>(0x00); } }
		}
		
		[CompilerGenerated]
		public partial class AnimTreeBlendCase : MemoryObject
		{
			public const int SizeOf = 0x0C; // 12
			
			public int x00_Enum { get { return Read<int>(0x00); } } // ForwardSpeed = 0, TurnSpeed = 1, IsIdle = 2, WeaponClass = 3, WalkSlowSpeed = 4, WalkSpeed = 5, RunSpeed = 6, SprintSpeed = 7, InTown = 8, IsSpecialMove = 9, AbsTurnSpeed = 10, AimYaw = 11, AimBlend = 12, IsAlive = 13, IsTurning = 14, None = 16
			public int x04 { get { return Read<int>(0x04); } }
			public float x08 { get { return Read<float>(0x08); } }
		}
		
		[CompilerGenerated]
		public partial class AnimTreeBlendRamp : MemoryObject
		{
			public const int SizeOf = 0x18; // 24
			
			public float x00 { get { return Read<float>(0x00); } }
			public float x04 { get { return Read<float>(0x04); } }
			public float x08 { get { return Read<float>(0x08); } }
			public float x0C { get { return Read<float>(0x0C); } }
			public float x10 { get { return Read<float>(0x10); } }
			public float x14 { get { return Read<float>(0x14); } }
		}
	}
}
