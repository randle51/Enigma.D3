using System.Runtime.CompilerServices;
using Enigma.D3.DataTypes;
using Enigma.Memory;

namespace Enigma.D3.Assets
{
	[CompilerGenerated]
	public partial class QuestRange : SerializeMemoryObject
	{
		public const int SizeOf = 0x20; // 32
		
		public SNOHeader x00_Header { get { return Read<SNOHeader>(0x00); } }
		public int x0C { get { return Read<int>(0x0C); } }
		public QuestRangeData[] x10_QuestRangeData { get { return Deserialize<QuestRangeData>(x18_SerializeData); } }
		public SerializeData x18_SerializeData { get { return Read<SerializeData>(0x18); } }
		
		[CompilerGenerated]
		public partial class QuestRangeData : MemoryObject
		{
			public const int SizeOf = 0x10; // 16
			
			public QuestTime x00_QuestTime { get { return Read<QuestTime>(0x00); } }
			public QuestTime x08_QuestTime { get { return Read<QuestTime>(0x08); } }
		}
		
		[CompilerGenerated]
		public partial class QuestTime : MemoryObject
		{
			public const int SizeOf = 0x08; // 8
			
			public SNO x00_QuestSNO { get { return Read<SNO>(0x00); } }
			public int x04 { get { return Read<int>(0x04); } }
		}
	}
}
