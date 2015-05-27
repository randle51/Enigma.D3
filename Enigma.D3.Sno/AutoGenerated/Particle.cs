using System.Runtime.CompilerServices;
using Enigma.D3.Collections;
using Enigma.D3.Memory;
using Enigma.Memory;

namespace Enigma.D3.Sno
{
	[CompilerGenerated]
	public partial class Particle : SerializeMemoryObject
	{
		public const int SizeOf = 0x8F8; // 2296
		
		public SnoHeader x000_Header { get { return Read<SnoHeader>(0x000); } }
		public int x00C { get { return Read<int>(0x00C); } }
		public int x010 { get { return Read<int>(0x010); } }
		public Time x014_Time { get { return Read<Time>(0x014); } }
		public Time x018_Time { get { return Read<Time>(0x018); } }
		public Time x01C_Time { get { return Read<Time>(0x01C); } }
		public InterpolationScalar x020_InterpolationScalar { get { return Read<InterpolationScalar>(0x020); } }
		public int x02C { get { return Read<int>(0x02C); } }
		public FloatPath x030_FloatPath { get { return Read<FloatPath>(0x030); } }
		public IntPath x060_IntPath { get { return Read<IntPath>(0x060); } }
		public FloatPath x090_FloatPath { get { return Read<FloatPath>(0x090); } }
		public TimePath x0C0_TimePath { get { return Read<TimePath>(0x0C0); } }
		public FloatPath x0F0_FloatPath { get { return Read<FloatPath>(0x0F0); } }
		public AnglePath x120_AnglePath { get { return Read<AnglePath>(0x120); } }
		public VelocityVectorPath x150_VelocityVectorPath { get { return Read<VelocityVectorPath>(0x150); } }
		public VelocityVectorPath x180_VelocityVectorPath { get { return Read<VelocityVectorPath>(0x180); } }
		public VelocityPath x1B0_VelocityPath { get { return Read<VelocityPath>(0x1B0); } }
		public VelocityPath x1E0_VelocityPath { get { return Read<VelocityPath>(0x1E0); } }
		public VelocityPath x210_VelocityPath { get { return Read<VelocityPath>(0x210); } }
		public VectorPath x240_VectorPath { get { return Read<VectorPath>(0x240); } }
		public VelocityPath x270_VelocityPath { get { return Read<VelocityPath>(0x270); } }
		public float x2A0 { get { return Read<float>(0x2A0); } }
		public UberMaterial x2A8_UberMaterial { get { return Read<UberMaterial>(0x2A8); } }
		public Sno x310_PhysicsSno { get { return Read<Sno>(0x310); } }
		public Mass x314_Mass { get { return Read<Mass>(0x314); } }
		public int x318 { get { return Read<int>(0x318); } }
		public float x31C { get { return Read<float>(0x31C); } }
		public float x320 { get { return Read<float>(0x320); } }
		public float x324 { get { return Read<float>(0x324); } }
		public float x328 { get { return Read<float>(0x328); } }
		public float x32C { get { return Read<float>(0x32C); } }
		public float x330 { get { return Read<float>(0x330); } }
		public float x334 { get { return Read<float>(0x334); } }
		public Sno x338_ActorSno { get { return Read<Sno>(0x338); } }
		public EmitterParams x340_EmitterParams { get { return Read<EmitterParams>(0x340); } }
		public ColorPath x458_ColorPath { get { return Read<ColorPath>(0x458); } }
		public FloatPath x488_FloatPath { get { return Read<FloatPath>(0x488); } }
		public FloatPath x4B8_FloatPath { get { return Read<FloatPath>(0x4B8); } }
		public FloatPath x4E8_FloatPath { get { return Read<FloatPath>(0x4E8); } }
		public FloatPath x518_FloatPath { get { return Read<FloatPath>(0x518); } }
		public AnglePath x548_AnglePath { get { return Read<AnglePath>(0x548); } }
		public AngularVelocityPath x578_AngularVelocityPath { get { return Read<AngularVelocityPath>(0x578); } }
		public AngularVelocityPath x5A8_AngularVelocityPath { get { return Read<AngularVelocityPath>(0x5A8); } }
		public AnglePath x5D8_AnglePath { get { return Read<AnglePath>(0x5D8); } }
		public VectorPath x608_VectorPath { get { return Read<VectorPath>(0x608); } }
		public FloatPath x638_FloatPath { get { return Read<FloatPath>(0x638); } }
		public VelocityPath x668_VelocityPath { get { return Read<VelocityPath>(0x668); } }
		public AngularVelocityPath x698_AngularVelocityPath { get { return Read<AngularVelocityPath>(0x698); } }
		public VectorPath x6C8_VectorPath { get { return Read<VectorPath>(0x6C8); } }
		public FloatPath x6F8_FloatPath { get { return Read<FloatPath>(0x6F8); } }
		public VelocityPath x728_VelocityPath { get { return Read<VelocityPath>(0x728); } }
		public VectorPath x758_VectorPath { get { return Read<VectorPath>(0x758); } }
		public VelocityVectorPath x788_VelocityVectorPath { get { return Read<VelocityVectorPath>(0x788); } }
		public AccelVectorPath x7B8_AccelVectorPath { get { return Read<AccelVectorPath>(0x7B8); } }
		public VectorPath x7E8_VectorPath { get { return Read<VectorPath>(0x7E8); } }
		public VelocityVectorPath x818_VelocityVectorPath { get { return Read<VelocityVectorPath>(0x818); } }
		public AccelVectorPath x848_AccelVectorPath { get { return Read<AccelVectorPath>(0x848); } }
		public VelocityPath x878_VelocityPath { get { return Read<VelocityPath>(0x878); } }
		public FloatPath x8A8_FloatPath { get { return Read<FloatPath>(0x8A8); } }
		public int x8D8 { get { return Read<int>(0x8D8); } }
		public float x8DC { get { return Read<float>(0x8DC); } }
		public float x8E0 { get { return Read<float>(0x8E0); } }
		public SerializeData x8E4_SerializeData { get { return Read<SerializeData>(0x8E4); } }
		public int x8EC { get { return Read<int>(0x8EC); } }
		public MsgTriggeredEvent[] x8F0_MsgTriggeredEvents { get { return Deserialize<MsgTriggeredEvent>(x8E4_SerializeData); } }
		
