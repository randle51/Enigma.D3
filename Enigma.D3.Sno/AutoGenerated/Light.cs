using System.Runtime.CompilerServices;
using Enigma.D3.Collections;
using Enigma.D3.Memory;
using Enigma.Memory;

namespace Enigma.D3.Sno
{
	[CompilerGenerated]
	public partial class Light : SerializeMemoryObject
	{
		// 2.1.1.27255
		public const int SizeOf = 0x5A0; // 1440
		
		public SnoHeader x000_Header { get { return Read<SnoHeader>(0x000); } }
		public int x00C { get { return Read<int>(0x00C); } }
		public int x010 { get { return Read<int>(0x010); } }
		public int x014 { get { return Read<int>(0x014); } }
		public MaterialTexture x018_MaterialTexture { get { return Read<MaterialTexture>(0x018); } }
		public Time x0B0_Time { get { return Read<Time>(0x0B0); } }
		public int x0B4 { get { return Read<int>(0x0B4); } }
		public float x0B8 { get { return Read<float>(0x0B8); } }
		public LightStateParams x0C0_LightStateParams { get { return Read<LightStateParams>(0x0C0); } }
		public LightStateParams x330_LightStateParams { get { return Read<LightStateParams>(0x330); } }
		
		[CompilerGenerated]
		public partial class MaterialTexture : MemoryObject
		{
			// 2.1.1.27255
			public const int SizeOf = 0x98; // 152
			
			public Sno x00_TexturesSno { get { return Read<Sno>(0x00); } }
			public TexAnimParams x04_TexAnimParams { get { return Read<TexAnimParams>(0x04); } }
			public int x94 { get { return Read<int>(0x94); } }
		}
		
		[CompilerGenerated]
		public partial class LightStateParams : SerializeMemoryObject
		{
			// 2.1.1.27255
			public const int SizeOf = 0x270; // 624
			
			public FloatPath x000_FloatPath { get { return Read<FloatPath>(0x000); } }
			public FloatPath x030_FloatPath { get { return Read<FloatPath>(0x030); } }
			public FloatPath[] x060_FloatPaths { get { return Read<FloatPath>(0x060, 3); } }
			public AnglePath x0F0_AnglePath { get { return Read<AnglePath>(0x0F0); } }
			public AnglePath x120_AnglePath { get { return Read<AnglePath>(0x120); } }
			public ColorPath x150_ColorPath { get { return Read<ColorPath>(0x150); } }
			public FloatPath x180_FloatPath { get { return Read<FloatPath>(0x180); } }
			public ColorPath x1B0_ColorPath { get { return Read<ColorPath>(0x1B0); } }
			public FloatPath x1E0_FloatPath { get { return Read<FloatPath>(0x1E0); } }
			public ColorPath x210_ColorPath { get { return Read<ColorPath>(0x210); } }
			public FloatPath x240_FloatPath { get { return Read<FloatPath>(0x240); } }
		}
		
		[CompilerGenerated]
		public partial class TexAnimParams : MemoryObject
		{
			// 2.1.1.27255
			public const int SizeOf = 0x90; // 144
			
			public int x00 { get { return Read<int>(0x00); } }
			public Matrix4x4 x04_Matrix4x4 { get { return Read<Matrix4x4>(0x04); } }
			public float x44 { get { return Read<float>(0x44); } }
			public Velocity x48_Velocity { get { return Read<Velocity>(0x48); } }
			public Velocity x4C_Velocity { get { return Read<Velocity>(0x4C); } }
			public float x50 { get { return Read<float>(0x50); } }
			public Velocity x54_Velocity { get { return Read<Velocity>(0x54); } }
			public Velocity x58_Velocity { get { return Read<Velocity>(0x58); } }
			public Angle x5C_Angle { get { return Read<Angle>(0x5C); } }
			public AngularVelocity x60_AngularVelocity { get { return Read<AngularVelocity>(0x60); } }
			public AngularVelocity x64_AngularVelocity { get { return Read<AngularVelocity>(0x64); } }
			public int x68 { get { return Read<int>(0x68); } }
			public int x6C { get { return Read<int>(0x6C); } }
			public int x70 { get { return Read<int>(0x70); } }
			public int x74 { get { return Read<int>(0x74); } }
			public FrameAnim x78_FrameAnim { get { return Read<FrameAnim>(0x78); } }
			public int x8C { get { return Read<int>(0x8C); } }
		}
		
		[CompilerGenerated]
		public partial class FloatPath : SerializeMemoryObject
		{
			// 2.1.1.27255
			public const int SizeOf = 0x30; // 48
			
			public InterpolationPathHeader x00_InterpolationPathHeader { get { return Read<InterpolationPathHeader>(0x00); } }
			public FloatNode[] x20_FloatNodes { get { return Deserialize<FloatNode>(x28_SerializeData); } }
			public SerializeData x28_SerializeData { get { return Read<SerializeData>(0x28); } }
		}
		
		[CompilerGenerated]
		public partial class AnglePath : SerializeMemoryObject
		{
			// 2.1.1.27255
			public const int SizeOf = 0x30; // 48
			
