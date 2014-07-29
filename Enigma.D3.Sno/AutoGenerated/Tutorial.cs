using System.Runtime.CompilerServices;
using Enigma.D3.Collections;
using Enigma.D3.Memory;

namespace Enigma.D3.Sno
{
	[CompilerGenerated]
	public partial class Tutorial : SerializeMemoryObject
	{
		// 2.0.6.24641
		public const int SizeOf = 0x30; // 48
		
		public int x0C { get { return Field<int>(0x0C); } }
		public int x10 { get { return Field<int>(0x10); } }
		public Time x14_Time { get { return Field<Time>(0x14); } }
		public Time x18_Time { get { return Field<Time>(0x18); } }
		public int x1C { get { return Field<int>(0x1C); } }
		public int x20 { get { return Field<int>(0x20); } }
		public IVector2D x24_IVector2D { get { return Field<IVector2D>(0x24); } }
		public int x2C { get { return Field<int>(0x2C); } }
		
		[CompilerGenerated]
		public partial class IVector2D : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x8; // 8
			
			public int x00 { get { return Field<int>(0x00); } }
			public int x04 { get { return Field<int>(0x04); } }
		}
	}
}
