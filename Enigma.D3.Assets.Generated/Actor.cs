using System.Runtime.CompilerServices;
using Enigma.D3.DataTypes;
using Enigma.Memory;

namespace Enigma.D3.Assets
{
	[CompilerGenerated]
	public partial class Actor : SerializeMemoryObject
	{
		public const int SizeOf = 0x370; // 880
		
		public SNOHeader x000_Header { get { return Read<SNOHeader>(0x000); } }
		public int x00C { get { return Read<int>(0x00C); } }
		public int x010_Enum { get { return Read<int>(0x010); } } // Invalid = 0, Monster = 1, Gizmo = 2, Client Effect = 3, Server Prop = 4, Environment = 5, Critter = 6, Player = 7, Item = 8, Axe Symbol = 9, Projectile = 10, Custom Brain = 11
		public SNO x014_AppearanceSNO { get { return Read<SNO>(0x014); } }
		public SNO x018_PhysMeshSNO { get { return Read<SNO>(0x018); } }
		public AxialCylinder x01C_AxialCylinder { get { return Read<AxialCylinder>(0x01C); } }
		public Sphere x030 { get { return Read<Sphere>(0x030); } }
		public AABB x040 { get { return Read<AABB>(0x040); } }
		public SerializeData x058_SerializeData { get { return Read<SerializeData>(0x058); } }
		public TagMap x060_TagMap { get { return new TagMap(Deserialize<byte>(x058_SerializeData)); } } // type: 0x00010000
		public SNO x068_AnimSetSNO { get { return Read<SNO>(0x068); } }
		public SNO x06C_MonsterSNO { get { return Read<SNO>(0x06C); } }
		public SerializeData x070_SerializeData { get { return Read<SerializeData>(0x070); } }
		public int x078 { get { return Read<int>(0x078); } }
		public MsgTriggeredEvent[] x080_MsgTriggeredEvents { get { return Deserialize<MsgTriggeredEvent>(x070_SerializeData); } }
		public Vector3 x088 { get { return Read<Vector3>(0x088); } }
		public WeightedLook[] x094_WeightedLooks { get { return Read<WeightedLook>(0x094, 8); } }
		public SNO x2B4_PhysicsSNO { get { return Read<SNO>(0x2B4); } }
		public int x2B8 { get { return Read<int>(0x2B8); } }
		public int x2BC { get { return Read<int>(0x2BC); } }
		public float x2C0 { get { return Read<float>(0x2C0); } }
		public float x2C4 { get { return Read<float>(0x2C4); } }
		public float x2C8 { get { return Read<float>(0x2C8); } }
		public ActorCollisionData x2CC_ActorCollisionData { get { return Read<ActorCollisionData>(0x2CC); } }
		public InventoryImages[] x310_InventoryImages { get { return Read<InventoryImages>(0x310, 7); } }
		public int x348 { get { return Read<int>(0x348); } }
		public string x350_Text { get { return DeserializeString(x358_SerializeData); } }
		public SerializeData x358_SerializeData { get { return Read<SerializeData>(0x358); } }
		public string x360_Text { get { return DeserializeString(x368_SerializeData); } }
		public SerializeData x368_SerializeData { get { return Read<SerializeData>(0x368); } }
		
		[CompilerGenerated]
		public partial class AxialCylinder : MemoryObject
		{
			public const int SizeOf = 0x14; // 20
			
			public Vector3 x00 { get { return Read<Vector3>(0x00); } }
			public float x0C { get { return Read<float>(0x0C); } }
			public float x10 { get { return Read<float>(0x10); } }
		}
		
		[CompilerGenerated]
		public partial class MsgTriggeredEvent : MemoryObject
		{
			public const int SizeOf = 0x19C; // 412
			
			public int x000 { get { return Read<int>(0x000); } }
			public TriggerEvent x004_TriggerEvent { get { return Read<TriggerEvent>(0x004); } }
		}
		
		[CompilerGenerated]
		public partial class WeightedLook : MemoryObject
		{
			public const int SizeOf = 0x44; // 68
			
			public LookLink x00_LookLink { get { return Read<LookLink>(0x00); } }
			public int x40 { get { return Read<int>(0x40); } }
		}
		
		[CompilerGenerated]
		public partial class ActorCollisionData : MemoryObject
		{
			public const int SizeOf = 0x44; // 68
			
			public ActorCollisionFlags x00_ActorCollisionFlags { get { return Read<ActorCollisionFlags>(0x00); } }
			public int x10 { get { return Read<int>(0x10); } }
			public AxialCylinder x14_AxialCylinder { get { return Read<AxialCylinder>(0x14); } }
			public AABB x28 { get { return Read<AABB>(0x28); } }
			public float x40 { get { return Read<float>(0x40); } }
		}
		
		[CompilerGenerated]
		public partial class InventoryImages : MemoryObject
		{
			public const int SizeOf = 0x08; // 8
			
			public int x00 { get { return Read<int>(0x00); } }
			public int x04 { get { return Read<int>(0x04); } }
		}
		
		[CompilerGenerated]
		public partial class TriggerEvent : MemoryObject
		{
			public const int SizeOf = 0x198; // 408
			
			public int x000 { get { return Read<int>(0x000); } }
			public TriggerConditions x004_TriggerConditions { get { return Read<TriggerConditions>(0x004); } }
			public int x028 { get { return Read<int>(0x028); } }
			public SNOName x02C { get { return Read<SNOName>(0x02C); } }
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
			public DT_RGBACOLOR x188_DT_RGBACOLOR { get { return Read<DT_RGBACOLOR>(0x188); } }
			public Time x18C_Time { get { return Read<Time>(0x18C); } }
			public DT_RGBACOLOR x190_DT_RGBACOLOR { get { return Read<DT_RGBACOLOR>(0x190); } }
			public Time x194_Time { get { return Read<Time>(0x194); } }
		}
		
		[CompilerGenerated]
		public partial class LookLink : MemoryObject
		{
			public const int SizeOf = 0x40; // 64
			
			public string x00_Text { get { return ReadString(0x00, 64); } }
		}
		
		[CompilerGenerated]
		public partial class ActorCollisionFlags : MemoryObject
		{
			public const int SizeOf = 0x10; // 16
			
			public int x00 { get { return Read<int>(0x00); } }
			public int x04 { get { return Read<int>(0x04); } }
			public int x08 { get { return Read<int>(0x08); } }
			public int x0C { get { return Read<int>(0x0C); } }
		}
		
		[CompilerGenerated]
		public partial class TriggerConditions : MemoryObject
		{
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
		public partial class HardpointLink : MemoryObject
		{
			public const int SizeOf = 0x44; // 68
			
			public string x00_Text { get { return ReadString(0x00, 64); } }
			public int x40 { get { return Read<int>(0x40); } }
		}
		
		[CompilerGenerated]
		public partial class ConstraintLink : MemoryObject
		{
			public const int SizeOf = 0x40; // 64
			
			public string x00_Text { get { return ReadString(0x00, 64); } }
		}
		
		[CompilerGenerated]
		public partial class DT_RGBACOLOR : MemoryObject
		{
			public const int SizeOf = 0x03; // 3
			
			public byte x00 { get { return Read<byte>(0x00); } }
			public byte x01 { get { return Read<byte>(0x01); } }
			public byte x02 { get { return Read<byte>(0x02); } }
			public byte x03 { get { return Read<byte>(0x03); } }
		}
	}
}
