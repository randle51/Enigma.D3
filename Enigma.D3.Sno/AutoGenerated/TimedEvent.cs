using System.Runtime.CompilerServices;
using Enigma.D3.Collections;
using Enigma.D3.Memory;

namespace Enigma.D3.Sno
{
	[CompilerGenerated]
	public partial class TimedEvent : SerializeMemoryObject
	{
		// 2.0.6.24641
		public const int SizeOf = 0x10; // 16
		
		public Time x0C_Time { get { return Field<Time>(0x0C); } }
	}
}
