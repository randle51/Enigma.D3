using System.Runtime.CompilerServices;
using Enigma.D3.DataTypes;
using Enigma.Memory;

namespace Enigma.D3.Assets
{
	[CompilerGenerated]
	public partial class Condition : MemoryObject
	{
		public const int SizeOf = 0x4D4; // 1236
		
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
		public int x084 { get { return Read<int>(0x084); } }
		public int x088 { get { return Read<int>(0x088); } }
		public int x08C { get { return Read<int>(0x08C); } }
		public ItemSubcondition[] x090_ItemSubconditions { get { return Read<ItemSubcondition>(0x090, 3); } }
		public int x0C0 { get { return Read<int>(0x0C0); } }
		public int x0C4 { get { return Read<int>(0x0C4); } }
		public int x0C8 { get { return Read<int>(0x0C8); } }
		public int x0CC { get { return Read<int>(0x0CC); } }
		public int x0D0 { get { return Read<int>(0x0D0); } }
		public int x0D4 { get { return Read<int>(0x0D4); } }
		public int x0D8 { get { return Read<int>(0x0D8); } }
		public int x0DC { get { return Read<int>(0x0DC); } }
		public int x0E4 { get { return Read<int>(0x0E4); } }
		public int x0E8 { get { return Read<int>(0x0E8); } }
		public int x0EC { get { return Read<int>(0x0EC); } }
		public int x0F0 { get { return Read<int>(0x0F0); } }
		public Sno x0F4_WorldsSno { get { return Read<Sno>(0x0F4); } }
		public Sno x0F8_LevelAreaSno { get { return Read<Sno>(0x0F8); } }
		public Sno x0FC_QuestRangeSno { get { return Read<Sno>(0x0FC); } }
		public FollowerSubcondition x100_FollowerSubcondition { get { return Read<FollowerSubcondition>(0x100); } }
		public LabelSubcondition[] x108_LabelSubconditions { get { return Read<LabelSubcondition>(0x108, 3); } }
		public SkillSubcondition[] x120_SkillSubconditions { get { return Read<SkillSubcondition>(0x120, 3); } }
		public int x144 { get { return Read<int>(0x144); } }
		public int x148 { get { return Read<int>(0x148); } }
		public int x14C { get { return Read<int>(0x14C); } }
		public int x150 { get { return Read<int>(0x150); } }
		public int x154 { get { return Read<int>(0x154); } }
		public int x158 { get { return Read<int>(0x158); } }
		public int x15C { get { return Read<int>(0x15C); } }
		public int x160 { get { return Read<int>(0x160); } }
		public int x164 { get { return Read<int>(0x164); } }
		public MonsterSubcondition[] x168_MonsterSubconditions { get { return Read<MonsterSubcondition>(0x168, 15); } }
		public GameFlagSubcondition[] x1A4_GameFlagSubconditions { get { return Read<GameFlagSubcondition>(0x1A4, 3); } }
		public PlayerFlagSubcondition[] x324_PlayerFlagSubconditions { get { return Read<PlayerFlagSubcondition>(0x324, 3); } }
		public BuffSubcondition[] x4A4_BuffSubconditions { get { return Read<BuffSubcondition>(0x4A4, 3); } }
		public int x4C8 { get { return Read<int>(0x4C8); } }
		public int x4CC { get { return Read<int>(0x4CC); } }
		public int x4D0 { get { return Read<int>(0x4D0); } }
		
		[CompilerGenerated]
		public partial class LoreSubcondition : MemoryObject
		{
			public const int SizeOf = 0x08; // 8
			
			public Sno x00_LoreSno { get { return Read<Sno>(0x00); } }
			public int x04 { get { return Read<int>(0x04); } }
		}
		
		[CompilerGenerated]
		public partial class QuestSubcondition : MemoryObject
		{
			public const int SizeOf = 0x10; // 16
			
			public Sno x00_QuestSno { get { return Read<Sno>(0x00); } }
			public int x04 { get { return Read<int>(0x04); } }
			public int x08 { get { return Read<int>(0x08); } }
			public int x0C { get { return Read<int>(0x0C); } }
		}
		
		[CompilerGenerated]
		public partial class ItemSubcondition : MemoryObject
		{
			public const int SizeOf = 0x10; // 16
			
			public GameBalanceId x00_ItemsGameBalanceId { get { return Read<GameBalanceId>(0x00); } }
			public int x04 { get { return Read<int>(0x04); } }
			public int x08 { get { return Read<int>(0x08); } }
			public int x0C { get { return Read<int>(0x0C); } }
		}
		
		[CompilerGenerated]
		public partial class FollowerSubcondition : MemoryObject
		{
			public const int SizeOf = 0x08; // 8
			
			public int x00_Enum { get { return Read<int>(0x00); } } // - None - = 0, Templar = 1, Scoundrel = 2, Enchantress = 3
			public int x04 { get { return Read<int>(0x04); } }
		}
		
		[CompilerGenerated]
		public partial class LabelSubcondition : MemoryObject
		{
			public const int SizeOf = 0x08; // 8
			
			public GameBalanceId x00_LabelsGameBalanceId { get { return Read<GameBalanceId>(0x00); } }
			public int x04 { get { return Read<int>(0x04); } }
		}
		
		[CompilerGenerated]
		public partial class SkillSubcondition : MemoryObject
		{
			public const int SizeOf = 0x0C; // 12
			
			public Sno x00_PowerSno { get { return Read<Sno>(0x00); } }
			public int x04 { get { return Read<int>(0x04); } }
			public int x08 { get { return Read<int>(0x08); } }
		}
		
		[CompilerGenerated]
		public partial class MonsterSubcondition : MemoryObject
		{
			public const int SizeOf = 0x04; // 4
			
			public Sno x00_ActorSno { get { return Read<Sno>(0x00); } }
		}
		
		[CompilerGenerated]
		public partial class GameFlagSubcondition : MemoryObject
		{
			public const int SizeOf = 0x80; // 128
			
			public string x00_Text { get { return ReadString(0x00, 128); } }
		}
		
		[CompilerGenerated]
		public partial class PlayerFlagSubcondition : MemoryObject
		{
			public const int SizeOf = 0x80; // 128
			
			public string x00_Text { get { return ReadString(0x00, 128); } }
		}
		
		[CompilerGenerated]
		public partial class BuffSubcondition : MemoryObject
		{
			public const int SizeOf = 0x0C; // 12
			
			public Sno x00_PowerSno { get { return Read<Sno>(0x00); } }
			public int x04 { get { return Read<int>(0x04); } }
			public int x08 { get { return Read<int>(0x08); } }
		}
	}
}
