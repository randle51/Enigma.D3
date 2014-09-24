using System.Runtime.CompilerServices;
using Enigma.D3.Collections;
using Enigma.D3.Memory;
using Enigma.Memory;

namespace Enigma.D3.Sno
{
	[CompilerGenerated]
	public partial class Scene : SerializeMemoryObject
	{
		// 2.1.1.27255
		public const int SizeOf = 0x210; // 528
		
		public SnoHeader x000_Header { get { return Read<SnoHeader>(0x000); } }
		public int x00C { get { return Read<int>(0x00C); } }
		public AABB x010_AABB { get { return Read<AABB>(0x010); } }
		public AABB x028_AABB { get { return Read<AABB>(0x028); } }
		public NavMeshDef x040_NavMeshDef { get { return Read<NavMeshDef>(0x040); } }
		public SerializeData x068_SerializeData { get { return Read<SerializeData>(0x068); } }
		public Sno[] x070_Snos { get { return Deserialize<Sno>(x068_SerializeData); } }
		public SerializeData x0A8_SerializeData { get { return Read<SerializeData>(0x0A8); } }
		public Sno[] x0B0_Snos { get { return Deserialize<Sno>(x0A8_SerializeData); } }
		public SerializeData x0E8_SerializeData { get { return Read<SerializeData>(0x0E8); } }
		public Sno[] x0F0_Snos { get { return Deserialize<Sno>(x0E8_SerializeData); } }
		public LookLink x128_LookLink { get { return Read<LookLink>(0x128); } }
		public SerializeData x168_SerializeData { get { return Read<SerializeData>(0x168); } }
		public int x170 { get { return Read<int>(0x170); } }
		public MsgTriggeredEvent[] x178_MsgTriggeredEvents { get { return Deserialize<MsgTriggeredEvent>(x168_SerializeData); } }
		public NavZoneDefinition x180_NavZoneDefinition { get { return Read<NavZoneDefinition>(0x180); } }
		public Sno x208_AppearanceSno { get { return Read<Sno>(0x208); } }
		public Sno x20C_PhysMeshSno { get { return Read<Sno>(0x20C); } }
		
		[CompilerGenerated]
		public partial class AABB : MemoryObject
		{
			// 2.1.1.27255
			public const int SizeOf = 0x18; // 24
			
			public Vector3D x00_Vector3D { get { return Read<Vector3D>(0x00); } }
			public Vector3D x0C_Vector3D { get { return Read<Vector3D>(0x0C); } }
		}
		
		[CompilerGenerated]
		public partial class NavMeshDef : SerializeMemoryObject
		{
			// 2.1.1.27255
			public const int SizeOf = 0x28; // 40
			
			public int x00 { get { return Read<int>(0x00); } }
			public int x04 { get { return Read<int>(0x04); } }
			public int x08 { get { return Read<int>(0x08); } }
			public int x0C { get { return Read<int>(0x0C); } }
			public float x10 { get { return Read<float>(0x10); } }
			public SerializeData x14_SerializeData { get { return Read<SerializeData>(0x14); } }
			public int x1C { get { return Read<int>(0x1C); } }
			public NavMeshSquare[] x20_NavMeshSquares { get { return Deserialize<NavMeshSquare>(x14_SerializeData); } }
		}
		
		[CompilerGenerated]
		public partial class LookLink : MemoryObject
		{
			// 2.1.1.27255
			public const int SizeOf = 0x40; // 64
			
			public string x00_Text { get { return ReadString(0x00, 64); } }
		}
		
		[CompilerGenerated]
		public partial class MsgTriggeredEvent : MemoryObject
		{
			// 2.1.1.27255
			public const int SizeOf = 0x19C; // 412
			
			public int x000 { get { return Read<int>(0x000); } }
			public TriggerEvent x004_TriggerEvent { get { return Read<TriggerEvent>(0x004); } }
		}
		
