using System.Runtime.CompilerServices;
using Enigma.D3.Collections;
using Enigma.D3.Memory;

namespace Enigma.D3.Sno
{
	[CompilerGenerated]
	public partial class LevelArea : SerializeMemoryObject
	{
		// 2.0.6.24641
		public const int SizeOf = 0x28; // 40
		
		public int x0C { get { return Field<int>(0x0C); } }
		public Sno x10_LevelAreaSno { get { return Field<Sno>(0x10); } }
		public Sno x14_LevelAreaSno { get { return Field<Sno>(0x14); } }
		public LevelAreaServerData[] x18_LevelAreaServerDatas { get { return Deserialize<LevelAreaServerData>(x20_SerializeData); } }
		public SerializeData x20_SerializeData { get { return Field<SerializeData>(0x20); } }
		
		[CompilerGenerated]
		public partial class LevelAreaServerData : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x360; // 864
			
			public Sno x000_LevelAreaSno { get { return Field<Sno>(0x000); } }
			public GizmoLocSet x008_GizmoLocSet { get { return Field<GizmoLocSet>(0x008); } }
			public Sno x348_LevelAreaSno { get { return Field<Sno>(0x348); } }
			public int x34C { get { return Field<int>(0x34C); } }
			public LevelAreaSpawnPopulation[] x350_LevelAreaSpawnPopulations { get { return Deserialize<LevelAreaSpawnPopulation>(x358_SerializeData); } }
			public SerializeData x358_SerializeData { get { return Field<SerializeData>(0x358); } }
		}
		
		[CompilerGenerated]
		public partial class GizmoLocSet : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x340; // 832
			
			public GizmoLocSpawnType[] x000_GizmoLocSpawnTypes { get { return Field<GizmoLocSpawnType>(0x000, 52); } }
		}
		
		[CompilerGenerated]
		public partial class LevelAreaSpawnPopulation : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x98; // 152
			
			public string x00_Text { get { return Field(0x00, 64); } }
			public int x40 { get { return Field<int>(0x40); } }
			public float x44 { get { return Field<float>(0x44); } }
			public float x48 { get { return Field<float>(0x48); } }
			public int[] x4C_int { get { return Field<int>(0x4C, 4); } }
			public int[] x5C_int { get { return Field<int>(0x5C, 4); } }
			public int x6C { get { return Field<int>(0x6C); } }
			public LevelAreaSpawnGroup[] x70_LevelAreaSpawnGroups { get { return Deserialize<LevelAreaSpawnGroup>(x78_SerializeData); } }
			public SerializeData x78_SerializeData { get { return Field<SerializeData>(0x78); } }
			public Sno[] x80_Snos { get { return Deserialize<Sno>(x88_SerializeData); } }
			public SerializeData x88_SerializeData { get { return Field<SerializeData>(0x88); } }
			public Sno x90_EncounterSno { get { return Field<Sno>(0x90); } }
		}
		
		[CompilerGenerated]
		public partial class GizmoLocSpawnType : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x10; // 16
			
			public GizmoLocSpawnEntry[] x00_GizmoLocSpawnEntries { get { return Deserialize<GizmoLocSpawnEntry>(x08_SerializeData); } }
			public SerializeData x08_SerializeData { get { return Field<SerializeData>(0x08); } }
		}
		
		[CompilerGenerated]
		public partial class LevelAreaSpawnGroup : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x38; // 56
			
			public int x00_Enum { get { return Field<int>(0x00); } } // Count per 100 sq ft = 0, Exactly = 1
			public float x04 { get { return Field<float>(0x04); } }
			public float x08 { get { return Field<float>(0x08); } }
			public int x0C { get { return Field<int>(0x0C); } }
			public int x10 { get { return Field<int>(0x10); } }
			public LevelAreaSpawnItem[] x18_LevelAreaSpawnItems { get { return Deserialize<LevelAreaSpawnItem>(x20_SerializeData); } }
			public SerializeData x20_SerializeData { get { return Field<SerializeData>(0x20); } }
			public int x28 { get { return Field<int>(0x28); } }
			public int x2C { get { return Field<int>(0x2C); } }
			public Sno x30_ConditionSno { get { return Field<Sno>(0x30); } }
		}
		
		[CompilerGenerated]
		public partial class GizmoLocSpawnEntry : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x28; // 40
			
			public int x00 { get { return Field<int>(0x00); } }
			public int x04 { get { return Field<int>(0x04); } }
			public int x08 { get { return Field<int>(0x08); } }
			public int x0C { get { return Field<int>(0x0C); } }
			public HighPrecisionPercent x10_HighPrecisionPercent { get { return Field<HighPrecisionPercent>(0x10); } }
			public Sno x14_ConditionSno { get { return Field<Sno>(0x14); } }
			public GizmoLocSpawnChoice[] x18_GizmoLocSpawnChoices { get { return Deserialize<GizmoLocSpawnChoice>(x20_SerializeData); } }
			public SerializeData x20_SerializeData { get { return Field<SerializeData>(0x20); } }
		}
		
		[CompilerGenerated]
		public partial class LevelAreaSpawnItem : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x20; // 32
			
			public SNOName x00_SNOName { get { return Field<SNOName>(0x00); } }
			public int x08_Enum { get { return Field<int>(0x08); } } //  = 0, Champion = 1, Rare = 2, Minion = 3, Unique = 4, Hireling = 5, Boss = 7
			public int x0C { get { return Field<int>(0x0C); } }
			public int x10 { get { return Field<int>(0x10); } }
			public int x14 { get { return Field<int>(0x14); } }
			public int x18 { get { return Field<int>(0x18); } }
			public float x1C { get { return Field<float>(0x1C); } }
		}
		
		[CompilerGenerated]
		public partial class GizmoLocSpawnChoice : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x14; // 20
			
			public SNOName x00_SNOName { get { return Field<SNOName>(0x00); } }
			public int x08 { get { return Field<int>(0x08); } }
			public float x0C { get { return Field<float>(0x0C); } }
			public int x10 { get { return Field<int>(0x10); } }
		}
		
		[CompilerGenerated]
		public partial class SNOName : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x8; // 8
			
			public SnoGroup x00_SnoGroup { get { return Field<SnoGroup>(0x00); } }
			public SnoNameHandle x04_SnoNameHandle { get { return Field<SnoNameHandle>(0x04); } }
		}
	}
}
