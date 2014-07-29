using System.Runtime.CompilerServices;
using Enigma.D3.Collections;
using Enigma.D3.Memory;

namespace Enigma.D3.Sno
{
	[CompilerGenerated]
	public partial class Lore : SerializeMemoryObject
	{
		// 2.0.6.24641
		public const int SizeOf = 0x24; // 36
		
		public int x0C { get { return Field<int>(0x0C); } }
		public int x10 { get { return Field<int>(0x10); } }
		public int x14 { get { return Field<int>(0x14); } }
		public int x18 { get { return Field<int>(0x18); } }
		public Sno x1C_ConversationSno { get { return Field<Sno>(0x1C); } }
		public int x20 { get { return Field<int>(0x20); } }
	}
}
