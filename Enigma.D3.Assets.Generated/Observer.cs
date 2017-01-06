using System.Runtime.CompilerServices;
using Enigma.D3.DataTypes;
using Enigma.Memory;

namespace Enigma.D3.Assets
{
	[CompilerGenerated]
	public partial class Observer : MemoryObject
	{
		public const int SizeOf = 0x5C; // 92
		
		public SNOHeader x00_Header { get { return Read<SNOHeader>(0x00); } }
		public int x0C { get { return Read<int>(0x0C); } }
		public float x10 { get { return Read<float>(0x10); } }
		public Angle x14_Angle { get { return Read<Angle>(0x14); } }
		public float x18 { get { return Read<float>(0x18); } }
		public float x1C { get { return Read<float>(0x1C); } }
		public float x20 { get { return Read<float>(0x20); } }
		public Angle x24_Angle { get { return Read<Angle>(0x24); } }
		public Angle x28_Angle { get { return Read<Angle>(0x28); } }
		public float x2C { get { return Read<float>(0x2C); } }
		public Vector3 x30 { get { return Read<Vector3>(0x30); } }
		public Vector3 x3C { get { return Read<Vector3>(0x3C); } }
		public float x48 { get { return Read<float>(0x48); } }
		public float x4C { get { return Read<float>(0x4C); } }
		public float x50 { get { return Read<float>(0x50); } }
		public float x54 { get { return Read<float>(0x54); } }
		public float x58 { get { return Read<float>(0x58); } }
	}
}
