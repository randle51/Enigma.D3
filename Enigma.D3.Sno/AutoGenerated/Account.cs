using System.Runtime.CompilerServices;
using Enigma.D3.Collections;
using Enigma.D3.Memory;

namespace Enigma.D3.Sno
{
	[CompilerGenerated]
	public partial class Account : SerializeMemoryObject
	{
		// 2.0.6.24641
		public const int SizeOf = 0x20; // 32
		
		public SerializeData x0C_SerializeData { get { return Field<SerializeData>(0x0C); } }
		public byte[] x18_byte { get { return Deserialize<byte>(x0C_SerializeData); } }
	}
}
