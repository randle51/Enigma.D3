using System.Runtime.CompilerServices;
using Enigma.D3.DataTypes;
using Enigma.Memory;

namespace Enigma.D3.Assets
{
	[CompilerGenerated]
	public partial class Monster : SerializeMemoryObject
	{
		public const int SizeOf = 0x540; // 1344
		
		public SNOHeader x000_Header { get { return Read<SNOHeader>(0x000); } }
		public int x00C { get { return Read<int>(0x00C); } }
		public SNO x010_ActorSNO { get { return Read<SNO>(0x010); } }
		public int x014 { get { return Read<int>(0x014); } }
		public int x018_Enum { get { return Read<int>(0x018); } } //  = -1, Undead = 0, Demon = 1, Beast = 2, Human = 3, Breakable = 4, Scenery = 5, Ally = 6, Team = 7, Helper = 8, CorruptedAngel = 9, Pandemonium = 10, Adria = 11, Blood Golem = 12
		public int x01C_Enum { get { return Read<int>(0x01C); } } //  = 0, Fallen = 1, GoatMen = 2, Rogue = 3, Skeleton = 4, Zombie = 5, Spider = 6, Triune = 7, WoodWraith = 8, Human = 9, Animal = 10, TreasureGoblin = 11, CrazedAngel = 12
		public int x020_Enum { get { return Read<int>(0x020); } } //  = -1, Big = 3, Standard = 4, Ranged = 5, Swarm = 6, Boss = 7
		public MonsterData x024_MonsterData { get { return Read<MonsterData>(0x024); } }
		public int x038_Enum { get { return Read<int>(0x038); } } // None = -1, Physical = 0, Fire = 1, Lightning = 2, Cold = 3, Poison = 4, Arcane = 5, Holy = 6
		public int x03C { get { return Read<int>(0x03C); } }
		public int x040 { get { return Read<int>(0x040); } }
		public float[] x044_float { get { return Read<float>(0x044, 146); } }
		public float x28C { get { return Read<float>(0x28C); } }
		public float x290 { get { return Read<float>(0x290); } }
		public float x294 { get { return Read<float>(0x294); } }
		public float x298 { get { return Read<float>(0x298); } }
		public float x29C { get { return Read<float>(0x29C); } }
		public float x2A0 { get { return Read<float>(0x2A0); } }
		public int x2A4 { get { return Read<int>(0x2A4); } }
		public HealthDropInfo x2A8_HealthDropInfo { get { return Read<HealthDropInfo>(0x2A8); } }
		public HealthDropInfo x2B4_HealthDropInfo { get { return Read<HealthDropInfo>(0x2B4); } }
		public HealthDropInfo x2C0_HealthDropInfo { get { return Read<HealthDropInfo>(0x2C0); } }
		public HealthDropInfo x2CC_HealthDropInfo { get { return Read<HealthDropInfo>(0x2CC); } }
		public SNO x2D8_SkillKitSNO { get { return Read<SNO>(0x2D8); } }
		public SkillDeclaration[] x2DC_SkillDeclarations { get { return Read<SkillDeclaration>(0x2DC, 8); } }
		public MonsterSkillDeclaration[] x31C_MonsterSkillDeclarations { get { return Read<MonsterSkillDeclaration>(0x31C, 8); } }
		public SNO x39C_TreasureClassSNO { get { return Read<SNO>(0x39C); } }
		public SNO x3A0_TreasureClassSNO { get { return Read<SNO>(0x3A0); } }
		public SNO x3A4_TreasureClassSNO { get { return Read<SNO>(0x3A4); } }
		public SNO x3A8_TreasureClassSNO { get { return Read<SNO>(0x3A8); } }
		public SNO x3AC_TreasureClassSNO { get { return Read<SNO>(0x3AC); } }
		public float x3B0 { get { return Read<float>(0x3B0); } }
		public float x3B4 { get { return Read<float>(0x3B4); } }
		public float x3B8 { get { return Read<float>(0x3B8); } }
		public float x3BC { get { return Read<float>(0x3BC); } }
		public int x3C0 { get { return Read<int>(0x3C0); } }
		public float x3C4 { get { return Read<float>(0x3C4); } }
		public int x3C8 { get { return Read<int>(0x3C8); } }
		public int x3CC { get { return Read<int>(0x3CC); } }
		public SNO x3D0_TreasureClassSNO { get { return Read<SNO>(0x3D0); } }
		public SNO x3D4_TreasureClassSNO { get { return Read<SNO>(0x3D4); } }
		public SNO x3D8_LoreSNO { get { return Read<SNO>(0x3D8); } }
		public SNO[] x3DC_SNOs { get { return Read<SNO>(0x3DC, 6); } }
		public GBID[] x3F4_GBIDs { get { return Read<GBID>(0x3F4, 8); } }
		public SNO[] x414_SNOs { get { return Read<SNO>(0x414, 6); } }
		public int x42C { get { return Read<int>(0x42C); } }
		public GBID[] x430_GBIDs { get { return Read<GBID>(0x430, 4); } }
		public GBID[] x440_GBIDs { get { return Read<GBID>(0x440, 6); } }
		public int x458 { get { return Read<int>(0x458); } }
		public int x45C { get { return Read<int>(0x45C); } }
		public int x460 { get { return Read<int>(0x460); } }
		public int x464_Enum { get { return Read<int>(0x464); } } // Mana = 0, Arcanum = 1, Fury = 2, Spirit = 3, Power = 4, Hatred = 5, Discipline = 6, Faith = 7
		public SerializeData x480_SerializeData { get { return Read<SerializeData>(0x480); } }
		public int[] x488_TagMap { get { return Deserialize<int>(x480_SerializeData); } } // type: 0x00120000
		public int x490 { get { return Read<int>(0x490); } }
		public MonsterMinionSpawnGroup[] x498_MonsterMinionSpawnGroups { get { return Deserialize<MonsterMinionSpawnGroup>(x4A0_SerializeData); } }
		public SerializeData x4A0_SerializeData { get { return Read<SerializeData>(0x4A0); } }
		public int x4A8 { get { return Read<int>(0x4A8); } }
		public MonsterChampionSpawnGroup[] x4B0_MonsterChampionSpawnGroups { get { return Deserialize<MonsterChampionSpawnGroup>(x4B8_SerializeData); } }
		public SerializeData x4B8_SerializeData { get { return Read<SerializeData>(0x4B8); } }
		public string x4C0_Text { get { return ReadString(0x4C0, 128); } }
		
