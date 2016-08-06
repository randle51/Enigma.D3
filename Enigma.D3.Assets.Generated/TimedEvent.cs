using System.Runtime.CompilerServices;
using Enigma.D3.DataTypes;
using Enigma.Memory;

namespace Enigma.D3.Assets
{
	[CompilerGenerated]
	public partial class TimedEvent : MemoryObject
	{
		public const int SizeOf = 0x10; // 16
		
		public SNOHeader x00_Header { get { return Read<SNOHeader>(0x00); } }
		public Time x0C_Time { get { return Read<Time>(0x0C); } }
	}
}
