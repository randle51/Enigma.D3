using System.Runtime.CompilerServices;
using Enigma.D3.DataTypes;
using Enigma.Memory;

namespace Enigma.D3.Assets
{
	[CompilerGenerated]
	public partial class Act : SerializeMemoryObject
	{
		public const int SizeOf = 0x1060; // 4192
		
		public SNOHeader x0000_Header { get { return Read<SNOHeader>(0x0000); } }
		public SerializeData x000C_SerializeData { get { return Read<SerializeData>(0x000C); } }
		public ActQuestInfo[] x0018_ActQuestInfos { get { return Deserialize<ActQuestInfo>(x000C_SerializeData); } }
		public WaypointInfo[] x0020_WaypointInfos { get { return Read<WaypointInfo>(0x0020, 100); } }
		public ResolvedPortalDestination x0FC0_ResolvedPortalDestination { get { return Read<ResolvedPortalDestination>(0x0FC0); } }
		public ActStartLocOverride[] x0FCC_ActStartLocOverrides { get { return Read<ActStartLocOverride>(0x0FCC, 6); } }
		
		[CompilerGenerated]
		public partial class ActQuestInfo : MemoryObject
		{
			public const int SizeOf = 0x04; // 4
			
			public SNO x00_QuestSNO { get { return Read<SNO>(0x00); } }
		}
		
		[CompilerGenerated]
		public partial class WaypointInfo : MemoryObject
		{
			public const int SizeOf = 0x28; // 40
			
			public int x00 { get { return Read<int>(0x00); } }
			public SNO x04_WorldsSNO { get { return Read<SNO>(0x04); } }
			public SNO x08_LevelAreaSNO { get { return Read<SNO>(0x08); } }
			public int x0C { get { return Read<int>(0x0C); } }
			public int x10 { get { return Read<int>(0x10); } }
			public int x14 { get { return Read<int>(0x14); } }
			public SNO x18_QuestRangeSNO { get { return Read<SNO>(0x18); } }
			public int x1C { get { return Read<int>(0x1C); } }
			public Vector2I x20 { get { return Read<Vector2I>(0x20); } }
		}
		
		[CompilerGenerated]
		public partial class ResolvedPortalDestination : MemoryObject
		{
			public const int SizeOf = 0x0C; // 12
			
			public SNO x00_WorldsSNO { get { return Read<SNO>(0x00); } }
			public int x04 { get { return Read<int>(0x04); } }
			public SNO x08_LevelAreaSNO { get { return Read<SNO>(0x08); } }
		}
		
		[CompilerGenerated]
		public partial class ActStartLocOverride : MemoryObject
		{
			public const int SizeOf = 0x18; // 24
			
			public ResolvedPortalDestination x00_ResolvedPortalDestination { get { return Read<ResolvedPortalDestination>(0x00); } }
			public SNO x0C_QuestRangeSNO { get { return Read<SNO>(0x0C); } }
			public SNO x10_WorldsSNO { get { return Read<SNO>(0x10); } }
			public int x14 { get { return Read<int>(0x14); } }
		}
	}
}
