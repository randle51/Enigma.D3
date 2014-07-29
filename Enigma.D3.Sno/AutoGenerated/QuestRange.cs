using System.Runtime.CompilerServices;
using Enigma.D3.Collections;
using Enigma.D3.Memory;

namespace Enigma.D3.Sno
{
	[CompilerGenerated]
	public partial class QuestRange : SerializeMemoryObject
	{
		// 2.0.6.24641
		public const int SizeOf = 0x20; // 32
		
		public int x0C { get { return Field<int>(0x0C); } }
		public QuestRange[] x10_QuestRanges { get { return Deserialize<QuestRange>(x18_SerializeData); } }
		public SerializeData x18_SerializeData { get { return Field<SerializeData>(0x18); } }
	}
}
