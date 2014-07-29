using System.Runtime.CompilerServices;
using Enigma.D3.Collections;
using Enigma.D3.Memory;

namespace Enigma.D3.Sno
{
	[CompilerGenerated]
	public partial class Weather : SerializeMemoryObject
	{
		// 2.0.6.24641
		public const int SizeOf = 0x190; // 400
		
		public int x00C { get { return Field<int>(0x00C); } }
		public Time x010_Time { get { return Field<Time>(0x010); } }
		public VelocityVectorPath x018_VelocityVectorPath { get { return Field<VelocityVectorPath>(0x018); } }
		public VelocityVectorPath x048_VelocityVectorPath { get { return Field<VelocityVectorPath>(0x048); } }
		public Time x078_Time { get { return Field<Time>(0x078); } }
		public FloatPath x080_FloatPath { get { return Field<FloatPath>(0x080); } }
		public Sno x0B0_ParticleSno { get { return Field<Sno>(0x0B0); } }
		public Sno x0B4_ParticleSno { get { return Field<Sno>(0x0B4); } }
		public Sno x0B8_SoundSno { get { return Field<Sno>(0x0B8); } }
		public Sno x0BC_ActorSno { get { return Field<Sno>(0x0BC); } }
		public float x0C0 { get { return Field<float>(0x0C0); } }
		public Time x0C4_Time { get { return Field<Time>(0x0C4); } }
		public Time x0C8_Time { get { return Field<Time>(0x0C8); } }
		public Time x0CC_Time { get { return Field<Time>(0x0CC); } }
		public Sno x0D0_LightSno { get { return Field<Sno>(0x0D0); } }
		public Sno x0D4_EffectGroupSno { get { return Field<Sno>(0x0D4); } }
		public Sno x0D8_SoundSno { get { return Field<Sno>(0x0D8); } }
		public float x0DC { get { return Field<float>(0x0DC); } }
		public float x0E0 { get { return Field<float>(0x0E0); } }
		public float x0E4 { get { return Field<float>(0x0E4); } }
		public WeatherStateParams x0E8_WeatherStateParams { get { return Field<WeatherStateParams>(0x0E8); } }
		public WeatherStateParams x128_WeatherStateParams { get { return Field<WeatherStateParams>(0x128); } }
		public float x168 { get { return Field<float>(0x168); } }
		public ColorCorrectionParams x16C_ColorCorrectionParams { get { return Field<ColorCorrectionParams>(0x16C); } }
		public Sno[] x178_Snos { get { return Deserialize<Sno>(x180_SerializeData); } }
		public SerializeData x180_SerializeData { get { return Field<SerializeData>(0x180); } }
		public int x188 { get { return Field<int>(0x188); } }
		public int x18C { get { return Field<int>(0x18C); } }
		
		[CompilerGenerated]
		public partial class VelocityVectorPath : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x30; // 48
			
			public InterpolationPathHeader x00_InterpolationPathHeader { get { return Field<InterpolationPathHeader>(0x00); } }
			public VelocityVectorNode[] x20_VelocityVectorNodes { get { return Deserialize<VelocityVectorNode>(x28_SerializeData); } }
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
		public partial class WeatherStateParams : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x40; // 64
			
			public int x00 { get { return Field<int>(0x00); } }
			public RGBAColor x04_RGBAColor { get { return Field<RGBAColor>(0x04); } }
			public float x08 { get { return Field<float>(0x08); } }
			public float x0C { get { return Field<float>(0x0C); } }
			public float x10 { get { return Field<float>(0x10); } }
			public float x14 { get { return Field<float>(0x14); } }
			public RGBAColor x18_RGBAColor { get { return Field<RGBAColor>(0x18); } }
			public float x1C { get { return Field<float>(0x1C); } }
			public float x20 { get { return Field<float>(0x20); } }
			public Sno x24_LightSno { get { return Field<Sno>(0x24); } }
			public Sno x28_LightSno { get { return Field<Sno>(0x28); } }
			public float x2C { get { return Field<float>(0x2C); } }
			public float x30 { get { return Field<float>(0x30); } }
			public Sno x34_LightSno { get { return Field<Sno>(0x34); } }
			public Sno x38_LightSno { get { return Field<Sno>(0x38); } }
			public Sno x3C_LightSno { get { return Field<Sno>(0x3C); } }
		}
		
		[CompilerGenerated]
		public partial class ColorCorrectionParams : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0xC; // 12
			
			public Sno x00_TexturesSno { get { return Field<Sno>(0x00); } }
			public Sno x04_TexturesSno { get { return Field<Sno>(0x04); } }
			public Sno x08_TexturesSno { get { return Field<Sno>(0x08); } }
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
		public partial class VelocityVectorNode : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x1C; // 28
			
			public VelocityVector3D x00_VelocityVector3D { get { return Field<VelocityVector3D>(0x00); } }
			public VelocityVector3D x0C_VelocityVector3D { get { return Field<VelocityVector3D>(0x0C); } }
			public float x18 { get { return Field<float>(0x18); } }
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
		public partial class RGBAColor : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x4; // 4
			
			public byte x00 { get { return Field<byte>(0x00); } }
			public byte x01 { get { return Field<byte>(0x01); } }
			public byte x02 { get { return Field<byte>(0x02); } }
			public byte x03 { get { return Field<byte>(0x03); } }
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
		public partial class VelocityVector3D : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0xC; // 12
			
			public Velocity x00_Velocity { get { return Field<Velocity>(0x00); } }
			public Velocity x04_Velocity { get { return Field<Velocity>(0x04); } }
			public Velocity x08_Velocity { get { return Field<Velocity>(0x08); } }
		}
	}
}
