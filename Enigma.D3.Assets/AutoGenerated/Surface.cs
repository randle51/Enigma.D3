using System.Runtime.CompilerServices;
using Enigma.D3.DataTypes;
using Enigma.Memory;

namespace Enigma.D3.Assets
{
	[CompilerGenerated]
	public partial class Surface : SerializeMemoryObject
	{
		public const int SizeOf = 0x28; // 40
		
		public SnoHeader x00_Header { get { return Read<SnoHeader>(0x00); } }
		public int x0C { get { return Read<int>(0x0C); } }
		public Sno x10_ParticleSno { get { return Read<Sno>(0x10); } }
		public int x14 { get { return Read<int>(0x14); } }
		public SerializeData x18_SerializeData { get { return Read<SerializeData>(0x18); } }
		public int[] x20_TagMap { get { return Deserialize<int>(x18_SerializeData); } } // type: 0x00050000
	}
}
