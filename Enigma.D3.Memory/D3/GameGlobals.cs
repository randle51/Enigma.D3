using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace Enigma.D3
{
	[Obsolete]
	public partial class GameGlobals : MemoryObject
	{
		public const int SizeOf = 0x398; // 920

		public int x000 { get { return Read<int>(0x000); } }
		public int x004_Neg1_WorldSnoId { get { return Read<int>(0x004); } }
		public int x008_Neg1 { get { return Read<int>(0x008); } }
		public int x00C_Neg1 { get { return Read<int>(0x00C); } }
		public int x010_Neg1 { get { return Read<int>(0x010); } }
		public int x014_One { get { return Read<int>(0x014); } }
		public int x018 { get { return Read<int>(0x018); } }
		public int x01C { get { return Read<int>(0x01C); } }
		public int x020_Flags { get { return Read<int>(0x020); } }
		public int x024 { get { return Read<int>(0x024); } }
		public int x028 { get { return Read<int>(0x028); } }
		public int x02C { get { return Read<int>(0x02C); } }
		public int x030_GameType { get { return Read<int>(0x030); } }
		public int x034_Neg1 { get { return Read<int>(0x034); } }
		public int x038 { get { return Read<int>(0x038); } }
		public int x03C { get { return Read<int>(0x03C); } }
		public int x040 { get { return Read<int>(0x040); } }
		public int _x044 { get { return Read<int>(0x044); } }
		public int x048 { get { return Read<int>(0x048); } }
		public int _x04C { get { return Read<int>(0x04C); } }
		public int x050 { get { return Read<int>(0x050); } }
		public int x054_Neg1 { get { return Read<int>(0x054); } }
		public string x058_ServerName { get { return ReadString(0x058, 128); } }
		public int _x0D8 { get { return Read<int>(0x0D8); } }
		public int _x0DC { get { return Read<int>(0x0DC); } }
		public int _x0E0 { get { return Read<int>(0x0E0); } }
		public int _x0E4 { get { return Read<int>(0x0E4); } }
		public int _x0E8 { get { return Read<int>(0x0E8); } }
		public int _x0EC { get { return Read<int>(0x0EC); } }
		public int _x0F0 { get { return Read<int>(0x0F0); } }
		public int _x0F4 { get { return Read<int>(0x0F4); } }
		public int _x0F8 { get { return Read<int>(0x0F8); } }
		public int _x0FC { get { return Read<int>(0x0FC); } }
		public int _x100 { get { return Read<int>(0x100); } }
		public int _x104 { get { return Read<int>(0x104); } }
		public int _x108 { get { return Read<int>(0x108); } }
		public int _x10C { get { return Read<int>(0x10C); } }
		public int _x110 { get { return Read<int>(0x110); } }
		public int _x114 { get { return Read<int>(0x114); } }
		public int _x118 { get { return Read<int>(0x118); } }
		public int _x11C { get { return Read<int>(0x11C); } }
		public int _x120 { get { return Read<int>(0x120); } }
		public int _x124 { get { return Read<int>(0x124); } }
		public int _x128 { get { return Read<int>(0x128); } }
		public int _x12C { get { return Read<int>(0x12C); } }
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
		public int _x158 { get { return Read<int>(0x158); } }
		public int x15C { get { return Read<int>(0x15C); } }
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
		public int _x1AC { get { return Read<int>(0x1AC); } }
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
		public int _x22C { get { return Read<int>(0x22C); } }
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
		public string x260_Tag { get { return ReadString(0x260, 128); } }
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
		public double x368 { get { return Read<double>(0x368); } }
		public double x370 { get { return Read<double>(0x370); } }
		public double x378 { get { return Read<double>(0x378); } }
		public double x380 { get { return Read<double>(0x380); } }
		public double x388 { get { return Read<double>(0x388); } }
		public int x390 { get { return Read<int>(0x390); } }
		public int x394 { get { return Read<int>(0x394); } }
		public int x398_Neg1 { get { return Read<int>(0x398); } }
		public int _x39C { get { return Read<int>(0x39C); } }
		public int _x3A0_int { get { return Read<int>(0x3A0); } } // 0
		public int x3A4_WorldsSnoId { get { return Read<int>(0x3A4); } } // 223474 (Worlds: utility_server_world)
	}

	public partial class GameGlobals
	{
		public static GameGlobals Instance { get { return Engine.TryGet(engine => engine.ObjectManager.x068_GameGlobals); } }

		public static GameGlobals BuilderInstance { get { return Engine.TryGet(engine => engine.ObjectManager.x400_GameGlobals); } }
	}
}
