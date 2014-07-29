using System.Runtime.CompilerServices;
using Enigma.D3.Collections;
using Enigma.D3.Memory;

namespace Enigma.D3.Sno
{
	[CompilerGenerated]
	public partial class Act : SerializeMemoryObject
	{
		// 2.0.6.24641
		public const int SizeOf = 0x1060; // 4192
		
		public SerializeData x000C_SerializeData { get { return Field<SerializeData>(0x000C); } }
		public ActQuestInfo[] x0018_ActQuestInfos { get { return Deserialize<ActQuestInfo>(x000C_SerializeData); } }
		public WaypointInfo[] x0020_WaypointInfos { get { return Field<WaypointInfo>(0x0020, 100); } }
		public ResolvedPortalDestination x0FC0_ResolvedPortalDestination { get { return Field<ResolvedPortalDestination>(0x0FC0); } }
		public ActStartLocOverride[] x0FCC_ActStartLocOverrides { get { return Field<ActStartLocOverride>(0x0FCC, 6); } }
		
		[CompilerGenerated]
		public partial class ActQuestInfo : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x4; // 4
			
			public Sno x00_QuestSno { get { return Field<Sno>(0x00); } }
		}
		
		[CompilerGenerated]
		public partial class WaypointInfo : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x28; // 40
			
			public int x00 { get { return Field<int>(0x00); } }
			public Sno x04_WorldsSno { get { return Field<Sno>(0x04); } }
			public Sno x08_LevelAreaSno { get { return Field<Sno>(0x08); } }
			public int x0C { get { return Field<int>(0x0C); } }
			public int x10 { get { return Field<int>(0x10); } }
			public int x14 { get { return Field<int>(0x14); } }
			public Sno x18_QuestRangeSno { get { return Field<Sno>(0x18); } }
			public int x1C { get { return Field<int>(0x1C); } }
			public IVector2D x20_IVector2D { get { return Field<IVector2D>(0x20); } }
		}
		
		[CompilerGenerated]
		public partial class ResolvedPortalDestination : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0xC; // 12
			
			public Sno x00_WorldsSno { get { return Field<Sno>(0x00); } }
			public int x04 { get { return Field<int>(0x04); } }
			public Sno x08_LevelAreaSno { get { return Field<Sno>(0x08); } }
		}
		
		[CompilerGenerated]
		public partial class ActStartLocOverride : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x18; // 24
			
			public ResolvedPortalDestination x00_ResolvedPortalDestination { get { return Field<ResolvedPortalDestination>(0x00); } }
			public Sno x0C_QuestRangeSno { get { return Field<Sno>(0x0C); } }
			public Sno x10_WorldsSno { get { return Field<Sno>(0x10); } }
			public int x14 { get { return Field<int>(0x14); } }
		}
		
		[CompilerGenerated]
		public partial class IVector2D : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x8; // 8
			
			public int x00 { get { return Field<int>(0x00); } }
			public int x04 { get { return Field<int>(0x04); } }
		}
	}
}
