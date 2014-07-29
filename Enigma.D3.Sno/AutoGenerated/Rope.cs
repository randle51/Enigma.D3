using System.Runtime.CompilerServices;
using Enigma.D3.Collections;
using Enigma.D3.Memory;

namespace Enigma.D3.Sno
{
	[CompilerGenerated]
	public partial class Rope : SerializeMemoryObject
	{
		// 2.0.6.24641
		public const int SizeOf = 0x460; // 1120
		
		public int x00C { get { return Field<int>(0x00C); } }
		public int x010 { get { return Field<int>(0x010); } }
		public float x014 { get { return Field<float>(0x014); } }
		public Mass x018_Mass { get { return Field<Mass>(0x018); } }
		public float x01C { get { return Field<float>(0x01C); } }
		public Mass x020_Mass { get { return Field<Mass>(0x020); } }
		public float x024 { get { return Field<float>(0x024); } }
		public float x028 { get { return Field<float>(0x028); } }
		public UberMaterial x030_UberMaterial { get { return Field<UberMaterial>(0x030); } }
		public Sno x098_PhysicsSno { get { return Field<Sno>(0x098); } }
		public Time x09C_Time { get { return Field<Time>(0x09C); } }
		public Time x0A0_Time { get { return Field<Time>(0x0A0); } }
		public Time x0A4_Time { get { return Field<Time>(0x0A4); } }
		public Time x0A8_Time { get { return Field<Time>(0x0A8); } }
		public ColorPath x0B0_ColorPath { get { return Field<ColorPath>(0x0B0); } }
		public ColorPath x0E0_ColorPath { get { return Field<ColorPath>(0x0E0); } }
		public FloatPath x110_FloatPath { get { return Field<FloatPath>(0x110); } }
		public FloatPath x140_FloatPath { get { return Field<FloatPath>(0x140); } }
		public FloatPath x170_FloatPath { get { return Field<FloatPath>(0x170); } }
		public FloatPath x1A0_FloatPath { get { return Field<FloatPath>(0x1A0); } }
		public FloatPath x1D0_FloatPath { get { return Field<FloatPath>(0x1D0); } }
		public FloatPath x200_FloatPath { get { return Field<FloatPath>(0x200); } }
		public FloatPath x230_FloatPath { get { return Field<FloatPath>(0x230); } }
		public FloatPath x260_FloatPath { get { return Field<FloatPath>(0x260); } }
		public FloatPath x290_FloatPath { get { return Field<FloatPath>(0x290); } }
		public FloatPath x2C0_FloatPath { get { return Field<FloatPath>(0x2C0); } }
		public VectorPath x2F0_VectorPath { get { return Field<VectorPath>(0x2F0); } }
		public VelocityPath x320_VelocityPath { get { return Field<VelocityPath>(0x320); } }
		public float x350 { get { return Field<float>(0x350); } }
		public float x354 { get { return Field<float>(0x354); } }
		public FloatPath x358_FloatPath { get { return Field<FloatPath>(0x358); } }
		public FloatPath x388_FloatPath { get { return Field<FloatPath>(0x388); } }
		public FloatPath x3B8_FloatPath { get { return Field<FloatPath>(0x3B8); } }
		public FloatPath x3E8_FloatPath { get { return Field<FloatPath>(0x3E8); } }
		public FloatPath x418_FloatPath { get { return Field<FloatPath>(0x418); } }
		public SerializeData x448_SerializeData { get { return Field<SerializeData>(0x448); } }
		public int x450 { get { return Field<int>(0x450); } }
		public MsgTriggeredEvent[] x458_MsgTriggeredEvents { get { return Deserialize<MsgTriggeredEvent>(x448_SerializeData); } }
		
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
		public partial class ColorPath : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x30; // 48
			
			public InterpolationPathHeader x00_InterpolationPathHeader { get { return Field<InterpolationPathHeader>(0x00); } }
			public ColorNode[] x20_ColorNodes { get { return Deserialize<ColorNode>(x28_SerializeData); } }
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
		public partial class VectorPath : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x30; // 48
			
			public InterpolationPathHeader x00_InterpolationPathHeader { get { return Field<InterpolationPathHeader>(0x00); } }
			public VectorNode[] x20_VectorNodes { get { return Deserialize<VectorNode>(x28_SerializeData); } }
			public SerializeData x28_SerializeData { get { return Field<SerializeData>(0x28); } }
		}
		
		[CompilerGenerated]
		public partial class VelocityPath : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x30; // 48
			
