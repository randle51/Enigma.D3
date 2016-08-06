using System.Runtime.CompilerServices;
using Enigma.D3.DataTypes;
using Enigma.Memory;

namespace Enigma.D3.Assets
{
	[CompilerGenerated]
	public partial class SceneGroup : SerializeMemoryObject
	{
		public const int SizeOf = 0x28; // 40
		
		public SNOHeader x00_Header { get { return Read<SNOHeader>(0x00); } }
		public int x0C { get { return Read<int>(0x0C); } }
		public SerializeData x10_SerializeData { get { return Read<SerializeData>(0x10); } }
		public SceneGroupItem[] x18_SceneGroupItems { get { return Deserialize<SceneGroupItem>(x10_SerializeData); } }
		public int x20 { get { return Read<int>(0x20); } }
		
		[CompilerGenerated]
		public partial class SceneGroupItem : MemoryObject
		{
			public const int SizeOf = 0x0C; // 12
			
			public SNO x00_SceneSNO { get { return Read<SNO>(0x00); } }
			public int x04 { get { return Read<int>(0x04); } }
			public GBID x08_LabelsGBID { get { return Read<GBID>(0x08); } }
		}
	}
}
