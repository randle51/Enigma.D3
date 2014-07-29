using System.Runtime.CompilerServices;
using Enigma.D3.Collections;
using Enigma.D3.Memory;

namespace Enigma.D3.Sno
{
	[CompilerGenerated]
	public partial class StringList : SerializeMemoryObject
	{
		// 2.0.6.24641
		public const int SizeOf = 0x28; // 40
		
		public StringTableEntry[] x10_StringTableEntries { get { return Deserialize<StringTableEntry>(x18_SerializeData); } }
		public SerializeData x18_SerializeData { get { return Field<SerializeData>(0x18); } }
		
		[CompilerGenerated]
		public partial class StringTableEntry : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x28; // 40
			
			public string x00_Text { get { return Deserialize(x08_SerializeData); } }
			public SerializeData x08_SerializeData { get { return Field<SerializeData>(0x08); } }
			public string x10_Text { get { return Deserialize(x18_SerializeData); } }
			public SerializeData x18_SerializeData { get { return Field<SerializeData>(0x18); } }
			public int x20 { get { return Field<int>(0x20); } }
			public int x24 { get { return Field<int>(0x24); } }
		}
	}
}
