using System.Runtime.CompilerServices;
using Enigma.D3.Collections;
using Enigma.D3.Memory;
using Enigma.Memory;

namespace Enigma.D3.Sno
{
	[CompilerGenerated]
	public partial class SkillKit : SerializeMemoryObject
	{
		public const int SizeOf = 0x40; // 64
		
		public SnoHeader x00_Header { get { return Read<SnoHeader>(0x00); } }
		public TraitEntry[] x10_TraitEntries { get { return Deserialize<TraitEntry>(x18_SerializeData); } }
		public SerializeData x18_SerializeData { get { return Read<SerializeData>(0x18); } }
		public ActiveSkillEntry[] x20_ActiveSkillEntries { get { return Deserialize<ActiveSkillEntry>(x28_SerializeData); } }
		public SerializeData x28_SerializeData { get { return Read<SerializeData>(0x28); } }
		public int[] x30_int { get { return Deserialize<int>(x38_SerializeData); } }
		public SerializeData x38_SerializeData { get { return Read<SerializeData>(0x38); } }
		
		[CompilerGenerated]
		public partial class TraitEntry : MemoryObject
		{
			public const int SizeOf = 0x10; // 16
			
			public Sno x00_PowerSno { get { return Read<Sno>(0x00); } }
			public int x04 { get { return Read<int>(0x04); } }
			public int x08 { get { return Read<int>(0x08); } }
			public int x0C { get { return Read<int>(0x0C); } }
		}
		
		[CompilerGenerated]
		public partial class ActiveSkillEntry : MemoryObject
		{
			public const int SizeOf = 0x40; // 64
			
			public Sno x00_PowerSno { get { return Read<Sno>(0x00); } }
			public int x04 { get { return Read<int>(0x04); } }
			public int x08 { get { return Read<int>(0x08); } }
			public int x0C { get { return Read<int>(0x0C); } }
			public int x10 { get { return Read<int>(0x10); } }
			public int x14 { get { return Read<int>(0x14); } }
			public int x18 { get { return Read<int>(0x18); } }
			public int x1C { get { return Read<int>(0x1C); } }
			public int x20 { get { return Read<int>(0x20); } }
			public int x24 { get { return Read<int>(0x24); } }
			public int x28 { get { return Read<int>(0x28); } }
			public int[] x2C_int { get { return Read<int>(0x2C, 5); } }
		}
	}
}
