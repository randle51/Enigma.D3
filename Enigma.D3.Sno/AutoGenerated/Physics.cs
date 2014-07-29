using System.Runtime.CompilerServices;
using Enigma.D3.Collections;
using Enigma.D3.Memory;

namespace Enigma.D3.Sno
{
	[CompilerGenerated]
	public partial class Physics : SerializeMemoryObject
	{
		// 2.0.6.24641
		public const int SizeOf = 0x44; // 68
		
		public int x0C { get { return Field<int>(0x0C); } }
		public int x10 { get { return Field<int>(0x10); } }
		public float x14 { get { return Field<float>(0x14); } }
		public float x18 { get { return Field<float>(0x18); } }
		public float x1C { get { return Field<float>(0x1C); } }
		public float x20 { get { return Field<float>(0x20); } }
		public float x24 { get { return Field<float>(0x24); } }
		public short x28 { get { return Field<short>(0x28); } }
		public float x2C { get { return Field<float>(0x2C); } }
		public Acceleration x30_Acceleration { get { return Field<Acceleration>(0x30); } }
		public Acceleration x34_Acceleration { get { return Field<Acceleration>(0x34); } }
		public Velocity x38_Velocity { get { return Field<Velocity>(0x38); } }
		public Acceleration x3C_Acceleration { get { return Field<Acceleration>(0x3C); } }
		public Acceleration x40_Acceleration { get { return Field<Acceleration>(0x40); } }
	}
}