		[CompilerGenerated]
		public partial class InterpolationScalar : MemoryObject
		{
			public const int SizeOf = 0x0C; // 12
			
			public int x00 { get { return Read<int>(0x00); } }
			public float x04 { get { return Read<float>(0x04); } }
			public float x08 { get { return Read<float>(0x08); } }
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
		public partial class IntPath : SerializeMemoryObject
		{
			public const int SizeOf = 0x30; // 48
			
			public InterpolationPathHeader x00_InterpolationPathHeader { get { return Read<InterpolationPathHeader>(0x00); } }
			public IntNode[] x20_IntNodes { get { return Deserialize<IntNode>(x28_SerializeData); } }
			public SerializeData x28_SerializeData { get { return Read<SerializeData>(0x28); } }
		}
		
		[CompilerGenerated]
		public partial class TimePath : SerializeMemoryObject
		{
			public const int SizeOf = 0x30; // 48
			
			public InterpolationPathHeader x00_InterpolationPathHeader { get { return Read<InterpolationPathHeader>(0x00); } }
			public TimeNode[] x20_TimeNodes { get { return Deserialize<TimeNode>(x28_SerializeData); } }
			public SerializeData x28_SerializeData { get { return Read<SerializeData>(0x28); } }
		}
		
		[CompilerGenerated]
		public partial class AnglePath : SerializeMemoryObject
		{
			public const int SizeOf = 0x30; // 48
			
			public InterpolationPathHeader x00_InterpolationPathHeader { get { return Read<InterpolationPathHeader>(0x00); } }
			public AngleNode[] x20_AngleNodes { get { return Deserialize<AngleNode>(x28_SerializeData); } }
			public SerializeData x28_SerializeData { get { return Read<SerializeData>(0x28); } }
		}
		
		[CompilerGenerated]
		public partial class VelocityVectorPath : SerializeMemoryObject
		{
			public const int SizeOf = 0x30; // 48
			
			public InterpolationPathHeader x00_InterpolationPathHeader { get { return Read<InterpolationPathHeader>(0x00); } }
			public VelocityVectorNode[] x20_VelocityVectorNodes { get { return Deserialize<VelocityVectorNode>(x28_SerializeData); } }
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
		public partial class VectorPath : SerializeMemoryObject
		{
			public const int SizeOf = 0x30; // 48
			
