using System.Runtime.CompilerServices;
using Enigma.D3.DataTypes;
using Enigma.Memory;

namespace Enigma.D3.Assets
{
	[CompilerGenerated]
	public partial class SceneGroup : SerializeMemoryObject
	{
		public const int SizeOf = 0x28; // 40
		
		public SnoHeader x00_Header { get { return Read<SnoHeader>(0x00); } }
		public int x0C { get { return Read<int>(0x0C); } }
		public SerializeData x10_SerializeData { get { return Read<SerializeData>(0x10); } }
		public SceneGroupItem[] x18_SceneGroupItems { get { return Deserialize<SceneGroupItem>(x10_SerializeData); } }
		public int x20 { get { return Read<int>(0x20); } }
		
		[CompilerGenerated]
		public partial class SceneGroupItem : MemoryObject
		{
			public const int SizeOf = 0x0C; // 12
			
			public Sno x00_SceneSno { get { return Read<Sno>(0x00); } }
			public int x04 { get { return Read<int>(0x04); } }
			public GameBalanceId x08_LabelsGameBalanceId { get { return Read<GameBalanceId>(0x08); } }
		}
	}
}
