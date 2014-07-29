using System.Runtime.CompilerServices;
using Enigma.D3.Collections;
using Enigma.D3.Memory;

namespace Enigma.D3.Sno
{
	[CompilerGenerated]
	public partial class Condition : SerializeMemoryObject
	{
		// 2.0.6.24641
		public const int SizeOf = 0x4A4; // 1188
		
		public int x00C { get { return Field<int>(0x00C); } }
		public int x010 { get { return Field<int>(0x010); } }
		public int[] x014_int { get { return Field<int>(0x014, 6); } }
		public int x02C { get { return Field<int>(0x02C); } }
		public int x030 { get { return Field<int>(0x030); } }
		public int x034 { get { return Field<int>(0x034); } }
		public int x038 { get { return Field<int>(0x038); } }
		public LoreSubcondition[] x03C_LoreSubconditions { get { return Field<LoreSubcondition>(0x03C, 3); } }
		public QuestSubcondition[] x054_QuestSubconditions { get { return Field<QuestSubcondition>(0x054, 3); } }
		public ItemSubcondition[] x084_ItemSubconditions { get { return Field<ItemSubcondition>(0x084, 3); } }
		public int x0B4 { get { return Field<int>(0x0B4); } }
		public int x0B8 { get { return Field<int>(0x0B8); } }
		public int x0BC { get { return Field<int>(0x0BC); } }
		public int x0C0 { get { return Field<int>(0x0C0); } }
		public int x0C4 { get { return Field<int>(0x0C4); } }
		public int x0C8 { get { return Field<int>(0x0C8); } }
		public int x0D0 { get { return Field<int>(0x0D0); } }
		public int x0D4 { get { return Field<int>(0x0D4); } }
		public int x0D8 { get { return Field<int>(0x0D8); } }
		public int x0DC { get { return Field<int>(0x0DC); } }
		public Sno x0E0_WorldsSno { get { return Field<Sno>(0x0E0); } }
		public Sno x0E4_LevelAreaSno { get { return Field<Sno>(0x0E4); } }
		public Sno x0E8_QuestRangeSno { get { return Field<Sno>(0x0E8); } }
		public FollowerSubcondition x0EC_FollowerSubcondition { get { return Field<FollowerSubcondition>(0x0EC); } }
		public LabelSubcondition[] x0F4_LabelSubconditions { get { return Field<LabelSubcondition>(0x0F4, 3); } }
		public SkillSubcondition[] x10C_SkillSubconditions { get { return Field<SkillSubcondition>(0x10C, 3); } }
		public int x130 { get { return Field<int>(0x130); } }
		public int x134 { get { return Field<int>(0x134); } }
		public int x138 { get { return Field<int>(0x138); } }
		public int x13C { get { return Field<int>(0x13C); } }
		public int x140 { get { return Field<int>(0x140); } }
		public MonsterSubcondition[] x144_MonsterSubconditions { get { return Field<MonsterSubcondition>(0x144, 15); } }
		public GameFlagSubcondition[] x180_GameFlagSubconditions { get { return Field<GameFlagSubcondition>(0x180, 3); } }
		public PlayerFlagSubcondition[] x300_PlayerFlagSubconditions { get { return Field<PlayerFlagSubcondition>(0x300, 3); } }
		public BuffSubcondition[] x480_BuffSubconditions { get { return Field<BuffSubcondition>(0x480, 3); } }
		
		[CompilerGenerated]
		public partial class LoreSubcondition : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x8; // 8
			
			public Sno x00_LoreSno { get { return Field<Sno>(0x00); } }
			public int x04 { get { return Field<int>(0x04); } }
		}
		
		[CompilerGenerated]
		public partial class QuestSubcondition : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x10; // 16
			
			public Sno x00_QuestSno { get { return Field<Sno>(0x00); } }
			public int x04 { get { return Field<int>(0x04); } }
			public int x08 { get { return Field<int>(0x08); } }
			public int x0C { get { return Field<int>(0x0C); } }
		}
		
		[CompilerGenerated]
		public partial class ItemSubcondition : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x10; // 16
			
			public GameBalanceId x00_ItemsGameBalanceId { get { return Field<GameBalanceId>(0x00); } }
			public int x04 { get { return Field<int>(0x04); } }
			public int x08 { get { return Field<int>(0x08); } }
			public int x0C { get { return Field<int>(0x0C); } }
		}
		
		[CompilerGenerated]
		public partial class FollowerSubcondition : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x8; // 8
			
			public int x00_Enum { get { return Field<int>(0x00); } } // - None - = 0, Templar = 1, Scoundrel = 2, Enchantress = 3
			public int x04 { get { return Field<int>(0x04); } }
		}
		
		[CompilerGenerated]
		public partial class LabelSubcondition : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x8; // 8
			
			public GameBalanceId x00_LabelsGameBalanceId { get { return Field<GameBalanceId>(0x00); } }
			public int x04 { get { return Field<int>(0x04); } }
		}
		
		[CompilerGenerated]
		public partial class SkillSubcondition : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0xC; // 12
			
			public Sno x00_PowerSno { get { return Field<Sno>(0x00); } }
			public int x04 { get { return Field<int>(0x04); } }
			public int x08 { get { return Field<int>(0x08); } }
		}
		
		[CompilerGenerated]
		public partial class MonsterSubcondition : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x4; // 4
			
			public Sno x00_ActorSno { get { return Field<Sno>(0x00); } }
		}
		
		[CompilerGenerated]
		public partial class GameFlagSubcondition : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x80; // 128
			
			public string x00_Text { get { return Field(0x00, 128); } }
		}
		
		[CompilerGenerated]
		public partial class PlayerFlagSubcondition : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x80; // 128
			
			public string x00_Text { get { return Field(0x00, 128); } }
		}
		
		[CompilerGenerated]
		public partial class BuffSubcondition : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0xC; // 12
			
			public Sno x00_PowerSno { get { return Field<Sno>(0x00); } }
			public int x04 { get { return Field<int>(0x04); } }
			public int x08 { get { return Field<int>(0x08); } }
		}
	}
}
