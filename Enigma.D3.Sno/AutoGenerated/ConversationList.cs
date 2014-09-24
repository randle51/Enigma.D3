using System.Runtime.CompilerServices;
using Enigma.D3.Collections;
using Enigma.D3.Memory;
using Enigma.Memory;

namespace Enigma.D3.Sno
{
	[CompilerGenerated]
	public partial class ConversationList : SerializeMemoryObject
	{
		// 2.1.1.27255
		public const int SizeOf = 0x20; // 32
		
		public SnoHeader x00_Header { get { return Read<SnoHeader>(0x00); } }
		public ConversationListEntry[] x10_ConversationListEntries { get { return Deserialize<ConversationListEntry>(x18_SerializeData); } }
		public SerializeData x18_SerializeData { get { return Read<SerializeData>(0x18); } }
		
		[CompilerGenerated]
		public partial class ConversationListEntry : MemoryObject
		{
			// 2.1.1.27255
			public const int SizeOf = 0x14C; // 332
			
			public Sno x000_ConversationSno { get { return Read<Sno>(0x000); } }
			public int x004 { get { return Read<int>(0x004); } }
			public int x008 { get { return Read<int>(0x008); } }
			public int x00C { get { return Read<int>(0x00C); } }
			public GameBalanceId x010_ItemsGameBalanceId { get { return Read<GameBalanceId>(0x010); } }
			public string x014_Text { get { return ReadString(0x014, 128); } }
			public string x094_Text { get { return ReadString(0x094, 128); } }
			public Sno x114_QuestSno { get { return Read<Sno>(0x114); } }
			public int x118 { get { return Read<int>(0x118); } }
			public Sno x11C_QuestSno { get { return Read<Sno>(0x11C); } }
			public Sno x120_QuestSno { get { return Read<Sno>(0x120); } }
			public Sno x124_QuestSno { get { return Read<Sno>(0x124); } }
			public Sno x128_QuestRangeSno { get { return Read<Sno>(0x128); } }
			public Sno[] x12C_Snos { get { return Read<Sno>(0x12C, 6); } }
			public int x144 { get { return Read<int>(0x144); } }
			public int x148 { get { return Read<int>(0x148); } }
		}
	}
}
