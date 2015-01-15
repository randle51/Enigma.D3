using System.Runtime.CompilerServices;
using Enigma.D3.Collections;
using Enigma.D3.Memory;
using Enigma.Memory;

namespace Enigma.D3.Sno
{
	[CompilerGenerated]
	public partial class Tutorial : MemoryObject
	{
		// 2.1.2.28709
		public const int SizeOf = 0x30; // 48
		
		public SnoHeader x00_Header { get { return Read<SnoHeader>(0x00); } }
		public int x0C { get { return Read<int>(0x0C); } }
		public int x10 { get { return Read<int>(0x10); } }
		public Time x14_Time { get { return Read<Time>(0x14); } }
		public Time x18_Time { get { return Read<Time>(0x18); } }
		public int x1C { get { return Read<int>(0x1C); } }
		public int x20 { get { return Read<int>(0x20); } }
		public IVector2D x24_IVector2D { get { return Read<IVector2D>(0x24); } }
		public int x2C { get { return Read<int>(0x2C); } }
		
		[CompilerGenerated]
		public partial class IVector2D : MemoryObject
		{
			// 2.1.2.28709
			public const int SizeOf = 0x08; // 8
			
			public int x00 { get { return Read<int>(0x00); } }
			public int x04 { get { return Read<int>(0x04); } }
		}
	}
}
