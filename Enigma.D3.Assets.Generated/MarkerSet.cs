using System.Runtime.CompilerServices;
using Enigma.D3.DataTypes;
using Enigma.Memory;

namespace Enigma.D3.Assets
{
	[CompilerGenerated]
	public partial class MarkerSet : SerializeMemoryObject
	{
		public const int SizeOf = 0xC8; // 200
		
		public SNOHeader x00_Header { get { return Read<SNOHeader>(0x00); } }
		public SerializeData x0C_SerializeData { get { return Read<SerializeData>(0x0C); } }
		public Marker[] x18_Markers { get { return Deserialize<Marker>(x0C_SerializeData); } }
		public SerializeData x50_SerializeData { get { return Read<SerializeData>(0x50); } }
		public Circle[] x58_Circles { get { return Deserialize<Circle>(x50_SerializeData); } }
		public AABB x90 { get { return Read<AABB>(0x90); } }
		public int xA8 { get { return Read<int>(0xA8); } }
		public GBID xAC_LabelsGBID { get { return Read<GBID>(0xAC); } }
		public int xB0 { get { return Read<int>(0xB0); } }
		public SerializeData xB4_SerializeData { get { return Read<SerializeData>(0xB4); } }
		public short[] xC0_short { get { return Deserialize<short>(xB4_SerializeData); } }
		
		[CompilerGenerated]
		public partial class Marker : SerializeMemoryObject
		{
			public const int SizeOf = 0xD0; // 208
			
			public string x00_Text { get { return ReadString(0x00, 128); } }
			public int x80 { get { return Read<int>(0x80); } }
			public PRTransform x84_PRTransform { get { return Read<PRTransform>(0x84); } }
			public SNOName xA0 { get { return Read<SNOName>(0xA0); } }
			public SerializeData xA8_SerializeData { get { return Read<SerializeData>(0xA8); } }
			public TagMap xB0_TagMap { get { return new TagMap(Deserialize<byte>(xA8_SerializeData)); } } // type: 0x00080000
			public int xB8 { get { return Read<int>(0xB8); } }
			public SerializeData xBC_SerializeData { get { return Read<SerializeData>(0xBC); } }
			public MarkerLink[] xC8_MarkerLinks { get { return Deserialize<MarkerLink>(xBC_SerializeData); } }
		}
		
		[CompilerGenerated]
		public partial class Circle : MemoryObject
		{
			public const int SizeOf = 0x0C; // 12
			
			public Vector2 x00 { get { return Read<Vector2>(0x00); } }
			public float x08 { get { return Read<float>(0x08); } }
		}
		
		[CompilerGenerated]
		public partial class PRTransform : MemoryObject
		{
			public const int SizeOf = 0x1C; // 28
			
			public Quaternion x00 { get { return Read<Quaternion>(0x00); } }
			public Vector3 x10 { get { return Read<Vector3>(0x10); } }
		}
		
		[CompilerGenerated]
		public partial class MarkerLink : MemoryObject
		{
			public const int SizeOf = 0x100; // 256
			
			public string x000_Text { get { return ReadString(0x000, 128); } }
			public string x080_Text { get { return ReadString(0x080, 128); } }
		}
	}
}
