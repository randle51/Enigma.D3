using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.Legacy
{
	public class BattleNetPlatform : MemoryObject
	{
		public const int SizeOf = 0x220; // 1.0.8.16603

		public BattleNetPlatform(ProcessMemory memory, int address)
			: base(memory, address) { }

		public int x000 { get { return Field<int>(0x000); } }
		public int _x004 { get { return Field<int>(0x004); } }
		public int x008 { get { return Field<int>(0x008); } }
		public int x00C { get { return Field<int>(0x00C); } }
		public int _x010 { get { return Field<int>(0x010); } }
		public int _x014 { get { return Field<int>(0x014); } }
		public int _x018 { get { return Field<int>(0x018); } }
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
		public int x088 { get { return Field<int>(0x088); } }
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
		public int x150_Ptr8Bytes { get { return Field<int>(0x150); } }
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
		public int _x1E0 { get { return Field<int>(0x1E0); } }
		public int _x1E4 { get { return Field<int>(0x1E4); } }
		public int _x1E8 { get { return Field<int>(0x1E8); } }
		public int _x1EC { get { return Field<int>(0x1EC); } }
		public int _x1F0 { get { return Field<int>(0x1F0); } }
		public int _x1F4 { get { return Field<int>(0x1F4); } }
		public int _x1F8 { get { return Field<int>(0x1F8); } }
		public int _x1FC { get { return Field<int>(0x1FC); } }
		public int _x200 { get { return Field<int>(0x200); } }
		public int _x204 { get { return Field<int>(0x204); } }
		public int _x208 { get { return Field<int>(0x208); } }
		public int _x20C { get { return Field<int>(0x20C); } }
		public int x210_PtrMethodX00BC58D0 { get { return Field<int>(0x210); } }
		public int x214_PtrMethodX00BC5A90 { get { return Field<int>(0x214); } }
		public int _x218 { get { return Field<int>(0x218); } }
		public int _x21C { get { return Field<int>(0x21C); } }
	}
}
