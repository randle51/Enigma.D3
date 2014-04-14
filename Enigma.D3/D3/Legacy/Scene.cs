using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.Legacy
{
	public class Scene : MemoryObject
	{
		public const int SizeOf = 0x2A8; // 1.0.8.16603 (taken from container)

		public Scene(ProcessMemory memory, int address)
			: base(memory, address) { }

		public int x000_Id { get { return Field<int>(0x000); } }
		// START: NavMesh - END: Unknown, size at least 0x21C
		public int x004_NavMeshId { get { return Field<int>(0x004); } }
		public int x008_WorldId { get { return Field<int>(0x008); } }
		public int _x00C { get { return Field<int>(0x00C); } }
		public int _x010 { get { return Field<int>(0x010); } }
		public int _x014 { get { return Field<int>(0x014); } }
		public int x018_LevelAreaSnoId { get { return Field<int>(0x018); } }
		public int _x01C { get { return Field<int>(0x01C); } }
		public int _x020 { get { return Field<int>(0x020); } }
		public int _x024 { get { return Field<int>(0x024); } }
		public int _x028 { get { return Field<int>(0x028); } }
		public int _x02C { get { return Field<int>(0x02C); } }
		public int _x030 { get { return Field<int>(0x030); } }
		public int _x034 { get { return Field<int>(0x034); } }
		public int _x038 { get { return Field<int>(0x038); } }
		public int _x03C { get { return Field<int>(0x03C); } }
		public int _x040 { get { return Field<int>(0x040); } }
		public int _x044 { get { return Field<int>(0x044); } }
		public int _x048 { get { return Field<int>(0x048); } }
		public int _x04C { get { return Field<int>(0x04C); } }
		public int _x050 { get { return Field<int>(0x050); } }
		public int _x054 { get { return Field<int>(0x054); } }
		public int _x058 { get { return Field<int>(0x058); } }
		public int _x05C { get { return Field<int>(0x05C); } }
		public int _x060 { get { return Field<int>(0x060); } }
		public int _x064 { get { return Field<int>(0x064); } }
		public int _x068 { get { return Field<int>(0x068); } }
		public int _x06C { get { return Field<int>(0x06C); } }
		public int _x070 { get { return Field<int>(0x070); } }
		public int _x074 { get { return Field<int>(0x074); } }
		public int _x078 { get { return Field<int>(0x078); } }
		public int _x07C { get { return Field<int>(0x07C); } }
		public int _x080 { get { return Field<int>(0x080); } }
		public int _x084 { get { return Field<int>(0x084); } }
		// START: NavMeshX88 - END: Unknown, size at least 0x50
		public int _x088 { get { return Field<int>(0x088); } }
		public int _x08C { get { return Field<int>(0x08C); } }
		public int x090_SquaresX { get { return Field<int>(0x090); } }
		public int x094_SquaresY { get { return Field<int>(0x094); } }
		public AxisAlignedBoundingBox x098_Bounds { get { return Field<AxisAlignedBoundingBox>(0x098); } }
		public AxisAlignedBoundingBox x0B0_MarkerSetBounds { get { return Field<AxisAlignedBoundingBox>(0x0B0); } }
		public int x0B4_Struct_ { get { return Field<int>(0x0B4); } }
		public int _x0B8 { get { return Field<int>(0x0B8); } }
		public int _x0BC { get { return Field<int>(0x0BC); } }
		public int _x0C0 { get { return Field<int>(0x0C0); } }
		public int x0C4_MemHeaderX0C { get { return Field<int>(0x0C4); } } // <-- this could be the end of NavMeshX88
		public int _x0C8 { get { return Field<int>(0x0C8); } }
		public int _x0CC { get { return Field<int>(0x0CC); } }
		public int _x0D0 { get { return Field<int>(0x0D0); } }
		public int _x0D4 { get { return Field<int>(0x0D4); } }
		public int _x0D8 { get { return Field<int>(0x0D8); } }
		public int x0DC_SceneSnoId { get { return Field<int>(0x0DC); } }
		// START: struct
		public int _x0E0 { get { return Field<int>(0x0E0); } }
		public int _x0E4 { get { return Field<int>(0x0E4); } } // WorldPosX (KJ)?
		public int _x0E8 { get { return Field<int>(0x0E8); } } // WorldPosY (KJ)?
		public int _x0EC { get { return Field<int>(0x0EC); } }
		public int _x0F0 { get { return Field<int>(0x0F0); } }
		public int _x0F4 { get { return Field<int>(0x0F4); } }
		public int _x0F8 { get { return Field<int>(0x0F8); } }
		// could be end of struct
		public int _x0FC { get { return Field<int>(0x0FC); } }
		public int _x100 { get { return Field<int>(0x100); } }
		public int _x104 { get { return Field<int>(0x104); } }
		public int _x108 { get { return Field<int>(0x108); } }
		public int _x10C { get { return Field<int>(0x10C); } }
		public int _x110 { get { return Field<int>(0x110); } }
		public int _x114 { get { return Field<int>(0x114); } }
		public int _x118 { get { return Field<int>(0x118); } }
		public int _x11C { get { return Field<int>(0x11C); } }
		public int _x120 { get { return Field<int>(0x120); } }
		public int _x124 { get { return Field<int>(0x124); } }
		public int _x128 { get { return Field<int>(0x128); } }
		public int _x12C { get { return Field<int>(0x12C); } }
		public int _x130 { get { return Field<int>(0x130); } }
		public int _x134 { get { return Field<int>(0x134); } }
		public int _x138 { get { return Field<int>(0x138); } }
		public int _x13C { get { return Field<int>(0x13C); } }
		public int _x140 { get { return Field<int>(0x140); } }
		public int _x144 { get { return Field<int>(0x144); } }
		public int _x148 { get { return Field<int>(0x148); } }
		public int _x14C { get { return Field<int>(0x14C); } }
		public int _x150 { get { return Field<int>(0x150); } }
		public int _x154 { get { return Field<int>(0x154); } }
		public int _x158 { get { return Field<int>(0x158); } }
		public int _x15C { get { return Field<int>(0x15C); } }
		public int _x160 { get { return Field<int>(0x160); } }
		public int _x164 { get { return Field<int>(0x164); } }
		public int _x168 { get { return Field<int>(0x168); } } // MeshMaxX (KJ)?
		public int _x16C { get { return Field<int>(0x16C); } } // MeshMaxY (KJ)?
		public int _x170 { get { return Field<int>(0x170); } }
		public int _x174 { get { return Field<int>(0x174); } }
		public int x178_NavMesh { get { return Field<int>(0x178); } } // BaseHeight (KJ)?
		public int _x17C { get { return Field<int>(0x17C); } }
		public int _x180 { get { return Field<int>(0x180); } } // ZonePtr (KJ)?
		public int _x184 { get { return Field<int>(0x184); } }
		public int _x188 { get { return Field<int>(0x188); } }
		public int x18C_Flags { get { return Field<int>(0x18C); } } // If bit 0 is set (1), scene is considered active (see 00F436B0).
		public int _x190 { get { return Field<int>(0x190); } }
		public int _x194 { get { return Field<int>(0x194); } }
		public int _x198 { get { return Field<int>(0x198); } }
		public int _x19C { get { return Field<int>(0x19C); } }
		public int x1A0_Ptr_Subscenes_ { get { return Field<int>(0x1A0); } }
		public int _x1A4 { get { return Field<int>(0x1A4); } }
		public int _x1A8 { get { return Field<int>(0x1A8); } }
		public int _x1AC { get { return Field<int>(0x1AC); } }
		public int _x1B0 { get { return Field<int>(0x1B0); } }
		public int x1B4_ParentSceneId_ { get { return Field<int>(0x1B4); } }
		public int _x1B8 { get { return Field<int>(0x1B8); } }
		public int _x1BC { get { return Field<int>(0x1BC); } }
		public int _x1C0 { get { return Field<int>(0x1C0); } }
		public int _x1C4 { get { return Field<int>(0x1C4); } }
		public int _x1C8 { get { return Field<int>(0x1C8); } }
		public int _x1CC { get { return Field<int>(0x1CC); } }
		public int _x1D0 { get { return Field<int>(0x1D0); } }
		public int _x1D4 { get { return Field<int>(0x1D4); } }
		public LinkedList<MemoryObject> x1D8_Struct_List_ { get { return Field<LinkedList<MemoryObject>>(0x1D8); } } // The node values are 52 bytes long.
		public int _x1E8 { get { return Field<int>(0x1E8); } }
		public LinkedList<MemoryObject> x1EC_Struct_List_ { get { return Field<LinkedList<MemoryObject>>(0x1EC); } } // The node values are 52 bytes long.
		public int _x1FC { get { return Field<int>(0x1FC); } }
		public LinkedList<MemoryObject> x200_Struct_List_ { get { return Field<LinkedList<MemoryObject>>(0x200); } } // The node values are 52 bytes long.
		public int _x210 { get { return Field<int>(0x210); } }
		public int _x214 { get { return Field<int>(0x214); } }
		public int x218_Ptr_NavSquaresArray_ { get { return Field<int>(0x218); } }
		public int x21C_NavSquaresCount_ { get { return Field<int>(0x21C); } }
		public int _x220 { get { return Field<int>(0x220); } } // VisibilityFlag (KJ)?
		public int _x224 { get { return Field<int>(0x224); } }
		public int _x228 { get { return Field<int>(0x228); } }
		public int _x22C { get { return Field<int>(0x22C); } }
		public LinkedList<MemoryObject> x230_Struct_List_ { get { return Field<LinkedList<MemoryObject>>(0x230); } }
		public int _x240 { get { return Field<int>(0x240); } }
		public int _x244 { get { return Field<int>(0x244); } }
		public LinkedList<Attachment> x248_AttachmentList { get { return Field<LinkedList<Attachment>>(0x248); } }
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
		public int _x290 { get { return Field<int>(0x290); } }
		public LinkedList<MemoryObject> x294_Struct_List_ { get { return Field<LinkedList<MemoryObject>>(0x294); } }
		public int _x2A4 { get { return Field<int>(0x2A4); } }
	}
}
