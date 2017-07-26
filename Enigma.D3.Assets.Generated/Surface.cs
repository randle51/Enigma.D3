using System.Runtime.CompilerServices;
using Enigma.D3.DataTypes;
using Enigma.Memory;

namespace Enigma.D3.Assets
{
	[CompilerGenerated]
	public partial class Surface : SerializeMemoryObject
	{
		public const int SizeOf = 0x28; // 40
		
		public SNOHeader x00_Header { get { return Read<SNOHeader>(0x00); } }
		public int x0C { get { return Read<int>(0x0C); } }
		public SNO x10_ParticleSNO { get { return Read<SNO>(0x10); } }
		public int x14 { get { return Read<int>(0x14); } }
		public SerializeData x18_SerializeData { get { return Read<SerializeData>(0x18); } }
		public TagMap x20_TagMap { get { return new TagMap(Deserialize<byte>(x18_SerializeData)); } } // type: 0x00050000
	}
}