			public InterpolationPathHeader x00_InterpolationPathHeader { get { return Read<InterpolationPathHeader>(0x00); } }
			public AngleNode[] x20_AngleNodes { get { return Deserialize<AngleNode>(x28_SerializeData); } }
			public SerializeData x28_SerializeData { get { return Read<SerializeData>(0x28); } }
		}
		
		[CompilerGenerated]
		public partial class ColorPath : SerializeMemoryObject
		{
			// 2.1.1.27255
			public const int SizeOf = 0x30; // 48
			
			public InterpolationPathHeader x00_InterpolationPathHeader { get { return Read<InterpolationPathHeader>(0x00); } }
			public ColorNode[] x20_ColorNodes { get { return Deserialize<ColorNode>(x28_SerializeData); } }
			public SerializeData x28_SerializeData { get { return Read<SerializeData>(0x28); } }
		}
		
		[CompilerGenerated]
		public partial class Matrix4x4 : MemoryObject
		{
			// 2.1.1.27255
			public const int SizeOf = 0x40; // 64
			
			public float x00 { get { return Read<float>(0x00); } }
			public float x04 { get { return Read<float>(0x04); } }
			public float x08 { get { return Read<float>(0x08); } }
			public float x0C { get { return Read<float>(0x0C); } }
			public float x10 { get { return Read<float>(0x10); } }
			public float x14 { get { return Read<float>(0x14); } }
			public float x18 { get { return Read<float>(0x18); } }
			public float x1C { get { return Read<float>(0x1C); } }
			public float x20 { get { return Read<float>(0x20); } }
			public float x24 { get { return Read<float>(0x24); } }
			public float x28 { get { return Read<float>(0x28); } }
			public float x2C { get { return Read<float>(0x2C); } }
			public float x30 { get { return Read<float>(0x30); } }
			public float x34 { get { return Read<float>(0x34); } }
			public float x38 { get { return Read<float>(0x38); } }
			public float x3C { get { return Read<float>(0x3C); } }
		}
		
		[CompilerGenerated]
		public partial class FrameAnim : MemoryObject
		{
			// 2.1.1.27255
			public const int SizeOf = 0x14; // 20
			
			public int x00 { get { return Read<int>(0x00); } }
			public Velocity x04_Velocity { get { return Read<Velocity>(0x04); } }
			public Velocity x08_Velocity { get { return Read<Velocity>(0x08); } }
			public int x0C { get { return Read<int>(0x0C); } }
			public int x10 { get { return Read<int>(0x10); } }
		}
		
		[CompilerGenerated]
		public partial class InterpolationPathHeader : MemoryObject
		{
			// 2.1.1.27255
			public const int SizeOf = 0x1C; // 28
			
			public int x00 { get { return Read<int>(0x00); } }
			public float x04 { get { return Read<float>(0x04); } }
			public float x08 { get { return Read<float>(0x08); } }
			public int x0C { get { return Read<int>(0x0C); } }
			public InterpolationScalar x10_InterpolationScalar { get { return Read<InterpolationScalar>(0x10); } }
		}
		
		[CompilerGenerated]
		public partial class FloatNode : MemoryObject
		{
			// 2.1.1.27255
			public const int SizeOf = 0x0C; // 12
			
			public float x00 { get { return Read<float>(0x00); } }
			public float x04 { get { return Read<float>(0x04); } }
			public float x08 { get { return Read<float>(0x08); } }
		}
		
		[CompilerGenerated]
		public partial class AngleNode : MemoryObject
		{
			// 2.1.1.27255
			public const int SizeOf = 0x0C; // 12
			
			public Angle x00_Angle { get { return Read<Angle>(0x00); } }
			public Angle x04_Angle { get { return Read<Angle>(0x04); } }
			public float x08 { get { return Read<float>(0x08); } }
		}
		
		[CompilerGenerated]
		public partial class ColorNode : MemoryObject
		{
			// 2.1.1.27255
			public const int SizeOf = 0x0C; // 12
			
			public RGBAColor x00_RGBAColor { get { return Read<RGBAColor>(0x00); } }
			public RGBAColor x04_RGBAColor { get { return Read<RGBAColor>(0x04); } }
			public float x08 { get { return Read<float>(0x08); } }
		}
		
		[CompilerGenerated]
		public partial class InterpolationScalar : MemoryObject
		{
			// 2.1.1.27255
			public const int SizeOf = 0x0C; // 12
			
			public int x00 { get { return Read<int>(0x00); } }
			public float x04 { get { return Read<float>(0x04); } }
			public float x08 { get { return Read<float>(0x08); } }
		}
		
		[CompilerGenerated]
		public partial class RGBAColor : MemoryObject
		{
			// 2.1.1.27255
			public const int SizeOf = 0x04; // 4
			
			public byte x00 { get { return Read<byte>(0x00); } }
			public byte x01 { get { return Read<byte>(0x01); } }
			public byte x02 { get { return Read<byte>(0x02); } }
			public byte x03 { get { return Read<byte>(0x03); } }
		}
	}
}
