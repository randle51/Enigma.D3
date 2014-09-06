using System.Runtime.CompilerServices;
using Enigma.D3.Collections;
using Enigma.D3.Memory;
using Enigma.Memory;

namespace Enigma.D3.Sno
{
	[CompilerGenerated]
	public partial class ShaderMap : SerializeMemoryObject
	{
		// 2.1.0.26451
		public const int SizeOf = 0x20; // 32
		
		public int x0C { get { return Read<int>(0x0C); } }
		public SerializeData x10_SerializeData { get { return Read<SerializeData>(0x10); } }
		public int[] x18_TagMap { get { return Deserialize<int>(x10_SerializeData); } }
	}
}
