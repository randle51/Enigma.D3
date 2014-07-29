using System.Runtime.CompilerServices;
using Enigma.D3.Collections;
using Enigma.D3.Memory;

namespace Enigma.D3.Sno
{
	[CompilerGenerated]
	public partial class Shakes : SerializeMemoryObject
	{
		// 2.0.6.24641
		public const int SizeOf = 0x1A0; // 416
		
		public int x00C { get { return Field<int>(0x00C); } }
		public Time x010_Time { get { return Field<Time>(0x010); } }
		public Time x014_Time { get { return Field<Time>(0x014); } }
		public float x018 { get { return Field<float>(0x018); } }
		public float x01C { get { return Field<float>(0x01C); } }
		public VectorPath x020_VectorPath { get { return Field<VectorPath>(0x020); } }
		public VectorPath x050_VectorPath { get { return Field<VectorPath>(0x050); } }
		public AnglePath x080_AnglePath { get { return Field<AnglePath>(0x080); } }
		public FloatPath x0B0_FloatPath { get { return Field<FloatPath>(0x0B0); } }
		public AnglePath x0E0_AnglePath { get { return Field<AnglePath>(0x0E0); } }
		public FloatPath x110_FloatPath { get { return Field<FloatPath>(0x110); } }
		public AnglePath x140_AnglePath { get { return Field<AnglePath>(0x140); } }
		public FloatPath x170_FloatPath { get { return Field<FloatPath>(0x170); } }
		
		[CompilerGenerated]
		public partial class VectorPath : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x30; // 48
			
			public InterpolationPathHeader x00_InterpolationPathHeader { get { return Field<InterpolationPathHeader>(0x00); } }
			public VectorNode[] x20_VectorNodes { get { return Deserialize<VectorNode>(x28_SerializeData); } }
			public SerializeData x28_SerializeData { get { return Field<SerializeData>(0x28); } }
		}
		
		[CompilerGenerated]
		public partial class AnglePath : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x30; // 48
			
			public InterpolationPathHeader x00_InterpolationPathHeader { get { return Field<InterpolationPathHeader>(0x00); } }
			public AngleNode[] x20_AngleNodes { get { return Deserialize<AngleNode>(x28_SerializeData); } }
			public SerializeData x28_SerializeData { get { return Field<SerializeData>(0x28); } }
		}
		
		[CompilerGenerated]
		public partial class FloatPath : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x30; // 48
			
			public InterpolationPathHeader x00_InterpolationPathHeader { get { return Field<InterpolationPathHeader>(0x00); } }
			public FloatNode[] x20_FloatNodes { get { return Deserialize<FloatNode>(x28_SerializeData); } }
			public SerializeData x28_SerializeData { get { return Field<SerializeData>(0x28); } }
		}
		
		[CompilerGenerated]
		public partial class InterpolationPathHeader : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x1C; // 28
			
			public int x00 { get { return Field<int>(0x00); } }
			public float x04 { get { return Field<float>(0x04); } }
			public float x08 { get { return Field<float>(0x08); } }
			public int x0C { get { return Field<int>(0x0C); } }
			public InterpolationScalar x10_InterpolationScalar { get { return Field<InterpolationScalar>(0x10); } }
		}
		
		[CompilerGenerated]
		public partial class VectorNode : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x1C; // 28
			
			public Vector3D x00_Vector3D { get { return Field<Vector3D>(0x00); } }
			public Vector3D x0C_Vector3D { get { return Field<Vector3D>(0x0C); } }
			public float x18 { get { return Field<float>(0x18); } }
		}
		
		[CompilerGenerated]
		public partial class AngleNode : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0xC; // 12
			
			public Angle x00_Angle { get { return Field<Angle>(0x00); } }
			public Angle x04_Angle { get { return Field<Angle>(0x04); } }
			public float x08 { get { return Field<float>(0x08); } }
		}
		
		[CompilerGenerated]
		public partial class FloatNode : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0xC; // 12
			
			public float x00 { get { return Field<float>(0x00); } }
			public float x04 { get { return Field<float>(0x04); } }
			public float x08 { get { return Field<float>(0x08); } }
		}
		
		[CompilerGenerated]
		public partial class InterpolationScalar : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0xC; // 12
			
			public int x00 { get { return Field<int>(0x00); } }
			public float x04 { get { return Field<float>(0x04); } }
			public float x08 { get { return Field<float>(0x08); } }
		}
		
		[CompilerGenerated]
		public partial class Vector3D : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0xC; // 12
			
			public float x00 { get { return Field<float>(0x00); } }
			public float x04 { get { return Field<float>(0x04); } }
			public float x08 { get { return Field<float>(0x08); } }
		}
	}
}
