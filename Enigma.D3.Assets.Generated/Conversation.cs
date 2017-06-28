using System.Runtime.CompilerServices;
using Enigma.D3.DataTypes;
using Enigma.Memory;

namespace Enigma.D3.Assets
{
	[CompilerGenerated]
	public partial class Conversation : SerializeMemoryObject
	{
		public const int SizeOf = 0x110; // 272
		
		public SNOHeader x000_Header { get { return Read<SNOHeader>(0x000); } }
		public int x00C_Enum { get { return Read<int>(0x00C); } } // Quest Event = 13, Quest Float = 12, Quest Standard = 11, Talk Menu Gossip = 10, Ambient Gossip = 9, Lore Book = 8, Global Float = 7, Global Chatter = 6, Player Callout = 5, Follower Callout = 4, Follower Banter = 3, Ambient Float = 2, Player Emote = 1, Follower Soundset = 0
		public int x010 { get { return Read<int>(0x010); } }
		public SNO x014_ConversationSNO { get { return Read<SNO>(0x014); } }
		public SNO[] x018_SNOs { get { return Read<SNO>(0x018, 3); } }
		public int x024 { get { return Read<int>(0x024); } }
		public string x028_Text { get { return ReadString(0x028, 128); } }
		public SNO x0A8_ActorSNO { get { return Read<SNO>(0x0A8); } }
		public SNO x0AC_ActorSNO { get { return Read<SNO>(0x0AC); } }
		public SNO x0B0_ActorSNO { get { return Read<SNO>(0x0B0); } }
		public SNO x0B4_ActorSNO { get { return Read<SNO>(0x0B4); } }
		public SNO x0B8_ActorSNO { get { return Read<SNO>(0x0B8); } }
		public int x0BC { get { return Read<int>(0x0BC); } }
		public ConversationTreeNode[] x0C0_ConversationTreeNodes { get { return Deserialize<ConversationTreeNode>(x0C8_SerializeData); } }
		public SerializeData x0C8_SerializeData { get { return Read<SerializeData>(0x0C8); } }
		public byte[] x0D0_byte { get { return Deserialize<byte>(x0D8_SerializeData); } }
		public SerializeData x0D8_SerializeData { get { return Read<SerializeData>(0x0D8); } }
		public SNO x108_BossEncounterSNO { get { return Read<SNO>(0x108); } }
		public int x10C { get { return Read<int>(0x10C); } }
		
		[CompilerGenerated]
		public partial class ConversationTreeNode : SerializeMemoryObject
		{
			public const int SizeOf = 0x4A0; // 1184
			
			public int x000 { get { return Read<int>(0x000); } }
			public int x004 { get { return Read<int>(0x004); } }
			public int x008 { get { return Read<int>(0x008); } }
			public int x00C_Enum { get { return Read<int>(0x00C); } } // - None - = -1, Player = 0, Primary NPC = 1, Alt. NPC 1 = 2, Alt. NPC 2 = 3, Alt. NPC 3 = 4, Alt. NPC 4 = 5, Templar Follower = 6, Scoundrel Follower = 7, Enchantress Follower = 8
			public int x010_Enum { get { return Read<int>(0x010); } } // - None - = -1, Player = 0, Primary NPC = 1, Alt. NPC 1 = 2, Alt. NPC 2 = 3, Alt. NPC 3 = 4, Alt. NPC 4 = 5, Templar Follower = 6, Scoundrel Follower = 7, Enchantress Follower = 8
			public int x014 { get { return Read<int>(0x014); } }
			public Time x018_Time { get { return Read<Time>(0x018); } }
			public int x01C { get { return Read<int>(0x01C); } }
			public int x020 { get { return Read<int>(0x020); } }
			public int x024 { get { return Read<int>(0x024); } }
			public ConvLocaleDisplayTimes[] x028_ConvLocaleDisplayTimes { get { return Read<ConvLocaleDisplayTimes>(0x028, 19); } }
			public int x450 { get { return Read<int>(0x450); } }
			public int x454_Enum { get { return Read<int>(0x454); } } // - None - = -1, Equal To = 0, Less Than = 1, Greater Than = 2, Less Than Or Equal To = 3, Greater Than Or Equal To = 4, Not Equal To = 5
			public int x458 { get { return Read<int>(0x458); } }
			public int x45C { get { return Read<int>(0x45C); } }
			public int x460_Enum { get { return Read<int>(0x460); } } // - None - = -1, Incremented By = 0, Decremented By = 1, Set To = 2
			public int x464 { get { return Read<int>(0x464); } }
			public int x468 { get { return Read<int>(0x468); } }
			public int x46C { get { return Read<int>(0x46C); } }
			public ConversationTreeNode[] x470_ConversationTreeNodes { get { return Deserialize<ConversationTreeNode>(x478_SerializeData); } }
			public SerializeData x478_SerializeData { get { return Read<SerializeData>(0x478); } }
			public ConversationTreeNode[] x480_ConversationTreeNodes { get { return Deserialize<ConversationTreeNode>(x488_SerializeData); } }
			public SerializeData x488_SerializeData { get { return Read<SerializeData>(0x488); } }
			public ConversationTreeNode[] x490_ConversationTreeNodes { get { return Deserialize<ConversationTreeNode>(x498_SerializeData); } }
			public SerializeData x498_SerializeData { get { return Read<SerializeData>(0x498); } }
		}
		
		[CompilerGenerated]
		public partial class ConvLocaleDisplayTimes : MemoryObject
		{
			public const int SizeOf = 0x38; // 56
			
			public int[] x00_int { get { return Read<int>(0x00, 14); } }
		}
	}
}
