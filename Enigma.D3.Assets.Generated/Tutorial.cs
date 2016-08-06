using System.Runtime.CompilerServices;
using Enigma.D3.DataTypes;
using Enigma.Memory;

namespace Enigma.D3.Assets
{
	[CompilerGenerated]
	public partial class Tutorial : MemoryObject
	{
		public const int SizeOf = 0x30; // 48
		
		public SNOHeader x00_Header { get { return Read<SNOHeader>(0x00); } }
		public int x0C { get { return Read<int>(0x0C); } }
		public int x10 { get { return Read<int>(0x10); } }
		public Time x14_Time { get { return Read<Time>(0x14); } }
		public Time x18_Time { get { return Read<Time>(0x18); } }
		public int x1C { get { return Read<int>(0x1C); } }
		public int x20 { get { return Read<int>(0x20); } }
		public Vector2I x24 { get { return Read<Vector2I>(0x24); } }
		public int x2C { get { return Read<int>(0x2C); } }
	}
}
