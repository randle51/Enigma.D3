using System.Runtime.CompilerServices;
using Enigma.D3.Collections;
using Enigma.D3.Memory;
using Enigma.Memory;

namespace Enigma.D3.Sno
{
	[CompilerGenerated]
	public partial class Observer : MemoryObject
	{
		// 2.1.2.28709
		public const int SizeOf = 0x58; // 88
		
		public SnoHeader x00_Header { get { return Read<SnoHeader>(0x00); } }
		public int x0C { get { return Read<int>(0x0C); } }
		public Angle x10_Angle { get { return Read<Angle>(0x10); } }
		public float x14 { get { return Read<float>(0x14); } }
		public float x18 { get { return Read<float>(0x18); } }
		public float x1C { get { return Read<float>(0x1C); } }
		public Angle x20_Angle { get { return Read<Angle>(0x20); } }
		public Angle x24_Angle { get { return Read<Angle>(0x24); } }
		public float x28 { get { return Read<float>(0x28); } }
		public Vector3D x2C_Vector3D { get { return Read<Vector3D>(0x2C); } }
		public Vector3D x38_Vector3D { get { return Read<Vector3D>(0x38); } }
		public float x44 { get { return Read<float>(0x44); } }
		public float x48 { get { return Read<float>(0x48); } }
		public float x4C { get { return Read<float>(0x4C); } }
		public float x50 { get { return Read<float>(0x50); } }
		public float x54 { get { return Read<float>(0x54); } }
		
		[CompilerGenerated]
		public partial class Vector3D : MemoryObject
		{
			// 2.1.2.28709
			public const int SizeOf = 0x0C; // 12
			
			public float x00_X { get { return Read<float>(0x00); } }
			public float x04_Y { get { return Read<float>(0x04); } }
			public float x08_Z { get { return Read<float>(0x08); } }
		}
	}
}
