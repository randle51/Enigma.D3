using System.Runtime.CompilerServices;
using Enigma.D3.DataTypes;
using Enigma.Memory;

namespace Enigma.D3.Assets
{
	[CompilerGenerated]
	public partial class Weather : SerializeMemoryObject
	{
		public const int SizeOf = 0x1A0; // 416
		
		public SNOHeader x000_Header { get { return Read<SNOHeader>(0x000); } }
		public int x00C { get { return Read<int>(0x00C); } }
		public Time x010_Time { get { return Read<Time>(0x010); } }
		public VelocityVectorPath x018_VelocityVectorPath { get { return Read<VelocityVectorPath>(0x018); } }
		public VelocityVectorPath x048_VelocityVectorPath { get { return Read<VelocityVectorPath>(0x048); } }
		public Time x078_Time { get { return Read<Time>(0x078); } }
		public FloatPath x080_FloatPath { get { return Read<FloatPath>(0x080); } }
		public SNO x0B0_ParticleSNO { get { return Read<SNO>(0x0B0); } }
		public SNO x0B4_ParticleSNO { get { return Read<SNO>(0x0B4); } }
		public SNO x0B8_SoundSNO { get { return Read<SNO>(0x0B8); } }
		public SNO x0BC_ActorSNO { get { return Read<SNO>(0x0BC); } }
		public float x0C0 { get { return Read<float>(0x0C0); } }
		public Time x0C4_Time { get { return Read<Time>(0x0C4); } }
		public Time x0C8_Time { get { return Read<Time>(0x0C8); } }
		public Time x0CC_Time { get { return Read<Time>(0x0CC); } }
		public SNO x0D0_LightSNO { get { return Read<SNO>(0x0D0); } }
		public SNO x0D4_EffectGroupSNO { get { return Read<SNO>(0x0D4); } }
		public SNO x0D8_SoundSNO { get { return Read<SNO>(0x0D8); } }
		public float x0DC { get { return Read<float>(0x0DC); } }
		public float x0E0 { get { return Read<float>(0x0E0); } }
		public float x0E4 { get { return Read<float>(0x0E4); } }
		public WeatherStateParams x0E8_WeatherStateParams { get { return Read<WeatherStateParams>(0x0E8); } }
		public WeatherStateParams x12C_WeatherStateParams { get { return Read<WeatherStateParams>(0x12C); } }
		public float x170 { get { return Read<float>(0x170); } }
		public ColorCorrectionParams x174_ColorCorrectionParams { get { return Read<ColorCorrectionParams>(0x174); } }
		public SNO[] x188_SNOs { get { return Deserialize<SNO>(x190_SerializeData); } }
		public SerializeData x190_SerializeData { get { return Read<SerializeData>(0x190); } }
		public int x198 { get { return Read<int>(0x198); } }
		public int x19C { get { return Read<int>(0x19C); } }
		
		[CompilerGenerated]
		public partial class VelocityVectorPath : SerializeMemoryObject
		{
			public const int SizeOf = 0x30; // 48
			
			public InterpolationPathHeader x00_InterpolationPathHeader { get { return Read<InterpolationPathHeader>(0x00); } }
			public VelocityVectorNode[] x20_VelocityVectorNodes { get { return Deserialize<VelocityVectorNode>(x28_SerializeData); } }
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
		public partial class WeatherStateParams : MemoryObject
		{
			public const int SizeOf = 0x44; // 68
			
			public int x00 { get { return Read<int>(0x00); } }
			public DT_RGBACOLOR x04_DT_RGBACOLOR { get { return Read<DT_RGBACOLOR>(0x04); } }
			public float x08 { get { return Read<float>(0x08); } }
			public float x0C { get { return Read<float>(0x0C); } }
			public float x10 { get { return Read<float>(0x10); } }
			public float x14 { get { return Read<float>(0x14); } }
			public DT_RGBACOLOR x18_DT_RGBACOLOR { get { return Read<DT_RGBACOLOR>(0x18); } }
			public float x1C { get { return Read<float>(0x1C); } }
			public float x20 { get { return Read<float>(0x20); } }
			public float x24 { get { return Read<float>(0x24); } }
			public SNO x28_LightSNO { get { return Read<SNO>(0x28); } }
			public SNO x2C_LightSNO { get { return Read<SNO>(0x2C); } }
			public float x30 { get { return Read<float>(0x30); } }
			public float x34 { get { return Read<float>(0x34); } }
			public SNO x38_LightSNO { get { return Read<SNO>(0x38); } }
			public SNO x3C_LightSNO { get { return Read<SNO>(0x3C); } }
			public SNO x40_LightSNO { get { return Read<SNO>(0x40); } }
		}
		
		[CompilerGenerated]
		public partial class ColorCorrectionParams : MemoryObject
		{
			public const int SizeOf = 0x10; // 16
			
			public SNO x00_TexturesSNO { get { return Read<SNO>(0x00); } }
			public SNO x04_TexturesSNO { get { return Read<SNO>(0x04); } }
			public SNO x08_TexturesSNO { get { return Read<SNO>(0x08); } }
			public int x0C { get { return Read<int>(0x0C); } }
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
		public partial class VelocityVectorNode : MemoryObject
		{
			public const int SizeOf = 0x1C; // 28
			
			public VelocityVector3D x00_VelocityVector3D { get { return Read<VelocityVector3D>(0x00); } }
			public VelocityVector3D x0C_VelocityVector3D { get { return Read<VelocityVector3D>(0x0C); } }
			public float x18 { get { return Read<float>(0x18); } }
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
		public partial class DT_RGBACOLOR : MemoryObject
		{
			public const int SizeOf = 0x03; // 3
			
			public byte x00 { get { return Read<byte>(0x00); } }
			public byte x01 { get { return Read<byte>(0x01); } }
			public byte x02 { get { return Read<byte>(0x02); } }
			public byte x03 { get { return Read<byte>(0x03); } }
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
		public partial class VelocityVector3D : MemoryObject
		{
			public const int SizeOf = 0x0C; // 12
			
			public Velocity x00_Velocity { get { return Read<Velocity>(0x00); } }
			public Velocity x04_Velocity { get { return Read<Velocity>(0x04); } }
			public Velocity x08_Velocity { get { return Read<Velocity>(0x08); } }
		}
	}
}
