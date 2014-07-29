using System.Runtime.CompilerServices;
using Enigma.D3.Collections;
using Enigma.D3.Memory;

namespace Enigma.D3.Sno
{
	[CompilerGenerated]
	public partial class Conversation : SerializeMemoryObject
	{
		// 2.0.6.24641
		public const int SizeOf = 0x210; // 528
		
		public int x00C_Enum { get { return Field<int>(0x00C); } } // Quest Event = 13, Quest Float = 12, Quest Standard = 11, Talk Menu Gossip = 10, Ambient Gossip = 9, Lore Book = 8, Global Float = 7, Global Chatter = 6, Player Callout = 5, Follower Callout = 4, Follower Banter = 3, Ambient Float = 2, Player Emote = 1, Follower Soundset = 0
		public int x010 { get { return Field<int>(0x010); } }
		public Sno x014_ConversationSno { get { return Field<Sno>(0x014); } }
		public Sno[] x018_Snos { get { return Field<Sno>(0x018, 3); } }
		public int x024 { get { return Field<int>(0x024); } }
		public string x028_Text { get { return Field(0x028, 128); } }
		public Sno x0A8_ActorSno { get { return Field<Sno>(0x0A8); } }
		public Sno x0AC_ActorSno { get { return Field<Sno>(0x0AC); } }
		public Sno x0B0_ActorSno { get { return Field<Sno>(0x0B0); } }
		public Sno x0B4_ActorSno { get { return Field<Sno>(0x0B4); } }
		public Sno x0B8_ActorSno { get { return Field<Sno>(0x0B8); } }
		public int x0BC { get { return Field<int>(0x0BC); } }
		public ConversationTreeNode[] x0C0_ConversationTreeNodes { get { return Deserialize<ConversationTreeNode>(x0C8_SerializeData); } }
		public SerializeData x0C8_SerializeData { get { return Field<SerializeData>(0x0C8); } }
		public string x0D0_Text { get { return Field(0x0D0, 256); } }
		public byte[] x1D0_byte { get { return Deserialize<byte>(x1D8_SerializeData); } }
		public SerializeData x1D8_SerializeData { get { return Field<SerializeData>(0x1D8); } }
		public Sno x208_BossEncounterSno { get { return Field<Sno>(0x208); } }
		public int x20C { get { return Field<int>(0x20C); } }
		
		[CompilerGenerated]
		public partial class ConversationTreeNode : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x480; // 1152
			
			public int x000 { get { return Field<int>(0x000); } }
			public int x004 { get { return Field<int>(0x004); } }
			public int x008 { get { return Field<int>(0x008); } }
			public int x00C_Enum { get { return Field<int>(0x00C); } } // - None - = -1, Player = 0, Primary NPC = 1, Alt. NPC 1 = 2, Alt. NPC 2 = 3, Alt. NPC 3 = 4, Alt. NPC 4 = 5, Templar Follower = 6, Scoundrel Follower = 7, Enchantress Follower = 8
			public int x010_Enum { get { return Field<int>(0x010); } } // - None - = -1, Player = 0, Primary NPC = 1, Alt. NPC 1 = 2, Alt. NPC 2 = 3, Alt. NPC 3 = 4, Alt. NPC 4 = 5, Templar Follower = 6, Scoundrel Follower = 7, Enchantress Follower = 8
			public int x014 { get { return Field<int>(0x014); } }
			public Time x018_Time { get { return Field<Time>(0x018); } }
			public int x01C { get { return Field<int>(0x01C); } }
			public int x020 { get { return Field<int>(0x020); } }
			public int x024 { get { return Field<int>(0x024); } }
			public ConvLocaleDisplayTimes[] x028_ConvLocaleDisplayTimes { get { return Field<ConvLocaleDisplayTimes>(0x028, 19); } }
			public string x3B8_Text { get { return Field(0x3B8, 64); } }
			public int x3F8_Enum { get { return Field<int>(0x3F8); } } // - None - = -1, Equal To = 0, Less Than = 1, Greater Than = 2, Less Than Or Equal To = 3, Greater Than Or Equal To = 4, Not Equal To = 5
			public int x3FC { get { return Field<int>(0x3FC); } }
			public string x400_Text { get { return Field(0x400, 64); } }
			public int x440_Enum { get { return Field<int>(0x440); } } // - None - = -1, Incremented By = 0, Decremented By = 1, Set To = 2
			public int x444 { get { return Field<int>(0x444); } }
			public int x448 { get { return Field<int>(0x448); } }
			public int x44C { get { return Field<int>(0x44C); } }
			public ConversationTreeNode[] x450_ConversationTreeNodes { get { return Deserialize<ConversationTreeNode>(x458_SerializeData); } }
			public SerializeData x458_SerializeData { get { return Field<SerializeData>(0x458); } }
			public ConversationTreeNode[] x460_ConversationTreeNodes { get { return Deserialize<ConversationTreeNode>(x468_SerializeData); } }
			public SerializeData x468_SerializeData { get { return Field<SerializeData>(0x468); } }
			public ConversationTreeNode[] x470_ConversationTreeNodes { get { return Deserialize<ConversationTreeNode>(x478_SerializeData); } }
			public SerializeData x478_SerializeData { get { return Field<SerializeData>(0x478); } }
		}
		
		[CompilerGenerated]
		public partial class ConvLocaleDisplayTimes : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x30; // 48
			
			public int[] x00_int { get { return Field<int>(0x00, 12); } }
		}
	}
}
