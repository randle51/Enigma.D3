using System.Runtime.CompilerServices;
using Enigma.D3.DataTypes;
using Enigma.Memory;

namespace Enigma.D3.Assets
{
	[CompilerGenerated]
	public partial class Lore : MemoryObject
	{
		public const int SizeOf = 0x24; // 36
		
		public SNOHeader x00_Header { get { return Read<SNOHeader>(0x00); } }
		public int x0C { get { return Read<int>(0x0C); } }
		public int x10 { get { return Read<int>(0x10); } }
		public int x14 { get { return Read<int>(0x14); } }
		public int x18 { get { return Read<int>(0x18); } }
		public SNO x1C_ConversationSNO { get { return Read<SNO>(0x1C); } }
		public int x20 { get { return Read<int>(0x20); } }
	}
}
