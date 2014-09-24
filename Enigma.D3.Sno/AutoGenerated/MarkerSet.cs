using System.Runtime.CompilerServices;
using Enigma.D3.Collections;
using Enigma.D3.Memory;
using Enigma.Memory;

namespace Enigma.D3.Sno
{
	[CompilerGenerated]
	public partial class MarkerSet : SerializeMemoryObject
	{
		// 2.1.1.27255
		public const int SizeOf = 0xC8; // 200
		
		public SnoHeader x00_Header { get { return Read<SnoHeader>(0x00); } }
		public SerializeData x0C_SerializeData { get { return Read<SerializeData>(0x0C); } }
		public Marker[] x18_Markers { get { return Deserialize<Marker>(x0C_SerializeData); } }
		public SerializeData x50_SerializeData { get { return Read<SerializeData>(0x50); } }
		public Circle[] x58_Circles { get { return Deserialize<Circle>(x50_SerializeData); } }
		public AABB x90_AABB { get { return Read<AABB>(0x90); } }
		public int xA8 { get { return Read<int>(0xA8); } }
		public GameBalanceId xAC_LabelsGameBalanceId { get { return Read<GameBalanceId>(0xAC); } }
		public int xB0 { get { return Read<int>(0xB0); } }
		public SerializeData xB4_SerializeData { get { return Read<SerializeData>(0xB4); } }
		public short[] xC0_short { get { return Deserialize<short>(xB4_SerializeData); } }
		
		[CompilerGenerated]
		public partial class Marker : SerializeMemoryObject
		{
			// 2.1.1.27255
			public const int SizeOf = 0xD0; // 208
			
			public string x00_Text { get { return ReadString(0x00, 128); } }
			public int x80 { get { return Read<int>(0x80); } }
			public PRTransform x84_PRTransform { get { return Read<PRTransform>(0x84); } }
			public SNOName xA0_SNOName { get { return Read<SNOName>(0xA0); } }
			public SerializeData xA8_SerializeData { get { return Read<SerializeData>(0xA8); } }
			public int[] xB0_TagMap { get { return Deserialize<int>(xA8_SerializeData); } }
			public int xB8 { get { return Read<int>(0xB8); } }
			public SerializeData xBC_SerializeData { get { return Read<SerializeData>(0xBC); } }
			public MarkerLink[] xC8_MarkerLinks { get { return Deserialize<MarkerLink>(xBC_SerializeData); } }
		}
		
		[CompilerGenerated]
		public partial class Circle : MemoryObject
		{
			// 2.1.1.27255
			public const int SizeOf = 0x0C; // 12
			
			public Vector2D x00_Vector2D { get { return Read<Vector2D>(0x00); } }
			public float x08 { get { return Read<float>(0x08); } }
		}
		
		[CompilerGenerated]
		public partial class AABB : MemoryObject
		{
			// 2.1.1.27255
			public const int SizeOf = 0x18; // 24
			
			public Vector3D x00_Vector3D { get { return Read<Vector3D>(0x00); } }
			public Vector3D x0C_Vector3D { get { return Read<Vector3D>(0x0C); } }
		}
		
		[CompilerGenerated]
		public partial class PRTransform : MemoryObject
		{
			// 2.1.1.27255
			public const int SizeOf = 0x1C; // 28
			
			public Quaternion x00_Quaternion { get { return Read<Quaternion>(0x00); } }
			public Vector3D x10_Vector3D { get { return Read<Vector3D>(0x10); } }
		}
		
		[CompilerGenerated]
		public partial class SNOName : MemoryObject
		{
			// 2.1.1.27255
			public const int SizeOf = 0x08; // 8
			
			public SnoGroup x00_SnoGroup { get { return Read<SnoGroup>(0x00); } }
			public SnoNameHandle x04_SnoNameHandle { get { return Read<SnoNameHandle>(0x04); } }
		}
		
		[CompilerGenerated]
		public partial class MarkerLink : MemoryObject
		{
			// 2.1.1.27255
			public const int SizeOf = 0x100; // 256
			
			public string x000_Text { get { return ReadString(0x000, 128); } }
			public string x080_Text { get { return ReadString(0x080, 128); } }
		}
		
		[CompilerGenerated]
		public partial class Vector2D : MemoryObject
		{
			// 2.1.1.27255
			public const int SizeOf = 0x08; // 8
			
			public float x00 { get { return Read<float>(0x00); } }
			public float x04 { get { return Read<float>(0x04); } }
		}
		
		[CompilerGenerated]
		public partial class Vector3D : MemoryObject
		{
			// 2.1.1.27255
			public const int SizeOf = 0x0C; // 12
			
			public float x00_X { get { return Read<float>(0x00); } }
			public float x04_Y { get { return Read<float>(0x04); } }
			public float x08_Z { get { return Read<float>(0x08); } }
		}
		
		[CompilerGenerated]
		public partial class Quaternion : MemoryObject
		{
			// 2.1.1.27255
			public const int SizeOf = 0x10; // 16
			
			public Vector3D x00_Vector3D { get { return Read<Vector3D>(0x00); } }
			public float x0C { get { return Read<float>(0x0C); } }
		}
	}
}
