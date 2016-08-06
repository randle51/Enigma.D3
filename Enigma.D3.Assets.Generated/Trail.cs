using System.Runtime.CompilerServices;
using Enigma.D3.DataTypes;
using Enigma.Memory;

namespace Enigma.D3.Assets
{
	[CompilerGenerated]
	public partial class Trail : SerializeMemoryObject
	{
		public const int SizeOf = 0x158; // 344
		
		public SNOHeader x000_Header { get { return Read<SNOHeader>(0x000); } }
		public int x00C { get { return Read<int>(0x00C); } }
		public int x010 { get { return Read<int>(0x010); } }
		public int x014 { get { return Read<int>(0x014); } }
		public Time x018_Time { get { return Read<Time>(0x018); } }
		public Time x01C_Time { get { return Read<Time>(0x01C); } }
		public Time x020_Time { get { return Read<Time>(0x020); } }
		public Time x024_Time { get { return Read<Time>(0x024); } }
		public ColorPath x028_ColorPath { get { return Read<ColorPath>(0x028); } }
		public ColorPath x058_ColorPath { get { return Read<ColorPath>(0x058); } }
		public FloatPath x088_FloatPath { get { return Read<FloatPath>(0x088); } }
		public FloatPath x0B8_FloatPath { get { return Read<FloatPath>(0x0B8); } }
		public int x0E8_Enum { get { return Read<int>(0x0E8); } } // Line = 0, Cross = 1, Circle = 2
		public int x0EC { get { return Read<int>(0x0EC); } }
		public UberMaterial x0F0_UberMaterial { get { return Read<UberMaterial>(0x0F0); } }
		
		[CompilerGenerated]
		public partial class ColorPath : SerializeMemoryObject
		{
			public const int SizeOf = 0x30; // 48
			
			public InterpolationPathHeader x00_InterpolationPathHeader { get { return Read<InterpolationPathHeader>(0x00); } }
			public ColorNode[] x20_ColorNodes { get { return Deserialize<ColorNode>(x28_SerializeData); } }
			public SerializeData x28_SerializeData { get { return Read<SerializeData>(0x28); } }
		}
		
		[CompilerGenerated]
		public partial class FloatPath : SerializeMemoryObject
		{
			public const int SizeOf = 0x30; // 48
			
			public InterpolationPathHeader x00_InterpolationPathHeader { get { return Read<InterpolationPathHeader>(0x00); } }
			public FloatNode[] x20_FloatNodes { get { return Deserialize<FloatNode>(x28_SerializeData); } }
			public SerializeData x28_SerializeData { get { return Read<SerializeData>(0x28); } }
		}
		
		[CompilerGenerated]
		public partial class UberMaterial : SerializeMemoryObject
		{
			public const int SizeOf = 0x68; // 104
			
			public SNO x00_ShaderMapSNO { get { return Read<SNO>(0x00); } }
			public Material x04_Material { get { return Read<Material>(0x04); } }
			public SerializeData x4C_SerializeData { get { return Read<SerializeData>(0x4C); } }
			public MaterialTextureEntry[] x58_MaterialTextureEntries { get { return Deserialize<MaterialTextureEntry>(x4C_SerializeData); } }
		}
		
		[CompilerGenerated]
		public partial class InterpolationPathHeader : MemoryObject
		{
			public const int SizeOf = 0x1C; // 28
			
			public int x00 { get { return Read<int>(0x00); } }
			public float x04 { get { return Read<float>(0x04); } }
			public float x08 { get { return Read<float>(0x08); } }
			public int x0C { get { return Read<int>(0x0C); } }
			public InterpolationScalar x10_InterpolationScalar { get { return Read<InterpolationScalar>(0x10); } }
		}
		
		[CompilerGenerated]
		public partial class ColorNode : MemoryObject
		{
			public const int SizeOf = 0x0C; // 12
			
			public DT_RGBACOLOR x00_DT_RGBACOLOR { get { return Read<DT_RGBACOLOR>(0x00); } }
			public DT_RGBACOLOR x04_DT_RGBACOLOR { get { return Read<DT_RGBACOLOR>(0x04); } }
			public float x08 { get { return Read<float>(0x08); } }
		}
		
