using System.Runtime.CompilerServices;
using Enigma.D3.Collections;
using Enigma.D3.Memory;
using Enigma.Memory;

namespace Enigma.D3.Sno
{
	[CompilerGenerated]
	public partial class Worlds : SerializeMemoryObject
	{
		// 2.1.0.26451
		public const int SizeOf = 0xB8; // 184
		
		public SnoHeader x00_Header { get { return Read<SnoHeader>(0x00); } }
		public int x0C { get { return Read<int>(0x0C); } }
		public SerializeData x10_SerializeData { get { return Read<SerializeData>(0x10); } }
		public WorldServerData[] x18_WorldServerDatas { get { return Deserialize<WorldServerData>(x10_SerializeData); } }
		public SerializeData x20_SerializeData { get { return Read<SerializeData>(0x20); } }
		public Sno[] x28_Snos { get { return Deserialize<Sno>(x20_SerializeData); } }
		public Environment x60_Environment { get { return Read<Environment>(0x60); } }
		public float xAC { get { return Read<float>(0xAC); } }
		public int xB0 { get { return Read<int>(0xB0); } }
		public float xB4 { get { return Read<float>(0xB4); } }
		
		[CompilerGenerated]
		public partial class WorldServerData : SerializeMemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x90; // 144
			
			public SerializeData x00_SerializeData { get { return Read<SerializeData>(0x00); } }
			public DRLGParams[] x08_DRLGParams { get { return Deserialize<DRLGParams>(x00_SerializeData); } }
			public SerializeData x10_SerializeData { get { return Read<SerializeData>(0x10); } }
			public SceneParams[] x18_SceneParams { get { return Deserialize<SceneParams>(x10_SerializeData); } }
			public LabelRuleSet x20_LabelRuleSet { get { return Read<LabelRuleSet>(0x20); } }
			public int x38 { get { return Read<int>(0x38); } }
			public SceneClusterSet x40_SceneClusterSet { get { return Read<SceneClusterSet>(0x40); } }
			public Sno[] x58_Snos { get { return Read<Sno>(0x58, 4); } }
			public GameBalanceId[] x68_GameBalanceIds { get { return Read<GameBalanceId>(0x68, 3); } }
			public Sno x74_35Sno { get { return Read<Sno>(0x74); } }
			public int x78 { get { return Read<int>(0x78); } }
			public Sno[] x80_Snos { get { return Deserialize<Sno>(x88_SerializeData); } }
			public SerializeData x88_SerializeData { get { return Read<SerializeData>(0x88); } }
		}
		
		[CompilerGenerated]
		public partial class Environment : MemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x4C; // 76
			
