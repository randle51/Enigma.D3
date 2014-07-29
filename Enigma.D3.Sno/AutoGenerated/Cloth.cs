using System.Runtime.CompilerServices;
using Enigma.D3.Collections;
using Enigma.D3.Memory;

namespace Enigma.D3.Sno
{
	[CompilerGenerated]
	public partial class Cloth : SerializeMemoryObject
	{
		// 2.0.6.24641
		public const int SizeOf = 0x64; // 100
		
		public int x0C { get { return Field<int>(0x0C); } }
		public int x10 { get { return Field<int>(0x10); } }
		public float x14 { get { return Field<float>(0x14); } }
		public float x18 { get { return Field<float>(0x18); } }
		public float x1C { get { return Field<float>(0x1C); } }
		public float x20 { get { return Field<float>(0x20); } }
		public float x24 { get { return Field<float>(0x24); } }
		public float x28 { get { return Field<float>(0x28); } }
		public float x2C { get { return Field<float>(0x2C); } }
		public Acceleration x30_Acceleration { get { return Field<Acceleration>(0x30); } }
		public float x34 { get { return Field<float>(0x34); } }
		public float x38 { get { return Field<float>(0x38); } }
		public float x3C { get { return Field<float>(0x3C); } }
		public int[] x40_int { get { return Field<int>(0x40, 4); } }
		public Sno x50_AmbientSoundSno { get { return Field<Sno>(0x50); } }
		public int x54 { get { return Field<int>(0x54); } }
		public Vector3D x58_Vector3D { get { return Field<Vector3D>(0x58); } }
		
		[CompilerGenerated]
		public partial class Vector3D : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0xC; // 12
			
			public float x00 { get { return Field<float>(0x00); } }
			public float x04 { get { return Field<float>(0x04); } }
			public float x08 { get { return Field<float>(0x08); } }
		}
	}
}
