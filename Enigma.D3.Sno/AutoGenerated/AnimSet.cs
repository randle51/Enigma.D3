using System.Runtime.CompilerServices;
using Enigma.D3.Collections;
using Enigma.D3.Memory;

namespace Enigma.D3.Sno
{
	[CompilerGenerated]
	public partial class AnimSet : SerializeMemoryObject
	{
		// 2.0.6.24641
		public const int SizeOf = 0x1E0; // 480
		
		public Sno x00C_AnimSetSno { get { return Field<Sno>(0x00C); } }
		public SerializeData x010_SerializeData { get { return Field<SerializeData>(0x010); } }
		public int[] x018_TagMap { get { return Deserialize<int>(x010_SerializeData); } }
		public AnimSetTagMap[] x020_AnimSetTagMaps { get { return Field<AnimSetTagMap>(0x020, 28); } }
		
		[CompilerGenerated]
		public partial class AnimSetTagMap : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x10; // 16
			
			public SerializeData x00_SerializeData { get { return Field<SerializeData>(0x00); } }
			public int[] x08_TagMap { get { return Deserialize<int>(x00_SerializeData); } }
		}
	}
}
