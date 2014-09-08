using System.Runtime.CompilerServices;
using Enigma.D3.Collections;
using Enigma.D3.Memory;
using Enigma.Memory;

namespace Enigma.D3.Sno
{
	[CompilerGenerated]
	public partial class Reverb : MemoryObject
	{
		// 2.1.0.26451
		public const int SizeOf = 0x68; // 104
		
		public SnoHeader x00_Header { get { return Read<SnoHeader>(0x00); } }
		public ReverbParams x0C_ReverbParams { get { return Read<ReverbParams>(0x0C); } }
		public int x64 { get { return Read<int>(0x64); } }
		
		[CompilerGenerated]
		public partial class ReverbParams : MemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x58; // 88
			
			public int x00 { get { return Read<int>(0x00); } }
			public float x04 { get { return Read<float>(0x04); } }
			public float x08 { get { return Read<float>(0x08); } }
			public int x0C { get { return Read<int>(0x0C); } }
			public int x10 { get { return Read<int>(0x10); } }
			public int x14 { get { return Read<int>(0x14); } }
			public float x18 { get { return Read<float>(0x18); } }
			public float x1C { get { return Read<float>(0x1C); } }
			public float x20 { get { return Read<float>(0x20); } }
			public int x24 { get { return Read<int>(0x24); } }
			public float x28 { get { return Read<float>(0x28); } }
			public int x2C { get { return Read<int>(0x2C); } }
			public float x30 { get { return Read<float>(0x30); } }
			public float x34 { get { return Read<float>(0x34); } }
			public float x38 { get { return Read<float>(0x38); } }
			public float x3C { get { return Read<float>(0x3C); } }
			public float x40 { get { return Read<float>(0x40); } }
			public float x44 { get { return Read<float>(0x44); } }
			public float x48 { get { return Read<float>(0x48); } }
			public float x4C { get { return Read<float>(0x4C); } }
			public float x50 { get { return Read<float>(0x50); } }
			public int x54 { get { return Read<int>(0x54); } }
		}
	}
}
