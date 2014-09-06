using System.Runtime.CompilerServices;
using Enigma.D3.Collections;
using Enigma.D3.Memory;
using Enigma.Memory;

namespace Enigma.D3.Sno
{
	[CompilerGenerated]
	public partial class TimedEvent : MemoryObject
	{
		// 2.1.0.26451
		public const int SizeOf = 0x10; // 16
		
		public Time x0C_Time { get { return Read<Time>(0x0C); } }
	}
}
