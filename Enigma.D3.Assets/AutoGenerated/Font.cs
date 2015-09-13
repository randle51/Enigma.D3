using System.Runtime.CompilerServices;
using Enigma.D3.DataTypes;
using Enigma.Memory;

namespace Enigma.D3.Assets
{
	[CompilerGenerated]
	public partial class Font : SerializeMemoryObject
	{
		public const int SizeOf = 0xC8; // 200
		
		public SnoHeader x00_Header { get { return Read<SnoHeader>(0x00); } }
		public int x0C { get { return Read<int>(0x0C); } }
		public string x10_Text { get { return ReadString(0x10, 64); } }
		public string x50_Text { get { return ReadString(0x50, 64); } }
		public int x90 { get { return Read<int>(0x90); } }
		public int x94_Enum { get { return Read<int>(0x94); } } // Disabled = 1, Native = 0, Auto = 2
		public int x98_Enum { get { return Read<int>(0x98); } } // Normal = 0, Light = 1, LCD = 2, LCD Vertical = 3
		public int x9C { get { return Read<int>(0x9C); } }
		public float xA0 { get { return Read<float>(0xA0); } }
		public float xA4 { get { return Read<float>(0xA4); } }
		public SerializeData xA8_SerializeData { get { return Read<SerializeData>(0xA8); } }
		public byte[] xB0_byte { get { return Deserialize<byte>(xA8_SerializeData); } }
		public int xB8 { get { return Read<int>(0xB8); } }
		public int xBC { get { return Read<int>(0xBC); } }
		public long xC0 { get { return Read<long>(0xC0); } }
	}
}
