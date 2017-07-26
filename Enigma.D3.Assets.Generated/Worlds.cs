using System.Runtime.CompilerServices;
using Enigma.D3.DataTypes;
using Enigma.Memory;

namespace Enigma.D3.Assets
{
	[CompilerGenerated]
	public partial class Worlds : SerializeMemoryObject
	{
		public const int SizeOf = 0xB8; // 184
		
		public SNOHeader x00_Header { get { return Read<SNOHeader>(0x00); } }
		public int x0C { get { return Read<int>(0x0C); } }
		public SerializeData x10_SerializeData { get { return Read<SerializeData>(0x10); } }
		public WorldServerData[] x18_WorldServerData { get { return Deserialize<WorldServerData>(x10_SerializeData); } }
		public SerializeData x20_SerializeData { get { return Read<SerializeData>(0x20); } }
		public SNO[] x28_SNOs { get { return Deserialize<SNO>(x20_SerializeData); } }
		public Environment x60_Environment { get { return Read<Environment>(0x60); } }
		public float xAC { get { return Read<float>(0xAC); } }
		public int xB0 { get { return Read<int>(0xB0); } }
		public float xB4 { get { return Read<float>(0xB4); } }
		
		[CompilerGenerated]
		public partial class WorldServerData : SerializeMemoryObject
		{
			public const int SizeOf = 0x90; // 144
			
			public SerializeData x00_SerializeData { get { return Read<SerializeData>(0x00); } }
			public DRLGParams[] x08_DRLGParams { get { return Deserialize<DRLGParams>(x00_SerializeData); } }
			public SerializeData x10_SerializeData { get { return Read<SerializeData>(0x10); } }
			public SceneParams[] x18_SceneParams { get { return Deserialize<SceneParams>(x10_SerializeData); } }
			public LabelRuleSet x20_LabelRuleSet { get { return Read<LabelRuleSet>(0x20); } }
			public int x38 { get { return Read<int>(0x38); } }
			public SceneClusterSet x40_SceneClusterSet { get { return Read<SceneClusterSet>(0x40); } }
			public SNO[] x58_SNOs { get { return Read<SNO>(0x58, 4); } }
			public GBID[] x68_GBIDs { get { return Read<GBID>(0x68, 3); } }
			public SNO x74_35SNO { get { return Read<SNO>(0x74); } }
			public int x78 { get { return Read<int>(0x78); } }
			public SNO[] x80_SNOs { get { return Deserialize<SNO>(x88_SerializeData); } }
			public SerializeData x88_SerializeData { get { return Read<SerializeData>(0x88); } }
		}
		
		[CompilerGenerated]
		public partial class Environment : MemoryObject
		{
			public const int SizeOf = 0x4C; // 76
			
			public DT_RGBACOLOR x00_DT_RGBACOLOR { get { return Read<DT_RGBACOLOR>(0x00); } }
			public PostFXParams x04_PostFXParams { get { return Read<PostFXParams>(0x04); } }
			public SNO x24_ActorSNO { get { return Read<SNO>(0x24); } }
			public SNO x28_MusicSNO { get { return Read<SNO>(0x28); } }
			public SNO x2C_MusicSNO { get { return Read<SNO>(0x2C); } }
			public float x30 { get { return Read<float>(0x30); } }
			public float x34 { get { return Read<float>(0x34); } }
			public SNO x38_AmbientSoundSNO { get { return Read<SNO>(0x38); } }
			public SNO x3C_ReverbSNO { get { return Read<SNO>(0x3C); } }
			public SNO x40_WeatherSNO { get { return Read<SNO>(0x40); } }
			public SNO x44_TexturesSNO { get { return Read<SNO>(0x44); } }
			public SNO x48_TexturesSNO { get { return Read<SNO>(0x48); } }
		}
		
		[CompilerGenerated]
		public partial class DRLGParams : SerializeMemoryObject
		{
			public const int SizeOf = 0x78; // 120
			
			public SerializeData x00_SerializeData { get { return Read<SerializeData>(0x00); } }
			public TileInfo[] x08_TileInfos { get { return Deserialize<TileInfo>(x00_SerializeData); } }
			public int x40 { get { return Read<int>(0x40); } }
			public SerializeData x44_SerializeData { get { return Read<SerializeData>(0x44); } }
			public DRLGCommand[] x50_DRLGCommands { get { return Deserialize<DRLGCommand>(x44_SerializeData); } }
			public SerializeData x58_SerializeData { get { return Read<SerializeData>(0x58); } }
			public int[] x60_int { get { return Deserialize<int>(x58_SerializeData); } }
			public SerializeData x68_SerializeData { get { return Read<SerializeData>(0x68); } }
			public TagMap x70_TagMap { get { return new TagMap(Deserialize<byte>(x68_SerializeData)); } } // type: 0x000D0000
		}
		
