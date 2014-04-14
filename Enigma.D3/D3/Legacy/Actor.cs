using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.Legacy
{
	public class Actor : MemoryObject
	{
		public const int SizeOf = 0x42C; // 1.0.8.16603 : [00B329C2]

		public Actor(ProcessMemory memory, int address)
			: base(memory, address) { }

		public int x000_Id { get { return Field<int>(0x000); } }
		public int x004_AcdId { get { return Field<int>(0x004); } }
		public string x008_Name { get { return Field(0x008, 128); } }
		public int x088_SnoId { get { return Field<int>(0x088); } }
		public int x08C_ActorLocation { get { return Field<int>(0x08C); } } // Logged if zero: "Actor Location is not AL_WORLD! (%d)\n", actor->x08C_ActorLocation;
		// START Inline Struct
		public float x090 { get { return Field<float>(0x090); } }
		public float x094 { get { return Field<float>(0x094); } }
		public float x098_Direction_Abs0to1 { get { return Field<float>(0x098); } }
		public float x09C_Direction_1toNeg1 { get { return Field<float>(0x09C); } }
		public Circle x0A0 { get { return Field<Circle>(0x0A0); } }
		public Circle x0B0_WorldCoordinate { get { return Field<Circle>(0x0B0); } }
		// Seems to be grouped
		public Circle x0C0_WorldCoordinateBottom { get { return Field<Circle>(0x0C0); } }
		public int _x0D0_Ptr { get { return Field<int>(0x0D0); } }
		//
		// END Inline Struct
		public Circle x0D4 { get { return Dereference<Circle>(0x0D4); } }
		public int x0D8_WorldId { get { return Field<int>(0x0D8); } }
		public int x0DC_SceneId { get { return Field<int>(0x0DC); } }
		public int _x0E0 { get { return Field<int>(0x0E0); } }
		public int _x0E4 { get { return Field<int>(0x0E4); } }
		public int _x0E8 { get { return Field<int>(0x0E8); } }
		public int _x0EC { get { return Field<int>(0x0EC); } }
		public int _x0F0 { get { return Field<int>(0x0F0); } }
		public int _x0F4 { get { return Field<int>(0x0F4); } }
		public float x0F8_Direction_Abs0to1 { get { return Field<float>(0x0F8); } } // SW:  0.0, { non-linear }, NE: +1.0
		public float x0FC_Direction_1toNeg1 { get { return Field<float>(0x0FC); } } // SW: -1.0 (NW) / +1.0 (SE) NE: 0.0
		public Circle x100 { get { return Field<Circle>(0x100); } }
		public float x110_Direction_UnknownFormat { get { return Field<float>(0x110); } } // SW: +1.2, NW:  0.0, NE: -1.2, SE:  0.0
		public float x114_Direction_UnknownFormat { get { return Field<float>(0x114); } } // SW:  0.0, NW: -1.2, NE:  0.0, SE: +1.2
		public float _x118 { get { return Field<float>(0x118); } }
		public float _x11C { get { return Field<float>(0x11C); } }
		public float x120_Direction_UnknownFormat { get { return Field<float>(0x120); } } // SW:  0.0, NW: +1.2, NE:  0.0, SE: -1.2 
		public float x124_Direction_UnknownFormat { get { return Field<float>(0x124); } } // SW: +1.2, NW:  0.0, NE: -1.2, SE:  0.0
		public int _x128 { get { return Field<int>(0x128); } }
		public int _x12C { get { return Field<int>(0x12C); } }
		public int _x130 { get { return Field<int>(0x130); } }
		public int _x134 { get { return Field<int>(0x134); } }
		public float _x138 { get { return Field<float>(0x138); } }
		public int _x13C { get { return Field<int>(0x13C); } }
		public Circle _x140 { get { return Field<Circle>(0x140); } }
		public int x150_SnoId_Unknown { get { return Field<int>(0x150); } }
		public int _x154 { get { return Field<int>(0x154); } }
		public int _x158 { get { return Field<int>(0x158); } }
		public int _x15C { get { return Field<int>(0x15C); } }
		public int _x160 { get { return Field<int>(0x160); } }
		public int _x164 { get { return Field<int>(0x164); } }
		public int _x168 { get { return Field<int>(0x168); } }
		public int _x16C { get { return Field<int>(0x16C); } }
		public int _x170 { get { return Field<int>(0x170); } }
		public int _x174 { get { return Field<int>(0x174); } }
		public int _x178 { get { return Field<int>(0x178); } }
		public int _x17C { get { return Field<int>(0x17C); } }
		public int _x180 { get { return Field<int>(0x180); } }
		public int _x184 { get { return Field<int>(0x184); } }
		public int _x188 { get { return Field<int>(0x188); } }
		public int _x18C { get { return Field<int>(0x18C); } }
		public int _x190 { get { return Field<int>(0x190); } }
		public int _x194 { get { return Field<int>(0x194); } }
		public int _x198 { get { return Field<int>(0x198); } }
		public int _x19C { get { return Field<int>(0x19C); } }
		public int _x1A0 { get { return Field<int>(0x1A0); } }
		public int _x1A4 { get { return Field<int>(0x1A4); } }
		public int _x1A8 { get { return Field<int>(0x1A8); } }
		public int _x1AC { get { return Field<int>(0x1AC); } }
		public int _x1B0 { get { return Field<int>(0x1B0); } }
		public int _x1B4 { get { return Field<int>(0x1B4); } }
		public int _x1B8 { get { return Field<int>(0x1B8); } }
		public int _x1BC { get { return Field<int>(0x1BC); } }
		public int _x1C0 { get { return Field<int>(0x1C0); } }
		public int _x1C4 { get { return Field<int>(0x1C4); } }
		public int _x1C8 { get { return Field<int>(0x1C8); } }
		public int _x1CC { get { return Field<int>(0x1CC); } }
		public int _x1D0 { get { return Field<int>(0x1D0); } }
		public int _x1D4 { get { return Field<int>(0x1D4); } }
		public int _x1D8 { get { return Field<int>(0x1D8); } }
		public int _x1DC { get { return Field<int>(0x1DC); } }
		public LinkedList<int> x1E0_List { get { return Field<LinkedList<int>>(0x1E0); } }
		public int _x1F0 { get { return Field<int>(0x1F0); } }
		public int _x1F4 { get { return Field<int>(0x1F4); } }
		public LinkedList<Attachment> x1F8_AttachmentList { get { return Field<LinkedList<Attachment>>(0x1F8); } }
		public int _x208 { get { return Field<int>(0x208); } }
		public int _x20C { get { return Field<int>(0x20C); } }
		public int _x210_RelatedTo_EffectGroup { get { return Field<int>(0x210); } }
		public Point3D x214 { get { return Field<Point3D>(0x214); } }
		public int x220_Facing_ { get { return Field<int>(0x220); } } // <-- pointer to a structure that is edited on a ACDLookAtMessage (see 0x00B3BDA0)
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
		public int _x250 { get { return Field<int>(0x250); } }
		public int _x254 { get { return Field<int>(0x254); } }
		public int _x258 { get { return Field<int>(0x258); } }
		public int _x25C { get { return Field<int>(0x25C); } }
		public int _x260 { get { return Field<int>(0x260); } }
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
		public int x290_WorldSnoId_ { get { return Field<int>(0x290); } }
		public int x294_SceneSnoId_ { get { return Field<int>(0x294); } }
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
		public int _x2C8 { get { return Field<int>(0x2C8); } }
		public int _x2CC { get { return Field<int>(0x2CC); } }
		public int _x2D0 { get { return Field<int>(0x2D0); } }
		public int _x2D4 { get { return Field<int>(0x2D4); } }
		public int _x2D8 { get { return Field<int>(0x2D8); } }
		public int _x2DC { get { return Field<int>(0x2DC); } }
		public int _x2E0 { get { return Field<int>(0x2E0); } }
		public int _x2E4 { get { return Field<int>(0x2E4); } }
		public int _x2E8 { get { return Field<int>(0x2E8); } }
		public int _x2EC { get { return Field<int>(0x2EC); } }
		public int _x2F0 { get { return Field<int>(0x2F0); } }
		public int _x2F4 { get { return Field<int>(0x2F4); } }
		public int _x2F8 { get { return Field<int>(0x2F8); } }
		public int _x2FC { get { return Field<int>(0x2FC); } }
		public int _x300 { get { return Field<int>(0x300); } }
		public int _x304 { get { return Field<int>(0x304); } }
		public int _x308 { get { return Field<int>(0x308); } }
		public int _x30C { get { return Field<int>(0x30C); } }
		public int _x310 { get { return Field<int>(0x310); } }
		public int _x314 { get { return Field<int>(0x314); } }
		public int _x318 { get { return Field<int>(0x318); } }
		public int _x31C { get { return Field<int>(0x31C); } }
		public int _x320 { get { return Field<int>(0x320); } }
		public int _x324 { get { return Field<int>(0x324); } }
		public int _x328 { get { return Field<int>(0x328); } }
		public int _x32C { get { return Field<int>(0x32C); } }
		public int _x330 { get { return Field<int>(0x330); } }
		public int _x334 { get { return Field<int>(0x334); } }
		public int _x338 { get { return Field<int>(0x338); } }
		public int _x33C { get { return Field<int>(0x33C); } }
		public int _x340 { get { return Field<int>(0x340); } }
		public int _x344 { get { return Field<int>(0x344); } }
		public int _x348 { get { return Field<int>(0x348); } }
		public int _x34C { get { return Field<int>(0x34C); } }
		public int _x350 { get { return Field<int>(0x350); } }
		public int _x354 { get { return Field<int>(0x354); } }
		public int _x358 { get { return Field<int>(0x358); } }
		public int _x35C { get { return Field<int>(0x35C); } }
		public int _x360 { get { return Field<int>(0x360); } }
		public int _x364 { get { return Field<int>(0x364); } }
		public int _x368 { get { return Field<int>(0x368); } }
		public int _x36C { get { return Field<int>(0x36C); } }
		public int _x370 { get { return Field<int>(0x370); } }
		public int _x374 { get { return Field<int>(0x374); } }
		public int _x378 { get { return Field<int>(0x378); } }
		public int _x37C { get { return Field<int>(0x37C); } }
		public int _x380 { get { return Field<int>(0x380); } }
		public int _x384 { get { return Dereference<int>(0x384); } }
		public float x388_Direction_Radians { get { return Field<float>(0x388); } }
		public int _x38C { get { return Field<int>(0x38C); } }
		public int _x390 { get { return Field<int>(0x390); } }
		public int _x394 { get { return Field<int>(0x394); } }
		public int _x398 { get { return Field<int>(0x398); } }
		public int _x39C { get { return Field<int>(0x39C); } }
		public int _x3A0 { get { return Field<int>(0x3A0); } }
		public float x3A4_VelocityX { get { return Field<float>(0x3A4); } }
		public float x3A8_VelocityY { get { return Field<float>(0x3A8); } }
		public float x3AC_VelocityZ { get { return Field<float>(0x3AC); } }
		public Circle x3B0 { get { return Field<Circle>(0x3B0); } }
		public int x3C0_NavMeshId { get { return Field<int>(0x3C0); } }
		public int _x3C4 { get { return Field<int>(0x3C4); } }
		public int _x3C8 { get { return Field<int>(0x3C8); } }
		public int _x3CC { get { return Field<int>(0x3CC); } }
		public int _x3D0 { get { return Field<int>(0x3D0); } }
		public int _x3D4 { get { return Field<int>(0x3D4); } }
		public int _x3D8 { get { return Field<int>(0x3D8); } }
		public int _x3DC { get { return Field<int>(0x3DC); } }
		public int x3E0 { get { return Field<int>(0x3E0); } } // <-- This is set on an ACDShearMessage
		public int _x3E4 { get { return Field<int>(0x3E4); } }
		public float x3E8_Scale { get { return Field<float>(0x3E8); } } // TODO: Confirm float
		public int _x3EC { get { return Field<int>(0x3EC); } }
		public int _x3F0 { get { return Field<int>(0x3F0); } }
		public int _x3F4 { get { return Field<int>(0x3F4); } }
		public float x3F8_RelatedTo_DamageNumbers { get { return Field<float>(0x3F8); } }
		public int x3FC_NextHealFrame { get { return Field<int>(0x3FC); } }
		public int _x400 { get { return Field<int>(0x400); } }
		public int _x404 { get { return Field<int>(0x404); } }
		public int _x408 { get { return Field<int>(0x408); } }
		public int _x40C { get { return Field<int>(0x40C); } }
		public int _x410 { get { return Field<int>(0x410); } }
		public int _x414 { get { return Field<int>(0x414); } }
		public int _x418 { get { return Field<int>(0x418); } }
		public int x41C_Frame { get { return Field<int>(0x41C); } }
		public int _x420 { get { return Field<int>(0x420); } }
		public int _x424 { get { return Field<int>(0x424); } }
		public int _x428 { get { return Field<int>(0x428); } }
	}

	public struct Circle
	{
		public Point3D Point;
		public float Radius;

		public override string ToString()
		{
			return Point.ToString() + " Radius: " + Radius.ToString("0.00");
		}
	}
}