			public InterpolationPathHeader x00_InterpolationPathHeader { get { return Read<InterpolationPathHeader>(0x00); } }
			public VectorNode[] x20_VectorNodes { get { return Deserialize<VectorNode>(x28_SerializeData); } }
			public SerializeData x28_SerializeData { get { return Read<SerializeData>(0x28); } }
		}
		
		[CompilerGenerated]
		public partial class UberMaterial : SerializeMemoryObject
		{
			public const int SizeOf = 0x68; // 104
			
			public Sno x00_ShaderMapSno { get { return Read<Sno>(0x00); } }
			public Material x04_Material { get { return Read<Material>(0x04); } }
			public SerializeData x4C_SerializeData { get { return Read<SerializeData>(0x4C); } }
			public MaterialTextureEntry[] x58_MaterialTextureEntries { get { return Deserialize<MaterialTextureEntry>(x4C_SerializeData); } }
		}
		
		[CompilerGenerated]
		public partial class EmitterParams : SerializeMemoryObject
		{
			public const int SizeOf = 0x118; // 280
			
			public FloatPath x000_FloatPath { get { return Read<FloatPath>(0x000); } }
			public FloatPath x030_FloatPath { get { return Read<FloatPath>(0x030); } }
			public VectorPath x060_VectorPath { get { return Read<VectorPath>(0x060); } }
			public int x090 { get { return Read<int>(0x090); } }
			public string x094_Text { get { return ReadString(0x094, 128); } }
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
		public partial class AngularVelocityPath : SerializeMemoryObject
		{
			public const int SizeOf = 0x30; // 48
			
			public InterpolationPathHeader x00_InterpolationPathHeader { get { return Read<InterpolationPathHeader>(0x00); } }
			public AngularVelocityNode[] x20_AngularVelocityNodes { get { return Deserialize<AngularVelocityNode>(x28_SerializeData); } }
			public SerializeData x28_SerializeData { get { return Read<SerializeData>(0x28); } }
		}
		
		[CompilerGenerated]
		public partial class AccelVectorPath : SerializeMemoryObject
		{
			public const int SizeOf = 0x30; // 48
			
			public InterpolationPathHeader x00_InterpolationPathHeader { get { return Read<InterpolationPathHeader>(0x00); } }
			public AccelVectorNode[] x20_AccelVectorNodes { get { return Deserialize<AccelVectorNode>(x28_SerializeData); } }
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
		public partial class FloatNode : MemoryObject
		{
			public const int SizeOf = 0x0C; // 12
			
			public float x00 { get { return Read<float>(0x00); } }
			public float x04 { get { return Read<float>(0x04); } }
			public float x08 { get { return Read<float>(0x08); } }
		}
		
		[CompilerGenerated]
		public partial class IntNode : MemoryObject
		{
			public const int SizeOf = 0x0C; // 12
			
			public int x00 { get { return Read<int>(0x00); } }
			public int x04 { get { return Read<int>(0x04); } }
			public float x08 { get { return Read<float>(0x08); } }
		}
		
		[CompilerGenerated]
		public partial class TimeNode : MemoryObject
		{
			public const int SizeOf = 0x0C; // 12
			
			public Time x00_Time { get { return Read<Time>(0x00); } }
			public Time x04_Time { get { return Read<Time>(0x04); } }
			public float x08 { get { return Read<float>(0x08); } }
		}
		
		[CompilerGenerated]
		public partial class AngleNode : MemoryObject
		{
			public const int SizeOf = 0x0C; // 12
			
			public Angle x00_Angle { get { return Read<Angle>(0x00); } }
			public Angle x04_Angle { get { return Read<Angle>(0x04); } }
			public float x08 { get { return Read<float>(0x08); } }
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
		public partial class VelocityNode : MemoryObject
		{
			public const int SizeOf = 0x0C; // 12
			
			public Velocity x00_Velocity { get { return Read<Velocity>(0x00); } }
			public Velocity x04_Velocity { get { return Read<Velocity>(0x04); } }
			public float x08 { get { return Read<float>(0x08); } }
		}
		
		[CompilerGenerated]
		public partial class VectorNode : MemoryObject
		{
			public const int SizeOf = 0x1C; // 28
			
