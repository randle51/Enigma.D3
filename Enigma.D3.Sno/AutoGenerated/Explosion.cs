using System.Runtime.CompilerServices;
using Enigma.D3.Collections;
using Enigma.D3.Memory;

namespace Enigma.D3.Sno
{
	[CompilerGenerated]
	public partial class Explosion : SerializeMemoryObject
	{
		// 2.0.6.24641
		public const int SizeOf = 0x40; // 64
		
		public int x0C { get { return Field<int>(0x0C); } }
		public int x10 { get { return Field<int>(0x10); } }
		public Vector3D x14_Vector3D { get { return Field<Vector3D>(0x14); } }
		public Impulse x20_Impulse { get { return Field<Impulse>(0x20); } }
		public float x24 { get { return Field<float>(0x24); } }
		public float x28 { get { return Field<float>(0x28); } }
		public float x2C { get { return Field<float>(0x2C); } }
		public float x30 { get { return Field<float>(0x30); } }
		public int x34 { get { return Field<int>(0x34); } }
		public float x38 { get { return Field<float>(0x38); } }
		public int x3C { get { return Field<int>(0x3C); } }
		
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