			public InterpolationPathHeader x00_InterpolationPathHeader { get { return Field<InterpolationPathHeader>(0x00); } }
			public VelocityNode[] x20_VelocityNodes { get { return Deserialize<VelocityNode>(x28_SerializeData); } }
			public SerializeData x28_SerializeData { get { return Field<SerializeData>(0x28); } }
		}
		
		[CompilerGenerated]
		public partial class MsgTriggeredEvent : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x19C; // 412
			
			public int x000 { get { return Field<int>(0x000); } }
			public TriggerEvent x004_TriggerEvent { get { return Field<TriggerEvent>(0x004); } }
		}
		
		[CompilerGenerated]
		public partial class Material : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x48; // 72
			
			public RGBAColorValue x00_RGBAColorValue { get { return Field<RGBAColorValue>(0x00); } }
			public RGBAColorValue x10_RGBAColorValue { get { return Field<RGBAColorValue>(0x10); } }
			public RGBAColorValue x20_RGBAColorValue { get { return Field<RGBAColorValue>(0x20); } }
			public RGBAColorValue x30_RGBAColorValue { get { return Field<RGBAColorValue>(0x30); } }
			public float x40 { get { return Field<float>(0x40); } }
			public int x44 { get { return Field<int>(0x44); } }
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
		public partial class ColorNode : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0xC; // 12
			
			public RGBAColor x00_RGBAColor { get { return Field<RGBAColor>(0x00); } }
			public RGBAColor x04_RGBAColor { get { return Field<RGBAColor>(0x04); } }
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
		public partial class VectorNode : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x1C; // 28
			
			public Vector3D x00_Vector3D { get { return Field<Vector3D>(0x00); } }
			public Vector3D x0C_Vector3D { get { return Field<Vector3D>(0x0C); } }
			public float x18 { get { return Field<float>(0x18); } }
		}
		
		[CompilerGenerated]
		public partial class VelocityNode : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0xC; // 12
			
			public Velocity x00_Velocity { get { return Field<Velocity>(0x00); } }
			public Velocity x04_Velocity { get { return Field<Velocity>(0x04); } }
			public float x08 { get { return Field<float>(0x08); } }
		}
		
		[CompilerGenerated]
		public partial class TriggerEvent : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x198; // 408
			
			public int x000 { get { return Field<int>(0x000); } }
			public TriggerConditions x004_TriggerConditions { get { return Field<TriggerConditions>(0x004); } }
			public int x028 { get { return Field<int>(0x028); } }
			public SNOName x02C_SNOName { get { return Field<SNOName>(0x02C); } }
			public int x034 { get { return Field<int>(0x034); } }
			public int x038 { get { return Field<int>(0x038); } }
			public int x03C { get { return Field<int>(0x03C); } }
			public int x040 { get { return Field<int>(0x040); } }
			public HardpointLink[] x044_HardpointLinks { get { return Field<HardpointLink>(0x044, 2); } }
			public LookLink x0CC_LookLink { get { return Field<LookLink>(0x0CC); } }
			public ConstraintLink x10C_ConstraintLink { get { return Field<ConstraintLink>(0x10C); } }
			public int x14C { get { return Field<int>(0x14C); } }
			public float x150 { get { return Field<float>(0x150); } }
			public int x154 { get { return Field<int>(0x154); } }
			public int x158 { get { return Field<int>(0x158); } }
			public int x15C { get { return Field<int>(0x15C); } }
			public int x160 { get { return Field<int>(0x160); } }
			public int x164 { get { return Field<int>(0x164); } }
			public float x168 { get { return Field<float>(0x168); } }
			public float x16C { get { return Field<float>(0x16C); } }
			public int x170 { get { return Field<int>(0x170); } }
			public float x174 { get { return Field<float>(0x174); } }
			public int x178 { get { return Field<int>(0x178); } }
			public Velocity x17C_Velocity { get { return Field<Velocity>(0x17C); } }
			public int x180 { get { return Field<int>(0x180); } }
			public Time x184_Time { get { return Field<Time>(0x184); } }
			public RGBAColor x188_RGBAColor { get { return Field<RGBAColor>(0x188); } }
			public Time x18C_Time { get { return Field<Time>(0x18C); } }
			public RGBAColor x190_RGBAColor { get { return Field<RGBAColor>(0x190); } }
			public Time x194_Time { get { return Field<Time>(0x194); } }
		}
		
		[CompilerGenerated]
		public partial class RGBAColorValue : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x10; // 16
			
			public float x00 { get { return Field<float>(0x00); } }
			public float x04 { get { return Field<float>(0x04); } }
			public float x08 { get { return Field<float>(0x08); } }
			public float x0C { get { return Field<float>(0x0C); } }
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
		public partial class InterpolationScalar : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0xC; // 12
			
			public int x00 { get { return Field<int>(0x00); } }
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
		public partial class Vector3D : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0xC; // 12
			
			public float x00 { get { return Field<float>(0x00); } }
			public float x04 { get { return Field<float>(0x04); } }
			public float x08 { get { return Field<float>(0x08); } }
		}
		
		[CompilerGenerated]
		public partial class TriggerConditions : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x24; // 36
			
			public Percent x00_Percent { get { return Field<Percent>(0x00); } }
			public Time x04_Time { get { return Field<Time>(0x04); } }
			public Time x08_Time { get { return Field<Time>(0x08); } }
			public Time x0C_Time { get { return Field<Time>(0x0C); } }
			public Time x10_Time { get { return Field<Time>(0x10); } }
			public Impulse x14_Impulse { get { return Field<Impulse>(0x14); } }
			public Impulse x18_Impulse { get { return Field<Impulse>(0x18); } }
			public int x1C { get { return Field<int>(0x1C); } }
			public int x20 { get { return Field<int>(0x20); } }
		}
		
		[CompilerGenerated]
		public partial class SNOName : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x8; // 8
			
			public SnoGroup x00_SnoGroup { get { return Field<SnoGroup>(0x00); } }
			public SnoNameHandle x04_SnoNameHandle { get { return Field<SnoNameHandle>(0x04); } }
		}
		
		[CompilerGenerated]
		public partial class HardpointLink : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x44; // 68
			
			public string x00_Text { get { return Field(0x00, 64); } }
			public int x40 { get { return Field<int>(0x40); } }
		}
		
		[CompilerGenerated]
		public partial class LookLink : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x40; // 64
			
			public string x00_Text { get { return Field(0x00, 64); } }
		}
		
		[CompilerGenerated]
		public partial class ConstraintLink : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x40; // 64
			
			public string x00_Text { get { return Field(0x00, 64); } }
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
