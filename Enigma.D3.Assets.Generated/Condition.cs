using System.Runtime.CompilerServices;
using Enigma.D3.DataTypes;
using Enigma.Memory;

namespace Enigma.D3.Assets
{
	[CompilerGenerated]
	public partial class Condition : MemoryObject
	{
		public const int SizeOf = 0x4D8; // 1240
		
		public SNOHeader x000_Header { get { return Read<SNOHeader>(0x000); } }
		public int x00C { get { return Read<int>(0x00C); } }
		public int x010 { get { return Read<int>(0x010); } }
		public int[] x014_int { get { return Read<int>(0x014, 7); } }
		public int x030 { get { return Read<int>(0x030); } }
		public int x034 { get { return Read<int>(0x034); } }
		public int x038 { get { return Read<int>(0x038); } }
		public int x03C { get { return Read<int>(0x03C); } }
		public LoreSubcondition[] x040_LoreSubconditions { get { return Read<LoreSubcondition>(0x040, 3); } }
		public QuestSubcondition[] x058_QuestSubconditions { get { return Read<QuestSubcondition>(0x058, 3); } }
		public int x088 { get { return Read<int>(0x088); } }
		public int x08C { get { return Read<int>(0x08C); } }
		public int x090 { get { return Read<int>(0x090); } }
		public ItemSubcondition[] x094_ItemSubconditions { get { return Read<ItemSubcondition>(0x094, 3); } }
		public int x0C4 { get { return Read<int>(0x0C4); } }
		public int x0C8 { get { return Read<int>(0x0C8); } }
		public int x0CC { get { return Read<int>(0x0CC); } }
		public int x0D0 { get { return Read<int>(0x0D0); } }
		public int x0D4 { get { return Read<int>(0x0D4); } }
		public int x0D8 { get { return Read<int>(0x0D8); } }
		public int x0DC { get { return Read<int>(0x0DC); } }
		public int x0E0 { get { return Read<int>(0x0E0); } }
		public int x0E8 { get { return Read<int>(0x0E8); } }
		public int x0EC { get { return Read<int>(0x0EC); } }
		public int x0F0 { get { return Read<int>(0x0F0); } }
		public int x0F4 { get { return Read<int>(0x0F4); } }
		public SNO x0F8_WorldsSNO { get { return Read<SNO>(0x0F8); } }
		public SNO x0FC_LevelAreaSNO { get { return Read<SNO>(0x0FC); } }
		public SNO x100_QuestRangeSNO { get { return Read<SNO>(0x100); } }
		public FollowerSubcondition x104_FollowerSubcondition { get { return Read<FollowerSubcondition>(0x104); } }
		public LabelSubcondition[] x10C_LabelSubconditions { get { return Read<LabelSubcondition>(0x10C, 3); } }
		public SkillSubcondition[] x124_SkillSubconditions { get { return Read<SkillSubcondition>(0x124, 3); } }
		public int x148 { get { return Read<int>(0x148); } }
		public int x14C { get { return Read<int>(0x14C); } }
		public int x150 { get { return Read<int>(0x150); } }
		public int x154 { get { return Read<int>(0x154); } }
		public int x158 { get { return Read<int>(0x158); } }
		public int x15C { get { return Read<int>(0x15C); } }
		public int x160 { get { return Read<int>(0x160); } }
		public int x164 { get { return Read<int>(0x164); } }
		public int x168 { get { return Read<int>(0x168); } }
		public MonsterSubcondition[] x16C_MonsterSubconditions { get { return Read<MonsterSubcondition>(0x16C, 15); } }
		public GameFlagSubcondition[] x1A8_GameFlagSubconditions { get { return Read<GameFlagSubcondition>(0x1A8, 3); } }
		public PlayerFlagSubcondition[] x328_PlayerFlagSubconditions { get { return Read<PlayerFlagSubcondition>(0x328, 3); } }
		public BuffSubcondition[] x4A8_BuffSubconditions { get { return Read<BuffSubcondition>(0x4A8, 3); } }
		public int x4CC { get { return Read<int>(0x4CC); } }
		public int x4D0 { get { return Read<int>(0x4D0); } }
		public int x4D4 { get { return Read<int>(0x4D4); } }
		
		[CompilerGenerated]
		public partial class LoreSubcondition : MemoryObject
		{
			public const int SizeOf = 0x08; // 8
			
			public SNO x00_LoreSNO { get { return Read<SNO>(0x00); } }
			public int x04 { get { return Read<int>(0x04); } }
		}
		
		[CompilerGenerated]
		public partial class QuestSubcondition : MemoryObject
		{
			public const int SizeOf = 0x10; // 16
			
			public SNO x00_QuestSNO { get { return Read<SNO>(0x00); } }
			public int x04 { get { return Read<int>(0x04); } }
			public int x08 { get { return Read<int>(0x08); } }
			public int x0C { get { return Read<int>(0x0C); } }
		}
		
		[CompilerGenerated]
		public partial class ItemSubcondition : MemoryObject
		{
			public const int SizeOf = 0x10; // 16
			
			public GBID x00_ItemsGBID { get { return Read<GBID>(0x00); } }
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
			
			public GBID x00_LabelsGBID { get { return Read<GBID>(0x00); } }
			public int x04 { get { return Read<int>(0x04); } }
		}
		
		[CompilerGenerated]
		public partial class SkillSubcondition : MemoryObject
		{
			public const int SizeOf = 0x0C; // 12
			
			public SNO x00_PowerSNO { get { return Read<SNO>(0x00); } }
			public int x04 { get { return Read<int>(0x04); } }
			public int x08 { get { return Read<int>(0x08); } }
		}
		
		[CompilerGenerated]
		public partial class MonsterSubcondition : MemoryObject
		{
			public const int SizeOf = 0x04; // 4
			
			public SNO x00_ActorSNO { get { return Read<SNO>(0x00); } }
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
			
			public SNO x00_PowerSNO { get { return Read<SNO>(0x00); } }
			public int x04 { get { return Read<int>(0x04); } }
			public int x08 { get { return Read<int>(0x08); } }
		}
	}
}
