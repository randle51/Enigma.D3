using System.Runtime.CompilerServices;
using Enigma.D3.Collections;
using Enigma.D3.Memory;

namespace Enigma.D3.Sno
{
	[CompilerGenerated]
	public partial class Adventure : SerializeMemoryObject
	{
		// 2.0.6.24641
		public const int SizeOf = 0x24; // 36
		
		public Sno x0C_ActorSno { get { return Field<Sno>(0x0C); } }
		public float x10 { get { return Field<float>(0x10); } }
		public Angle x14_Angle { get { return Field<Angle>(0x14); } }
		public Angle x18_Angle { get { return Field<Angle>(0x18); } }
		public Angle x1C_Angle { get { return Field<Angle>(0x1C); } }
		public Sno x20_MarkerSetSno { get { return Field<Sno>(0x20); } }
	}
}
