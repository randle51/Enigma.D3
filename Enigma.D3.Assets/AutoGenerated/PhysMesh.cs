using System.Runtime.CompilerServices;
using Enigma.D3.DataTypes;
using Enigma.Memory;

namespace Enigma.D3.Assets
{
	[CompilerGenerated]
	public partial class PhysMesh : SerializeMemoryObject
	{
		public const int SizeOf = 0x30; // 48
		
		public SnoHeader x00_Header { get { return Read<SnoHeader>(0x00); } }
		public int x0C { get { return Read<int>(0x0C); } }
		public int x10 { get { return Read<int>(0x10); } }
		public SerializeData x14_SerializeData { get { return Read<SerializeData>(0x14); } }
		public CollisionMesh[] x20_CollisionMeshs { get { return Deserialize<CollisionMesh>(x14_SerializeData); } }
		public int x28 { get { return Read<int>(0x28); } }
		
		[CompilerGenerated]
		public partial class CollisionMesh : SerializeMemoryObject
		{
			public const int SizeOf = 0x70; // 112
			
			public dmMeshNode[] x00_dmMeshNodes { get { return Deserialize<dmMeshNode>(x60_SerializeData); } }
			public dmFloat4[] x08_dmFloat4s { get { return Deserialize<dmFloat4>(x50_SerializeData); } }
			public dmMeshTriangle[] x10_dmMeshTriangles { get { return Deserialize<dmMeshTriangle>(x58_SerializeData); } }
			public Vector3 x18 { get { return Read<Vector3>(0x18); } }
			public Vector3 x24 { get { return Read<Vector3>(0x24); } }
			public Vector3 x30 { get { return Read<Vector3>(0x30); } }
			public int x3C { get { return Read<int>(0x3C); } }
			public int x40 { get { return Read<int>(0x40); } }
			public int x44 { get { return Read<int>(0x44); } }
			public int x48 { get { return Read<int>(0x48); } }
			public SerializeData x50_SerializeData { get { return Read<SerializeData>(0x50); } }
			public SerializeData x58_SerializeData { get { return Read<SerializeData>(0x58); } }
			public SerializeData x60_SerializeData { get { return Read<SerializeData>(0x60); } }
			public int x68 { get { return Read<int>(0x68); } }
			public int x6C { get { return Read<int>(0x6C); } }
		}
		
		[CompilerGenerated]
		public partial class dmMeshNode : MemoryObject
		{
			public const int SizeOf = 0x10; // 16
			
			public short x00 { get { return Read<short>(0x00); } }
			public short x02 { get { return Read<short>(0x02); } }
			public short x04 { get { return Read<short>(0x04); } }
			public short x06 { get { return Read<short>(0x06); } }
			public short x08 { get { return Read<short>(0x08); } }
			public short x0A { get { return Read<short>(0x0A); } }
			public int x0C { get { return Read<int>(0x0C); } }
		}
		
		[CompilerGenerated]
		public partial class dmFloat4 : MemoryObject
		{
			public const int SizeOf = 0x10; // 16
			
			public float x00 { get { return Read<float>(0x00); } }
			public float x04 { get { return Read<float>(0x04); } }
			public float x08 { get { return Read<float>(0x08); } }
			public float x0C { get { return Read<float>(0x0C); } }
		}
		
		[CompilerGenerated]
		public partial class dmMeshTriangle : MemoryObject
		{
			public const int SizeOf = 0x1C; // 28
			
			public int x00 { get { return Read<int>(0x00); } }
			public int x04 { get { return Read<int>(0x04); } }
			public int x08 { get { return Read<int>(0x08); } }
			public int x0C { get { return Read<int>(0x0C); } }
			public int x10 { get { return Read<int>(0x10); } }
			public int x14 { get { return Read<int>(0x14); } }
			public short x18 { get { return Read<short>(0x18); } }
			public short x1A { get { return Read<short>(0x1A); } }
		}
	}
}
