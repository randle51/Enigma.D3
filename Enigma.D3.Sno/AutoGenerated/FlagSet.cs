using System.Runtime.CompilerServices;
using Enigma.D3.Collections;
using Enigma.D3.Memory;
using Enigma.Memory;

namespace Enigma.D3.Sno
{
	[CompilerGenerated]
	public partial class FlagSet : SerializeMemoryObject
	{
		// 2.2.0.30894
		public const int SizeOf = 0x20; // 32
		
		public SnoHeader x00_Header { get { return Read<SnoHeader>(0x00); } }
		public FlagLookup[] x10_FlagLookups { get { return Deserialize<FlagLookup>(x18_SerializeData); } }
		public SerializeData x18_SerializeData { get { return Read<SerializeData>(0x18); } }
		
		[CompilerGenerated]
		public partial class FlagLookup : MemoryObject
		{
			// 2.2.0.30894
			public const int SizeOf = 0x184; // 388
			
			public int x000 { get { return Read<int>(0x000); } }
			public string x004_Text { get { return ReadString(0x004, 128); } }
			public string x084_Text { get { return ReadString(0x084, 256); } }
		}
	}
}
