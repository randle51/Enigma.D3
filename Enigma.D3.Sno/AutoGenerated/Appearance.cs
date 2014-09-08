using System.Runtime.CompilerServices;
using Enigma.D3.Collections;
using Enigma.D3.Memory;
using Enigma.Memory;

namespace Enigma.D3.Sno
{
	[CompilerGenerated]
	public partial class Appearance : SerializeMemoryObject
	{
		// 2.1.0.26451
		public const int SizeOf = 0x218; // 536
		
		public SnoHeader x000_Header { get { return Read<SnoHeader>(0x000); } }
		public Structure x010_Structure { get { return Read<Structure>(0x010); } }
		public int x1A0 { get { return Read<int>(0x1A0); } }
		public int x1A4 { get { return Read<int>(0x1A4); } }
		public SerializeData x1A8_SerializeData { get { return Read<SerializeData>(0x1A8); } }
		public AppearanceMaterial[] x1B0_AppearanceMaterials { get { return Deserialize<AppearanceMaterial>(x1A8_SerializeData); } }
		public SerializeData x1B8_SerializeData { get { return Read<SerializeData>(0x1B8); } }
		public AppearanceLook[] x1C0_AppearanceLooks { get { return Deserialize<AppearanceLook>(x1B8_SerializeData); } }
		public int x1C8 { get { return Read<int>(0x1C8); } }
		public SerializeData x1CC_SerializeData { get { return Read<SerializeData>(0x1CC); } }
		public StaticLight[] x1D8_StaticLights { get { return Deserialize<StaticLight>(x1CC_SerializeData); } }
		public int x1E0 { get { return Read<int>(0x1E0); } }
		public Time x1E4_Time { get { return Read<Time>(0x1E4); } }
		public Time x1E8_Time { get { return Read<Time>(0x1E8); } }
		public Time x1EC_Time { get { return Read<Time>(0x1EC); } }
		public Time x1F0_Time { get { return Read<Time>(0x1F0); } }
		public Time x1F4_Time { get { return Read<Time>(0x1F4); } }
		public int x1F8 { get { return Read<int>(0x1F8); } }
		public float x1FC { get { return Read<float>(0x1FC); } }
		public int x200 { get { return Read<int>(0x200); } }
		public int x204 { get { return Read<int>(0x204); } }
		public long x208 { get { return Read<long>(0x208); } }
		public int x210 { get { return Read<int>(0x210); } }
		
		[CompilerGenerated]
		public partial class Structure : SerializeMemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x190; // 400
			
			public int x000 { get { return Read<int>(0x000); } }
			public int x004 { get { return Read<int>(0x004); } }
			public SerializeData x008_SerializeData { get { return Read<SerializeData>(0x008); } }
			public BoneStructure[] x010_BoneStructures { get { return Deserialize<BoneStructure>(x008_SerializeData); } }
			public LookAtData x018_LookAtData { get { return Read<LookAtData>(0x018); } }
			public int x074 { get { return Read<int>(0x074); } }
			public BonePulseData[] x078_BonePulseDatas { get { return Deserialize<BonePulseData>(x080_SerializeData); } }
			public SerializeData x080_SerializeData { get { return Read<SerializeData>(0x080); } }
			public GeoSet[] x088_GeoSets { get { return Read<GeoSet>(0x088, 2); } }
			public Sphere x0B8_Sphere { get { return Read<Sphere>(0x0B8); } }
			public int x0C8 { get { return Read<int>(0x0C8); } }
			public SerializeData x0CC_SerializeData { get { return Read<SerializeData>(0x0CC); } }
			public CollisionCapsule[] x0D8_CollisionCapsules { get { return Deserialize<CollisionCapsule>(x0CC_SerializeData); } }
			public int x0E0 { get { return Read<int>(0x0E0); } }
			public SerializeData x0E4_SerializeData { get { return Read<SerializeData>(0x0E4); } }
			public Hardpoint[] x0F0_Hardpoints { get { return Deserialize<Hardpoint>(x0E4_SerializeData); } }
			public Vector3D x0F8_Vector3D { get { return Read<Vector3D>(0x0F8); } }
			public Octree x108_Octree { get { return Read<Octree>(0x108); } }
			public AABB x150_AABB { get { return Read<AABB>(0x150); } }
			public int x168 { get { return Read<int>(0x168); } }
			public SerializeData x16C_SerializeData { get { return Read<SerializeData>(0x16C); } }
			public ConstraintParameters[] x178_ConstraintParameters { get { return Deserialize<ConstraintParameters>(x16C_SerializeData); } }
			public int x180 { get { return Read<int>(0x180); } }
			public long x188 { get { return Read<long>(0x188); } }
		}
		