			public DT_VECTOR3D x00_DT_VECTOR3D { get { return Read<DT_VECTOR3D>(0x00); } }
			public DT_VECTOR3D x0C_DT_VECTOR3D { get { return Read<DT_VECTOR3D>(0x0C); } }
			public float x18 { get { return Read<float>(0x18); } }
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
		public partial class ColorNode : MemoryObject
		{
			public const int SizeOf = 0x0C; // 12
			
			public DT_RGBACOLOR x00_DT_RGBACOLOR { get { return Read<DT_RGBACOLOR>(0x00); } }
			public DT_RGBACOLOR x04_DT_RGBACOLOR { get { return Read<DT_RGBACOLOR>(0x04); } }
			public float x08 { get { return Read<float>(0x08); } }
		}
		
		[CompilerGenerated]
		public partial class AngularVelocityNode : MemoryObject
		{
			public const int SizeOf = 0x0C; // 12
			
			public AngularVelocity x00_AngularVelocity { get { return Read<AngularVelocity>(0x00); } }
			public AngularVelocity x04_AngularVelocity { get { return Read<AngularVelocity>(0x04); } }
			public float x08 { get { return Read<float>(0x08); } }
		}
		
		[CompilerGenerated]
		public partial class AccelVectorNode : MemoryObject
		{
			public const int SizeOf = 0x1C; // 28
			
			public AccelVector3D x00_AccelVector3D { get { return Read<AccelVector3D>(0x00); } }
			public AccelVector3D x0C_AccelVector3D { get { return Read<AccelVector3D>(0x0C); } }
			public float x18 { get { return Read<float>(0x18); } }
		}
		
		[CompilerGenerated]
		public partial class TriggerEvent : MemoryObject
		{
			public const int SizeOf = 0x198; // 408
			
			public int x000 { get { return Read<int>(0x000); } }
			public TriggerConditions x004_TriggerConditions { get { return Read<TriggerConditions>(0x004); } }
			public int x028 { get { return Read<int>(0x028); } }
			public SNOName x02C_SNOName { get { return Read<SNOName>(0x02C); } }
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
		public partial class VelocityVector3D : MemoryObject
		{
			public const int SizeOf = 0x0C; // 12
			
			public Velocity x00_Velocity { get { return Read<Velocity>(0x00); } }
			public Velocity x04_Velocity { get { return Read<Velocity>(0x04); } }
			public Velocity x08_Velocity { get { return Read<Velocity>(0x08); } }
		}
		
		[CompilerGenerated]
		public partial class DT_VECTOR3D : MemoryObject
		{
			public const int SizeOf = 0x08; // 8
			
			public float x00_X { get { return Read<float>(0x00); } }
			public float x04_Y { get { return Read<float>(0x04); } }
			public float x08_Z { get { return Read<float>(0x08); } }
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
			
			public Sno x00_TexturesSno { get { return Read<Sno>(0x00); } }
			public TexAnimParams x04_TexAnimParams { get { return Read<TexAnimParams>(0x04); } }
			public int x94 { get { return Read<int>(0x94); } }
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
		public partial class AccelVector3D : MemoryObject
		{
			public const int SizeOf = 0x0C; // 12
			
			public Acceleration x00_Acceleration { get { return Read<Acceleration>(0x00); } }
			public Acceleration x04_Acceleration { get { return Read<Acceleration>(0x04); } }
			public Acceleration x08_Acceleration { get { return Read<Acceleration>(0x08); } }
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
		public partial class SNOName : MemoryObject
		{
			public const int SizeOf = 0x08; // 8
			
			public SnoGroup x00_SnoGroup { get { return Read<SnoGroup>(0x00); } }
			public SnoNameHandle x04_SnoNameHandle { get { return Read<SnoNameHandle>(0x04); } }
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
		public partial class Matrix4x4 : MemoryObject
		{
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
			public const int SizeOf = 0x14; // 20
			
			public int x00 { get { return Read<int>(0x00); } }
			public Velocity x04_Velocity { get { return Read<Velocity>(0x04); } }
			public Velocity x08_Velocity { get { return Read<Velocity>(0x08); } }
			public int x0C { get { return Read<int>(0x0C); } }
			public int x10 { get { return Read<int>(0x10); } }
		}
	}
}
