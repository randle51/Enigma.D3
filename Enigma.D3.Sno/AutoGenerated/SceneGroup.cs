using System.Runtime.CompilerServices;
using Enigma.D3.Collections;
using Enigma.D3.Memory;

namespace Enigma.D3.Sno
{
	[CompilerGenerated]
	public partial class SceneGroup : SerializeMemoryObject
	{
		// 2.0.6.24641
		public const int SizeOf = 0x28; // 40
		
		public int x0C { get { return Field<int>(0x0C); } }
		public SerializeData x10_SerializeData { get { return Field<SerializeData>(0x10); } }
		public SceneGroupItem[] x18_SceneGroupItems { get { return Deserialize<SceneGroupItem>(x10_SerializeData); } }
		public int x20 { get { return Field<int>(0x20); } }
		
		[CompilerGenerated]
		public partial class SceneGroupItem : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0xC; // 12
			
			public Sno x00_SceneSno { get { return Field<Sno>(0x00); } }
			public int x04 { get { return Field<int>(0x04); } }
			public GameBalanceId x08_LabelsGameBalanceId { get { return Field<GameBalanceId>(0x08); } }
		}
	}
}