		[CompilerGenerated]
		public partial class SceneParams : SerializeMemoryObject
		{
			public const int SizeOf = 0x18; // 24
			
			public SerializeData x00_SerializeData { get { return Read<SerializeData>(0x00); } }
			public int x08 { get { return Read<int>(0x08); } }
			public SceneChunk[] x10_SceneChunks { get { return Deserialize<SceneChunk>(x00_SerializeData); } }
		}
		
		[CompilerGenerated]
		public partial class LabelRuleSet : SerializeMemoryObject
		{
			public const int SizeOf = 0x18; // 24
			
			public int x00 { get { return Read<int>(0x00); } }
			public LabelRule[] x08_LabelRules { get { return Deserialize<LabelRule>(x10_SerializeData); } }
			public SerializeData x10_SerializeData { get { return Read<SerializeData>(0x10); } }
		}
		
		[CompilerGenerated]
		public partial class SceneClusterSet : SerializeMemoryObject
		{
			public const int SizeOf = 0x18; // 24
			
			public int x00 { get { return Read<int>(0x00); } }
			public SceneCluster[] x08_SceneClusters { get { return Deserialize<SceneCluster>(x10_SerializeData); } }
			public SerializeData x10_SerializeData { get { return Read<SerializeData>(0x10); } }
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
		public partial class PostFXParams : MemoryObject
		{
			public const int SizeOf = 0x20; // 32
			
			public float[] x00_float { get { return Read<float>(0x00, 4); } }
			public float[] x10_float { get { return Read<float>(0x10, 4); } }
		}
		
		[CompilerGenerated]
		public partial class TileInfo : SerializeMemoryObject
		{
			public const int SizeOf = 0x50; // 80
			
			public int x00 { get { return Read<int>(0x00); } }
			public int x04 { get { return Read<int>(0x04); } }
			public SNO x08_SceneSNO { get { return Read<SNO>(0x08); } }
			public int x0C { get { return Read<int>(0x0C); } }
			public SerializeData x10_SerializeData { get { return Read<SerializeData>(0x10); } }
			public TagMap x18_TagMap { get { return new TagMap(Deserialize<byte>(x10_SerializeData)); } } // type: 0x000F0000
			public CustomTileInfo x20_CustomTileInfo { get { return Read<CustomTileInfo>(0x20); } }
			public int x48 { get { return Read<int>(0x48); } }
		}
		
		[CompilerGenerated]
		public partial class DRLGCommand : SerializeMemoryObject
		{
			public const int SizeOf = 0x98; // 152
			
			public string x00_Text { get { return ReadString(0x00, 128); } }
			public int x80 { get { return Read<int>(0x80); } }
			public SerializeData x84_SerializeData { get { return Read<SerializeData>(0x84); } }
			public TagMap x90_TagMap { get { return new TagMap(Deserialize<byte>(x84_SerializeData)); } } // type: 0x00110000
		}
		
		[CompilerGenerated]
		public partial class SceneChunk : MemoryObject
		{
			public const int SizeOf = 0x100; // 256
			
			public SNOName x000 { get { return Read<SNOName>(0x000); } }
			public PRTransform x008_PRTransform { get { return Read<PRTransform>(0x008); } }
			public SceneSpecification x024_SceneSpecification { get { return Read<SceneSpecification>(0x024); } }
		}
		
		[CompilerGenerated]
		public partial class LabelRule : SerializeMemoryObject
		{
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
			public const int SizeOf = 0x28; // 40
			
			public int x00 { get { return Read<int>(0x00); } }
			public int x04 { get { return Read<int>(0x04); } }
			public int x08 { get { return Read<int>(0x08); } }
			public Vector2I x0C { get { return Read<Vector2I>(0x0C); } }
			public SerializeData x14_SerializeData { get { return Read<SerializeData>(0x14); } }
			public CustomTileCell[] x20_CustomTileCells { get { return Deserialize<CustomTileCell>(x14_SerializeData); } }
		}
		
		[CompilerGenerated]
		public partial class PRTransform : MemoryObject
		{
			public const int SizeOf = 0x1C; // 28
			
			public Quaternion x00 { get { return Read<Quaternion>(0x00); } }
			public Vector3 x10 { get { return Read<Vector3>(0x10); } }
		}
		
		[CompilerGenerated]
		public partial class SceneSpecification : MemoryObject
		{
			public const int SizeOf = 0xDC; // 220
			
