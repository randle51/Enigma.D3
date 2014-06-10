using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3
{
	public class CameraData : MemoryObject
	{
		public const int SizeOf = 0x230; // 560

		public CameraData(ProcessMemory memory, int address)
			: base(memory, address) { }

		public int x000_Neg1_ObserverSnoId { get { return Field<int>(0x000); } }
		public float x004_StructStart_Min1124Bytes { get { return Field<float>(0x004); } }
		public float x008 { get { return Field<float>(0x008); } }
		public float x00C { get { return Field<float>(0x00C); } }
		public float x010 { get { return Field<float>(0x010); } }
		public float x014_X { get { return Field<float>(0x014); } }
		public float x018_Y { get { return Field<float>(0x018); } }
		public float x01C_Z { get { return Field<float>(0x01C); } }
		public int x020 { get { return Field<int>(0x020); } }
		public int x024 { get { return Field<int>(0x024); } }
		public float x028 { get { return Field<float>(0x028); } }
		public float x02C { get { return Field<float>(0x02C); } }
		public float x030 { get { return Field<float>(0x030); } }
		public float x034 { get { return Field<float>(0x034); } }
		public float x038 { get { return Field<float>(0x038); } }
		public int _x03C { get { return Field<int>(0x03C); } }
		public int x040 { get { return Field<int>(0x040); } }
		public float x044_AspectRatio { get { return Field<float>(0x044); } }
		public float x048 { get { return Field<float>(0x048); } }
		public float x04C { get { return Field<float>(0x04C); } }
		public float x050 { get { return Field<float>(0x050); } }
		public float x054 { get { return Field<float>(0x054); } }
		public int _x058 { get { return Field<int>(0x058); } }
		public int _x05C { get { return Field<int>(0x05C); } }
		public int _x060 { get { return Field<int>(0x060); } }
		public int _x064 { get { return Field<int>(0x064); } }
		public int _x068 { get { return Field<int>(0x068); } }
		public int _x06C { get { return Field<int>(0x06C); } }
		public int _x070 { get { return Field<int>(0x070); } }
		public int _x074 { get { return Field<int>(0x074); } }
		public int _x078 { get { return Field<int>(0x078); } }
		public float x07C { get { return Field<float>(0x07C); } }
		public float x080 { get { return Field<float>(0x080); } }
		public float x084 { get { return Field<float>(0x084); } }
		public float x088 { get { return Field<float>(0x088); } }
		public float x08C_X { get { return Field<float>(0x08C); } }
		public float x090_Y { get { return Field<float>(0x090); } }
		public float x094_Z { get { return Field<float>(0x094); } }
		public float x098_X { get { return Field<float>(0x098); } }
		public float x09C_Y { get { return Field<float>(0x09C); } }
		public float x0A0_Z { get { return Field<float>(0x0A0); } }
		public float x0A4_X { get { return Field<float>(0x0A4); } }
		public float x0A8_Y { get { return Field<float>(0x0A8); } }
		public float x0AC_Z { get { return Field<float>(0x0AC); } }
		public float x0B0_X { get { return Field<float>(0x0B0); } }
		public float x0B4_Y { get { return Field<float>(0x0B4); } }
		public float x0B8_Z { get { return Field<float>(0x0B8); } }
		public float x0BC { get { return Field<float>(0x0BC); } }
		public float x0C0 { get { return Field<float>(0x0C0); } }
		public float x0C4 { get { return Field<float>(0x0C4); } }
		public float x0C8 { get { return Field<float>(0x0C8); } }
		public float x0CC { get { return Field<float>(0x0CC); } }
		public float x0D0 { get { return Field<float>(0x0D0); } }
		public float x0D4 { get { return Field<float>(0x0D4); } }
		public float x0D8 { get { return Field<float>(0x0D8); } }
		public float x0DC { get { return Field<float>(0x0DC); } }
		public float x0E0 { get { return Field<float>(0x0E0); } }
		public float x0E4 { get { return Field<float>(0x0E4); } }
		public float x0E8 { get { return Field<float>(0x0E8); } }
		public float _x0EC { get { return Field<float>(0x0EC); } }
		public float _x0F0 { get { return Field<float>(0x0F0); } }
		public float _x0F4 { get { return Field<float>(0x0F4); } }
		public float _x0F8 { get { return Field<float>(0x0F8); } }
		public float _x0FC { get { return Field<float>(0x0FC); } }
		public float _x100 { get { return Field<float>(0x100); } }
		public float _x104 { get { return Field<float>(0x104); } }
		public float _x108 { get { return Field<float>(0x108); } }
		public float _x10C { get { return Field<float>(0x10C); } }
		public float _x110 { get { return Field<float>(0x110); } }
		public float _x114 { get { return Field<float>(0x114); } }
		public float _x118 { get { return Field<float>(0x118); } }
		public float _x11C { get { return Field<float>(0x11C); } }
		public float _x120 { get { return Field<float>(0x120); } }
		public float _x124 { get { return Field<float>(0x124); } }
		public float _x128 { get { return Field<float>(0x128); } }
		public float _x12C { get { return Field<float>(0x12C); } }
		public float _x130 { get { return Field<float>(0x130); } }
		public float _x134 { get { return Field<float>(0x134); } }
		public float _x138 { get { return Field<float>(0x138); } }
		public float _x13C { get { return Field<float>(0x13C); } }
		public float _x140 { get { return Field<float>(0x140); } }
		public float _x144 { get { return Field<float>(0x144); } }
		public float _x148 { get { return Field<float>(0x148); } }
		public Struct x14C_StructStart_Min64Bytes { get { return Field<Struct>(0x14C); } }
		//public float _x150 { get { return Field<float>(0x150); } }
		//public int _x154 { get { return Field<int>(0x154); } }
		//public int _x158 { get { return Field<int>(0x158); } }
		//public int _x15C { get { return Field<int>(0x15C); } }
		//public int _x160 { get { return Field<int>(0x160); } }
		//public int _x164 { get { return Field<int>(0x164); } }
		//public int _x168 { get { return Field<int>(0x168); } }
		//public int _x16C { get { return Field<int>(0x16C); } }
		//public int _x170 { get { return Field<int>(0x170); } }
		//public int _x174 { get { return Field<int>(0x174); } }
		//public int _x178 { get { return Field<int>(0x178); } }
		//public int _x17C { get { return Field<int>(0x17C); } }
		//public int _x180 { get { return Field<int>(0x180); } }
		//public int _x184 { get { return Field<int>(0x184); } }
		//public int _x188 { get { return Field<int>(0x188); } }
		public Struct x18C_StructStart_Min64Bytes { get { return Field<Struct>(0x18C); } }
		//public int _x190 { get { return Field<int>(0x190); } }
		//public int _x194 { get { return Field<int>(0x194); } }
		//public int _x198 { get { return Field<int>(0x198); } }
		//public int _x19C { get { return Field<int>(0x19C); } }
		//public float _x1A0 { get { return Field<float>(0x1A0); } }
		//public int _x1A4 { get { return Field<int>(0x1A4); } }
		//public int _x1A8 { get { return Field<int>(0x1A8); } }
		//public int _x1AC { get { return Field<int>(0x1AC); } }
		//public int _x1B0 { get { return Field<int>(0x1B0); } }
		//public float _x1B4 { get { return Field<float>(0x1B4); } }
		//public float _x1B8 { get { return Field<float>(0x1B8); } }
		//public int _x1BC { get { return Field<int>(0x1BC); } }
		//public int _x1C0 { get { return Field<int>(0x1C0); } }
		//public float _x1C4 { get { return Field<float>(0x1C4); } }
		//public int _x1C8 { get { return Field<int>(0x1C8); } }
		public Struct _x1CC { get { return Field<Struct>(0x1CC); } }
		//public int _x1D0 { get { return Field<int>(0x1D0); } }
		//public int _x1D4 { get { return Field<int>(0x1D4); } }
		//public int _x1D8 { get { return Field<int>(0x1D8); } }
		//public int _x1DC { get { return Field<int>(0x1DC); } }
		//public float _x1E0 { get { return Field<float>(0x1E0); } }
		//public int _x1E4 { get { return Field<int>(0x1E4); } }
		//public int _x1E8 { get { return Field<int>(0x1E8); } }
		//public int _x1EC { get { return Field<int>(0x1EC); } }
		//public int _x1F0 { get { return Field<int>(0x1F0); } }
		//public float _x1F4 { get { return Field<float>(0x1F4); } }
		//public float _x1F8 { get { return Field<float>(0x1F8); } }
		//public int _x1FC { get { return Field<int>(0x1FC); } }
		//public int _x200 { get { return Field<int>(0x200); } }
		//public float _x204 { get { return Field<float>(0x204); } }
		//public int _x208 { get { return Field<int>(0x208); } }
		public float x20C_StructStart_Min16Bytes { get { return Field<float>(0x20C); } }
		public float x210 { get { return Field<float>(0x210); } }
		public float x214 { get { return Field<float>(0x214); } }
		public float x218 { get { return Field<float>(0x218); } }
		public float x21C { get { return Field<float>(0x21C); } }
		public float x220 { get { return Field<float>(0x220); } }
		public float x224 { get { return Field<float>(0x224); } }
		public int _x228 { get { return Field<int>(0x228); } }
		public int _x22C { get { return Field<int>(0x22C); } }

		public class Struct : MemoryObject
		{
			public const int SizeOf = 0x40;

			public Struct(ProcessMemory memory, int address)
				: base(memory, address) { }

			public float x00 { get { return Field<float>(0x00); } }
			public float x04 { get { return Field<float>(0x04); } }
			public float x08 { get { return Field<float>(0x08); } }
			public float x0C { get { return Field<float>(0x0C); } }
			public float x10 { get { return Field<float>(0x10); } }
			public float x14 { get { return Field<float>(0x14); } }
			public float x18 { get { return Field<float>(0x18); } }
			public float x1C { get { return Field<float>(0x1C); } }
			public float x20 { get { return Field<float>(0x20); } }
			public float x24 { get { return Field<float>(0x24); } }
			public float x28 { get { return Field<float>(0x28); } }
			public float x2C { get { return Field<float>(0x2C); } }
			public float x30_X { get { return Field<float>(0x30); } }
			public float x34_Y { get { return Field<float>(0x34); } }
			public float x38_Z { get { return Field<float>(0x38); } }
			public float x3C { get { return Field<float>(0x3C); } }
		}
	}

	public class CameraManager : MemoryObject
	{
		// 2.0.5.24017
		public const int SizeOf = 0x13BC; // 5052

		public CameraManager(ProcessMemory memory, int address)
			: base(memory, address) { }

		public CameraData[] x0000_CameraData { get { return Field<CameraData>(0x0000, 9); } }
		public int x13B0_Index { get { return Field<int>(0x13B0); } }
		public int x13B4_Count { get { return Field<int>(0x13B4); } }
		public float x13B8 { get { return Field<float>(0x13B8); } }
	}
}
