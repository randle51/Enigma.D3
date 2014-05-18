public class ItemDropTableEntry : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x478; // 1144

	public ItemDropTableEntry(ProcessMemory memory, int address)
		: base(memory, address) { }

	public string x000 { get { return Field(0x000, 256); } }
	public int x100 { get { return Field<int>(0x100); } }
	public int x104 { get { return Field<int>(0x104); } }
	public int x108 { get { return Field<int>(0x108); } }
	public int x10C { get { return Field<int>(0x10C); } }
	public int x110 { get { return Field<int>(0x110); } }
	public int x114 { get { return Field<int>(0x114); } }
	public int x118 { get { return Field<int>(0x118); } }
	public int x11C { get { return Field<int>(0x11C); } }
	public int x120 { get { return Field<int>(0x120); } }
	public int x124 { get { return Field<int>(0x124); } }
	public int x128 { get { return Field<int>(0x128); } }
	public int x12C { get { return Field<int>(0x12C); } }
	public int x130 { get { return Field<int>(0x130); } }
	public int x134 { get { return Field<int>(0x134); } }
	public int x138 { get { return Field<int>(0x138); } }
	public int x13C { get { return Field<int>(0x13C); } }
	public int x140 { get { return Field<int>(0x140); } }
	public int x144 { get { return Field<int>(0x144); } }
	public int x148 { get { return Field<int>(0x148); } }
	public int x14C { get { return Field<int>(0x14C); } }
	public int x150 { get { return Field<int>(0x150); } }
	public int x154 { get { return Field<int>(0x154); } }
	public int x158 { get { return Field<int>(0x158); } }
	public int x15C { get { return Field<int>(0x15C); } }
	public int x160 { get { return Field<int>(0x160); } }
	public int x164 { get { return Field<int>(0x164); } }
	public int x168 { get { return Field<int>(0x168); } }
	public int x16C { get { return Field<int>(0x16C); } }
	public int x170 { get { return Field<int>(0x170); } }
	public int x174 { get { return Field<int>(0x174); } }
	public int x178 { get { return Field<int>(0x178); } }
	public int x17C { get { return Field<int>(0x17C); } }
	public int x180 { get { return Field<int>(0x180); } }
	public int x184 { get { return Field<int>(0x184); } }
	public int x188 { get { return Field<int>(0x188); } }
	public int x18C { get { return Field<int>(0x18C); } }
	public int x190 { get { return Field<int>(0x190); } }
	public int x194 { get { return Field<int>(0x194); } }
	public int x198 { get { return Field<int>(0x198); } }
	public int x19C { get { return Field<int>(0x19C); } }
	public int x1A0 { get { return Field<int>(0x1A0); } }
	public int x1A4 { get { return Field<int>(0x1A4); } }
	public int x1A8 { get { return Field<int>(0x1A8); } }
	public int x1AC { get { return Field<int>(0x1AC); } }
	public int x1B0 { get { return Field<int>(0x1B0); } }
	public int x1B4 { get { return Field<int>(0x1B4); } }
	public int x1B8 { get { return Field<int>(0x1B8); } }
	public int x1BC { get { return Field<int>(0x1BC); } }
	public int x1C0 { get { return Field<int>(0x1C0); } }
	public int x1C4 { get { return Field<int>(0x1C4); } }
	public int x1C8 { get { return Field<int>(0x1C8); } }
	public int x1CC { get { return Field<int>(0x1CC); } }
	public int x1D0 { get { return Field<int>(0x1D0); } }
	public int x1D4 { get { return Field<int>(0x1D4); } }
	public int x1D8 { get { return Field<int>(0x1D8); } }
	public int x1DC { get { return Field<int>(0x1DC); } }
	public int x1E0 { get { return Field<int>(0x1E0); } }
	public int x1E4 { get { return Field<int>(0x1E4); } }
	public int x1E8 { get { return Field<int>(0x1E8); } }
	public int x1EC { get { return Field<int>(0x1EC); } }
	public int x1F0 { get { return Field<int>(0x1F0); } }
	public int x1F4 { get { return Field<int>(0x1F4); } }
	public int x1F8 { get { return Field<int>(0x1F8); } }
	public int x1FC { get { return Field<int>(0x1FC); } }
	public int x200 { get { return Field<int>(0x200); } }
	public int x204 { get { return Field<int>(0x204); } }
	public int x208 { get { return Field<int>(0x208); } }
	public int x20C { get { return Field<int>(0x20C); } }
	public int x210 { get { return Field<int>(0x210); } }
	public int x214 { get { return Field<int>(0x214); } }
	public int x218 { get { return Field<int>(0x218); } }
	public int x21C { get { return Field<int>(0x21C); } }
	public int x220 { get { return Field<int>(0x220); } }
	public int x224 { get { return Field<int>(0x224); } }
	public int x228 { get { return Field<int>(0x228); } }
	public int x22C { get { return Field<int>(0x22C); } }
	public int x230 { get { return Field<int>(0x230); } }
	public int x234 { get { return Field<int>(0x234); } }
	public int x238 { get { return Field<int>(0x238); } }
	public int x23C { get { return Field<int>(0x23C); } }
	public int x240 { get { return Field<int>(0x240); } }
	public int x244 { get { return Field<int>(0x244); } }
	public int x248 { get { return Field<int>(0x248); } }
	public int x24C { get { return Field<int>(0x24C); } }
	public int x250 { get { return Field<int>(0x250); } }
	public int x254 { get { return Field<int>(0x254); } }
	public int x258 { get { return Field<int>(0x258); } }
	public int x25C { get { return Field<int>(0x25C); } }
	public int x260 { get { return Field<int>(0x260); } }
	public int x264 { get { return Field<int>(0x264); } }
	public int x268 { get { return Field<int>(0x268); } }
	public int x26C { get { return Field<int>(0x26C); } }
	public int x270 { get { return Field<int>(0x270); } }
	public int x274 { get { return Field<int>(0x274); } }
	public int x278 { get { return Field<int>(0x278); } }
	public int x27C { get { return Field<int>(0x27C); } }
	public int x280 { get { return Field<int>(0x280); } }
	public int x284 { get { return Field<int>(0x284); } }
	public int x288 { get { return Field<int>(0x288); } }
	public int x28C { get { return Field<int>(0x28C); } }
	public int x290 { get { return Field<int>(0x290); } }
	public int x294 { get { return Field<int>(0x294); } }
	public int x298 { get { return Field<int>(0x298); } }
	public int x29C { get { return Field<int>(0x29C); } }
	public int x2A0 { get { return Field<int>(0x2A0); } }
	public int x2A4 { get { return Field<int>(0x2A4); } }
	public int x2A8 { get { return Field<int>(0x2A8); } }
	public int x2AC { get { return Field<int>(0x2AC); } }
	public int x2B0 { get { return Field<int>(0x2B0); } }
	public int x2B4 { get { return Field<int>(0x2B4); } }
	public int x2B8 { get { return Field<int>(0x2B8); } }
	public int x2BC { get { return Field<int>(0x2BC); } }
	public int x2C0 { get { return Field<int>(0x2C0); } }
	public int x2C4 { get { return Field<int>(0x2C4); } }
	public int x2C8 { get { return Field<int>(0x2C8); } }
	public int x2CC { get { return Field<int>(0x2CC); } }
	public int x2D0 { get { return Field<int>(0x2D0); } }
	public int x2D4 { get { return Field<int>(0x2D4); } }
	public int x2D8 { get { return Field<int>(0x2D8); } }
	public int x2DC { get { return Field<int>(0x2DC); } }
	public int x2E0 { get { return Field<int>(0x2E0); } }
	public int x2E4 { get { return Field<int>(0x2E4); } }
	public int x2E8 { get { return Field<int>(0x2E8); } }
	public int x2EC { get { return Field<int>(0x2EC); } }
	public int x2F0 { get { return Field<int>(0x2F0); } }
	public int x2F4 { get { return Field<int>(0x2F4); } }
	public int x2F8 { get { return Field<int>(0x2F8); } }
	public int x2FC { get { return Field<int>(0x2FC); } }
	public int x300 { get { return Field<int>(0x300); } }
	public int x304 { get { return Field<int>(0x304); } }
	public int x308 { get { return Field<int>(0x308); } }
	public int x30C { get { return Field<int>(0x30C); } }
	public int x310 { get { return Field<int>(0x310); } }
	public int x314 { get { return Field<int>(0x314); } }
	public int x318 { get { return Field<int>(0x318); } }
	public int x31C { get { return Field<int>(0x31C); } }
	public int x320 { get { return Field<int>(0x320); } }
	public int x324 { get { return Field<int>(0x324); } }
	public int x328 { get { return Field<int>(0x328); } }
	public int x32C { get { return Field<int>(0x32C); } }
	public int x330 { get { return Field<int>(0x330); } }
	public int x334 { get { return Field<int>(0x334); } }
	public int x338 { get { return Field<int>(0x338); } }
	public int x33C { get { return Field<int>(0x33C); } }
	public int x340 { get { return Field<int>(0x340); } }
	public int x344 { get { return Field<int>(0x344); } }
	public int x348 { get { return Field<int>(0x348); } }
	public int x34C { get { return Field<int>(0x34C); } }
	public int x350 { get { return Field<int>(0x350); } }
	public int x354 { get { return Field<int>(0x354); } }
	public int x358 { get { return Field<int>(0x358); } }
	public int x35C { get { return Field<int>(0x35C); } }
	public int x360 { get { return Field<int>(0x360); } }
	public int x364 { get { return Field<int>(0x364); } }
	public int x368 { get { return Field<int>(0x368); } }
	public int x36C { get { return Field<int>(0x36C); } }
	public int x370 { get { return Field<int>(0x370); } }
	public int x374 { get { return Field<int>(0x374); } }
	public int x378 { get { return Field<int>(0x378); } }
	public int x37C { get { return Field<int>(0x37C); } }
	public int x380 { get { return Field<int>(0x380); } }
	public int x384 { get { return Field<int>(0x384); } }
	public int x388 { get { return Field<int>(0x388); } }
	public int x38C { get { return Field<int>(0x38C); } }
	public int x390 { get { return Field<int>(0x390); } }
	public int x394 { get { return Field<int>(0x394); } }
	public int x398 { get { return Field<int>(0x398); } }
	public int x39C { get { return Field<int>(0x39C); } }
	public int x3A0 { get { return Field<int>(0x3A0); } }
	public int x3A4 { get { return Field<int>(0x3A4); } }
	public int x3A8 { get { return Field<int>(0x3A8); } }
	public int x3AC { get { return Field<int>(0x3AC); } }
	public int x3B0 { get { return Field<int>(0x3B0); } }
	public int x3B4 { get { return Field<int>(0x3B4); } }
	public int x3B8 { get { return Field<int>(0x3B8); } }
	public int x3BC { get { return Field<int>(0x3BC); } }
	public int x3C0 { get { return Field<int>(0x3C0); } }
	public int x3C4 { get { return Field<int>(0x3C4); } }
	public int x3C8 { get { return Field<int>(0x3C8); } }
	public int x3CC { get { return Field<int>(0x3CC); } }
	public int x3D0 { get { return Field<int>(0x3D0); } }
	public int x3D4 { get { return Field<int>(0x3D4); } }
	public int x3D8 { get { return Field<int>(0x3D8); } }
	public int x3DC { get { return Field<int>(0x3DC); } }
	public int x3E0 { get { return Field<int>(0x3E0); } }
	public int x3E4 { get { return Field<int>(0x3E4); } }
	public int x3E8 { get { return Field<int>(0x3E8); } }
	public int x3EC { get { return Field<int>(0x3EC); } }
	public int x3F0 { get { return Field<int>(0x3F0); } }
	public int x3F4 { get { return Field<int>(0x3F4); } }
	public int x3F8 { get { return Field<int>(0x3F8); } }
	public int x3FC { get { return Field<int>(0x3FC); } }
	public int x404 { get { return Field<int>(0x404); } }
	public int x408 { get { return Field<int>(0x408); } }
	public int x40C { get { return Field<int>(0x40C); } }
	public int x410 { get { return Field<int>(0x410); } }
	public int x414 { get { return Field<int>(0x414); } }
	public int x418 { get { return Field<int>(0x418); } }
	public int x41C { get { return Field<int>(0x41C); } }
	public int x420 { get { return Field<int>(0x420); } }
	public int x424 { get { return Field<int>(0x424); } }
	public int x428 { get { return Field<int>(0x428); } }
	public int x42C { get { return Field<int>(0x42C); } }
	public int x430 { get { return Field<int>(0x430); } }
	public int x434 { get { return Field<int>(0x434); } }
	public int x438 { get { return Field<int>(0x438); } }
	public int x43C { get { return Field<int>(0x43C); } }
	public int x440 { get { return Field<int>(0x440); } }
	public int x444 { get { return Field<int>(0x444); } }
	public int x448 { get { return Field<int>(0x448); } }
	public int x44C { get { return Field<int>(0x44C); } }
	public int x450 { get { return Field<int>(0x450); } }
	public int x454 { get { return Field<int>(0x454); } }
	public int x458 { get { return Field<int>(0x458); } }
	public int x45C { get { return Field<int>(0x45C); } }
	public int x460 { get { return Field<int>(0x460); } }
	public int x464 { get { return Field<int>(0x464); } }
	public int x468 { get { return Field<int>(0x468); } }
	public int x46C { get { return Field<int>(0x46C); } }
	public int x470 { get { return Field<int>(0x470); } }
	public int x474 { get { return Field<int>(0x474); } }
}