			public int x00 { get { return Read<int>(0x00); } }
			public Vector2I x04 { get { return Read<Vector2I>(0x04); } }
			public SNO[] x0C_SNOs { get { return Read<SNO>(0x0C, 4); } }
			public SNO x1C_WorldsSNO { get { return Read<SNO>(0x1C); } }
			public int x20 { get { return Read<int>(0x20); } }
			public SNO x24_LevelAreaSNO { get { return Read<SNO>(0x24); } }
			public SNO x28_WorldsSNO { get { return Read<SNO>(0x28); } }
			public int x2C { get { return Read<int>(0x2C); } }
			public SNO x30_LevelAreaSNO { get { return Read<SNO>(0x30); } }
			public SNO x34_MusicSNO { get { return Read<SNO>(0x34); } }
			public SNO x38_AmbientSoundSNO { get { return Read<SNO>(0x38); } }
			public SNO x3C_ReverbSNO { get { return Read<SNO>(0x3C); } }
			public SNO x40_WeatherSNO { get { return Read<SNO>(0x40); } }
			public SNO x44_WorldsSNO { get { return Read<SNO>(0x44); } }
			public int x48 { get { return Read<int>(0x48); } }
			public int x4C { get { return Read<int>(0x4C); } }
			public int x50 { get { return Read<int>(0x50); } }
			public int x88 { get { return Read<int>(0x88); } }
			public SceneCachedValues x8C_SceneCachedValues { get { return Read<SceneCachedValues>(0x8C); } }
		}
		
		[CompilerGenerated]
		public partial class LabelCondition : MemoryObject
		{
			public const int SizeOf = 0x18; // 24
			
			public int x00_Enum { get { return Read<int>(0x00); } } // Always = 0, Label Already Set = 2, Game Is Open World = 3
			public int x04 { get { return Read<int>(0x04); } }
			public int[] x08_int { get { return Read<int>(0x08, 4); } }
		}
		
		[CompilerGenerated]
		public partial class LabelEntry : MemoryObject
		{
			public const int SizeOf = 0x14; // 20
			
			public GBID x00_LabelsGBID { get { return Read<GBID>(0x00); } }
			public int x04 { get { return Read<int>(0x04); } }
			public float x08 { get { return Read<float>(0x08); } }
			public int x0C { get { return Read<int>(0x0C); } }
			public int x10 { get { return Read<int>(0x10); } }
		}
		
		[CompilerGenerated]
		public partial class SubSceneGroup : SerializeMemoryObject
		{
			public const int SizeOf = 0x20; // 32
			
			public SNO x00_ConditionSNO { get { return Read<SNO>(0x00); } }
			public int x04 { get { return Read<int>(0x04); } }
			public int x08 { get { return Read<int>(0x08); } }
			public SubSceneEntry[] x10_SubSceneEntries { get { return Deserialize<SubSceneEntry>(x18_SerializeData); } }
			public SerializeData x18_SerializeData { get { return Read<SerializeData>(0x18); } }
		}
		
		[CompilerGenerated]
		public partial class CustomTileCell : MemoryObject
		{
			public const int SizeOf = 0x24; // 36
			
			public int x00 { get { return Read<int>(0x00); } }
			public int x04 { get { return Read<int>(0x04); } }
			public int x08 { get { return Read<int>(0x08); } }
			public SNO x0C_SceneSNO { get { return Read<SNO>(0x0C); } }
			public int x10 { get { return Read<int>(0x10); } }
			public int[] x14_int { get { return Read<int>(0x14, 4); } }
		}
		
		[CompilerGenerated]
		public partial class SceneCachedValues : MemoryObject
		{
			public const int SizeOf = 0x50; // 80
			
			public int x00 { get { return Read<int>(0x00); } }
			public int x04 { get { return Read<int>(0x04); } }
			public int x08 { get { return Read<int>(0x08); } }
			public AABB x0C { get { return Read<AABB>(0x0C); } }
			public AABB x24 { get { return Read<AABB>(0x24); } }
			public int[] x3C_int { get { return Read<int>(0x3C, 4); } }
			public int x4C { get { return Read<int>(0x4C); } }
		}
		
		[CompilerGenerated]
		public partial class SubSceneEntry : SerializeMemoryObject
		{
			public const int SizeOf = 0x20; // 32
			
			public SNO x00_SceneSNO { get { return Read<SNO>(0x00); } }
			public int x04 { get { return Read<int>(0x04); } }
			public int x08 { get { return Read<int>(0x08); } }
			public SubSceneLabel[] x10_SubSceneLabels { get { return Deserialize<SubSceneLabel>(x18_SerializeData); } }
			public SerializeData x18_SerializeData { get { return Read<SerializeData>(0x18); } }
		}
		
		[CompilerGenerated]
		public partial class SubSceneLabel : MemoryObject
		{
			public const int SizeOf = 0x08; // 8
			
			public GBID x00_GBID { get { return Read<GBID>(0x00); } }
			public int x04 { get { return Read<int>(0x04); } }
		}
	}
}
