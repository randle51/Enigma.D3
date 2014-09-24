using System.Runtime.CompilerServices;
using Enigma.D3.Collections;
using Enigma.D3.Memory;
using Enigma.Memory;

namespace Enigma.D3.Sno
{
	[CompilerGenerated]
	public partial class Weather : SerializeMemoryObject
	{
		// 2.1.1.27255
		public const int SizeOf = 0x198; // 408
		
		public SnoHeader x000_Header { get { return Read<SnoHeader>(0x000); } }
		public int x00C { get { return Read<int>(0x00C); } }
		public Time x010_Time { get { return Read<Time>(0x010); } }
		public VelocityVectorPath x018_VelocityVectorPath { get { return Read<VelocityVectorPath>(0x018); } }
		public VelocityVectorPath x048_VelocityVectorPath { get { return Read<VelocityVectorPath>(0x048); } }
		public Time x078_Time { get { return Read<Time>(0x078); } }
		public FloatPath x080_FloatPath { get { return Read<FloatPath>(0x080); } }
		public Sno x0B0_ParticleSno { get { return Read<Sno>(0x0B0); } }
		public Sno x0B4_ParticleSno { get { return Read<Sno>(0x0B4); } }
		public Sno x0B8_SoundSno { get { return Read<Sno>(0x0B8); } }
		public Sno x0BC_ActorSno { get { return Read<Sno>(0x0BC); } }
		public float x0C0 { get { return Read<float>(0x0C0); } }
		public Time x0C4_Time { get { return Read<Time>(0x0C4); } }
		public Time x0C8_Time { get { return Read<Time>(0x0C8); } }
		public Time x0CC_Time { get { return Read<Time>(0x0CC); } }
		public Sno x0D0_LightSno { get { return Read<Sno>(0x0D0); } }
		public Sno x0D4_EffectGroupSno { get { return Read<Sno>(0x0D4); } }
		public Sno x0D8_SoundSno { get { return Read<Sno>(0x0D8); } }
		public float x0DC { get { return Read<float>(0x0DC); } }
		public float x0E0 { get { return Read<float>(0x0E0); } }
		public float x0E4 { get { return Read<float>(0x0E4); } }
		public WeatherStateParams x0E8_WeatherStateParams { get { return Read<WeatherStateParams>(0x0E8); } }
		public WeatherStateParams x12C_WeatherStateParams { get { return Read<WeatherStateParams>(0x12C); } }
		public float x170 { get { return Read<float>(0x170); } }
		public ColorCorrectionParams x174_ColorCorrectionParams { get { return Read<ColorCorrectionParams>(0x174); } }
		public Sno[] x180_Snos { get { return Deserialize<Sno>(x188_SerializeData); } }
		public SerializeData x188_SerializeData { get { return Read<SerializeData>(0x188); } }
		public int x190 { get { return Read<int>(0x190); } }
		public int x194 { get { return Read<int>(0x194); } }
		
		[CompilerGenerated]
		public partial class VelocityVectorPath : SerializeMemoryObject
		{
			// 2.1.1.27255
			public const int SizeOf = 0x30; // 48
			
			public InterpolationPathHeader x00_InterpolationPathHeader { get { return Read<InterpolationPathHeader>(0x00); } }
			public VelocityVectorNode[] x20_VelocityVectorNodes { get { return Deserialize<VelocityVectorNode>(x28_SerializeData); } }
			public SerializeData x28_SerializeData { get { return Read<SerializeData>(0x28); } }
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
		public partial class WeatherStateParams : MemoryObject
		{
			// 2.1.1.27255
			public const int SizeOf = 0x44; // 68
			
			public int x00 { get { return Read<int>(0x00); } }
			public RGBAColor x04_RGBAColor { get { return Read<RGBAColor>(0x04); } }
			public float x08 { get { return Read<float>(0x08); } }
			public float x0C { get { return Read<float>(0x0C); } }
			public float x10 { get { return Read<float>(0x10); } }
			public float x14 { get { return Read<float>(0x14); } }
			public RGBAColor x18_RGBAColor { get { return Read<RGBAColor>(0x18); } }
			public float x1C { get { return Read<float>(0x1C); } }
			public float x20 { get { return Read<float>(0x20); } }
			public float x24 { get { return Read<float>(0x24); } }
			public Sno x28_LightSno { get { return Read<Sno>(0x28); } }
			public Sno x2C_LightSno { get { return Read<Sno>(0x2C); } }
			public float x30 { get { return Read<float>(0x30); } }
			public float x34 { get { return Read<float>(0x34); } }
			public Sno x38_LightSno { get { return Read<Sno>(0x38); } }
			public Sno x3C_LightSno { get { return Read<Sno>(0x3C); } }
			public Sno x40_LightSno { get { return Read<Sno>(0x40); } }
		}
		
		[CompilerGenerated]
		public partial class ColorCorrectionParams : MemoryObject
		{
			// 2.1.1.27255
			public const int SizeOf = 0x0C; // 12
			
			public Sno x00_TexturesSno { get { return Read<Sno>(0x00); } }
			public Sno x04_TexturesSno { get { return Read<Sno>(0x04); } }
			public Sno x08_TexturesSno { get { return Read<Sno>(0x08); } }
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
		public partial class VelocityVectorNode : MemoryObject
		{
			// 2.1.1.27255
			public const int SizeOf = 0x1C; // 28
			
			public VelocityVector3D x00_VelocityVector3D { get { return Read<VelocityVector3D>(0x00); } }
			public VelocityVector3D x0C_VelocityVector3D { get { return Read<VelocityVector3D>(0x0C); } }
			public float x18 { get { return Read<float>(0x18); } }
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
		public partial class RGBAColor : MemoryObject
		{
			// 2.1.1.27255
			public const int SizeOf = 0x04; // 4
			
			public byte x00 { get { return Read<byte>(0x00); } }
			public byte x01 { get { return Read<byte>(0x01); } }
			public byte x02 { get { return Read<byte>(0x02); } }
			public byte x03 { get { return Read<byte>(0x03); } }
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
		public partial class VelocityVector3D : MemoryObject
		{
			// 2.1.1.27255
			public const int SizeOf = 0x0C; // 12
			
			public Velocity x00_Velocity { get { return Read<Velocity>(0x00); } }
			public Velocity x04_Velocity { get { return Read<Velocity>(0x04); } }
			public Velocity x08_Velocity { get { return Read<Velocity>(0x08); } }
		}
	}
}
