using System.Runtime.CompilerServices;
using Enigma.D3.Collections;
using Enigma.D3.Memory;

namespace Enigma.D3.Sno
{
	[CompilerGenerated]
	public partial class Observer : SerializeMemoryObject
	{
		// 2.0.6.24641
		public const int SizeOf = 0x58; // 88
		
		public int x0C { get { return Field<int>(0x0C); } }
		public Angle x10_Angle { get { return Field<Angle>(0x10); } }
		public float x14 { get { return Field<float>(0x14); } }
		public float x18 { get { return Field<float>(0x18); } }
		public float x1C { get { return Field<float>(0x1C); } }
		public Angle x20_Angle { get { return Field<Angle>(0x20); } }
		public Angle x24_Angle { get { return Field<Angle>(0x24); } }
		public float x28 { get { return Field<float>(0x28); } }
		public Vector3D x2C_Vector3D { get { return Field<Vector3D>(0x2C); } }
		public Vector3D x38_Vector3D { get { return Field<Vector3D>(0x38); } }
		public float x44 { get { return Field<float>(0x44); } }
		public float x48 { get { return Field<float>(0x48); } }
		public float x4C { get { return Field<float>(0x4C); } }
		public float x50 { get { return Field<float>(0x50); } }
		public float x54 { get { return Field<float>(0x54); } }
		
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
