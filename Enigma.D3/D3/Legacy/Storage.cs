using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.Legacy
{
	public class Storage : MemoryObject
	{
		public const int SizeOf = 0x138;

		public Storage(ProcessMemory memory, int address)
			: base(memory, address) { }

		public Allocator x000_Allocator { get { return Field<Allocator>(0x000); } }
		public int x01C { get { return Field<int>(0x01C); } }
		public int x020 { get { return Field<int>(0x020); } }
		public Allocator x024_Allocator { get { return Field<Allocator>(0x024); } }
		public int x028 { get { return Field<int>(0x028); } }
		public int x02C { get { return Field<int>(0x02C); } }
		public int x030 { get { return Field<int>(0x030); } }
		public int x034 { get { return Field<int>(0x034); } }
		public int x038 { get { return Field<int>(0x038); } }
		public int x03C { get { return Field<int>(0x03C); } }
		public int x040 { get { return Field<int>(0x040); } }
		public int x044 { get { return Field<int>(0x044); } }
		public int x048 { get { return Field<int>(0x048); } }
		public int x04C { get { return Field<int>(0x04C); } }
		public int x050 { get { return Field<int>(0x050); } }
		public int x054 { get { return Field<int>(0x054); } }
		public int x058 { get { return Field<int>(0x058); } }
		public int x05C { get { return Field<int>(0x05C); } }
		public int x060 { get { return Field<int>(0x060); } }
		public int x064 { get { return Field<int>(0x064); } }
		public int x068 { get { return Field<int>(0x068); } }
		public int x06C { get { return Field<int>(0x06C); } }
		public int x070 { get { return Field<int>(0x070); } }
		public int x074 { get { return Field<int>(0x074); } }
		public int x078 { get { return Field<int>(0x078); } }
		public int x07C { get { return Field<int>(0x07C); } }
		public int x080 { get { return Field<int>(0x080); } }
		public int x084 { get { return Field<int>(0x084); } }
		public int x088 { get { return Field<int>(0x088); } }
		public int x08C { get { return Field<int>(0x08C); } }
		public int x090 { get { return Field<int>(0x090); } }
		public int x094 { get { return Field<int>(0x094); } }
		public int x098 { get { return Field<int>(0x098); } }
		public int x09C { get { return Field<int>(0x09C); } }
		public int x0A0 { get { return Field<int>(0x0A0); } }
		public int x0A4 { get { return Field<int>(0x0A4); } }
		public int x0A8 { get { return Field<int>(0x0A8); } }
		public int x0AC { get { return Field<int>(0x0AC); } }
		public int x0B0_GameTick { get { return Field<int>(0x0B0); } }
		public int x0B4 { get { return Field<int>(0x0B4); } }
		public int x0B8 { get { return Field<int>(0x0B8); } }
		public int x0BC_Markers_Ptr12Bytes { get { return Field<int>(0x0BC); } }
		public int x0C0_InactiveMarkers_Ptr368Bytes { get { return Field<int>(0x0C0); } }
		public PlayerContainer x0C4_PlayerContainer { get { return Dereference<PlayerContainer>(0x0C4); } }
		public int x0C8_RelatedTo_Scenes_Ptr116Bytes { get { return Field<int>(0x0C8); } }
		public int x0CC_Items_Ptr112Bytes { get { return Field<int>(0x0CC); } }
		public int x0D0 { get { return Field<int>(0x0D0); } }
		public int x0D4 { get { return Field<int>(0x0D4); } }
		public int x0D8 { get { return Field<int>(0x0D8); } }
		public int x0DC { get { return Field<int>(0x0DC); } }
		public int x0E0 { get { return Field<int>(0x0E0); } }
		public int x0E4_FastAttrib_Ptr120Bytes { get { return Field<int>(0x0E4); } } // AttributesContainer
		public int x0E8_Teams_Ptr368Bytes { get { return Field<int>(0x0E8); } }
		public int x0EC { get { return Field<int>(0x0EC); } }
		public AcdContainerWrapper x0F0_ActorCommonData { get { return Dereference<AcdContainerWrapper>(0x0F0); } }
		public int x0F4 { get { return Field<int>(0x0F4); } }
		public int x0F8 { get { return Field<int>(0x0F8); } }
		public Allocator x0FC_GameBalance_Allocator16x10 { get { return Dereference<Allocator>(0x0FC); } }
		public int x100_Quests_Ptr120Bytes { get { return Field<int>(0x100); } }
		public Allocator x104_Allocator { get { return Dereference<Allocator>(0x104); } }
		public int x108 { get { return Field<int>(0x108); } }
		public int x10C_NavCellPath_Ptr16Bytes { get { return Field<int>(0x10C); } }
		public int x110_ActorInventory_Ptr96Bytes { get { return Field<int>(0x110); } }
		public Allocator x114_VisualInventory_Allocator256x16 { get { return Dereference<Allocator>(0x114); } }
		public Allocator x118_Portals_Allocator12x10 { get { return Dereference<Allocator>(0x118); } }
		public int x11C { get { return Field<int>(0x11C); } }
		public Structure120 x120 { get { return Dereference<Structure120>(0x120); } }
		public Structure124 x124 { get { return Dereference<Structure124>(0x124); } }
		public int x128 { get { return Field<int>(0x128); } }
		public int x12C { get { return Field<int>(0x12C); } }
		public int x130 { get { return Field<int>(0x130); } }
		public int x134 { get { return Field<int>(0x134); } } // Could be connected to world somehow

		public class Structure120 : MemoryObject
		{
			public const int SizeOf = 0x130; // 1.0.8.16603 : [00EA3C10]

			public Structure120(ProcessMemory memory, int address)
				: base(memory, address) { }

			public int x000 { get { return Field<int>(0x000); } }
			public int _x004 { get { return Field<int>(0x004); } }
			public int _x008 { get { return Field<int>(0x008); } }
			public int _x00C { get { return Field<int>(0x00C); } }
			public int x010 { get { return Field<int>(0x010); } }
			public int x014 { get { return Field<int>(0x014); } }
			public int x018 { get { return Field<int>(0x018); } }
			public int x01C { get { return Field<int>(0x01C); } }
			public int x020 { get { return Field<int>(0x020); } }
			public int _x024 { get { return Field<int>(0x024); } }
			public int x028 { get { return Field<int>(0x028); } }
			public int x02C { get { return Field<int>(0x02C); } }
			public int x030 { get { return Field<int>(0x030); } }
			public int x034_Flags { get { return Field<int>(0x034); } }
			public int x038 { get { return Field<int>(0x038); } }
			public int x03C { get { return Field<int>(0x03C); } }
			public int x040_GoodFood { get { return Field<int>(0x040); } }
			public int _x044 { get { return Field<int>(0x044); } }
			public int _x048 { get { return Field<int>(0x048); } }
			public int _x04C { get { return Field<int>(0x04C); } }
			public int x050 { get { return Field<int>(0x050); } }
			public int x054 { get { return Field<int>(0x054); } }
			public int x058 { get { return Field<int>(0x058); } }
			public int x05C { get { return Field<int>(0x05C); } }
			public int x060 { get { return Field<int>(0x060); } }
			public int x064 { get { return Field<int>(0x064); } }
			public int x068 { get { return Field<int>(0x068); } }
			public int _x06C { get { return Field<int>(0x06C); } }
			public int x070 { get { return Field<int>(0x070); } }
			public int x074 { get { return Field<int>(0x074); } }
			public int x078 { get { return Field<int>(0x078); } }
			public int _x07C { get { return Field<int>(0x07C); } }
			public int x080 { get { return Field<int>(0x080); } }
			public int x084 { get { return Field<int>(0x084); } }
			public int x088 { get { return Field<int>(0x088); } }
			public int x08C_Flags { get { return Field<int>(0x08C); } }
			public int x090 { get { return Field<int>(0x090); } }
			public int x094 { get { return Field<int>(0x094); } }
			public int x098_GoodFood { get { return Field<int>(0x098); } }
			public int _x09C { get { return Field<int>(0x09C); } }
			public int _x0A0 { get { return Field<int>(0x0A0); } }
			public int _x0A4 { get { return Field<int>(0x0A4); } }
			public int x0A8 { get { return Field<int>(0x0A8); } }
			public int x0AC { get { return Field<int>(0x0AC); } }
			public int x0B0 { get { return Field<int>(0x0B0); } }
			public int x0B4 { get { return Field<int>(0x0B4); } }
			public int x0B8 { get { return Field<int>(0x0B8); } }
			public int _x0BC { get { return Field<int>(0x0BC); } }
			public int x0C0 { get { return Field<int>(0x0C0); } }
			public int x0C4 { get { return Field<int>(0x0C4); } }
			public int x0C8 { get { return Field<int>(0x0C8); } }
			public int x0CC_Flags { get { return Field<int>(0x0CC); } }
			public int x0D0 { get { return Field<int>(0x0D0); } }
			public int x0D4 { get { return Field<int>(0x0D4); } }
			public int x0D8_GoodFood { get { return Field<int>(0x0D8); } }
			public int _x0DC { get { return Field<int>(0x0DC); } }
			public int _x0E0 { get { return Field<int>(0x0E0); } }
			public int _x0E4 { get { return Field<int>(0x0E4); } }
			public int x0E8 { get { return Field<int>(0x0E8); } }
			public int x0EC { get { return Field<int>(0x0EC); } }
			public int x0F0 { get { return Field<int>(0x0F0); } }
			public int x0F4 { get { return Field<int>(0x0F4); } }
			public int x0F8 { get { return Field<int>(0x0F8); } }
			public int _x0FC { get { return Field<int>(0x0FC); } }
			public int _x100 { get { return Field<int>(0x100); } }
			public int _x104 { get { return Field<int>(0x104); } }
			public int _x108 { get { return Field<int>(0x108); } }
			public int _x10C { get { return Field<int>(0x10C); } }
			public int _x110 { get { return Field<int>(0x110); } }
			public int x114 { get { return Field<int>(0x114); } }
			public int _x118 { get { return Field<int>(0x118); } }
			public int _x11C { get { return Field<int>(0x11C); } }
			public int _x120 { get { return Field<int>(0x120); } }
			public int _x124 { get { return Field<int>(0x124); } }
			public int x128 { get { return Field<int>(0x128); } }
			public int _x12C { get { return Field<int>(0x12C); } }
		}

		public class Structure124 : MemoryObject
		{
			public const int SizeOf = 0x120; // 1.0.8.16603 - Not confirmed

			public Structure124(ProcessMemory memory, int address)
				: base(memory, address) { }

			public int x000 { get { return Field<int>(0x000); } }
			public int x004 { get { return Field<int>(0x004); } }
			public int x008 { get { return Field<int>(0x008); } }
			public int x00C { get { return Field<int>(0x00C); } }
			public int x010 { get { return Field<int>(0x010); } }
			public int x014 { get { return Field<int>(0x014); } }
			public int x018 { get { return Field<int>(0x018); } }
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
			public int _x088 { get { return Field<int>(0x088); } }
			public int _x08C { get { return Field<int>(0x08C); } }
			public int _x090 { get { return Field<int>(0x090); } }
			public int _x094 { get { return Field<int>(0x094); } }
			public int _x098 { get { return Field<int>(0x098); } }
			public int _x09C { get { return Field<int>(0x09C); } }
			public int _x0A0 { get { return Field<int>(0x0A0); } }
			public int _x0A4 { get { return Field<int>(0x0A4); } }
			public int _x0A8 { get { return Field<int>(0x0A8); } }
			public int _x0AC { get { return Field<int>(0x0AC); } }
			public int _x0B0 { get { return Field<int>(0x0B0); } }
			public int _x0B4 { get { return Field<int>(0x0B4); } }
			public int _x0B8 { get { return Field<int>(0x0B8); } }
			public int _x0BC { get { return Field<int>(0x0BC); } }
			public int _x0C0 { get { return Field<int>(0x0C0); } }
			public int _x0C4 { get { return Field<int>(0x0C4); } }
			public int _x0C8 { get { return Field<int>(0x0C8); } }
			public int _x0CC { get { return Field<int>(0x0CC); } }
			public int _x0D0 { get { return Field<int>(0x0D0); } }
			public int _x0D4 { get { return Field<int>(0x0D4); } }
			public int _x0D8 { get { return Field<int>(0x0D8); } }
			public int _x0DC { get { return Field<int>(0x0DC); } }
			public int _x0E0 { get { return Field<int>(0x0E0); } }
			public int _x0E4 { get { return Field<int>(0x0E4); } }
			public int _x0E8 { get { return Field<int>(0x0E8); } }
			public int _x0EC { get { return Field<int>(0x0EC); } }
			public int _x0F0 { get { return Field<int>(0x0F0); } }
			public int _x0F4 { get { return Field<int>(0x0F4); } }
			public int _x0F8 { get { return Field<int>(0x0F8); } }
			public int _x0FC { get { return Field<int>(0x0FC); } }
			public int _x100 { get { return Field<int>(0x100); } }
			public int _x104 { get { return Field<int>(0x104); } }
			public int _x108 { get { return Field<int>(0x108); } }
			public int _x10C { get { return Field<int>(0x10C); } }
			public int _x110 { get { return Field<int>(0x110); } }
			public int _x114 { get { return Field<int>(0x114); } }
			public int _x118 { get { return Field<int>(0x118); } }
			public int x11C { get { return Field<int>(0x11C); } }
		}
	}
}
