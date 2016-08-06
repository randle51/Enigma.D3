using System.Runtime.CompilerServices;
using Enigma.D3.DataTypes;
using Enigma.Memory;

namespace Enigma.D3.Assets
{
	[CompilerGenerated]
	public partial class Rope : SerializeMemoryObject
	{
		public const int SizeOf = 0x460; // 1120
		
		public SNOHeader x000_Header { get { return Read<SNOHeader>(0x000); } }
		public int x00C { get { return Read<int>(0x00C); } }
		public int x010 { get { return Read<int>(0x010); } }
		public float x014 { get { return Read<float>(0x014); } }
		public Mass x018_Mass { get { return Read<Mass>(0x018); } }
		public float x01C { get { return Read<float>(0x01C); } }
		public Mass x020_Mass { get { return Read<Mass>(0x020); } }
		public float x024 { get { return Read<float>(0x024); } }
		public float x028 { get { return Read<float>(0x028); } }
		public UberMaterial x030_UberMaterial { get { return Read<UberMaterial>(0x030); } }
		public SNO x098_PhysicsSNO { get { return Read<SNO>(0x098); } }
		public Time x09C_Time { get { return Read<Time>(0x09C); } }
		public Time x0A0_Time { get { return Read<Time>(0x0A0); } }
		public Time x0A4_Time { get { return Read<Time>(0x0A4); } }
		public Time x0A8_Time { get { return Read<Time>(0x0A8); } }
		public ColorPath x0B0_ColorPath { get { return Read<ColorPath>(0x0B0); } }
		public ColorPath x0E0_ColorPath { get { return Read<ColorPath>(0x0E0); } }
		public FloatPath x110_FloatPath { get { return Read<FloatPath>(0x110); } }
		public FloatPath x140_FloatPath { get { return Read<FloatPath>(0x140); } }
		public FloatPath x170_FloatPath { get { return Read<FloatPath>(0x170); } }
		public FloatPath x1A0_FloatPath { get { return Read<FloatPath>(0x1A0); } }
		public FloatPath x1D0_FloatPath { get { return Read<FloatPath>(0x1D0); } }
		public FloatPath x200_FloatPath { get { return Read<FloatPath>(0x200); } }
		public FloatPath x230_FloatPath { get { return Read<FloatPath>(0x230); } }
		public FloatPath x260_FloatPath { get { return Read<FloatPath>(0x260); } }
		public FloatPath x290_FloatPath { get { return Read<FloatPath>(0x290); } }
		public FloatPath x2C0_FloatPath { get { return Read<FloatPath>(0x2C0); } }
		public VectorPath x2F0_VectorPath { get { return Read<VectorPath>(0x2F0); } }
		public VelocityPath x320_VelocityPath { get { return Read<VelocityPath>(0x320); } }
		public float x350 { get { return Read<float>(0x350); } }
		public float x354 { get { return Read<float>(0x354); } }
		public FloatPath x358_FloatPath { get { return Read<FloatPath>(0x358); } }
		public FloatPath x388_FloatPath { get { return Read<FloatPath>(0x388); } }
		public FloatPath x3B8_FloatPath { get { return Read<FloatPath>(0x3B8); } }
		public FloatPath x3E8_FloatPath { get { return Read<FloatPath>(0x3E8); } }
		public FloatPath x418_FloatPath { get { return Read<FloatPath>(0x418); } }
		public SerializeData x448_SerializeData { get { return Read<SerializeData>(0x448); } }
		public int x450 { get { return Read<int>(0x450); } }
		public MsgTriggeredEvent[] x458_MsgTriggeredEvents { get { return Deserialize<MsgTriggeredEvent>(x448_SerializeData); } }
		
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
		public partial class VectorPath : SerializeMemoryObject
		{
			public const int SizeOf = 0x30; // 48
			
			public InterpolationPathHeader x00_InterpolationPathHeader { get { return Read<InterpolationPathHeader>(0x00); } }
			public VectorNode[] x20_VectorNodes { get { return Deserialize<VectorNode>(x28_SerializeData); } }
			public SerializeData x28_SerializeData { get { return Read<SerializeData>(0x28); } }
		}
		
		[CompilerGenerated]
		public partial class VelocityPath : SerializeMemoryObject
		{
			public const int SizeOf = 0x30; // 48
			
			public InterpolationPathHeader x00_InterpolationPathHeader { get { return Read<InterpolationPathHeader>(0x00); } }
			public VelocityNode[] x20_VelocityNodes { get { return Deserialize<VelocityNode>(x28_SerializeData); } }
			public SerializeData x28_SerializeData { get { return Read<SerializeData>(0x28); } }
		}
		
		[CompilerGenerated]
		public partial class MsgTriggeredEvent : MemoryObject
		{
			public const int SizeOf = 0x19C; // 412
			
