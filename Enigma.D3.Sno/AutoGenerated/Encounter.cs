using System.Runtime.CompilerServices;
using Enigma.D3.Collections;
using Enigma.D3.Memory;

namespace Enigma.D3.Sno
{
	[CompilerGenerated]
	public partial class Encounter : SerializeMemoryObject
	{
		// 2.0.6.24641
		public const int SizeOf = 0x20; // 32
		
		public Sno x0C_ActorSno { get { return Field<Sno>(0x0C); } }
		public EncounterSpawnOption[] x10_EncounterSpawnOptions { get { return Deserialize<EncounterSpawnOption>(x18_SerializeData); } }
		public SerializeData x18_SerializeData { get { return Field<SerializeData>(0x18); } }
		
		[CompilerGenerated]
		public partial class EncounterSpawnOption : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0xC; // 12
			
			public Sno x00_ActorSno { get { return Field<Sno>(0x00); } }
			public int x04 { get { return Field<int>(0x04); } }
			public int x08 { get { return Field<int>(0x08); } }
		}
	}
}
