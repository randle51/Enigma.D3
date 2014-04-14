using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.Legacy
{
	public class Acd : MemoryObject
	{
		public const int SizeOf = 0x2D0; // 1.0.8.16603 : [0x00EE1D00] ACD::Create

		public Acd(ProcessMemory memory, int address)
			: base(memory, address) { }

		public int x000_Id { get { return Field<int>(0x000); } }
		public string x004_Name { get { return Field(0x004, 128); } }
		public int _x084 { get { return Field<int>(0x084); } }
		public int x088_AnnId { get { return Field<int>(0x088); } }
		public int x08C_ActorId { get { return Field<int>(0x08C); } }
		public int x090_ActorSnoId { get { return Field<int>(0x090); } } // <-- this is set on a ACDInventoryUpdateActorSNO message
		public int _x094 { get { return Field<int>(0x094); } }
		public int _x098 { get { return Field<int>(0x098); } }
		public int _x09C { get { return Field<int>(0x09C); } }
		public int _x0A0 { get { return Field<int>(0x0A0); } }
		public int _x0A4 { get { return Field<int>(0x0A4); } }
		public int _x0A8 { get { return Field<int>(0x0A8); } }
		public int _x0AC { get { return Field<int>(0x0AC); } }
		public ActorType x0B0_ActorType { get { return (ActorType)Field<int>(0x0B0); } }
		public int x0B4_GameBalanceId { get { return Field<int>(0x0B4); } }
		public ActorRarity x0B8_ActorRarity { get { return (ActorRarity)Field<int>(0x0B8); } }
		// Structure starts here (see sub_ED9140), at least 100 (0x64) bytes
		public int _x0BC_RelatedToWorldId { get { return Field<int>(0x0BC); } }
		// Structure starts here (see sub_B38160), at least 96 (0x60) bytes
		public float x0C0_Struct_ { get { return Field<int>(0x0C0); } }
		public float _x0C4 { get { return Field<int>(0x0C4); } }
		public float _x0C8 { get { return Field<int>(0x0C8); } }
		public float _x0CC { get { return Field<int>(0x0CC); } }
		public Point3D _x0D0_Position { get { return Field<Point3D>(0x0D0); } }
		public float x0DC_Scale { get { return Field<int>(0x0DC); } }
		//		another structure starts here (see sub_FD2A00)
		public int x0E0_SphereNodeX { get { return Field<int>(0x0E0); } }
		public int x0E4_SphereNodeY { get { return Field<int>(0x0E4); } }
		public int x0E8_SphereNodeZ { get { return Field<int>(0x0E8); } }
		public int x0EC_SphereNodeRadius { get { return Field<int>(0x0EC); } }
		//		could be end
		//		another structure starts here (see 
		public int x0F0 { get { return Field<int>(0x0F0); } }
		public int x0F4 { get { return Field<int>(0x0F4); } }
		public int x0F8 { get { return Field<int>(0x0F8); } }
		public int x0FC { get { return Field<int>(0x0FC); } }
		public int x100 { get { return Field<int>(0x100); } }
		//		could be end
		public int _x104 { get { return Field<int>(0x104); } }
		public int x108_WorldId { get { return Field<int>(0x108); } }
		public int x10C_SceneId { get { return Field<int>(0x10C); } }
		// Could be end
		// Structure starts here? (see sub_ED9080), at least 16 bytes (see uses of sub_ED9070)
		public int _x110 { get { return Field<int>(0x110); } } // ID_ACD?
		public ItemLocation x114_ItemLocation { get { return (ItemLocation)Field<int>(0x114); } }
		public int x118_ItemLocationX { get { return Field<int>(0x118); } }
		public int x11C_ItemLocationY { get { return Field<int>(0x11C); } }
		// End of x0BC struct??
		public int x120_AttributeId { get { return Field<int>(0x120); } }
		public int x124_Id_ { get { return Field<int>(0x124); } }
		public int x128_Id_ { get { return Field<int>(0x128); } }
		// Structure starts here (see sub_F146E0), at least 164 (0xA4) bytes
		public int x12C { get { return Field<int>(0x12C); } }
		public int x130_Struct_ { get { return Field<int>(0x130); } }
		public int _x134 { get { return Field<int>(0x134); } }
		public int x138 { get { return Field<int>(0x138); } }
		public int x13C { get { return Field<int>(0x13C); } }
		public int x140 { get { return Field<int>(0x140); } }
		public int x144 { get { return Field<int>(0x144); } }
		public List<MemoryObject> x148_AffixList { get { return Field<List<MemoryObject>>(0x148); } }
		public int _x158 { get { return Field<int>(0x158); } }
		public List<MemoryObject> x15C_AffixList { get { return Field<List<MemoryObject>>(0x15C); } }
		public int x16C { get { return Field<int>(0x16C); } }
		public long x170_RelatedTo_RareItemName { get { return Field<long>(0x170); } }
		public long x178_RelatedTo_RareItemName { get { return Field<long>(0x178); } }
		public int x180_RelatedTo_RareMonsterNames { get { return Field<int>(0x180); } }
		public int x184_RelatedTo_RareMonsterNames { get { return Field<int>(0x184); } }
		public int x188_RelatedTo_RareMonsterNames { get { return Field<int>(0x188); } }
		public int x18C_RelatedTo_RareMonsterNames { get { return Field<int>(0x18C); } }
		public int x190_RelatedTo_RareMonsterNames { get { return Field<int>(0x190); } }
		public int x194_RelatedTo_RareMonsterNames { get { return Field<int>(0x194); } }
		public int x198_RelatedTo_RareMonsterNames { get { return Field<int>(0x198); } }
		public int x19C_RelatedTo_RareMonsterNames { get { return Field<int>(0x19C); } }
		public int x1A0_RelatedTo_RareMonsterNames { get { return Field<int>(0x1A0); } }
		public int x1A4_RelatedTo_RareMonsterNames { get { return Field<int>(0x1A4); } }
		public int _x1A8 { get { return Field<int>(0x1A8); } }
		public int _x1AC { get { return Field<int>(0x1AC); } }
		public int x1B0_Struct_ { get { return Field<int>(0x1B0); } }
		public int x1B4 { get { return Field<int>(0x1B4); } }
		public int x1B8 { get { return Field<int>(0x1B8); } }
		public int x1BC { get { return Field<int>(0x1BC); } }
		public int x1C0 { get { return Field<int>(0x1C0); } }
		public int x1C4_List_ { get { return Field<int>(0x1C4); } }
		public int x1C8 { get { return Field<int>(0x1C8); } }
		public int x1CC { get { return Field<int>(0x1CC); } }
		public int x1D0 { get { return Field<int>(0x1D0); } }
		public int x1D4 { get { return Field<int>(0x1D4); } }
		public int x1D8_List_ { get { return Field<int>(0x1D8); } }
		public int x1DC { get { return Field<int>(0x1DC); } }
		public int x1E0 { get { return Field<int>(0x1E0); } }
		public int x1E4 { get { return Field<int>(0x1E4); } }
		public int x1E8 { get { return Field<int>(0x1E8); } }
		public int x1EC_Ptr { get { return Field<int>(0x1EC); } }
		public Portal x1F0_Portal { get { return Dereference<Portal>(0x1F0); } }
		public int _x1F4 { get { return Field<int>(0x1F4); } }
		public int _x1F8 { get { return Field<int>(0x1F8); } }
		public int _x1FC { get { return Field<int>(0x1FC); } }
		public int _x200 { get { return Field<int>(0x200); } }
		public int _x204 { get { return Field<int>(0x204); } }
		public int _x208_RelatedTo_QuestOrGroup_ { get { return Field<int>(0x208); } }
		public int _x20C { get { return Field<int>(0x20C); } }
		public int _x210_RelatedTo_QuestOrGroup_ { get { return Field<int>(0x210); } }
		public int _x214 { get { return Field<int>(0x214); } }
		public int _x218 { get { return Field<int>(0x218); } }
		public int _x21C { get { return Field<int>(0x21C); } }
		public int _x220 { get { return Field<int>(0x220); } }
		public int _x224 { get { return Field<int>(0x224); } }
		public int _x228 { get { return Field<int>(0x228); } }
		public int _x22C { get { return Field<int>(0x22C); } }
		public int _x230 { get { return Field<int>(0x230); } }
		public int _x234 { get { return Field<int>(0x234); } }
		public int _x238 { get { return Field<int>(0x238); } }
		public int _x23C { get { return Field<int>(0x23C); } }
		public int _x240 { get { return Field<int>(0x240); } }
		public int _x244 { get { return Field<int>(0x244); } }
		public int _x248 { get { return Field<int>(0x248); } }
		public int _x24C { get { return Field<int>(0x24C); } }
		public int x250 { get { return Field<int>(0x250); } }
		public int x254 { get { return Field<int>(0x254); } }
		public int _x258 { get { return Field<int>(0x258); } }
		public int _x25C { get { return Field<int>(0x25C); } }
		public int x260_Struct_ { get { return Field<int>(0x260); } }
		public int _x264 { get { return Field<int>(0x264); } }
		public int _x268 { get { return Field<int>(0x268); } }
		public int _x26C { get { return Field<int>(0x26C); } }
		public int _x270 { get { return Field<int>(0x270); } }
		public int _x274 { get { return Field<int>(0x274); } }
		public int _x278 { get { return Field<int>(0x278); } }
		public int _x27C { get { return Field<int>(0x27C); } }
		public int _x280 { get { return Field<int>(0x280); } }
		public int _x284 { get { return Field<int>(0x284); } }
		public int _x288 { get { return Field<int>(0x288); } }
		public int _x28C { get { return Field<int>(0x28C); } }
		public int _x290 { get { return Field<int>(0x290); } }
		public int _x294 { get { return Field<int>(0x294); } }
		public int _x298 { get { return Field<int>(0x298); } }
		public int _x29C { get { return Field<int>(0x29C); } }
		public int _x2A0 { get { return Field<int>(0x2A0); } }
		public int _x2A4 { get { return Field<int>(0x2A4); } }
		public int _x2A8 { get { return Field<int>(0x2A8); } }
		public int _x2AC { get { return Field<int>(0x2AC); } }
		public int _x2B0 { get { return Field<int>(0x2B0); } }
		public int _x2B4 { get { return Field<int>(0x2B4); } }
		public int _x2B8 { get { return Field<int>(0x2B8); } }
		public int _x2BC { get { return Field<int>(0x2BC); } }
		public int _x2C0 { get { return Field<int>(0x2C0); } }
		public int _x2C4 { get { return Field<int>(0x2C4); } }
		public int x2C8 { get { return Field<int>(0x2C8); } }
		public int _x2CC { get { return Field<int>(0x2CC); } }
	}

	public enum ActorType : int
	{
		Unspecified = -1,

		Item = 2,
		Hireling = 4,
		Player = 7,
		Projectile = 17,

		/*Invalid = 0,
		Monster = 1,
		Gizmo = 2,
		ClientEffect = 3,
		ServerProp = 4,
		Environment = 5,
		Critter = 6,
		Player = 7,
		Item = 8,
		AxeSymbol = 9,
		Projectile = 10,
		CustomBrain = 11*/
	}

	public enum ActorRarity : int
	{
		Normal = 0,
		Champion = 1,
		Rare = 2,
		RareMinion = 3,
		Unique = 4,
		Boss = 7
	}

	public enum ItemLocation : int
	{
		Unspecified = -1,

		Inventory = 0,
		Head = 1,
		Torso = 2,
		RightHand = 3,
		LeftHand = 4,
		Hands = 5,
		Waist = 6,
		Feet = 7,
		Shoulders = 8,
		Legs = 9,
		Bracers = 10,
		LeftRing = 11,
		RightRing = 12,
		Neck = 13,
		//Talisman = 14,
		Buyback = 14,
		Stash,
		Gold,
		Merchant,
		InSocket,
		PetRightHand,
		PetLeftHand,
		PetSpecial,
		PetNeck,
		PetRightRing,
		PetLeftRing,
		Floor
	}
}
