using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3
{
	public class Quest : MemoryObject
	{
		// 2.0.4.23119
		public const int SizeOf = 0x164;

		public Quest(MemoryBase memory, int address)
			: base(memory, address) { }

		public int x000_QuestSnoId { get { return Field<int>(0x000); } }
		public int x004_CreationTick { get { return Field<int>(0x004); } }
		public int x008 { get { return Field<int>(0x008); } }
		public int x00C_AcdId { get { return Field<int>(0x00C); } }
		public float x010_QuestMeterProgress_ { get { return Field<float>(0x010); } }
		public int x014_QuestState { get { return Field<int>(0x014); } } // 0 = NotStarted? 1 = Started? 2 = Completed?
		public int x018_QuestStep { get { return Field<int>(0x018); } }
		public int x01C_Neg1 { get { return Field<int>(0x01C); } }
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
		public int x070_StructStart_ { get { return Field<int>(0x070); } }
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
		public int x160_Neg1 { get { return Field<int>(0x160); } }
	}
}
