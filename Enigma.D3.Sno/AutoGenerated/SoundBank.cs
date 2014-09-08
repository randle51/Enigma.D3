using System.Runtime.CompilerServices;
using Enigma.D3.Collections;
using Enigma.D3.Memory;
using Enigma.Memory;

namespace Enigma.D3.Sno
{
	[CompilerGenerated]
	public partial class SoundBank : SerializeMemoryObject
	{
		// 2.1.0.26451
		public const int SizeOf = 0x40; // 64
		
		public SnoHeader x00_Header { get { return Read<SnoHeader>(0x00); } }
		public SerializeData x0C_SerializeData { get { return Read<SerializeData>(0x0C); } }
		public SoundSample[] x18_SoundSamples { get { return Deserialize<SoundSample>(x0C_SerializeData); } }
		public int x20 { get { return Read<int>(0x20); } }
		public int x24 { get { return Read<int>(0x24); } }
		public SerializeData x28_SerializeData { get { return Read<SerializeData>(0x28); } }
		public long[] x30_long { get { return Deserialize<long>(x28_SerializeData); } }
		public int x38 { get { return Read<int>(0x38); } }
		public int x3C { get { return Read<int>(0x3C); } }
		
		[CompilerGenerated]
		public partial class SoundSample : MemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0xA0; // 160
			
			public string x00_Text { get { return ReadString(0x00, 128); } }
			public int x80 { get { return Read<int>(0x80); } }
			public int x84 { get { return Read<int>(0x84); } }
			public int x88 { get { return Read<int>(0x88); } }
			public int x8C { get { return Read<int>(0x8C); } }
			public int x90 { get { return Read<int>(0x90); } }
			public int x94 { get { return Read<int>(0x94); } }
			public int x98 { get { return Read<int>(0x98); } }
			public int x9C { get { return Read<int>(0x9C); } }
		}
	}
}
