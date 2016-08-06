using System.Runtime.CompilerServices;
using Enigma.D3.DataTypes;
using Enigma.Memory;

namespace Enigma.D3.Assets
{
	[CompilerGenerated]
	public partial class Adventure : MemoryObject
	{
		public const int SizeOf = 0x24; // 36
		
		public SNOHeader x00_Header { get { return Read<SNOHeader>(0x00); } }
		public SNO x0C_ActorSNO { get { return Read<SNO>(0x0C); } }
		public float x10 { get { return Read<float>(0x10); } }
		public Angle x14_Angle { get { return Read<Angle>(0x14); } }
		public Angle x18_Angle { get { return Read<Angle>(0x18); } }
		public Angle x1C_Angle { get { return Read<Angle>(0x1C); } }
		public SNO x20_MarkerSetSNO { get { return Read<SNO>(0x20); } }
	}
}
