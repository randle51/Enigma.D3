using System.Runtime.CompilerServices;
using Enigma.D3.Collections;
using Enigma.D3.Memory;
using Enigma.Memory;

namespace Enigma.D3.Sno
{
	[CompilerGenerated]
	public partial class Lore : MemoryObject
	{
		public const int SizeOf = 0x24; // 36
		
		public SnoHeader x00_Header { get { return Read<SnoHeader>(0x00); } }
		public int x0C { get { return Read<int>(0x0C); } }
		public int x10 { get { return Read<int>(0x10); } }
		public int x14 { get { return Read<int>(0x14); } }
		public int x18 { get { return Read<int>(0x18); } }
		public Sno x1C_ConversationSno { get { return Read<Sno>(0x1C); } }
		public int x20 { get { return Read<int>(0x20); } }
	}
}