			public RGBAColor x00_RGBAColor { get { return Read<RGBAColor>(0x00); } }
			public PostFXParams x04_PostFXParams { get { return Read<PostFXParams>(0x04); } }
			public Sno x24_ActorSno { get { return Read<Sno>(0x24); } }
			public Sno x28_MusicSno { get { return Read<Sno>(0x28); } }
			public Sno x2C_MusicSno { get { return Read<Sno>(0x2C); } }
			public float x30 { get { return Read<float>(0x30); } }
			public float x34 { get { return Read<float>(0x34); } }
			public Sno x38_AmbientSoundSno { get { return Read<Sno>(0x38); } }
			public Sno x3C_ReverbSno { get { return Read<Sno>(0x3C); } }
			public Sno x40_WeatherSno { get { return Read<Sno>(0x40); } }
			public Sno x44_TexturesSno { get { return Read<Sno>(0x44); } }
			public Sno x48_TexturesSno { get { return Read<Sno>(0x48); } }
		}
		
		[CompilerGenerated]
		public partial class DRLGParams : SerializeMemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x78; // 120
			
			public SerializeData x00_SerializeData { get { return Read<SerializeData>(0x00); } }
			public TileInfo[] x08_TileInfos { get { return Deserialize<TileInfo>(x00_SerializeData); } }
			public int x40 { get { return Read<int>(0x40); } }
			public SerializeData x44_SerializeData { get { return Read<SerializeData>(0x44); } }
			public DRLGCommand[] x50_DRLGCommands { get { return Deserialize<DRLGCommand>(x44_SerializeData); } }
			public SerializeData x58_SerializeData { get { return Read<SerializeData>(0x58); } }
			public int[] x60_int { get { return Deserialize<int>(x58_SerializeData); } }
			public SerializeData x68_SerializeData { get { return Read<SerializeData>(0x68); } }
			public int[] x70_TagMap { get { return Deserialize<int>(x68_SerializeData); } }
		}
		
		[CompilerGenerated]
		public partial class SceneParams : SerializeMemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x18; // 24
			
			public SerializeData x00_SerializeData { get { return Read<SerializeData>(0x00); } }
			public int x08 { get { return Read<int>(0x08); } }
			public SceneChunk[] x10_SceneChunks { get { return Deserialize<SceneChunk>(x00_SerializeData); } }
		}
		
		[CompilerGenerated]
		public partial class LabelRuleSet : SerializeMemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x18; // 24
			
			public int x00 { get { return Read<int>(0x00); } }
			public LabelRule[] x08_LabelRules { get { return Deserialize<LabelRule>(x10_SerializeData); } }
			public SerializeData x10_SerializeData { get { return Read<SerializeData>(0x10); } }
		}
		
		[CompilerGenerated]
		public partial class SceneClusterSet : SerializeMemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x18; // 24
			
			public int x00 { get { return Read<int>(0x00); } }
			public SceneCluster[] x08_SceneClusters { get { return Deserialize<SceneCluster>(x10_SerializeData); } }
			public SerializeData x10_SerializeData { get { return Read<SerializeData>(0x10); } }
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
		public partial class PostFXParams : MemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x20; // 32
			
			public float[] x00_float { get { return Read<float>(0x00, 4); } }
			public float[] x10_float { get { return Read<float>(0x10, 4); } }
		}
		
		[CompilerGenerated]
		public partial class TileInfo : SerializeMemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x50; // 80
			
			public int x00 { get { return Read<int>(0x00); } }
			public int x04 { get { return Read<int>(0x04); } }
			public Sno x08_SceneSno { get { return Read<Sno>(0x08); } }
			public int x0C { get { return Read<int>(0x0C); } }
			public SerializeData x10_SerializeData { get { return Read<SerializeData>(0x10); } }
			public int[] x18_TagMap { get { return Deserialize<int>(x10_SerializeData); } }
			public CustomTileInfo x20_CustomTileInfo { get { return Read<CustomTileInfo>(0x20); } }
			public int x48 { get { return Read<int>(0x48); } }
		}
		
		[CompilerGenerated]
		public partial class DRLGCommand : SerializeMemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x98; // 152
			
			public string x00_Text { get { return ReadString(0x00, 128); } }
			public int x80 { get { return Read<int>(0x80); } }
			public SerializeData x84_SerializeData { get { return Read<SerializeData>(0x84); } }
			public int[] x90_TagMap { get { return Deserialize<int>(x84_SerializeData); } }
		}
		
		[CompilerGenerated]
		public partial class SceneChunk : MemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x100; // 256
			
			public SNOName x000_SNOName { get { return Read<SNOName>(0x000); } }
			public PRTransform x008_PRTransform { get { return Read<PRTransform>(0x008); } }
			public SceneSpecification x024_SceneSpecification { get { return Read<SceneSpecification>(0x024); } }
		}
		
		[CompilerGenerated]
		public partial class LabelRule : SerializeMemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0xB0; // 176
			
			public string x00_Text { get { return ReadString(0x00, 128); } }
			public LabelCondition x80_LabelCondition { get { return Read<LabelCondition>(0x80); } }
			public int x98 { get { return Read<int>(0x98); } }
			public int x9C { get { return Read<int>(0x9C); } }
			public LabelEntry[] xA0_LabelEntries { get { return Deserialize<LabelEntry>(xA8_SerializeData); } }
			public SerializeData xA8_SerializeData { get { return Read<SerializeData>(0xA8); } }
		}
		
		[CompilerGenerated]
		public partial class SceneCluster : SerializeMemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0xB8; // 184
			
			public string x00_Text { get { return ReadString(0x00, 128); } }
			public int x80 { get { return Read<int>(0x80); } }
			public int x84 { get { return Read<int>(0x84); } }
			public SubSceneGroup[] x88_SubSceneGroups { get { return Deserialize<SubSceneGroup>(x90_SerializeData); } }
			public SerializeData x90_SerializeData { get { return Read<SerializeData>(0x90); } }
			public SubSceneGroup x98_SubSceneGroup { get { return Read<SubSceneGroup>(0x98); } }
		}
		
		[CompilerGenerated]
		public partial class CustomTileInfo : SerializeMemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x28; // 40
			
			public int x00 { get { return Read<int>(0x00); } }
			public int x04 { get { return Read<int>(0x04); } }
			public int x08 { get { return Read<int>(0x08); } }
			public IVector2D x0C_IVector2D { get { return Read<IVector2D>(0x0C); } }
			public SerializeData x14_SerializeData { get { return Read<SerializeData>(0x14); } }
			public CustomTileCell[] x20_CustomTileCells { get { return Deserialize<CustomTileCell>(x14_SerializeData); } }
		}
		
		[CompilerGenerated]
		public partial class SNOName : MemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x08; // 8
			
			public SnoGroup x00_SnoGroup { get { return Read<SnoGroup>(0x00); } }
			public SnoNameHandle x04_SnoNameHandle { get { return Read<SnoNameHandle>(0x04); } }
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
		public partial class SceneSpecification : MemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0xDC; // 220
			
			public int x00 { get { return Read<int>(0x00); } }
			public IVector2D x04_IVector2D { get { return Read<IVector2D>(0x04); } }
			public Sno[] x0C_Snos { get { return Read<Sno>(0x0C, 4); } }
			public Sno x1C_WorldsSno { get { return Read<Sno>(0x1C); } }
			public int x20 { get { return Read<int>(0x20); } }
			public Sno x24_LevelAreaSno { get { return Read<Sno>(0x24); } }
			public Sno x28_WorldsSno { get { return Read<Sno>(0x28); } }
			public int x2C { get { return Read<int>(0x2C); } }
			public Sno x30_LevelAreaSno { get { return Read<Sno>(0x30); } }
			public Sno x34_MusicSno { get { return Read<Sno>(0x34); } }
			public Sno x38_AmbientSoundSno { get { return Read<Sno>(0x38); } }
			public Sno x3C_ReverbSno { get { return Read<Sno>(0x3C); } }
			public Sno x40_WeatherSno { get { return Read<Sno>(0x40); } }
			public Sno x44_WorldsSno { get { return Read<Sno>(0x44); } }
			public int x48 { get { return Read<int>(0x48); } }
			public int x4C { get { return Read<int>(0x4C); } }
			public int x50 { get { return Read<int>(0x50); } }
			public int x88 { get { return Read<int>(0x88); } }
			public SceneCachedValues x8C_SceneCachedValues { get { return Read<SceneCachedValues>(0x8C); } }
		}
		
		[CompilerGenerated]
		public partial class LabelCondition : MemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x18; // 24
			
			public int x00_Enum { get { return Read<int>(0x00); } } // Always = 0, Label Already Set = 2, Game Is Open World = 3
			public int x04 { get { return Read<int>(0x04); } }
			public int[] x08_int { get { return Read<int>(0x08, 4); } }
		}
		
		[CompilerGenerated]
		public partial class LabelEntry : MemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x14; // 20
			
			public GameBalanceId x00_LabelsGameBalanceId { get { return Read<GameBalanceId>(0x00); } }
			public int x04 { get { return Read<int>(0x04); } }
			public float x08 { get { return Read<float>(0x08); } }
			public int x0C { get { return Read<int>(0x0C); } }
			public int x10 { get { return Read<int>(0x10); } }
		}
		
		[CompilerGenerated]
		public partial class SubSceneGroup : SerializeMemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x20; // 32
			
			public Sno x00_ConditionSno { get { return Read<Sno>(0x00); } }
			public int x04 { get { return Read<int>(0x04); } }
			public int x08 { get { return Read<int>(0x08); } }
			public SubSceneEntry[] x10_SubSceneEntries { get { return Deserialize<SubSceneEntry>(x18_SerializeData); } }
			public SerializeData x18_SerializeData { get { return Read<SerializeData>(0x18); } }
		}
		
		[CompilerGenerated]
		public partial class IVector2D : MemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x08; // 8
			
			public int x00 { get { return Read<int>(0x00); } }
			public int x04 { get { return Read<int>(0x04); } }
		}
		
		[CompilerGenerated]
		public partial class CustomTileCell : MemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x24; // 36
			
			public int x00 { get { return Read<int>(0x00); } }
			public int x04 { get { return Read<int>(0x04); } }
			public int x08 { get { return Read<int>(0x08); } }
			public Sno x0C_SceneSno { get { return Read<Sno>(0x0C); } }
			public int x10 { get { return Read<int>(0x10); } }
			public int[] x14_int { get { return Read<int>(0x14, 4); } }
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
		public partial class Vector3D : MemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x0C; // 12
			
			public float x00_X { get { return Read<float>(0x00); } }
			public float x04_Y { get { return Read<float>(0x04); } }
			public float x08_Z { get { return Read<float>(0x08); } }
		}
		
		[CompilerGenerated]
		public partial class SceneCachedValues : MemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x50; // 80
			
			public int x00 { get { return Read<int>(0x00); } }
			public int x04 { get { return Read<int>(0x04); } }
			public int x08 { get { return Read<int>(0x08); } }
			public AABB x0C_AABB { get { return Read<AABB>(0x0C); } }
			public AABB x24_AABB { get { return Read<AABB>(0x24); } }
			public int[] x3C_int { get { return Read<int>(0x3C, 4); } }
			public int x4C { get { return Read<int>(0x4C); } }
		}
		
		[CompilerGenerated]
		public partial class SubSceneEntry : SerializeMemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x20; // 32
			
			public Sno x00_SceneSno { get { return Read<Sno>(0x00); } }
			public int x04 { get { return Read<int>(0x04); } }
			public int x08 { get { return Read<int>(0x08); } }
			public SubSceneLabel[] x10_SubSceneLabels { get { return Deserialize<SubSceneLabel>(x18_SerializeData); } }
			public SerializeData x18_SerializeData { get { return Read<SerializeData>(0x18); } }
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
		public partial class SubSceneLabel : MemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x08; // 8
			
			public GameBalanceId x00_GameBalanceId { get { return Read<GameBalanceId>(0x00); } }
			public int x04 { get { return Read<int>(0x04); } }
		}
	}
}
