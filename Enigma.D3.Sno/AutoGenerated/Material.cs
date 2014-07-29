using System.Runtime.CompilerServices;
using Enigma.D3.Collections;
using Enigma.D3.Memory;

namespace Enigma.D3.Sno
{
	[CompilerGenerated]
	public partial class Material : SerializeMemoryObject
	{
		// 2.0.6.24641
		public const int SizeOf = 0x88; // 136
		
		public int x0C { get { return Field<int>(0x0C); } }
		public SerializeData x10_SerializeData { get { return Field<SerializeData>(0x10); } }
		public int[] x18_TagMap { get { return Deserialize<int>(x10_SerializeData); } }
		public UberMaterial x20_UberMaterial { get { return Field<UberMaterial>(0x20); } }
		
		[CompilerGenerated]
		public partial class UberMaterial : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x68; // 104
			
			public Sno x00_ShaderMapSno { get { return Field<Sno>(0x00); } }
			public Material x04_Material { get { return Field<Material>(0x04); } }
			public SerializeData x4C_SerializeData { get { return Field<SerializeData>(0x4C); } }
			public MaterialTextureEntry[] x58_MaterialTextureEntries { get { return Deserialize<MaterialTextureEntry>(x4C_SerializeData); } }
		}
		
		[CompilerGenerated]
		public partial class MaterialTextureEntry : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0xA0; // 160
			
			public int x00 { get { return Field<int>(0x00); } }
			public int x04 { get { return Field<int>(0x04); } }
			public MaterialTexture x08_MaterialTexture { get { return Field<MaterialTexture>(0x08); } }
		}
		
		[CompilerGenerated]
		public partial class MaterialTexture : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x98; // 152
			
			public Sno x00_TexturesSno { get { return Field<Sno>(0x00); } }
			public TexAnimParams x04_TexAnimParams { get { return Field<TexAnimParams>(0x04); } }
			public int x94 { get { return Field<int>(0x94); } }
		}
		
		[CompilerGenerated]
		public partial class TexAnimParams : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x90; // 144
			
			public int x00 { get { return Field<int>(0x00); } }
			public Matrix4x4 x04_Matrix4x4 { get { return Field<Matrix4x4>(0x04); } }
			public float x44 { get { return Field<float>(0x44); } }
			public Velocity x48_Velocity { get { return Field<Velocity>(0x48); } }
			public Velocity x4C_Velocity { get { return Field<Velocity>(0x4C); } }
			public float x50 { get { return Field<float>(0x50); } }
			public Velocity x54_Velocity { get { return Field<Velocity>(0x54); } }
			public Velocity x58_Velocity { get { return Field<Velocity>(0x58); } }
			public Angle x5C_Angle { get { return Field<Angle>(0x5C); } }
			public AngularVelocity x60_AngularVelocity { get { return Field<AngularVelocity>(0x60); } }
			public AngularVelocity x64_AngularVelocity { get { return Field<AngularVelocity>(0x64); } }
			public int x68 { get { return Field<int>(0x68); } }
			public int x6C { get { return Field<int>(0x6C); } }
			public int x70 { get { return Field<int>(0x70); } }
			public int x74 { get { return Field<int>(0x74); } }
			public FrameAnim x78_FrameAnim { get { return Field<FrameAnim>(0x78); } }
			public int x8C { get { return Field<int>(0x8C); } }
		}
		
		[CompilerGenerated]
		public partial class Matrix4x4 : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x40; // 64
			
			public float x00 { get { return Field<float>(0x00); } }
			public float x04 { get { return Field<float>(0x04); } }
			public float x08 { get { return Field<float>(0x08); } }
			public float x0C { get { return Field<float>(0x0C); } }
			public float x10 { get { return Field<float>(0x10); } }
			public float x14 { get { return Field<float>(0x14); } }
			public float x18 { get { return Field<float>(0x18); } }
			public float x1C { get { return Field<float>(0x1C); } }
			public float x20 { get { return Field<float>(0x20); } }
			public float x24 { get { return Field<float>(0x24); } }
			public float x28 { get { return Field<float>(0x28); } }
			public float x2C { get { return Field<float>(0x2C); } }
			public float x30 { get { return Field<float>(0x30); } }
			public float x34 { get { return Field<float>(0x34); } }
			public float x38 { get { return Field<float>(0x38); } }
			public float x3C { get { return Field<float>(0x3C); } }
		}
		
		[CompilerGenerated]
		public partial class FrameAnim : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x14; // 20
			
			public int x00 { get { return Field<int>(0x00); } }
			public Velocity x04_Velocity { get { return Field<Velocity>(0x04); } }
			public Velocity x08_Velocity { get { return Field<Velocity>(0x08); } }
			public int x0C { get { return Field<int>(0x0C); } }
			public int x10 { get { return Field<int>(0x10); } }
		}
	}
}
