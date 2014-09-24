using System.Runtime.CompilerServices;
using Enigma.D3.Collections;
using Enigma.D3.Memory;
using Enigma.Memory;

namespace Enigma.D3.Sno
{
	[CompilerGenerated]
	public partial class Encounter : SerializeMemoryObject
	{
		// 2.1.1.27255
		public const int SizeOf = 0x20; // 32
		
		public SnoHeader x00_Header { get { return Read<SnoHeader>(0x00); } }
		public Sno x0C_ActorSno { get { return Read<Sno>(0x0C); } }
		public EncounterSpawnOption[] x10_EncounterSpawnOptions { get { return Deserialize<EncounterSpawnOption>(x18_SerializeData); } }
		public SerializeData x18_SerializeData { get { return Read<SerializeData>(0x18); } }
		
		[CompilerGenerated]
		public partial class EncounterSpawnOption : MemoryObject
		{
			// 2.1.1.27255
			public const int SizeOf = 0x10; // 16
			
			public Sno x00_ActorSno { get { return Read<Sno>(0x00); } }
			public int x04 { get { return Read<int>(0x04); } }
			public int x08 { get { return Read<int>(0x08); } }
			public Sno x0C_ConditionSno { get { return Read<Sno>(0x0C); } }
		}
	}
}
