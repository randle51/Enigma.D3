using System.Runtime.CompilerServices;
using Enigma.D3.Collections;
using Enigma.D3.Memory;

namespace Enigma.D3.Sno
{
	[CompilerGenerated]
	public partial class Font : SerializeMemoryObject
	{
		// 2.0.6.24641
		public const int SizeOf = 0xC8; // 200
		
		public int x0C { get { return Field<int>(0x0C); } }
		public string x10_Text { get { return Field(0x10, 64); } }
		public string x50_Text { get { return Field(0x50, 64); } }
		public int x90 { get { return Field<int>(0x90); } }
		public int x94_Enum { get { return Field<int>(0x94); } } // Disabled = 1, Native = 0, Auto = 2
		public int x98_Enum { get { return Field<int>(0x98); } } // Normal = 0, Light = 1, LCD = 2, LCD Vertical = 3
		public int x9C { get { return Field<int>(0x9C); } }
		public float xA0 { get { return Field<float>(0xA0); } }
		public float xA4 { get { return Field<float>(0xA4); } }
		public SerializeData xA8_SerializeData { get { return Field<SerializeData>(0xA8); } }
		public byte[] xB0_byte { get { return Deserialize<byte>(xA8_SerializeData); } }
		public int xB8 { get { return Field<int>(0xB8); } }
		public int xBC { get { return Field<int>(0xBC); } }
		public long xC0 { get { return Field<long>(0xC0); } }
	}
}
