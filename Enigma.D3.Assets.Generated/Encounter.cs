using System.Runtime.CompilerServices;
using Enigma.D3.DataTypes;
using Enigma.Memory;

namespace Enigma.D3.Assets
{
	[CompilerGenerated]
	public partial class Encounter : SerializeMemoryObject
	{
		public const int SizeOf = 0x20; // 32
		
		public SNOHeader x00_Header { get { return Read<SNOHeader>(0x00); } }
		public SNO x0C_ActorSNO { get { return Read<SNO>(0x0C); } }
		public EncounterSpawnOption[] x10_EncounterSpawnOptions { get { return Deserialize<EncounterSpawnOption>(x18_SerializeData); } }
		public SerializeData x18_SerializeData { get { return Read<SerializeData>(0x18); } }
		
		[CompilerGenerated]
		public partial class EncounterSpawnOption : MemoryObject
		{
			public const int SizeOf = 0x10; // 16
			
			public SNO x00_ActorSNO { get { return Read<SNO>(0x00); } }
			public int x04 { get { return Read<int>(0x04); } }
			public int x08 { get { return Read<int>(0x08); } }
			public SNO x0C_ConditionSNO { get { return Read<SNO>(0x0C); } }
		}
	}
}