			public int x000 { get { return Read<int>(0x000); } }
			public TriggerEvent x004_TriggerEvent { get { return Read<TriggerEvent>(0x004); } }
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
		public partial class VectorNode : MemoryObject
		{
			public const int SizeOf = 0x1C; // 28
			
			public Vector3 x00 { get { return Read<Vector3>(0x00); } }
			public Vector3 x0C { get { return Read<Vector3>(0x0C); } }
			public float x18 { get { return Read<float>(0x18); } }
		}
		
		[CompilerGenerated]
		public partial class VelocityNode : MemoryObject
		{
			public const int SizeOf = 0x0C; // 12
			
			public Velocity x00_Velocity { get { return Read<Velocity>(0x00); } }
			public Velocity x04_Velocity { get { return Read<Velocity>(0x04); } }
			public float x08 { get { return Read<float>(0x08); } }
		}
		
		[CompilerGenerated]
		public partial class TriggerEvent : MemoryObject
		{
			public const int SizeOf = 0x198; // 408
			
			public int x000 { get { return Read<int>(0x000); } }
			public TriggerConditions x004_TriggerConditions { get { return Read<TriggerConditions>(0x004); } }
			public int x028 { get { return Read<int>(0x028); } }
			public SNOName x02C { get { return Read<SNOName>(0x02C); } }
			public int x034 { get { return Read<int>(0x034); } }
			public int x038 { get { return Read<int>(0x038); } }
			public int x03C { get { return Read<int>(0x03C); } }
			public int x040 { get { return Read<int>(0x040); } }
			public HardpointLink[] x044_HardpointLinks { get { return Read<HardpointLink>(0x044, 2); } }
			public LookLink x0CC_LookLink { get { return Read<LookLink>(0x0CC); } }
			public ConstraintLink x10C_ConstraintLink { get { return Read<ConstraintLink>(0x10C); } }
			public int x14C { get { return Read<int>(0x14C); } }
			public float x150 { get { return Read<float>(0x150); } }
			public int x154 { get { return Read<int>(0x154); } }
			public int x158 { get { return Read<int>(0x158); } }
			public int x15C { get { return Read<int>(0x15C); } }
			public int x160 { get { return Read<int>(0x160); } }
			public int x164 { get { return Read<int>(0x164); } }
			public float x168 { get { return Read<float>(0x168); } }
			public float x16C { get { return Read<float>(0x16C); } }
			public int x170 { get { return Read<int>(0x170); } }
			public float x174 { get { return Read<float>(0x174); } }
			public int x178 { get { return Read<int>(0x178); } }
			public Velocity x17C_Velocity { get { return Read<Velocity>(0x17C); } }
			public int x180 { get { return Read<int>(0x180); } }
			public Time x184_Time { get { return Read<Time>(0x184); } }
			public DT_RGBACOLOR x188_DT_RGBACOLOR { get { return Read<DT_RGBACOLOR>(0x188); } }
			public Time x18C_Time { get { return Read<Time>(0x18C); } }
			public DT_RGBACOLOR x190_DT_RGBACOLOR { get { return Read<DT_RGBACOLOR>(0x190); } }
			public Time x194_Time { get { return Read<Time>(0x194); } }
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
		public partial class TriggerConditions : MemoryObject
		{
			public const int SizeOf = 0x24; // 36
			
			public Percent x00_Percent { get { return Read<Percent>(0x00); } }
			public Time x04_Time { get { return Read<Time>(0x04); } }
			public Time x08_Time { get { return Read<Time>(0x08); } }
			public Time x0C_Time { get { return Read<Time>(0x0C); } }
			public Time x10_Time { get { return Read<Time>(0x10); } }
			public Impulse x14_Impulse { get { return Read<Impulse>(0x14); } }
			public Impulse x18_Impulse { get { return Read<Impulse>(0x18); } }
			public int x1C { get { return Read<int>(0x1C); } }
			public int x20 { get { return Read<int>(0x20); } }
		}
		
		[CompilerGenerated]
		public partial class HardpointLink : MemoryObject
		{
			public const int SizeOf = 0x44; // 68
			
			public string x00_Text { get { return ReadString(0x00, 64); } }
			public int x40 { get { return Read<int>(0x40); } }
		}
		
		[CompilerGenerated]
		public partial class LookLink : MemoryObject
		{
			public const int SizeOf = 0x40; // 64
			
			public string x00_Text { get { return ReadString(0x00, 64); } }
		}
		
		[CompilerGenerated]
		public partial class ConstraintLink : MemoryObject
		{
			public const int SizeOf = 0x40; // 64
			
			public string x00_Text { get { return ReadString(0x00, 64); } }
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
