using System.Runtime.CompilerServices;
using Enigma.D3.DataTypes;
using Enigma.Memory;

namespace Enigma.D3.Assets
{
	[CompilerGenerated]
	public partial class Hero : SerializeMemoryObject
	{
		public const int SizeOf = 0x20; // 32
		
		public SnoHeader x00_Header { get { return Read<SnoHeader>(0x00); } }
		public SerializeData x0C_SerializeData { get { return Read<SerializeData>(0x0C); } }
		public byte[] x18_byte { get { return Deserialize<byte>(x0C_SerializeData); } }
	}
}