		[CompilerGenerated]
		public partial class NavZoneDefinition : SerializeMemoryObject
		{
			// 2.1.1.27255
			public const int SizeOf = 0x88; // 136
			
			public int x00 { get { return Read<int>(0x00); } }
			public NavCell[] x08_NavCells { get { return Deserialize<NavCell>(x10_SerializeData); } }
			public SerializeData x10_SerializeData { get { return Read<SerializeData>(0x10); } }
			public int x18 { get { return Read<int>(0x18); } }
			public NavCellLookup[] x20_NavCellLookups { get { return Deserialize<NavCellLookup>(x28_SerializeData); } }
			public SerializeData x28_SerializeData { get { return Read<SerializeData>(0x28); } }
			public float x30 { get { return Read<float>(0x30); } }
			public float x34 { get { return Read<float>(0x34); } }
			public int x38 { get { return Read<int>(0x38); } }
			public IVector2D x3C_IVector2D { get { return Read<IVector2D>(0x3C); } }
			public NavGridSquare[] x48_NavGridSquares { get { return Deserialize<NavGridSquare>(x50_SerializeData); } }
			public SerializeData x50_SerializeData { get { return Read<SerializeData>(0x50); } }
			public int x58 { get { return Read<int>(0x58); } }
			public NavCellLookup[] x60_NavCellLookups { get { return Deserialize<NavCellLookup>(x68_SerializeData); } }
			public SerializeData x68_SerializeData { get { return Read<SerializeData>(0x68); } }
			public int x70 { get { return Read<int>(0x70); } }
			public NavCellBorderData[] x78_NavCellBorderDatas { get { return Deserialize<NavCellBorderData>(x80_SerializeData); } }
			public SerializeData x80_SerializeData { get { return Read<SerializeData>(0x80); } }
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
		public partial class NavMeshSquare : MemoryObject
		{
			// 2.1.1.27255
			public const int SizeOf = 0x08; // 8
			
			public float x00 { get { return Read<float>(0x00); } }
			public int x04 { get { return Read<int>(0x04); } }
		}
		
		[CompilerGenerated]
		public partial class TriggerEvent : MemoryObject
		{
			// 2.1.1.27255
			public const int SizeOf = 0x198; // 408
			
			public int x000 { get { return Read<int>(0x000); } }
			public TriggerConditions x004_TriggerConditions { get { return Read<TriggerConditions>(0x004); } }
			public int x028 { get { return Read<int>(0x028); } }
			public SNOName x02C_SNOName { get { return Read<SNOName>(0x02C); } }
			public int x034 { get { return Read<int>(0x034); } }
			public int x038 { get { return Read<int>(0x038); } }
			public int x03C { get { return Read<int>(0x03C); } }
			public int x040 { get { return Read<int>(0x040); } }
			public HardpointLink[] x044_HardpointLinks { get { return Read<HardpointLink>(0x044, 2); } }
			public LookLink x0CC_LookLink { get { return Read<LookLink>(0x0CC); } }
			public ConstraintLink x10C_ConstraintLink { get { return Read<ConstraintLink>(0x10C); } }
			public int x14C { get { return Read<int>(0x14C); } }
			public float x150 { get { return Read<float>(0x150); } }
			public int x154 { get { return Read<int>(0x154); } }
			public int x158 { get { return Read<int>(0x158); } }
			public int x15C { get { return Read<int>(0x15C); } }
			public int x160 { get { return Read<int>(0x160); } }
			public int x164 { get { return Read<int>(0x164); } }
			public float x168 { get { return Read<float>(0x168); } }
			public float x16C { get { return Read<float>(0x16C); } }
			public int x170 { get { return Read<int>(0x170); } }
			public float x174 { get { return Read<float>(0x174); } }
			public int x178 { get { return Read<int>(0x178); } }
			public Velocity x17C_Velocity { get { return Read<Velocity>(0x17C); } }
			public int x180 { get { return Read<int>(0x180); } }
			public Time x184_Time { get { return Read<Time>(0x184); } }
			public RGBAColor x188_RGBAColor { get { return Read<RGBAColor>(0x188); } }
			public Time x18C_Time { get { return Read<Time>(0x18C); } }
			public RGBAColor x190_RGBAColor { get { return Read<RGBAColor>(0x190); } }
			public Time x194_Time { get { return Read<Time>(0x194); } }
		}
		
