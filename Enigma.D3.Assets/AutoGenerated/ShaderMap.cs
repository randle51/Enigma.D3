using System.Runtime.CompilerServices;
using Enigma.D3.DataTypes;
using Enigma.Memory;

namespace Enigma.D3.Assets
{
	[CompilerGenerated]
	public partial class ShaderMap : SerializeMemoryObject
	{
		public const int SizeOf = 0x20; // 32
		
		public SnoHeader x00_Header { get { return Read<SnoHeader>(0x00); } }
		public int x0C { get { return Read<int>(0x0C); } }
		public SerializeData x10_SerializeData { get { return Read<SerializeData>(0x10); } }
		public int[] x18_TagMap { get { return Deserialize<int>(x10_SerializeData); } } // type: 0x00030000
	}
}
