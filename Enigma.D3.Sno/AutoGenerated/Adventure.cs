using System.Runtime.CompilerServices;
using Enigma.D3.Collections;
using Enigma.D3.Memory;
using Enigma.Memory;

namespace Enigma.D3.Sno
{
	[CompilerGenerated]
	public partial class Adventure : MemoryObject
	{
		// 2.1.2.28709
		public const int SizeOf = 0x24; // 36
		
		public SnoHeader x00_Header { get { return Read<SnoHeader>(0x00); } }
		public Sno x0C_ActorSno { get { return Read<Sno>(0x0C); } }
		public float x10 { get { return Read<float>(0x10); } }
		public Angle x14_Angle { get { return Read<Angle>(0x14); } }
		public Angle x18_Angle { get { return Read<Angle>(0x18); } }
		public Angle x1C_Angle { get { return Read<Angle>(0x1C); } }
		public Sno x20_MarkerSetSno { get { return Read<Sno>(0x20); } }
	}
}
