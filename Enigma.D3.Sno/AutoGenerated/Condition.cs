using System.Runtime.CompilerServices;
using Enigma.D3.Collections;
using Enigma.D3.Memory;
using Enigma.Memory;

namespace Enigma.D3.Sno
{
	[CompilerGenerated]
	public partial class Condition : MemoryObject
	{
		// 2.1.2.28709
		public const int SizeOf = 0x4B0; // 1200
		
		public SnoHeader x000_Header { get { return Read<SnoHeader>(0x000); } }
		public int x00C { get { return Read<int>(0x00C); } }
		public int x010 { get { return Read<int>(0x010); } }
		public int[] x014_int { get { return Read<int>(0x014, 6); } }
		public int x02C { get { return Read<int>(0x02C); } }
		public int x030 { get { return Read<int>(0x030); } }
		public int x034 { get { return Read<int>(0x034); } }
		public int x038 { get { return Read<int>(0x038); } }
		public LoreSubcondition[] x03C_LoreSubconditions { get { return Read<LoreSubcondition>(0x03C, 3); } }
		public QuestSubcondition[] x054_QuestSubconditions { get { return Read<QuestSubcondition>(0x054, 3); } }
		public ItemSubcondition[] x084_ItemSubconditions { get { return Read<ItemSubcondition>(0x084, 3); } }
		public int x0B4 { get { return Read<int>(0x0B4); } }
		public int x0B8 { get { return Read<int>(0x0B8); } }
		public int x0BC { get { return Read<int>(0x0BC); } }
		public int x0C0 { get { return Read<int>(0x0C0); } }
		public int x0C4 { get { return Read<int>(0x0C4); } }
		public int x0C8 { get { return Read<int>(0x0C8); } }
		public int x0CC { get { return Read<int>(0x0CC); } }
		public int x0D0 { get { return Read<int>(0x0D0); } }
		public int x0D8 { get { return Read<int>(0x0D8); } }
		public int x0DC { get { return Read<int>(0x0DC); } }
		public int x0E0 { get { return Read<int>(0x0E0); } }
		public int x0E4 { get { return Read<int>(0x0E4); } }
		public Sno x0E8_WorldsSno { get { return Read<Sno>(0x0E8); } }
		public Sno x0EC_LevelAreaSno { get { return Read<Sno>(0x0EC); } }
		public Sno x0F0_QuestRangeSno { get { return Read<Sno>(0x0F0); } }
		public FollowerSubcondition x0F4_FollowerSubcondition { get { return Read<FollowerSubcondition>(0x0F4); } }
		public LabelSubcondition[] x0FC_LabelSubconditions { get { return Read<LabelSubcondition>(0x0FC, 3); } }
		public SkillSubcondition[] x114_SkillSubconditions { get { return Read<SkillSubcondition>(0x114, 3); } }
		public int x138 { get { return Read<int>(0x138); } }
		public int x13C { get { return Read<int>(0x13C); } }
		public int x140 { get { return Read<int>(0x140); } }
		public int x144 { get { return Read<int>(0x144); } }
		public int x148 { get { return Read<int>(0x148); } }
		public MonsterSubcondition[] x14C_MonsterSubconditions { get { return Read<MonsterSubcondition>(0x14C, 15); } }
		public GameFlagSubcondition[] x188_GameFlagSubconditions { get { return Read<GameFlagSubcondition>(0x188, 3); } }
		public PlayerFlagSubcondition[] x308_PlayerFlagSubconditions { get { return Read<PlayerFlagSubcondition>(0x308, 3); } }
		public BuffSubcondition[] x488_BuffSubconditions { get { return Read<BuffSubcondition>(0x488, 3); } }
		public int x4AC { get { return Read<int>(0x4AC); } }
		
		[CompilerGenerated]
		public partial class LoreSubcondition : MemoryObject
		{
			// 2.1.2.28709
			public const int SizeOf = 0x08; // 8
			
			public Sno x00_LoreSno { get { return Read<Sno>(0x00); } }
			public int x04 { get { return Read<int>(0x04); } }
		}
		
		[CompilerGenerated]
		public partial class QuestSubcondition : MemoryObject
		{
			// 2.1.2.28709
			public const int SizeOf = 0x10; // 16
			
			public Sno x00_QuestSno { get { return Read<Sno>(0x00); } }
			public int x04 { get { return Read<int>(0x04); } }
			public int x08 { get { return Read<int>(0x08); } }
			public int x0C { get { return Read<int>(0x0C); } }
		}
		
		[CompilerGenerated]
		public partial class ItemSubcondition : MemoryObject
		{
			// 2.1.2.28709
			public const int SizeOf = 0x10; // 16
			
			public GameBalanceId x00_ItemsGameBalanceId { get { return Read<GameBalanceId>(0x00); } }
			public int x04 { get { return Read<int>(0x04); } }
			public int x08 { get { return Read<int>(0x08); } }
			public int x0C { get { return Read<int>(0x0C); } }
		}
		
		[CompilerGenerated]
		public partial class FollowerSubcondition : MemoryObject
		{
			// 2.1.2.28709
			public const int SizeOf = 0x08; // 8
			
			public int x00_Enum { get { return Read<int>(0x00); } } // - None - = 0, Templar = 1, Scoundrel = 2, Enchantress = 3
			public int x04 { get { return Read<int>(0x04); } }
		}
		
		[CompilerGenerated]
		public partial class LabelSubcondition : MemoryObject
		{
			// 2.1.2.28709
			public const int SizeOf = 0x08; // 8
			
			public GameBalanceId x00_LabelsGameBalanceId { get { return Read<GameBalanceId>(0x00); } }
			public int x04 { get { return Read<int>(0x04); } }
		}
		
		[CompilerGenerated]
		public partial class SkillSubcondition : MemoryObject
		{
			// 2.1.2.28709
			public const int SizeOf = 0x0C; // 12
			
			public Sno x00_PowerSno { get { return Read<Sno>(0x00); } }
			public int x04 { get { return Read<int>(0x04); } }
			public int x08 { get { return Read<int>(0x08); } }
		}
		
		[CompilerGenerated]
		public partial class MonsterSubcondition : MemoryObject
		{
			// 2.1.2.28709
			public const int SizeOf = 0x04; // 4
			
			public Sno x00_ActorSno { get { return Read<Sno>(0x00); } }
		}
		
		[CompilerGenerated]
		public partial class GameFlagSubcondition : MemoryObject
		{
			// 2.1.2.28709
			public const int SizeOf = 0x80; // 128
			
			public string x00_Text { get { return ReadString(0x00, 128); } }
		}
		
		[CompilerGenerated]
		public partial class PlayerFlagSubcondition : MemoryObject
		{
			// 2.1.2.28709
			public const int SizeOf = 0x80; // 128
			
			public string x00_Text { get { return ReadString(0x00, 128); } }
		}
		
		[CompilerGenerated]
		public partial class BuffSubcondition : MemoryObject
		{
			// 2.1.2.28709
			public const int SizeOf = 0x0C; // 12
			
			public Sno x00_PowerSno { get { return Read<Sno>(0x00); } }
			public int x04 { get { return Read<int>(0x04); } }
			public int x08 { get { return Read<int>(0x08); } }
		}
	}
}
