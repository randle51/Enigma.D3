using System.Runtime.CompilerServices;
using Enigma.D3.Collections;
using Enigma.D3.Memory;

namespace Enigma.D3.Sno
{
	[CompilerGenerated]
	public partial class Actor : SerializeMemoryObject
	{
		// 2.0.6.24641
		public const int SizeOf = 0x368; // 872
		
		public int x00C { get { return Field<int>(0x00C); } }
		public int x010_Enum { get { return Field<int>(0x010); } } // Invalid = 0, Monster = 1, Gizmo = 2, Client Effect = 3, Server Prop = 4, Environment = 5, Critter = 6, Player = 7, Item = 8, Axe Symbol = 9, Projectile = 10, Custom Brain = 11
		public Sno x014_AppearanceSno { get { return Field<Sno>(0x014); } }
		public Sno x018_PhysMeshSno { get { return Field<Sno>(0x018); } }
		public AxialCylinder x01C_AxialCylinder { get { return Field<AxialCylinder>(0x01C); } }
		public Sphere x030_Sphere { get { return Field<Sphere>(0x030); } }
		public AABB x040_AABB { get { return Field<AABB>(0x040); } }
		public SerializeData x058_SerializeData { get { return Field<SerializeData>(0x058); } }
		public int[] x060_TagMap { get { return Deserialize<int>(x058_SerializeData); } }
		public Sno x068_AnimSetSno { get { return Field<Sno>(0x068); } }
		public Sno x06C_MonsterSno { get { return Field<Sno>(0x06C); } }
		public SerializeData x070_SerializeData { get { return Field<SerializeData>(0x070); } }
		public int x078 { get { return Field<int>(0x078); } }
		public MsgTriggeredEvent[] x080_MsgTriggeredEvents { get { return Deserialize<MsgTriggeredEvent>(x070_SerializeData); } }
		public Vector3D x088_Vector3D { get { return Field<Vector3D>(0x088); } }
		public WeightedLook[] x094_WeightedLooks { get { return Field<WeightedLook>(0x094, 8); } }
		public Sno x2B4_PhysicsSno { get { return Field<Sno>(0x2B4); } }
		public int x2B8 { get { return Field<int>(0x2B8); } }
		public int x2BC { get { return Field<int>(0x2BC); } }
		public float x2C0 { get { return Field<float>(0x2C0); } }
		public float x2C4 { get { return Field<float>(0x2C4); } }
		public float x2C8 { get { return Field<float>(0x2C8); } }
		public ActorCollisionData x2CC_ActorCollisionData { get { return Field<ActorCollisionData>(0x2CC); } }
		public InventoryImages[] x310_InventoryImages { get { return Field<InventoryImages>(0x310, 6); } }
		public int x340 { get { return Field<int>(0x340); } }
		public string x348_Text { get { return Deserialize(x350_SerializeData); } }
		public SerializeData x350_SerializeData { get { return Field<SerializeData>(0x350); } }
		public string x358_Text { get { return Deserialize(x360_SerializeData); } }
		public SerializeData x360_SerializeData { get { return Field<SerializeData>(0x360); } }
		
		[CompilerGenerated]
		public partial class AxialCylinder : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x14; // 20
			
			public Vector3D x00_Vector3D { get { return Field<Vector3D>(0x00); } }
			public float x0C { get { return Field<float>(0x0C); } }
			public float x10 { get { return Field<float>(0x10); } }
		}
		
		[CompilerGenerated]
		public partial class Sphere : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x10; // 16
			
