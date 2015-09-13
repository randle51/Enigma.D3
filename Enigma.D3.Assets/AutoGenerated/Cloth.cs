using System.Runtime.CompilerServices;
using Enigma.D3.DataTypes;
using Enigma.Memory;

namespace Enigma.D3.Assets
{
	[CompilerGenerated]
	public partial class Cloth : MemoryObject
	{
		public const int SizeOf = 0x64; // 100
		
		public SnoHeader x00_Header { get { return Read<SnoHeader>(0x00); } }
		public int x0C { get { return Read<int>(0x0C); } }
		public int x10 { get { return Read<int>(0x10); } }
		public float x14 { get { return Read<float>(0x14); } }
		public float x18 { get { return Read<float>(0x18); } }
		public float x1C { get { return Read<float>(0x1C); } }
		public float x20 { get { return Read<float>(0x20); } }
		public float x24 { get { return Read<float>(0x24); } }
		public float x28 { get { return Read<float>(0x28); } }
		public float x2C { get { return Read<float>(0x2C); } }
		public Acceleration x30_Acceleration { get { return Read<Acceleration>(0x30); } }
		public float x34 { get { return Read<float>(0x34); } }
		public float x38 { get { return Read<float>(0x38); } }
		public float x3C { get { return Read<float>(0x3C); } }
		public int[] x40_int { get { return Read<int>(0x40, 4); } }
		public Sno x50_AmbientSoundSno { get { return Read<Sno>(0x50); } }
		public int x54 { get { return Read<int>(0x54); } }
		public Vector3 x58 { get { return Read<Vector3>(0x58); } }
	}
}
