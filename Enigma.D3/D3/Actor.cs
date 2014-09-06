using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Enigma.D3.Collections;
using Enigma.D3.Helpers;

namespace Enigma.D3
{
	public partial class Actor : MemoryObject
	{
		// 2.1.0.26451
		public const int SizeOf = 0x454; // 1108

		public int x000_Id { get { return Read<int>(0x000); } }
		public string x004_Name { get { return ReadString(0x004, 128); } }
		public int x084_SceneId { get { return Read<int>(0x084); } }
		public int x088_AcdId { get { return Read<int>(0x088); } }
		public int x08C_ActorSnoId { get { return Read<int>(0x08C); } }
		public int x090_StructStart_Min80Bytes_ActorLocation { get { return Read<int>(0x090); } }
		public float x094_StructStart_Min28Bytes { get { return Read<float>(0x094); } }
		public float x098 { get { return Read<float>(0x098); } }
		public int _x09C { get { return Read<int>(0x09C); } }
		public float x0A0_Direction_Abs0to1 { get { return Read<float>(0x0A0); } }
		public float x0A4_Direction_1toNeg1 { get { return Read<float>(0x0A4); } }
		public float x0A8_WorldPosX { get { return Read<float>(0x0A8); } }
		public float x0AC_WorldPosY { get { return Read<float>(0x0AC); } }
		public float x0B0_WorldPosZ { get { return Read<float>(0x0B0); } }
		public float x0B4_Radius { get { return Read<float>(0x0B4); } }
		public float x0B8_CollisionX { get { return Read<float>(0x0B8); } }
		public float x0BC_CollisionY { get { return Read<float>(0x0BC); } }
		public float x0C0_CollisionZ { get { return Read<float>(0x0C0); } }
		public float x0C4_CollisionRadius { get { return Read<float>(0x0C4); } }
		public float x0C8_BottomX { get { return Read<float>(0x0C8); } }
		public float x0CC_BottomY { get { return Read<float>(0x0CC); } }
		public float x0D0_BottomZ { get { return Read<float>(0x0D0); } }
		public float x0D4_BottomRadius { get { return Read<float>(0x0D4); } }
		public int _x0D8 { get { return Read<int>(0x0D8); } }
		public int _x0DC { get { return Read<int>(0x0DC); } }
		public int x0E0_WorldId { get { return Read<int>(0x0E0); } }
		public int x0E4_SceneNavMeshId { get { return Read<int>(0x0E4); } }
		public int _x0E8 { get { return Read<int>(0x0E8); } }
		public int _x0EC { get { return Read<int>(0x0EC); } }
		public int _x0F0 { get { return Read<int>(0x0F0); } }
		public int _x0F4 { get { return Read<int>(0x0F4); } }
		public int _x0F8 { get { return Read<int>(0x0F8); } }
		public int _x0FC { get { return Read<int>(0x0FC); } }
		public float _x100 { get { return Read<float>(0x100); } }
		public float _x104 { get { return Read<float>(0x104); } }
		public float x108_X { get { return Read<float>(0x108); } }
		public float x10C_Y { get { return Read<float>(0x10C); } }
		public float x110_Z { get { return Read<float>(0x110); } }
		public float x114_Radius { get { return Read<float>(0x114); } }
		public float _x118 { get { return Read<float>(0x118); } }
		public float _x11C { get { return Read<float>(0x11C); } }
		public int _x120 { get { return Read<int>(0x120); } }
		public int _x124 { get { return Read<int>(0x124); } }
		public float _x128 { get { return Read<float>(0x128); } }
		public float _x12C { get { return Read<float>(0x12C); } }
		public int _x130 { get { return Read<int>(0x130); } }
		public int _x134 { get { return Read<int>(0x134); } }
		public int _x138 { get { return Read<int>(0x138); } }
		public int _x13C { get { return Read<int>(0x13C); } }
		public int _x140 { get { return Read<int>(0x140); } }
		public int _x144 { get { return Read<int>(0x144); } }
		public int _x148 { get { return Read<int>(0x148); } }
		public int _x14C { get { return Read<int>(0x14C); } }
		public int _x150 { get { return Read<int>(0x150); } }
		public int _x154 { get { return Read<int>(0x154); } }
		public int x158_AppearanceSnoId { get { return Read<int>(0x158); } }
		public int _x15C { get { return Read<int>(0x15C); } }
		public int _x160 { get { return Read<int>(0x160); } }
		public int _x164 { get { return Read<int>(0x164); } }
		public int _x168 { get { return Read<int>(0x168); } }
		public int _x16C { get { return Read<int>(0x16C); } }
		public int _x170 { get { return Read<int>(0x170); } }
		public int _x174 { get { return Read<int>(0x174); } }
		public int _x178 { get { return Read<int>(0x178); } }
		public int _x17C { get { return Read<int>(0x17C); } }
		public int _x180 { get { return Read<int>(0x180); } }
		public int _x184 { get { return Read<int>(0x184); } }
		public int _x188 { get { return Read<int>(0x188); } }
		public int _x18C { get { return Read<int>(0x18C); } }
		public int _x190 { get { return Read<int>(0x190); } }
		public int _x194 { get { return Read<int>(0x194); } }
		public int _x198 { get { return Read<int>(0x198); } }
		public int _x19C { get { return Read<int>(0x19C); } }
		public int _x1A0 { get { return Read<int>(0x1A0); } }
		public int _x1A4 { get { return Read<int>(0x1A4); } }
		public int _x1A8 { get { return Read<int>(0x1A8); } }
		public ActorMovement x1AC_ActorMovement { get { return Dereference<ActorMovement>(0x1AC); } }
		public int _x1B0 { get { return Read<int>(0x1B0); } }
		public int _x1B4 { get { return Read<int>(0x1B4); } }
		public int _x1B8 { get { return Read<int>(0x1B8); } }
		public int _x1BC { get { return Read<int>(0x1BC); } }
		public int _x1C0 { get { return Read<int>(0x1C0); } }
		public int _x1C4 { get { return Read<int>(0x1C4); } }
		public int _x1C8 { get { return Read<int>(0x1C8); } }
		public int _x1CC { get { return Read<int>(0x1CC); } }
		public int _x1D0 { get { return Read<int>(0x1D0); } }
		public int _x1D4 { get { return Read<int>(0x1D4); } }
		public int _x1D8 { get { return Read<int>(0x1D8); } }
		public int _x1DC { get { return Read<int>(0x1DC); } }
		public int _x1E0 { get { return Read<int>(0x1E0); } }
		public int _x1E4 { get { return Read<int>(0x1E4); } }
		public int _x1E8 { get { return Read<int>(0x1E8); } }
		public int _x1EC { get { return Read<int>(0x1EC); } }
		public int _x1F0 { get { return Read<int>(0x1F0); } }
		public int _x1F4 { get { return Read<int>(0x1F4); } }
		public int _x1F8 { get { return Read<int>(0x1F8); } }
		public int _x1FC { get { return Read<int>(0x1FC); } }
		public int _x200 { get { return Read<int>(0x200); } }
		public int _x204 { get { return Read<int>(0x204); } }
		public int _x208 { get { return Read<int>(0x208); } }
		public int _x20C { get { return Read<int>(0x20C); } }
		public int _x210 { get { return Read<int>(0x210); } }
		public int _x214 { get { return Read<int>(0x214); } }
		public int _x218 { get { return Read<int>(0x218); } }
		public int _x21C { get { return Read<int>(0x21C); } }
		public int _x220 { get { return Read<int>(0x220); } }
		public int _x224 { get { return Read<int>(0x224); } }
		public int _x228 { get { return Read<int>(0x228); } }
		public int x22C_Frame { get { return Read<int>(0x22C); } }
		public int _x230 { get { return Read<int>(0x230); } }
		public int _x234 { get { return Read<int>(0x234); } }
		public int _x238 { get { return Read<int>(0x238); } }
		public int _x23C { get { return Read<int>(0x23C); } }
		public int _x240 { get { return Read<int>(0x240); } }
		public int _x244 { get { return Read<int>(0x244); } }
		public int _x248 { get { return Read<int>(0x248); } }
		public int _x24C { get { return Read<int>(0x24C); } }
		public int _x250 { get { return Read<int>(0x250); } }
		public int _x254 { get { return Read<int>(0x254); } }
		public int _x258 { get { return Read<int>(0x258); } }
		public int _x25C { get { return Read<int>(0x25C); } }
		public int _x260 { get { return Read<int>(0x260); } }
		public int _x264 { get { return Read<int>(0x264); } }
		public int _x268 { get { return Read<int>(0x268); } }
		public int _x26C { get { return Read<int>(0x26C); } }
		public int _x270 { get { return Read<int>(0x270); } }
		public int _x274 { get { return Read<int>(0x274); } }
		public int _x278 { get { return Read<int>(0x278); } }
		public int _x27C { get { return Read<int>(0x27C); } }
		public int _x280 { get { return Read<int>(0x280); } }
		public int _x284 { get { return Read<int>(0x284); } }
		public int _x288 { get { return Read<int>(0x288); } }
		public int _x28C { get { return Read<int>(0x28C); } }
		public int _x290 { get { return Read<int>(0x290); } }
		public int _x294 { get { return Read<int>(0x294); } }
		public int _x298 { get { return Read<int>(0x298); } }
		public int _x29C { get { return Read<int>(0x29C); } }
		public int _x2A0 { get { return Read<int>(0x2A0); } }
		public int _x2A4 { get { return Read<int>(0x2A4); } }
		public int _x2A8 { get { return Read<int>(0x2A8); } }
		public int _x2AC { get { return Read<int>(0x2AC); } }
		public int _x2B0 { get { return Read<int>(0x2B0); } }
		public int _x2B4 { get { return Read<int>(0x2B4); } }
		public int _x2B8 { get { return Read<int>(0x2B8); } }
		public int _x2BC { get { return Read<int>(0x2BC); } }
		public int _x2C0 { get { return Read<int>(0x2C0); } }
		public int _x2C4 { get { return Read<int>(0x2C4); } }
		public int _x2C8 { get { return Read<int>(0x2C8); } }
		public int _x2CC { get { return Read<int>(0x2CC); } }
		public int _x2D0 { get { return Read<int>(0x2D0); } }
		public int _x2D4 { get { return Read<int>(0x2D4); } }
		public int _x2D8 { get { return Read<int>(0x2D8); } }
		public int _x2DC { get { return Read<int>(0x2DC); } }
		public int _x2E0 { get { return Read<int>(0x2E0); } }
		public int _x2E4 { get { return Read<int>(0x2E4); } }
		public int _x2E8 { get { return Read<int>(0x2E8); } }
		public int _x2EC { get { return Read<int>(0x2EC); } }
		public int _x2F0 { get { return Read<int>(0x2F0); } }
		public int _x2F4 { get { return Read<int>(0x2F4); } }
		public int _x2F8 { get { return Read<int>(0x2F8); } }
		public int _x2FC { get { return Read<int>(0x2FC); } }
		public int _x300 { get { return Read<int>(0x300); } }
		public int _x304 { get { return Read<int>(0x304); } }
		public int _x308 { get { return Read<int>(0x308); } }
		public int _x30C { get { return Read<int>(0x30C); } }
		public int _x310 { get { return Read<int>(0x310); } }
		public int _x314 { get { return Read<int>(0x314); } }
		public int _x318 { get { return Read<int>(0x318); } }
		public int _x31C { get { return Read<int>(0x31C); } }
		public int _x320 { get { return Read<int>(0x320); } }
		public int _x324 { get { return Read<int>(0x324); } }
		public int _x328 { get { return Read<int>(0x328); } }
		public int _x32C { get { return Read<int>(0x32C); } }
		public int _x330 { get { return Read<int>(0x330); } }
		public int _x334 { get { return Read<int>(0x334); } }
		public int _x338 { get { return Read<int>(0x338); } }
		public int _x33C { get { return Read<int>(0x33C); } }
		public int _x340 { get { return Read<int>(0x340); } }
		public int _x344 { get { return Read<int>(0x344); } }
		public int _x348 { get { return Read<int>(0x348); } }
		public int _x34C { get { return Read<int>(0x34C); } }
		public int _x350 { get { return Read<int>(0x350); } }
		public int _x354 { get { return Read<int>(0x354); } }
		public int _x358 { get { return Read<int>(0x358); } }
		public int _x35C { get { return Read<int>(0x35C); } }
		public int _x360 { get { return Read<int>(0x360); } }
		public int _x364 { get { return Read<int>(0x364); } }
		public int _x368 { get { return Read<int>(0x368); } }
		public int _x36C { get { return Read<int>(0x36C); } }
		public int _x370 { get { return Read<int>(0x370); } }
		public int _x374 { get { return Read<int>(0x374); } }
		public int _x378 { get { return Read<int>(0x378); } }
		public int _x37C { get { return Read<int>(0x37C); } }
		public int _x380 { get { return Read<int>(0x380); } }
		public int x384 { get { return Read<int>(0x384); } }
		public int _x388 { get { return Read<int>(0x388); } }
		public int x38C { get { return Read<int>(0x38C); } }
		public int _x390 { get { return Read<int>(0x390); } }
		public float x394 { get { return Read<float>(0x394); } }
		public float x398 { get { return Read<float>(0x398); } }
		public float x39C { get { return Read<float>(0x39C); } }
		public float x3A0 { get { return Read<float>(0x3A0); } }
		public float x3A4_StructStart_4xFloats { get { return Read<float>(0x3A4); } }
		public float x3A8 { get { return Read<float>(0x3A8); } }
		public float x3AC { get { return Read<float>(0x3AC); } }
		public float x3B0 { get { return Read<float>(0x3B0); } }
		public int x3B4 { get { return Read<int>(0x3B4); } }
		public Map x3B8_Ptr112Bytes_Map { get { return Dereference<Map>(0x3B8); } }
		public int _x3BC { get { return Read<int>(0x3BC); } }
		public int x3C0_Ptr_24Bytes { get { return Dereference<int>(0x3C0); } }
		public int x3C4_StructStart_28Bytes { get { return Read<int>(0x3C4); } }
		public int x3E0 { get { return Read<int>(0x3E0); } }
		public int x3E4 { get { return Read<int>(0x3E4); } }
		public int x3E8 { get { return Read<int>(0x3E8); } }
		public float x3EC { get { return Read<float>(0x3EC); } }
		public float x3F0 { get { return Read<float>(0x3F0); } }
		public float x3F4 { get { return Read<float>(0x3F4); } }
		public int x3F8_CreationTick { get { return Read<int>(0x3F8); } }
		public int x3FC_Neg1_Id_ { get { return Read<int>(0x3FC); } }
		public int x400_2xShort_Neg1_Neg1 { get { return Read<int>(0x400); } }
		public int x404 { get { return Read<int>(0x404); } }
		public int x408_Neg1 { get { return Read<int>(0x408); } }
		public int x40C_Neg1 { get { return Read<int>(0x40C); } }
		public int _x410 { get { return Read<int>(0x410); } }
		public int x414 { get { return Read<int>(0x414); } }
		public float x418 { get { return Read<float>(0x418); } }
		public int x41C_ActorScalePinned { get { return Read<int>(0x41C); } }
		public int x420 { get { return Read<int>(0x420); } }
		public int _x424 { get { return Read<int>(0x424); } }
		public int _x428 { get { return Read<int>(0x428); } }
		public int _x42C { get { return Read<int>(0x42C); } }
		public int _x430 { get { return Read<int>(0x430); } }
		public int _x434 { get { return Read<int>(0x434); } }
		public int _x438 { get { return Read<int>(0x438); } }
		public int x43C { get { return Read<int>(0x43C); } }
		public int x440_Frame { get { return Read<int>(0x440); } }
		public int _x444 { get { return Read<int>(0x444); } }
		public int _x448 { get { return Read<int>(0x448); } }
		public int x44C_Ptr_48Bytes_BannerAttachments { get { return Read<int>(0x44C); } }
		public int _x450 { get { return Read<int>(0x450); } }
	}

	public partial class Actor
	{
		public static Actor Local
		{
			get
			{
				try
				{
					var localData = LocalData.Instance;
					localData.TakeSnapshot();
					if (localData.x00_IsActorCreated == 0)
						return null;

					var localPlayerData = PlayerData.Local;
					if (localPlayerData == null)
						return null;

					var container = Actor.Container;
					if (container != null)
						return container[(short)localPlayerData.x0008_ActorId];

					return null;
				}
				catch
				{
					return null;
				}
			}
		}

		public static ExpandableContainer<Actor> Container { get { return ObjectManager.Instance.IfNotNull(a => a.x928_RActors); } }

		public static IEnumerable<Actor> Enumerate()
		{
			var container = Container;
			if (container == null)
				return Enumerable.Empty<Actor>();
			container.TakeSnapshot();
			return container.Where(a => a.x000_Id != -1);
		}
	}
}
