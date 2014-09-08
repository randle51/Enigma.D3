using System.Runtime.CompilerServices;
using Enigma.D3.Collections;
using Enigma.D3.Memory;
using Enigma.Memory;

namespace Enigma.D3.Sno
{
	[CompilerGenerated]
	public partial class QuestRange : SerializeMemoryObject
	{
		// 2.1.0.26451
		public const int SizeOf = 0x20; // 32
		
		public SnoHeader x00_Header { get { return Read<SnoHeader>(0x00); } }
		public int x0C { get { return Read<int>(0x0C); } }
		public QuestRangeData[] x10_QuestRanges { get { return Deserialize<QuestRangeData>(x18_SerializeData); } }
		public SerializeData x18_SerializeData { get { return Read<SerializeData>(0x18); } }
		
		[CompilerGenerated]
		public partial class QuestRangeData : MemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x10; // 16
			
			public QuestTime x00_QuestTime { get { return Read<QuestTime>(0x00); } }
			public QuestTime x08_QuestTime { get { return Read<QuestTime>(0x08); } }
		}
		
		[CompilerGenerated]
		public partial class QuestTime : MemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x08; // 8
			
			public Sno x00_QuestSno { get { return Read<Sno>(0x00); } }
			public int x04 { get { return Read<int>(0x04); } }
		}
	}
}