			public Vector3D x00_Vector3D { get { return Field<Vector3D>(0x00); } }
			public float x0C { get { return Field<float>(0x0C); } }
		}
		
		[CompilerGenerated]
		public partial class AABB : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x18; // 24
			
			public Vector3D x00_Vector3D { get { return Field<Vector3D>(0x00); } }
			public Vector3D x0C_Vector3D { get { return Field<Vector3D>(0x0C); } }
		}
		
		[CompilerGenerated]
		public partial class MsgTriggeredEvent : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x19C; // 412
			
			public int x000 { get { return Field<int>(0x000); } }
			public TriggerEvent x004_TriggerEvent { get { return Field<TriggerEvent>(0x004); } }
		}
		
		[CompilerGenerated]
		public partial class Vector3D : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0xC; // 12
			
			public float x00 { get { return Field<float>(0x00); } }
			public float x04 { get { return Field<float>(0x04); } }
			public float x08 { get { return Field<float>(0x08); } }
		}
		
		[CompilerGenerated]
		public partial class WeightedLook : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x44; // 68
			
			public LookLink x00_LookLink { get { return Field<LookLink>(0x00); } }
			public int x40 { get { return Field<int>(0x40); } }
		}
		
		[CompilerGenerated]
		public partial class ActorCollisionData : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x44; // 68
			
			public ActorCollisionFlags x00_ActorCollisionFlags { get { return Field<ActorCollisionFlags>(0x00); } }
			public int x10 { get { return Field<int>(0x10); } }
			public AxialCylinder x14_AxialCylinder { get { return Field<AxialCylinder>(0x14); } }
			public AABB x28_AABB { get { return Field<AABB>(0x28); } }
			public float x40 { get { return Field<float>(0x40); } }
		}
		
		[CompilerGenerated]
		public partial class InventoryImages : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x8; // 8
			
			public int x00 { get { return Field<int>(0x00); } }
			public int x04 { get { return Field<int>(0x04); } }
		}
		
		[CompilerGenerated]
		public partial class TriggerEvent : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x198; // 408
			
			public int x000 { get { return Field<int>(0x000); } }
			public TriggerConditions x004_TriggerConditions { get { return Field<TriggerConditions>(0x004); } }
			public int x028 { get { return Field<int>(0x028); } }
			public SNOName x02C_SNOName { get { return Field<SNOName>(0x02C); } }
			public int x034 { get { return Field<int>(0x034); } }
			public int x038 { get { return Field<int>(0x038); } }
			public int x03C { get { return Field<int>(0x03C); } }
			public int x040 { get { return Field<int>(0x040); } }
			public HardpointLink[] x044_HardpointLinks { get { return Field<HardpointLink>(0x044, 2); } }
			public LookLink x0CC_LookLink { get { return Field<LookLink>(0x0CC); } }
			public ConstraintLink x10C_ConstraintLink { get { return Field<ConstraintLink>(0x10C); } }
			public int x14C { get { return Field<int>(0x14C); } }
			public float x150 { get { return Field<float>(0x150); } }
			public int x154 { get { return Field<int>(0x154); } }
			public int x158 { get { return Field<int>(0x158); } }
			public int x15C { get { return Field<int>(0x15C); } }
			public int x160 { get { return Field<int>(0x160); } }
			public int x164 { get { return Field<int>(0x164); } }
			public float x168 { get { return Field<float>(0x168); } }
			public float x16C { get { return Field<float>(0x16C); } }
			public int x170 { get { return Field<int>(0x170); } }
			public float x174 { get { return Field<float>(0x174); } }
			public int x178 { get { return Field<int>(0x178); } }
			public Velocity x17C_Velocity { get { return Field<Velocity>(0x17C); } }
			public int x180 { get { return Field<int>(0x180); } }
			public Time x184_Time { get { return Field<Time>(0x184); } }
			public RGBAColor x188_RGBAColor { get { return Field<RGBAColor>(0x188); } }
			public Time x18C_Time { get { return Field<Time>(0x18C); } }
			public RGBAColor x190_RGBAColor { get { return Field<RGBAColor>(0x190); } }
			public Time x194_Time { get { return Field<Time>(0x194); } }
		}
		
		[CompilerGenerated]
		public partial class LookLink : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x40; // 64
			
			public string x00_Text { get { return Field(0x00, 64); } }
		}
		
		[CompilerGenerated]
		public partial class ActorCollisionFlags : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x10; // 16
			
			public int x00 { get { return Field<int>(0x00); } }
			public int x04 { get { return Field<int>(0x04); } }
			public int x08 { get { return Field<int>(0x08); } }
			public int x0C { get { return Field<int>(0x0C); } }
		}
		
		[CompilerGenerated]
		public partial class TriggerConditions : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x24; // 36
			
			public Percent x00_Percent { get { return Field<Percent>(0x00); } }
			public Time x04_Time { get { return Field<Time>(0x04); } }
			public Time x08_Time { get { return Field<Time>(0x08); } }
			public Time x0C_Time { get { return Field<Time>(0x0C); } }
			public Time x10_Time { get { return Field<Time>(0x10); } }
			public Impulse x14_Impulse { get { return Field<Impulse>(0x14); } }
			public Impulse x18_Impulse { get { return Field<Impulse>(0x18); } }
			public int x1C { get { return Field<int>(0x1C); } }
			public int x20 { get { return Field<int>(0x20); } }
		}
		
		[CompilerGenerated]
		public partial class SNOName : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x8; // 8
			
			public SnoGroup x00_SnoGroup { get { return Field<SnoGroup>(0x00); } }
			public SnoNameHandle x04_SnoNameHandle { get { return Field<SnoNameHandle>(0x04); } }
		}
		
		[CompilerGenerated]
		public partial class HardpointLink : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x44; // 68
			
			public string x00_Text { get { return Field(0x00, 64); } }
			public int x40 { get { return Field<int>(0x40); } }
		}
		
		[CompilerGenerated]
		public partial class ConstraintLink : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x40; // 64
			
			public string x00_Text { get { return Field(0x00, 64); } }
		}
		
		[CompilerGenerated]
		public partial class RGBAColor : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x4; // 4
			
			public byte x00 { get { return Field<byte>(0x00); } }
			public byte x01 { get { return Field<byte>(0x01); } }
			public byte x02 { get { return Field<byte>(0x02); } }
			public byte x03 { get { return Field<byte>(0x03); } }
		}
	}
}
