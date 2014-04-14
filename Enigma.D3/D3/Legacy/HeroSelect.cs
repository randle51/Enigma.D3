using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.Legacy
{
	public class HeroSelect : MemoryObject
	{
		public const int SizeOf = 2168; // 1.0.8.16603 : [0x00BD4200] CHeroSelect::Initialize

		public HeroSelect(ProcessMemory memory, int address)
			: base(memory, address) { }

		public int x000_VTable_14C7E38 { get { return Field<int>(0x000); } }
		public int x004_Ptr2024Bytes { get { return Field<int>(0x004); } }
		public int x008_Ptr3056Bytes { get { return Field<int>(0x008); } }
		public int x00C_Ptr1672Bytes { get { return Field<int>(0x00C); } }
		public int x010_Ptr336Bytes { get { return Field<int>(0x010); } }
		public int x014_Ptr1688Bytes { get { return Field<int>(0x014); } }
		public int x018_Ptr128Bytes { get { return Field<int>(0x018); } }
		public int x01C_Ptr56Bytes { get { return Field<int>(0x01C); } }
		public int x020_Ptr176Bytes { get { return Field<int>(0x020); } }
		public int x024_Ptr76Bytes { get { return Field<int>(0x024); } }
		public int _x028_Ptr { get { return Field<int>(0x028); } }
		public int _x02C { get { return Field<int>(0x02C); } }
		public int _x030 { get { return Field<int>(0x030); } }
		public int _x034 { get { return Field<int>(0x034); } }
		public int _x038 { get { return Field<int>(0x038); } }
		public int _x03C_Bool_ { get { return Field<int>(0x03C); } }
		public int _x040 { get { return Field<int>(0x040); } }
		public int _x044 { get { return Field<int>(0x044); } }
		public int _x048 { get { return Field<int>(0x048); } }
		public int _x04C { get { return Field<int>(0x04C); } }
		public int _x050 { get { return Field<int>(0x050); } }
		public int _x054 { get { return Field<int>(0x054); } }
		public int _x058 { get { return Field<int>(0x058); } }
		public int _x05C { get { return Field<int>(0x05C); } }
		public int _x060 { get { return Field<int>(0x060); } }
		public int _x064_Ptr { get { return Field<int>(0x064); } }
		public int _x068 { get { return Field<int>(0x068); } }
		public int _x06C_NumberOf_ { get { return Field<int>(0x06C); } }
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
		public GameAccount _x09C_GameAccount { get { return Dereference<GameAccount>(0x09C); } }
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
		public int _x150_unk { get { return Field<int>(0x150); } }
		public int _x154_unk { get { return Field<int>(0x154); } }
		public int _x158_unk { get { return Field<int>(0x158); } }
		public int _x15C_unk { get { return Field<int>(0x15C); } }
		public int _x160_unk { get { return Field<int>(0x160); } }
		public int _x164 { get { return Field<int>(0x164); } }
		public int _x168_unk { get { return Field<int>(0x168); } }
		public int _x16C { get { return Field<int>(0x16C); } }
		public int _x170 { get { return Field<int>(0x170); } }
		public int _x174_unk { get { return Field<int>(0x174); } }
		public int _x178_unk { get { return Field<int>(0x178); } }
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
		public BattleNetPlatform x1C0_PtrBNetPlatform { get { return Dereference<BattleNetPlatform>(0x1C0); } }
		public int _x1C4 { get { return Field<int>(0x1C4); } }
		public int x1C8_Struct172BytesOrMore { get { return Field<int>(0x1C8); } }
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
		public int _x210 { get { return Field<int>(0x210); } }
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
		public int x278_BNetPlatform_SocketCode_ { get { return Field<int>(0x278); } }
		public int x27C { get { return Field<int>(0x27C); } }
		public int x280 { get { return Field<int>(0x280); } }
		public int x284 { get { return Field<int>(0x284); } }
		public int x288_PtrRefString { get { return Field<int>(0x288); } }
		public int _x28C { get { return Field<int>(0x28C); } }
		public int _x290 { get { return Field<int>(0x290); } }
		public int x294_PtrRefString { get { return Field<int>(0x294); } }
		public int _x298 { get { return Field<int>(0x298); } }
		public int _x29C { get { return Field<int>(0x29C); } }
		public int x2A0 { get { return Field<int>(0x2A0); } }
		public int x2A4 { get { return Field<int>(0x2A4); } }
		public int x2A8_ByteOrFlags { get { return Field<int>(0x2A8); } }
		public int x2AC { get { return Field<int>(0x2AC); } }
		public int x2B0 { get { return Field<int>(0x2B0); } }
		public int x2B4 { get { return Field<int>(0x2B4); } }
		public int x2B8 { get { return Field<int>(0x2B8); } }
		public int x2BC { get { return Field<int>(0x2BC); } }
		public int x2C0 { get { return Field<int>(0x2C0); } }
		public int x2C4 { get { return Field<int>(0x2C4); } }
		public HeroSelectStruct x2C8_Struct104Bytes { get { return Field<HeroSelectStruct>(0x2C8); } }
		public int x330_IsLoaded_2C8 { get { return Field<int>(0x330); } }
		public int _x334 { get { return Field<int>(0x334); } }
		public HeroSelectStruct x338_Struct104Bytes { get { return Field<HeroSelectStruct>(0x338); } }
		public int x3A0_IsLoaded_338 { get { return Field<int>(0x3A0); } }
		public int _x3A4 { get { return Field<int>(0x3A4); } }
		public HeroSelectStruct x3A8_Struct104Bytes { get { return Field<HeroSelectStruct>(0x3A8); } }
		public int x410_IsLoaded_3A8 { get { return Field<int>(0x410); } }
		public int _x414 { get { return Field<int>(0x414); } }
		public HeroSelectStruct x418_Struct104Bytes { get { return Field<HeroSelectStruct>(0x418); } }
		public int x480_IsLoaded_418 { get { return Field<int>(0x480); } }
		public int _x484 { get { return Field<int>(0x484); } }
		public HeroSelectStruct x488_Struct104Bytes { get { return Field<HeroSelectStruct>(0x488); } }
		public int x4F0_IsLoaded_488 { get { return Field<int>(0x4F0); } }
		public int _x4F4 { get { return Field<int>(0x4F4); } }
		public HeroSelectStruct x4F8_Struct104Bytes { get { return Field<HeroSelectStruct>(0x4F8); } }
		public int x560_IsLoaded_4F8 { get { return Field<int>(0x560); } }
		public int _x564 { get { return Field<int>(0x564); } }
		public HeroSelectStruct x568_Struct104Bytes { get { return Field<HeroSelectStruct>(0x568); } }
		public int x5D0_IsLoaded_568 { get { return Field<int>(0x5D0); } }
		public int _x5D4 { get { return Field<int>(0x5D4); } }
		public HeroSelectStruct x5D8_Struct104Bytes { get { return Field<HeroSelectStruct>(0x5D8); } }
		public int x640_IsLoaded_5D8 { get { return Field<int>(0x640); } }
		public int _x644 { get { return Field<int>(0x644); } }
		public HeroSelectStruct x648_Struct104Bytes { get { return Field<HeroSelectStruct>(0x648); } }
		public int x6B0_IsLoaded_648 { get { return Field<int>(0x6B0); } }
		public int _x6B4 { get { return Field<int>(0x6B4); } }
		public HeroSelectStruct x6B8_Struct104Bytes { get { return Field<HeroSelectStruct>(0x6B8); } }
		public int x720_IsLoaded_6B8 { get { return Field<int>(0x720); } }
		public int _x724 { get { return Field<int>(0x724); } }
		public HeroSelectStruct x728_Struct104Bytes { get { return Field<HeroSelectStruct>(0x728); } }
		public int x790_IsLoaded_728 { get { return Field<int>(0x790); } }
		public int _x794 { get { return Field<int>(0x794); } }
		public HeroSelectStruct x798_Struct104Bytes { get { return Field<HeroSelectStruct>(0x798); } }
		public int x800_IsLoaded_798 { get { return Field<int>(0x800); } }
		public int _x804 { get { return Field<int>(0x804); } }
		public HeroSelectStruct x808_Struct104Bytes { get { return Field<HeroSelectStruct>(0x808); } }
		public int x870_IsLoaded_808 { get { return Field<int>(0x870); } }
		public int _x874 { get { return Field<int>(0x874); } }

		public class HeroSelectStruct : MemoryObject
		{
			public const int SizeOf = 104; // Uncertain, could be 100

			public HeroSelectStruct(ProcessMemory memory, int address)
				: base(memory, address) { }

			public Allocator x00_PtrAllocatorX48 { get { return Dereference<Allocator>(0x00); } }
			public int _x04 { get { return Field<int>(0x04); } }
			public int x08_Struct { get { return Field<int>(0x08); } }
			public int _x0C { get { return Field<int>(0x0C); } }
			public int x10 { get { return Field<int>(0x10); } }
			public int _x14 { get { return Field<int>(0x14); } }
			public int x18 { get { return Field<int>(0x18); } }
			public int x1C { get { return Field<int>(0x1C); } }
			public int x20 { get { return Field<int>(0x20); } }
			public int x24_Flags { get { return Field<int>(0x24); } }
			public int x28 { get { return Field<int>(0x28); } }
			public int x2C { get { return Field<int>(0x2C); } }
			public int x30 { get { return Field<int>(0x30); } }
			public int _x34 { get { return Field<int>(0x34); } }
			public int _x38 { get { return Field<int>(0x38); } }
			public int _x3C { get { return Field<int>(0x3C); } }
			public int x40 { get { return Field<int>(0x40); } }
			public int x44 { get { return Field<int>(0x44); } }
			public Allocator x48_Allocator { get { return Field<Allocator>(0x48); } }
			public int _x64 { get { return Field<int>(0x64); } } // <-- Not sure if this is included
		}
	}
}
