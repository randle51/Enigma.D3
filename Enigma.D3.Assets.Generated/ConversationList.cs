using System.Runtime.CompilerServices;
using Enigma.D3.DataTypes;
using Enigma.Memory;

namespace Enigma.D3.Assets
{
	[CompilerGenerated]
	public partial class ConversationList : SerializeMemoryObject
	{
		public const int SizeOf = 0x20; // 32
		
		public SNOHeader x00_Header { get { return Read<SNOHeader>(0x00); } }
		public ConversationListEntry[] x10_ConversationListEntries { get { return Deserialize<ConversationListEntry>(x18_SerializeData); } }
		public SerializeData x18_SerializeData { get { return Read<SerializeData>(0x18); } }
		
		[CompilerGenerated]
		public partial class ConversationListEntry : MemoryObject
		{
			public const int SizeOf = 0x14C; // 332
			
			public SNO x000_ConversationSNO { get { return Read<SNO>(0x000); } }
			public int x004 { get { return Read<int>(0x004); } }
			public int x008 { get { return Read<int>(0x008); } }
			public int x00C { get { return Read<int>(0x00C); } }
			public GBID x010_ItemsGBID { get { return Read<GBID>(0x010); } }
			public string x014_Text { get { return ReadString(0x014, 128); } }
			public string x094_Text { get { return ReadString(0x094, 128); } }
			public SNO x114_QuestSNO { get { return Read<SNO>(0x114); } }
			public int x118 { get { return Read<int>(0x118); } }
			public SNO x11C_QuestSNO { get { return Read<SNO>(0x11C); } }
			public SNO x120_QuestSNO { get { return Read<SNO>(0x120); } }
			public SNO x124_QuestSNO { get { return Read<SNO>(0x124); } }
			public SNO x128_QuestRangeSNO { get { return Read<SNO>(0x128); } }
			public SNO[] x12C_SNOs { get { return Read<SNO>(0x12C, 6); } }
			public int x144 { get { return Read<int>(0x144); } }
			public int x148 { get { return Read<int>(0x148); } }
		}
	}
}
