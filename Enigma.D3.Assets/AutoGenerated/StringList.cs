using System.Runtime.CompilerServices;
using Enigma.D3.DataTypes;
using Enigma.Memory;

namespace Enigma.D3.Assets
{
	[CompilerGenerated]
	public partial class StringList : SerializeMemoryObject
	{
		public const int SizeOf = 0x28; // 40
		
		public SnoHeader x00_Header { get { return Read<SnoHeader>(0x00); } }
		public StringTableEntry[] x10_StringTableEntries { get { return Deserialize<StringTableEntry>(x18_SerializeData); } }
		public SerializeData x18_SerializeData { get { return Read<SerializeData>(0x18); } }
		
		[CompilerGenerated]
		public partial class StringTableEntry : SerializeMemoryObject
		{
			public const int SizeOf = 0x28; // 40
			
			public string x00_Text { get { return DeserializeString(x08_SerializeData); } }
			public SerializeData x08_SerializeData { get { return Read<SerializeData>(0x08); } }
			public string x10_Text { get { return DeserializeString(x18_SerializeData); } }
			public SerializeData x18_SerializeData { get { return Read<SerializeData>(0x18); } }
			public int x20 { get { return Read<int>(0x20); } }
			public int x24 { get { return Read<int>(0x24); } }
		}
	}
}