		[CompilerGenerated]
		public partial class FloatNode : MemoryObject
		{
			public const int SizeOf = 0x0C; // 12
			
			public float x00 { get { return Read<float>(0x00); } }
			public float x04 { get { return Read<float>(0x04); } }
			public float x08 { get { return Read<float>(0x08); } }
		}
		
		[CompilerGenerated]
		public partial class Material : MemoryObject
		{
			public const int SizeOf = 0x48; // 72
			
			public DT_RGBACOLORVALUE x00_DT_RGBACOLORVALUE { get { return Read<DT_RGBACOLORVALUE>(0x00); } }
			public DT_RGBACOLORVALUE x10_DT_RGBACOLORVALUE { get { return Read<DT_RGBACOLORVALUE>(0x10); } }
			public DT_RGBACOLORVALUE x20_DT_RGBACOLORVALUE { get { return Read<DT_RGBACOLORVALUE>(0x20); } }
			public DT_RGBACOLORVALUE x30_DT_RGBACOLORVALUE { get { return Read<DT_RGBACOLORVALUE>(0x30); } }
			public float x40 { get { return Read<float>(0x40); } }
			public int x44 { get { return Read<int>(0x44); } }
		}
		
		[CompilerGenerated]
		public partial class MaterialTextureEntry : MemoryObject
		{
			public const int SizeOf = 0xA0; // 160
			
			public int x00 { get { return Read<int>(0x00); } }
			public int x04 { get { return Read<int>(0x04); } }
			public MaterialTexture x08_MaterialTexture { get { return Read<MaterialTexture>(0x08); } }
		}
		
		[CompilerGenerated]
		public partial class InterpolationScalar : MemoryObject
		{
			public const int SizeOf = 0x0C; // 12
			
			public int x00 { get { return Read<int>(0x00); } }
			public float x04 { get { return Read<float>(0x04); } }
			public float x08 { get { return Read<float>(0x08); } }
		}
		
		[CompilerGenerated]
		public partial class DT_RGBACOLOR : MemoryObject
		{
			public const int SizeOf = 0x03; // 3
			
			public byte x00 { get { return Read<byte>(0x00); } }
			public byte x01 { get { return Read<byte>(0x01); } }
			public byte x02 { get { return Read<byte>(0x02); } }
			public byte x03 { get { return Read<byte>(0x03); } }
		}
		
		[CompilerGenerated]
		public partial class DT_RGBACOLORVALUE : MemoryObject
		{
			public const int SizeOf = 0x0C; // 12
			
			public float x00 { get { return Read<float>(0x00); } }
			public float x04 { get { return Read<float>(0x04); } }
			public float x08 { get { return Read<float>(0x08); } }
			public float x0C { get { return Read<float>(0x0C); } }
		}
		
		[CompilerGenerated]
		public partial class MaterialTexture : MemoryObject
		{
			public const int SizeOf = 0x98; // 152
			
			public SNO x00_TexturesSNO { get { return Read<SNO>(0x00); } }
			public TexAnimParams x04_TexAnimParams { get { return Read<TexAnimParams>(0x04); } }
			public int x94 { get { return Read<int>(0x94); } }
		}
		
		[CompilerGenerated]
		public partial class TexAnimParams : MemoryObject
		{
			public const int SizeOf = 0x90; // 144
			
			public int x00 { get { return Read<int>(0x00); } }
			public Matrix4x4 x04 { get { return Read<Matrix4x4>(0x04); } }
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
		public partial class FrameAnim : MemoryObject
		{
			public const int SizeOf = 0x14; // 20
			
			public int x00 { get { return Read<int>(0x00); } }
			public Velocity x04_Velocity { get { return Read<Velocity>(0x04); } }
			public Velocity x08_Velocity { get { return Read<Velocity>(0x08); } }
			public int x0C { get { return Read<int>(0x0C); } }
			public int x10 { get { return Read<int>(0x10); } }
		}
	}
}