		[CompilerGenerated]
		public partial class MonsterData : MemoryObject
		{
			public const int SizeOf = 0x14; // 20
			
			public float x00 { get { return Read<float>(0x00); } }
			public float x04 { get { return Read<float>(0x04); } }
			public float x08 { get { return Read<float>(0x08); } }
			public float x0C { get { return Read<float>(0x0C); } }
			public int x10 { get { return Read<int>(0x10); } }
		}
		
		[CompilerGenerated]
		public partial class HealthDropInfo : MemoryObject
		{
			public const int SizeOf = 0x0C; // 12
			
			public float x00 { get { return Read<float>(0x00); } }
			public GBID x04_ItemsGBID { get { return Read<GBID>(0x04); } }
			public int x08 { get { return Read<int>(0x08); } }
		}
		
		[CompilerGenerated]
		public partial class SkillDeclaration : MemoryObject
		{
			public const int SizeOf = 0x08; // 8
			
			public SNO x00_PowerSNO { get { return Read<SNO>(0x00); } }
			public int x04 { get { return Read<int>(0x04); } }
		}
		
		[CompilerGenerated]
		public partial class MonsterSkillDeclaration : MemoryObject
		{
			public const int SizeOf = 0x10; // 16
			
			public float x00 { get { return Read<float>(0x00); } }
			public float x04 { get { return Read<float>(0x04); } }
			public int x08 { get { return Read<int>(0x08); } }
			public float x0C { get { return Read<float>(0x0C); } }
		}
		
		[CompilerGenerated]
		public partial class MonsterMinionSpawnGroup : SerializeMemoryObject
		{
			public const int SizeOf = 0x18; // 24
			
			public float x00 { get { return Read<float>(0x00); } }
			public int x04 { get { return Read<int>(0x04); } }
			public MonsterMinionSpawnItem[] x08_MonsterMinionSpawnItems { get { return Deserialize<MonsterMinionSpawnItem>(x10_SerializeData); } }
			public SerializeData x10_SerializeData { get { return Read<SerializeData>(0x10); } }
		}
		
		[CompilerGenerated]
		public partial class MonsterChampionSpawnGroup : SerializeMemoryObject
		{
			public const int SizeOf = 0x18; // 24
			
			public int x00 { get { return Read<int>(0x00); } }
			public float x04 { get { return Read<float>(0x04); } }
			public MonsterChampionSpawnItem[] x08_MonsterChampionSpawnItems { get { return Deserialize<MonsterChampionSpawnItem>(x10_SerializeData); } }
			public SerializeData x10_SerializeData { get { return Read<SerializeData>(0x10); } }
		}
		
		[CompilerGenerated]
		public partial class MonsterMinionSpawnItem : MemoryObject
		{
			public const int SizeOf = 0x14; // 20
			
			public SNO x00_ActorSNO { get { return Read<SNO>(0x00); } }
			public int x04 { get { return Read<int>(0x04); } }
			public int x08 { get { return Read<int>(0x08); } }
			public int x0C { get { return Read<int>(0x0C); } }
			public int x10 { get { return Read<int>(0x10); } }
		}
		
		[CompilerGenerated]
		public partial class MonsterChampionSpawnItem : MemoryObject
		{
			public const int SizeOf = 0x08; // 8
			
			public SNO x00_ActorSNO { get { return Read<SNO>(0x00); } }
			public int x04 { get { return Read<int>(0x04); } }
		}
	}
}