		[CompilerGenerated]
		public partial class AppearanceMaterial : SerializeMemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x90; // 144
			
			public string x00_Text { get { return ReadString(0x00, 128); } }
			public SerializeData x80_SerializeData { get { return Read<SerializeData>(0x80); } }
			public SubObjectAppearance[] x88_SubObjectAppearances { get { return Deserialize<SubObjectAppearance>(x80_SerializeData); } }
		}
		
		[CompilerGenerated]
		public partial class AppearanceLook : MemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x40; // 64
			
			public string x00_Text { get { return ReadString(0x00, 64); } }
		}
		
		[CompilerGenerated]
		public partial class StaticLight : MemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x5C; // 92
			
			public int x00 { get { return Read<int>(0x00); } }
			public int x04 { get { return Read<int>(0x04); } }
			public Vector3D x08_Vector3D { get { return Read<Vector3D>(0x08); } }
			public Vector3D x14_Vector3D { get { return Read<Vector3D>(0x14); } }
			public float x20 { get { return Read<float>(0x20); } }
			public int x24 { get { return Read<int>(0x24); } }
			public float[] x28_float { get { return Read<float>(0x28, 3); } }
			public float x34 { get { return Read<float>(0x34); } }
			public float x38 { get { return Read<float>(0x38); } }
			public float x3C { get { return Read<float>(0x3C); } }
			public float x40 { get { return Read<float>(0x40); } }
			public int x44 { get { return Read<int>(0x44); } }
			public int x48 { get { return Read<int>(0x48); } }
			public RGBAColorValue x4C_RGBAColorValue { get { return Read<RGBAColorValue>(0x4C); } }
		}
		
		[CompilerGenerated]
		public partial class BoneStructure : SerializeMemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x138; // 312
			
			public string x000_Text { get { return ReadString(0x000, 64); } }
			public int x040 { get { return Read<int>(0x040); } }
			public AABB x044_AABB { get { return Read<AABB>(0x044); } }
			public Sphere x05C_Sphere { get { return Read<Sphere>(0x05C); } }
			public PRSTransform x06C_PRSTransform { get { return Read<PRSTransform>(0x06C); } }
			public PRSTransform x08C_PRSTransform { get { return Read<PRSTransform>(0x08C); } }
			public PRSTransform x0AC_PRSTransform { get { return Read<PRSTransform>(0x0AC); } }
			public PRSTransform x0CC_PRSTransform { get { return Read<PRSTransform>(0x0CC); } }
			public PRSTransform x0EC_PRSTransform { get { return Read<PRSTransform>(0x0EC); } }
			public int x10C { get { return Read<int>(0x10C); } }
			public SerializeData x110_SerializeData { get { return Read<SerializeData>(0x110); } }
			public CollisionShape[] x118_CollisionShapes { get { return Deserialize<CollisionShape>(x110_SerializeData); } }
			public SerializeData x120_SerializeData { get { return Read<SerializeData>(0x120); } }
			public ConstraintParameters[] x128_ConstraintParameters { get { return Deserialize<ConstraintParameters>(x120_SerializeData); } }
			public Sno x130_ParticleSno { get { return Read<Sno>(0x130); } }
		}
		
		[CompilerGenerated]
		public partial class LookAtData : MemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x5C; // 92
			
			public int x00 { get { return Read<int>(0x00); } }
			public string x04_Text { get { return ReadString(0x04, 64); } }
			public Angle x44_Angle { get { return Read<Angle>(0x44); } }
			public Angle x48_Angle { get { return Read<Angle>(0x48); } }
			public Angle x4C_Angle { get { return Read<Angle>(0x4C); } }
			public Angle x50_Angle { get { return Read<Angle>(0x50); } }
			public AngularVelocity x54_AngularVelocity { get { return Read<AngularVelocity>(0x54); } }
			public float x58 { get { return Read<float>(0x58); } }
		}
		
		[CompilerGenerated]
		public partial class BonePulseData : MemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x4C; // 76
			
			public string x00_Text { get { return ReadString(0x00, 64); } }
			public float x40 { get { return Read<float>(0x40); } }
			public float x44 { get { return Read<float>(0x44); } }
			public Angle x48_Angle { get { return Read<Angle>(0x48); } }
		}
		
		[CompilerGenerated]
		public partial class GeoSet : SerializeMemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x18; // 24
			
			public int x00 { get { return Read<int>(0x00); } }
			public SerializeData x04_SerializeData { get { return Read<SerializeData>(0x04); } }
			public SubObject[] x10_SubObjects { get { return Deserialize<SubObject>(x04_SerializeData); } }
		}
		
		[CompilerGenerated]
		public partial class Sphere : MemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x10; // 16
			
			public Vector3D x00_Vector3D { get { return Read<Vector3D>(0x00); } }
			public float x0C { get { return Read<float>(0x0C); } }
		}
		
		[CompilerGenerated]
		public partial class CollisionCapsule : MemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x68; // 104
			
			public float x00 { get { return Read<float>(0x00); } }
			public float x04 { get { return Read<float>(0x04); } }
			public Hardpoint x08_Hardpoint { get { return Read<Hardpoint>(0x08); } }
		}
		
		[CompilerGenerated]
		public partial class Hardpoint : MemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x60; // 96
			
			public string x00_Text { get { return ReadString(0x00, 64); } }
			public int x40 { get { return Read<int>(0x40); } }
			public PRTransform x44_PRTransform { get { return Read<PRTransform>(0x44); } }
		}
		
		[CompilerGenerated]
		public partial class Vector3D : MemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x0C; // 12
			
			public float x00_X { get { return Read<float>(0x00); } }
			public float x04_Y { get { return Read<float>(0x04); } }
			public float x08_Z { get { return Read<float>(0x08); } }
		}
		
		[CompilerGenerated]
		public partial class Octree : SerializeMemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x48; // 72
			
			public int x00 { get { return Read<int>(0x00); } }
			public int x04 { get { return Read<int>(0x04); } }
			public int x08 { get { return Read<int>(0x08); } }
			public int x0C { get { return Read<int>(0x0C); } }
			public int x10 { get { return Read<int>(0x10); } }
			public int x14 { get { return Read<int>(0x14); } }
			public SerializeData x18_SerializeData { get { return Read<SerializeData>(0x18); } }
			public OctreeNode[] x20_OctreeNodes { get { return Deserialize<OctreeNode>(x18_SerializeData); } }
			public SerializeData x28_SerializeData { get { return Read<SerializeData>(0x28); } }
			public OctreeLeaf[] x30_OctreeLeafs { get { return Deserialize<OctreeLeaf>(x28_SerializeData); } }
			public SerializeData x38_SerializeData { get { return Read<SerializeData>(0x38); } }
			public OctreePrimitive[] x40_OctreePrimitives { get { return Deserialize<OctreePrimitive>(x38_SerializeData); } }
		}
		
		[CompilerGenerated]
		public partial class AABB : MemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x18; // 24
			
			public Vector3D x00_Vector3D { get { return Read<Vector3D>(0x00); } }
			public Vector3D x0C_Vector3D { get { return Read<Vector3D>(0x0C); } }
		}
		
		[CompilerGenerated]
		public partial class ConstraintParameters : MemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x124; // 292
			
			public string x000_Text { get { return ReadString(0x000, 64); } }
			public int x040 { get { return Read<int>(0x040); } }
			public int x044 { get { return Read<int>(0x044); } }
			public int x048 { get { return Read<int>(0x048); } }
			public int x04C { get { return Read<int>(0x04C); } }
			public PRTransform x050_PRTransform { get { return Read<PRTransform>(0x050); } }
			public Vector3D x06C_Vector3D { get { return Read<Vector3D>(0x06C); } }
			public PRTransform x078_PRTransform { get { return Read<PRTransform>(0x078); } }
			public PRTransform x094_PRTransform { get { return Read<PRTransform>(0x094); } }
			public float x0B0 { get { return Read<float>(0x0B0); } }
			public float x0B4 { get { return Read<float>(0x0B4); } }
			public float x0B8 { get { return Read<float>(0x0B8); } }
			public float x0BC { get { return Read<float>(0x0BC); } }
			public float x0C0 { get { return Read<float>(0x0C0); } }
			public float x0C4 { get { return Read<float>(0x0C4); } }
			public float x0C8 { get { return Read<float>(0x0C8); } }
			public float x0CC { get { return Read<float>(0x0CC); } }
			public float x0D0 { get { return Read<float>(0x0D0); } }
			public float x0D4 { get { return Read<float>(0x0D4); } }
			public float x0D8 { get { return Read<float>(0x0D8); } }
			public float x0DC { get { return Read<float>(0x0DC); } }
			public float x0E0 { get { return Read<float>(0x0E0); } }
			public string x0E4_Text { get { return ReadString(0x0E4, 64); } }
		}
		
		[CompilerGenerated]
		public partial class SubObjectAppearance : SerializeMemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0xF8; // 248
			
			public int x00 { get { return Read<int>(0x00); } }
			public Sno x04_ClothSno { get { return Read<Sno>(0x04); } }
			public SerializeData x08_SerializeData { get { return Read<SerializeData>(0x08); } }
			public int[] x10_TagMap { get { return Deserialize<int>(x08_SerializeData); } }
			public UberMaterial x18_UberMaterial { get { return Read<UberMaterial>(0x18); } }
			public Sno x80_MaterialSno { get { return Read<Sno>(0x80); } }
			public UberMaterial x88_UberMaterial { get { return Read<UberMaterial>(0x88); } }
		}
		
		[CompilerGenerated]
		public partial class RGBAColorValue : MemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x10; // 16
			
			public float x00 { get { return Read<float>(0x00); } }
			public float x04 { get { return Read<float>(0x04); } }
			public float x08 { get { return Read<float>(0x08); } }
			public float x0C { get { return Read<float>(0x0C); } }
		}
		
		[CompilerGenerated]
		public partial class PRSTransform : MemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x20; // 32
			
			public Quaternion x00_Quaternion { get { return Read<Quaternion>(0x00); } }
			public Vector3D x10_Vector3D { get { return Read<Vector3D>(0x10); } }
			public float x1C { get { return Read<float>(0x1C); } }
		}
		
		[CompilerGenerated]
		public partial class CollisionShape : SerializeMemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x50; // 80
			
			public int x00 { get { return Read<int>(0x00); } }
			public int x04 { get { return Read<int>(0x04); } }
			public int x08 { get { return Read<int>(0x08); } }
			public int x0C { get { return Read<int>(0x0C); } }
			public float x10 { get { return Read<float>(0x10); } }
			public float x14 { get { return Read<float>(0x14); } }
			public float x18 { get { return Read<float>(0x18); } }
			public SerializeData x1C_SerializeData { get { return Read<SerializeData>(0x1C); } }
			public PolytopeData[] x28_PolytopeDatas { get { return Deserialize<PolytopeData>(x1C_SerializeData); } }
			public Vector3D x30_Vector3D { get { return Read<Vector3D>(0x30); } }
			public Vector3D x3C_Vector3D { get { return Read<Vector3D>(0x3C); } }
			public float x48 { get { return Read<float>(0x48); } }
		}
		
		[CompilerGenerated]
		public partial class SubObject : SerializeMemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x190; // 400
			
			public int x000 { get { return Read<int>(0x000); } }
			public int x004 { get { return Read<int>(0x004); } }
			public SerializeData x008_SerializeData { get { return Read<SerializeData>(0x008); } }
			public FatVertex[] x010_FatVertexs { get { return Deserialize<FatVertex>(x008_SerializeData); } }
			public SerializeData x018_SerializeData { get { return Read<SerializeData>(0x018); } }
			public VertInfluences[] x020_VertInfluences { get { return Deserialize<VertInfluences>(x018_SerializeData); } }
			public int x028 { get { return Read<int>(0x028); } }
			public SerializeData x02C_SerializeData { get { return Read<SerializeData>(0x02C); } }
			public short[] x038_short { get { return Deserialize<short>(x02C_SerializeData); } }
			public SerializeData x040_SerializeData { get { return Read<SerializeData>(0x040); } }
			public ClothStructure[] x048_ClothStructures { get { return Deserialize<ClothStructure>(x040_SerializeData); } }
			public Sno x050_SurfaceSno { get { return Read<Sno>(0x050); } }
			public int x054 { get { return Read<int>(0x054); } }
			public float x058 { get { return Read<float>(0x058); } }
			public string x05C_Text { get { return ReadString(0x05C, 128); } }
			public string x0DC_Text { get { return ReadString(0x0DC, 128); } }
			public AABB x15C_AABB { get { return Read<AABB>(0x15C); } }
			public int x174 { get { return Read<int>(0x174); } }
			public SerializeData x178_SerializeData { get { return Read<SerializeData>(0x178); } }
			public CollisionShape[] x180_CollisionShapes { get { return Deserialize<CollisionShape>(x178_SerializeData); } }
			public long x188 { get { return Read<long>(0x188); } }
		}
		
		[CompilerGenerated]
		public partial class PRTransform : MemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x1C; // 28
			
			public Quaternion x00_Quaternion { get { return Read<Quaternion>(0x00); } }
			public Vector3D x10_Vector3D { get { return Read<Vector3D>(0x10); } }
		}
		
		[CompilerGenerated]
		public partial class OctreeNode : MemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x30; // 48
			
			public OctreeCube x00_OctreeCube { get { return Read<OctreeCube>(0x00); } }
			public int[] x10_int { get { return Read<int>(0x10, 8); } }
		}
		
		[CompilerGenerated]
		public partial class OctreeLeaf : MemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x18; // 24
			
			public OctreeCube x00_OctreeCube { get { return Read<OctreeCube>(0x00); } }
			public int x10 { get { return Read<int>(0x10); } }
			public int x14 { get { return Read<int>(0x14); } }
		}
		
		[CompilerGenerated]
		public partial class OctreePrimitive : MemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x08; // 8
			
			public int x00 { get { return Read<int>(0x00); } }
			public int x04 { get { return Read<int>(0x04); } }
		}
		
		[CompilerGenerated]
		public partial class UberMaterial : SerializeMemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x68; // 104
			
			public Sno x00_ShaderMapSno { get { return Read<Sno>(0x00); } }
			public Material x04_Material { get { return Read<Material>(0x04); } }
			public SerializeData x4C_SerializeData { get { return Read<SerializeData>(0x4C); } }
			public MaterialTextureEntry[] x58_MaterialTextureEntries { get { return Deserialize<MaterialTextureEntry>(x4C_SerializeData); } }
		}
		
		[CompilerGenerated]
		public partial class Quaternion : MemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x10; // 16
			
			public Vector3D x00_Vector3D { get { return Read<Vector3D>(0x00); } }
			public float x0C { get { return Read<float>(0x0C); } }
		}
		
		[CompilerGenerated]
		public partial class PolytopeData : SerializeMemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x60; // 96
			
			public dmFloat3[] x00_dmFloat3s { get { return Deserialize<dmFloat3>(x40_SerializeData); } }
			public dmPlane[] x08_dmPlanes { get { return Deserialize<dmPlane>(x48_SerializeData); } }
			public dmSubEdge[] x10_dmSubEdges { get { return Deserialize<dmSubEdge>(x50_SerializeData); } }
			public byte[] x18_byte { get { return Deserialize<byte>(x58_SerializeData); } }
			public dmFloat3 x20_dmFloat3 { get { return Read<dmFloat3>(0x20); } }
			public int x2C { get { return Read<int>(0x2C); } }
			public int x30 { get { return Read<int>(0x30); } }
			public int x34 { get { return Read<int>(0x34); } }
			public float x38 { get { return Read<float>(0x38); } }
			public float x3C { get { return Read<float>(0x3C); } }
			public SerializeData x40_SerializeData { get { return Read<SerializeData>(0x40); } }
			public SerializeData x48_SerializeData { get { return Read<SerializeData>(0x48); } }
			public SerializeData x50_SerializeData { get { return Read<SerializeData>(0x50); } }
			public SerializeData x58_SerializeData { get { return Read<SerializeData>(0x58); } }
		}
		
		[CompilerGenerated]
		public partial class FatVertex : MemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x2C; // 44
			
			public Vector3D x00_Vector3D { get { return Read<Vector3D>(0x00); } }
			public RGBAColor x0C_RGBAColor { get { return Read<RGBAColor>(0x0C); } }
			public RGBAColor[] x10_RGBAColors { get { return Read<RGBAColor>(0x10, 2); } }
			public RGBAColor[] x18_RGBAColors { get { return Read<RGBAColor>(0x18, 2); } }
			public RGBAColor x20_RGBAColor { get { return Read<RGBAColor>(0x20); } }
			public RGBAColor x24_RGBAColor { get { return Read<RGBAColor>(0x24); } }
			public short x28 { get { return Read<short>(0x28); } }
			public short x2A { get { return Read<short>(0x2A); } }
		}
		
		[CompilerGenerated]
		public partial class VertInfluences : MemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x18; // 24
			
			public Influence[] x00_Influences { get { return Read<Influence>(0x00, 3); } }
		}
		
		[CompilerGenerated]
		public partial class ClothStructure : SerializeMemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x80; // 128
			
			public int x00 { get { return Read<int>(0x00); } }
			public SerializeData x04_SerializeData { get { return Read<SerializeData>(0x04); } }
			public ClothVertexSerializable[] x10_ClothVertexSerializables { get { return Deserialize<ClothVertexSerializable>(x04_SerializeData); } }
			public int x18 { get { return Read<int>(0x18); } }
			public SerializeData x1C_SerializeData { get { return Read<SerializeData>(0x1C); } }
			public ClothFaceSerializable[] x28_ClothFaceSerializables { get { return Deserialize<ClothFaceSerializable>(x1C_SerializeData); } }
			public int x30 { get { return Read<int>(0x30); } }
			public SerializeData x34_SerializeData { get { return Read<SerializeData>(0x34); } }
			public ClothStaple[] x40_ClothStaples { get { return Deserialize<ClothStaple>(x34_SerializeData); } }
			public int x48 { get { return Read<int>(0x48); } }
			public SerializeData x4C_SerializeData { get { return Read<SerializeData>(0x4C); } }
			public ClothConstraintSerializable[] x58_ClothConstraintSerializables { get { return Deserialize<ClothConstraintSerializable>(x4C_SerializeData); } }
			public int x60 { get { return Read<int>(0x60); } }
			public SerializeData x64_SerializeData { get { return Read<SerializeData>(0x64); } }
			public ClothConstraintSerializable[] x70_ClothConstraintSerializables { get { return Deserialize<ClothConstraintSerializable>(x64_SerializeData); } }
			public int x78 { get { return Read<int>(0x78); } }
			public float x7C { get { return Read<float>(0x7C); } }
		}
		
		[CompilerGenerated]
		public partial class OctreeCube : MemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x10; // 16
			
			public Vector3D x00_Vector3D { get { return Read<Vector3D>(0x00); } }
			public float x0C { get { return Read<float>(0x0C); } }
		}
		
		[CompilerGenerated]
		public partial class Material : MemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x48; // 72
			
			public RGBAColorValue x00_RGBAColorValue { get { return Read<RGBAColorValue>(0x00); } }
			public RGBAColorValue x10_RGBAColorValue { get { return Read<RGBAColorValue>(0x10); } }
			public RGBAColorValue x20_RGBAColorValue { get { return Read<RGBAColorValue>(0x20); } }
			public RGBAColorValue x30_RGBAColorValue { get { return Read<RGBAColorValue>(0x30); } }
			public float x40 { get { return Read<float>(0x40); } }
			public int x44 { get { return Read<int>(0x44); } }
		}
		
		[CompilerGenerated]
		public partial class MaterialTextureEntry : MemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0xA0; // 160
			
			public int x00 { get { return Read<int>(0x00); } }
			public int x04 { get { return Read<int>(0x04); } }
			public MaterialTexture x08_MaterialTexture { get { return Read<MaterialTexture>(0x08); } }
		}
		
		[CompilerGenerated]
		public partial class dmFloat3 : MemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x0C; // 12
			
			public float x00 { get { return Read<float>(0x00); } }
			public float x04 { get { return Read<float>(0x04); } }
			public float x08 { get { return Read<float>(0x08); } }
		}
		
		[CompilerGenerated]
		public partial class dmPlane : MemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x10; // 16
			
			public dmFloat3 x00_dmFloat3 { get { return Read<dmFloat3>(0x00); } }
			public float x0C { get { return Read<float>(0x0C); } }
		}
		
		[CompilerGenerated]
		public partial class dmSubEdge : MemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x04; // 4
			
			public byte x00 { get { return Read<byte>(0x00); } }
			public byte x01 { get { return Read<byte>(0x01); } }
			public byte x02 { get { return Read<byte>(0x02); } }
			public byte x03 { get { return Read<byte>(0x03); } }
		}
		
		[CompilerGenerated]
		public partial class RGBAColor : MemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x04; // 4
			
			public byte x00 { get { return Read<byte>(0x00); } }
			public byte x01 { get { return Read<byte>(0x01); } }
			public byte x02 { get { return Read<byte>(0x02); } }
			public byte x03 { get { return Read<byte>(0x03); } }
		}
		
		[CompilerGenerated]
		public partial class Influence : MemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x08; // 8
			
			public int x00 { get { return Read<int>(0x00); } }
			public float x04 { get { return Read<float>(0x04); } }
		}
		
		[CompilerGenerated]
		public partial class ClothVertexSerializable : MemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x54; // 84
			
			public Vector3D x00_Vector3D { get { return Read<Vector3D>(0x00); } }
			public Vector3D x0C_Vector3D { get { return Read<Vector3D>(0x0C); } }
			public Vector3D x18_Vector3D { get { return Read<Vector3D>(0x18); } }
			public Vector3D x24_Vector3D { get { return Read<Vector3D>(0x24); } }
			public float x30 { get { return Read<float>(0x30); } }
			public int x34 { get { return Read<int>(0x34); } }
			public int x38 { get { return Read<int>(0x38); } }
			public int x3C { get { return Read<int>(0x3C); } }
			public int x40 { get { return Read<int>(0x40); } }
			public Vector3D x44_Vector3D { get { return Read<Vector3D>(0x44); } }
			public int x50 { get { return Read<int>(0x50); } }
		}
		
		[CompilerGenerated]
		public partial class ClothFaceSerializable : MemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x1C; // 28
			
			public Vector3D x00_Vector3D { get { return Read<Vector3D>(0x00); } }
			public float x0C { get { return Read<float>(0x0C); } }
			public int x10 { get { return Read<int>(0x10); } }
			public int x14 { get { return Read<int>(0x14); } }
			public int x18 { get { return Read<int>(0x18); } }
		}
		
		[CompilerGenerated]
		public partial class ClothStaple : MemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x1C; // 28
			
			public int x00 { get { return Read<int>(0x00); } }
			public int[] x04_int { get { return Read<int>(0x04, 3); } }
			public float[] x10_float { get { return Read<float>(0x10, 3); } }
		}
		
		[CompilerGenerated]
		public partial class ClothConstraintSerializable : MemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x18; // 24
			
			public int x00 { get { return Read<int>(0x00); } }
			public int x04 { get { return Read<int>(0x04); } }
			public float x08 { get { return Read<float>(0x08); } }
			public float x0C { get { return Read<float>(0x0C); } }
			public float x10 { get { return Read<float>(0x10); } }
			public float x14 { get { return Read<float>(0x14); } }
		}
		
		[CompilerGenerated]
		public partial class MaterialTexture : MemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x98; // 152
			
			public Sno x00_TexturesSno { get { return Read<Sno>(0x00); } }
			public TexAnimParams x04_TexAnimParams { get { return Read<TexAnimParams>(0x04); } }
			public int x94 { get { return Read<int>(0x94); } }
		}
		
		[CompilerGenerated]
		public partial class TexAnimParams : MemoryObject
		{
			// 2.1.0.26451
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
			// 2.1.0.26451
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
			// 2.1.0.26451
			public const int SizeOf = 0x14; // 20
			
			public int x00 { get { return Read<int>(0x00); } }
			public Velocity x04_Velocity { get { return Read<Velocity>(0x04); } }
			public Velocity x08_Velocity { get { return Read<Velocity>(0x08); } }
			public int x0C { get { return Read<int>(0x0C); } }
			public int x10 { get { return Read<int>(0x10); } }
		}
	}
}