		[CompilerGenerated]
		public partial class NavCell : MemoryObject
		{
			// 2.1.1.27255
			public const int SizeOf = 0x20; // 32
			
			public Vector3D x00_Vector3D { get { return Read<Vector3D>(0x00); } }
			public Vector3D x0C_Vector3D { get { return Read<Vector3D>(0x0C); } }
			public short x18 { get { return Read<short>(0x18); } }
			public short x1A { get { return Read<short>(0x1A); } }
			public int x1C { get { return Read<int>(0x1C); } }
		}
		
		[CompilerGenerated]
		public partial class NavCellLookup : MemoryObject
		{
			// 2.1.1.27255
			public const int SizeOf = 0x04; // 4
			
			public short x00 { get { return Read<short>(0x00); } }
			public short x02 { get { return Read<short>(0x02); } }
		}
		
		[CompilerGenerated]
		public partial class IVector2D : MemoryObject
		{
			// 2.1.1.27255
			public const int SizeOf = 0x08; // 8
			
			public int x00 { get { return Read<int>(0x00); } }
			public int x04 { get { return Read<int>(0x04); } }
		}
		
		[CompilerGenerated]
		public partial class NavGridSquare : MemoryObject
		{
			// 2.1.1.27255
			public const int SizeOf = 0x06; // 6
			
			public short x00 { get { return Read<short>(0x00); } }
			public short x02 { get { return Read<short>(0x02); } }
			public short x04 { get { return Read<short>(0x04); } }
		}
		
		[CompilerGenerated]
		public partial class NavCellBorderData : MemoryObject
		{
			// 2.1.1.27255
			public const int SizeOf = 0x04; // 4
			
			public short x00 { get { return Read<short>(0x00); } }
			public short x02 { get { return Read<short>(0x02); } }
		}
		
		[CompilerGenerated]
		public partial class TriggerConditions : MemoryObject
		{
			// 2.1.1.27255
			public const int SizeOf = 0x24; // 36
			
			public Percent x00_Percent { get { return Read<Percent>(0x00); } }
			public Time x04_Time { get { return Read<Time>(0x04); } }
			public Time x08_Time { get { return Read<Time>(0x08); } }
			public Time x0C_Time { get { return Read<Time>(0x0C); } }
			public Time x10_Time { get { return Read<Time>(0x10); } }
			public Impulse x14_Impulse { get { return Read<Impulse>(0x14); } }
			public Impulse x18_Impulse { get { return Read<Impulse>(0x18); } }
			public int x1C { get { return Read<int>(0x1C); } }
			public int x20 { get { return Read<int>(0x20); } }
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
		public partial class HardpointLink : MemoryObject
		{
			// 2.1.1.27255
			public const int SizeOf = 0x44; // 68
			
			public string x00_Text { get { return ReadString(0x00, 64); } }
			public int x40 { get { return Read<int>(0x40); } }
		}
		
		[CompilerGenerated]
		public partial class ConstraintLink : MemoryObject
		{
			// 2.1.1.27255
			public const int SizeOf = 0x40; // 64
			
			public string x00_Text { get { return ReadString(0x00, 64); } }
		}
		
		[CompilerGenerated]
		public partial class RGBAColor : MemoryObject
		{
			// 2.1.1.27255
			public const int SizeOf = 0x04; // 4
			
			public byte x00 { get { return Read<byte>(0x00); } }
			public byte x01 { get { return Read<byte>(0x01); } }
			public byte x02 { get { return Read<byte>(0x02); } }
			public byte x03 { get { return Read<byte>(0x03); } }
		}
	}
}
