using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.Legacy
{
	public class GameAccount : MemoryObject
	{
		public const int SizeOf = 0x1F8; // 1.0.8.16603

		public GameAccount(ProcessMemory memory, int address)
			: base(memory, address) { }

		public int x000_VTable__ { get { return Field<int>(0x000); } }
		public int x004_unk { get { return Field<int>(0x004); } }
		public long x008_Int64 { get { return Field<long>(0x008); } }
		public long x010_Int64 { get { return Field<long>(0x010); } }
		public int x018_unk { get { return Field<int>(0x018); } }
		public int x01C_unk { get { return Field<int>(0x01C); } }
		public int x020_unk { get { return Field<int>(0x020); } }
		public int x024_unk { get { return Field<int>(0x024); } }
		public int x028_unk { get { return Field<int>(0x028); } }
		public int x02C_unk { get { return Field<int>(0x02C); } }
		public int x030_unk { get { return Field<int>(0x030); } }
		public int x034_unk { get { return Field<int>(0x034); } }
		public int x038_unk { get { return Field<int>(0x038); } }
		public int x03C_unk { get { return Field<int>(0x03C); } }
		public int x040_unk { get { return Field<int>(0x040); } }
		public int x044_unk { get { return Field<int>(0x044); } }
		public int x048_unk { get { return Field<int>(0x048); } }
		public int x04C_unk { get { return Field<int>(0x04C); } }
		public int x050_unk { get { return Field<int>(0x050); } }
		public int x054_unk { get { return Field<int>(0x054); } }
		public int x058_PtrToCharacterAllocator { get { return Field<int>(0x058); } }
		public int x05C_unk { get { return Field<int>(0x05C); } }
		public int x060 { get { return Field<int>(0x060); } }
		public int x064_unk { get { return Field<int>(0x064); } }
		public int x068_unk { get { return Field<int>(0x068); } }
		public int x06C_unk { get { return Field<int>(0x06C); } }
		public int x070_Ptr { get { return Field<int>(0x070); } }
		public int x074_unk { get { return Field<int>(0x074); } }
		public int x078_unk { get { return Field<int>(0x078); } }
		public int x07C_unk { get { return Field<int>(0x07C); } }
		public int x080_unk { get { return Field<int>(0x080); } }
		public int x084_unk { get { return Field<int>(0x084); } }
		public int x088_unk { get { return Field<int>(0x088); } }
		public int x08C_unk { get { return Field<int>(0x08C); } }
		public int x090_unk { get { return Field<int>(0x090); } }
		public int x094_unk { get { return Field<int>(0x094); } }
		public int x098 { get { return Field<int>(0x098); } }
		public int x09C_NumberOfCharacters { get { return Field<int>(0x09C); } }
		public Allocator x0A0_CharacterAllocator { get { return Field<Allocator>(0x0A0); } }
		public int x0BC_unk { get { return Field<int>(0x0BC); } }
		public int x0C0_unk { get { return Field<int>(0x0C0); } }
		public int x0C4_unk { get { return Field<int>(0x0C4); } }
		public int x0C8_unk { get { return Field<int>(0x0C8); } }
		public int x0CC_sub_F80EA0 { get { return Field<int>(0x0CC); } }
		public int x0D0_unk { get { return Field<int>(0x0D0); } }
		public int x0D4_unk { get { return Field<int>(0x0D4); } }
		public int x0D8_unk { get { return Field<int>(0x0D8); } }
		public int x0DC_unk { get { return Field<int>(0x0DC); } }
		public int x0E0_Ptr { get { return Field<int>(0x0E0); } }
		public int x0E4_unk { get { return Field<int>(0x0E4); } }
		public int x0E8_unk { get { return Field<int>(0x0E8); } }
		public int x0EC_unk { get { return Field<int>(0x0EC); } }
		public int x0F0_unk { get { return Field<int>(0x0F0); } }
		public int x0F4_PtrTo_x104 { get { return Field<int>(0x0F4); } }
		public int x0F8_unk { get { return Field<int>(0x0F8); } }
		public int x0FC_unk { get { return Field<int>(0x0FC); } }
		public int x100_unk { get { return Field<int>(0x100); } }
		public int x104_unk { get { return Field<int>(0x104); } }
		public int x108_unk { get { return Field<int>(0x108); } }
		public int x10C_unk { get { return Field<int>(0x10C); } }
		public int x110_unk { get { return Field<int>(0x110); } }
		public int x114_unk { get { return Field<int>(0x114); } }
		public int x118_unk { get { return Field<int>(0x118); } }
		public int x11C_unk { get { return Field<int>(0x11C); } }
		public int x120_unk { get { return Field<int>(0x120); } }
		public int x124_unk { get { return Field<int>(0x124); } }
		public int x128_unk { get { return Field<int>(0x128); } }
		public int x12C_unk { get { return Field<int>(0x12C); } }
		public int x130_unk { get { return Field<int>(0x130); } }
		public int x134_unk { get { return Field<int>(0x134); } }
		public int x138_unk { get { return Field<int>(0x138); } }
		public int x13C_unk { get { return Field<int>(0x13C); } }
		public int x140_unk { get { return Field<int>(0x140); } }
		public int x144_unk { get { return Field<int>(0x144); } }
		public int x148_unk { get { return Field<int>(0x148); } }
		public int x14C_unk { get { return Field<int>(0x14C); } }
		public long x150_Int64 { get { return Field<long>(0x150); } }
		public long x158_Int64 { get { return Field<long>(0x158); } }
		public long x160_Int64 { get { return Field<long>(0x160); } }
		public long x168_Int64 { get { return Field<long>(0x168); } }
		public int x16C { get { return Field<int>(0x16C); } }
		public int x170_unk { get { return Field<int>(0x170); } }
		public int x174 { get { return Field<int>(0x174); } }
		public int x178 { get { return Field<int>(0x178); } }
		public int x17C_unk { get { return Field<int>(0x17C); } }
		public int x180_unk { get { return Field<int>(0x180); } }
		public int x184_unk { get { return Field<int>(0x184); } }
		public int x188_unk { get { return Field<int>(0x188); } }
		public int x18C_unk { get { return Field<int>(0x18C); } }
		public int x190_unk { get { return Field<int>(0x190); } }
		public int x194_unk { get { return Field<int>(0x194); } }
		public int x198_unk { get { return Field<int>(0x198); } }
		public int x19C_unk { get { return Field<int>(0x19C); } }
		public int x1A0_unk { get { return Field<int>(0x1A0); } }
		public int x1A4_unk { get { return Field<int>(0x1A4); } }
		public int x1A8_unk { get { return Field<int>(0x1A8); } }
		public int x1AC_unk { get { return Field<int>(0x1AC); } }
		public int x1B0_unk { get { return Field<int>(0x1B0); } }
		public int x1B4_unk { get { return Field<int>(0x1B4); } }
		public int x1B8_unk { get { return Field<int>(0x1B8); } }
		public int x1BC_unk { get { return Field<int>(0x1BC); } }
		public int x1C0_unk { get { return Field<int>(0x1C0); } }
		public int x1C4_unk { get { return Field<int>(0x1C4); } }
		public int x1C8_unk { get { return Field<int>(0x1C8); } }
		public int x1CC_unk { get { return Field<int>(0x1CC); } }
		public int x1D0_unk { get { return Field<int>(0x1D0); } }
		public int x1D4_unk { get { return Field<int>(0x1D4); } }
		public int x1D8_unk { get { return Field<int>(0x1D8); } }
		public int x1DC_unk { get { return Field<int>(0x1DC); } }
		public int x1E0_unk { get { return Field<int>(0x1E0); } }
		public int x1E4 { get { return Field<int>(0x1E4); } }
		public int x1E8_unk { get { return Field<int>(0x1E8); } }
		public int x1EC_unk { get { return Field<int>(0x1EC); } }
		public int x1F0_Ptr_Undelete__ { get { return Field<int>(0x1F0); } }
	}
}
