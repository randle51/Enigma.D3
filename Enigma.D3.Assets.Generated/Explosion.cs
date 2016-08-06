using System.Runtime.CompilerServices;
using Enigma.D3.DataTypes;
using Enigma.Memory;

namespace Enigma.D3.Assets
{
	[CompilerGenerated]
	public partial class Explosion : MemoryObject
	{
		public const int SizeOf = 0x40; // 64
		
		public SNOHeader x00_Header { get { return Read<SNOHeader>(0x00); } }
		public int x0C { get { return Read<int>(0x0C); } }
		public int x10 { get { return Read<int>(0x10); } }
		public Vector3 x14 { get { return Read<Vector3>(0x14); } }
		public Impulse x20_Impulse { get { return Read<Impulse>(0x20); } }
		public float x24 { get { return Read<float>(0x24); } }
		public float x28 { get { return Read<float>(0x28); } }
		public float x2C { get { return Read<float>(0x2C); } }
		public float x30 { get { return Read<float>(0x30); } }
		public int x34 { get { return Read<int>(0x34); } }
		public float x38 { get { return Read<float>(0x38); } }
		public int x3C { get { return Read<int>(0x3C); } }
	}
}
