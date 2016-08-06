using System.Runtime.CompilerServices;
using Enigma.D3.DataTypes;
using Enigma.Memory;

namespace Enigma.D3.Assets
{
	[CompilerGenerated]
	public partial class AnimSet : SerializeMemoryObject
	{
		public const int SizeOf = 0x1E0; // 480
		
		public SNOHeader x000_Header { get { return Read<SNOHeader>(0x000); } }
		public SNO x00C_AnimSetSNO { get { return Read<SNO>(0x00C); } }
		public SerializeData x010_SerializeData { get { return Read<SerializeData>(0x010); } }
		public int[] x018_TagMap { get { return Deserialize<int>(x010_SerializeData); } } // type: 0x000C0000
		public AnimSetTagMap[] x020_AnimSetTagMaps { get { return Read<AnimSetTagMap>(0x020, 28); } }
		
		[CompilerGenerated]
		public partial class AnimSetTagMap : SerializeMemoryObject
		{
			public const int SizeOf = 0x10; // 16
			
			public SerializeData x00_SerializeData { get { return Read<SerializeData>(0x00); } }
			public int[] x08_TagMap { get { return Deserialize<int>(x00_SerializeData); } } // type: 0x000C0000
		}
	}
}
