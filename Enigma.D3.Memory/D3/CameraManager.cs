using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3
{
	public class CameraData : MemoryObject
	{
		public const int SizeOf = 0x230; // 560

		public int x000_Neg1_ObserverSnoId { get { return Read<int>(0x000); } }
		public int x004_Index { get { return Read<int>(0x004); } }
		public float x008_StructStart_Min1124Bytes { get { return Read<float>(0x008); } }
		public float x00C { get { return Read<float>(0x00C); } }
		public float x010 { get { return Read<float>(0x010); } }
		public float x014 { get { return Read<float>(0x014); } }
		public float x018_X { get { return Read<float>(0x018); } }
		public float x01C_Y { get { return Read<float>(0x01C); } }
		public float x020_Z { get { return Read<float>(0x020); } }
		public float x024 { get { return Read<float>(0x024); } }
		public int x028 { get { return Read<int>(0x028); } }
		public float x02C { get { return Read<float>(0x02C); } }
		public float x030 { get { return Read<float>(0x030); } }
		public float x034 { get { return Read<float>(0x034); } }
		public float x038 { get { return Read<float>(0x038); } }
		public float x03C { get { return Read<float>(0x03C); } }
		public int _x040 { get { return Read<int>(0x040); } }
		public int x044 { get { return Read<int>(0x044); } }
		public float x048_AspectRatio { get { return Read<float>(0x048); } }
		public float x04C { get { return Read<float>(0x04C); } }
		public float x050 { get { return Read<float>(0x050); } }
		public float x054 { get { return Read<float>(0x054); } }
		public float x058 { get { return Read<float>(0x058); } }
		public int _x05C { get { return Read<int>(0x05C); } }
		public int _x060 { get { return Read<int>(0x060); } }
		public int _x064 { get { return Read<int>(0x064); } }
		public int _x068 { get { return Read<int>(0x068); } }
		public int _x06C { get { return Read<int>(0x06C); } }
		public int _x070 { get { return Read<int>(0x070); } }
		public int _x074 { get { return Read<int>(0x074); } }
		public int _x078 { get { return Read<int>(0x078); } }
		public int _x07C { get { return Read<int>(0x07C); } }
		public float x080 { get { return Read<float>(0x080); } }
		public float x084 { get { return Read<float>(0x084); } }
		public float x088 { get { return Read<float>(0x088); } }
		public float x08C { get { return Read<float>(0x08C); } }
		public float x090_X { get { return Read<float>(0x090); } }
		public float x094_Y { get { return Read<float>(0x094); } }
		public float x098_Z { get { return Read<float>(0x098); } }
		public float x09C_X { get { return Read<float>(0x09C); } }
		public float x0A0_Y { get { return Read<float>(0x0A0); } }
		public float x0A4_Z { get { return Read<float>(0x0A4); } }
		public float x0A8_X { get { return Read<float>(0x0A8); } }
		public float x0AC_Y { get { return Read<float>(0x0AC); } }
		public float x0B0_Z { get { return Read<float>(0x0B0); } }
		public float x0B4_X { get { return Read<float>(0x0B4); } }
		public float x0B8_Y { get { return Read<float>(0x0B8); } }
		public float x0BC_Z { get { return Read<float>(0x0BC); } }
		public float x0C0 { get { return Read<float>(0x0C0); } }
		public float x0C4 { get { return Read<float>(0x0C4); } }
		public float x0C8 { get { return Read<float>(0x0C8); } }
		public float x0CC { get { return Read<float>(0x0CC); } }
		public float x0D0 { get { return Read<float>(0x0D0); } }
		public float x0D4 { get { return Read<float>(0x0D4); } }
		public float x0D8 { get { return Read<float>(0x0D8); } }
		public float x0DC { get { return Read<float>(0x0DC); } }
		public float x0E0 { get { return Read<float>(0x0E0); } }
		public float x0E4 { get { return Read<float>(0x0E4); } }
		public float x0E8 { get { return Read<float>(0x0E8); } }
		public float x0EC { get { return Read<float>(0x0EC); } }
		public float _x0F0 { get { return Read<float>(0x0F0); } }
		public float _x0F4 { get { return Read<float>(0x0F4); } }
		public float _x0F8 { get { return Read<float>(0x0F8); } }
		public float _x0FC { get { return Read<float>(0x0FC); } }
		public float _x100 { get { return Read<float>(0x100); } }
		public float _x104 { get { return Read<float>(0x104); } }
		public float _x108 { get { return Read<float>(0x108); } }
		public float _x10C { get { return Read<float>(0x10C); } }
		public float _x110 { get { return Read<float>(0x110); } }
		public float _x114 { get { return Read<float>(0x114); } }
		public float _x118 { get { return Read<float>(0x118); } }
		public float _x11C { get { return Read<float>(0x11C); } }
		public float _x120 { get { return Read<float>(0x120); } }
		public float _x124 { get { return Read<float>(0x124); } }
		public float _x128 { get { return Read<float>(0x128); } }
		public float _x12C { get { return Read<float>(0x12C); } }
		public float _x130 { get { return Read<float>(0x130); } }
		public float _x134 { get { return Read<float>(0x134); } }
		public float _x138 { get { return Read<float>(0x138); } }
		public float _x13C { get { return Read<float>(0x13C); } }
		public float _x140 { get { return Read<float>(0x140); } }
		public float _x144 { get { return Read<float>(0x144); } }
		public float _x148 { get { return Read<float>(0x148); } }
		public float _x14C { get { return Read<float>(0x14C); } }
		public X150 x150_Struct { get { return Read<X150>(0x150); } }
		public X150 x190_Struct { get { return Read<X150>(0x190); } }
		public X150 x1D0_Struct { get { return Read<X150>(0x1D0); } }
		public float x210_StructStart_Min16Bytes { get { return Read<float>(0x210); } }
		public float x214 { get { return Read<float>(0x214); } }
		public float x218 { get { return Read<float>(0x218); } }
		public float x21C { get { return Read<float>(0x21C); } }
		public float x220 { get { return Read<float>(0x220); } }
		public float x224 { get { return Read<float>(0x224); } }
		public float x228 { get { return Read<float>(0x228); } }
		public int _x22C { get { return Read<int>(0x22C); } }
		public int _x230 { get { return Read<int>(0x230); } }

		public class X150 : MemoryObject
		{
			public const int SizeOf = 0x40;

			public float x00 { get { return Read<float>(0x00); } }
			public float x04 { get { return Read<float>(0x04); } }
			public float x08 { get { return Read<float>(0x08); } }
			public float x0C { get { return Read<float>(0x0C); } }
			public float x10 { get { return Read<float>(0x10); } }
			public float x14 { get { return Read<float>(0x14); } }
			public float x18 { get { return Read<float>(0x18); } }
			public float x1C { get { return Read<float>(0x1C); } }
			public float x20 { get { return Read<float>(0x20); } }
			public float x24 { get { return Read<float>(0x24); } }
			public float x28 { get { return Read<float>(0x28); } }
			public float x2C { get { return Read<float>(0x2C); } }
			public float x30_X { get { return Read<float>(0x30); } }
			public float x34_Y { get { return Read<float>(0x34); } }
			public float x38_Z { get { return Read<float>(0x38); } }
			public float x3C { get { return Read<float>(0x3C); } }
		}
	}

	public partial class CameraManager : MemoryObject
	{
		public const int SizeOf = 0x13E0; // 5088

		[ArraySize(9)]
		public CameraData[] x0000_CameraData { get { return Read<CameraData>(0x0000, 9); } }
		public int x13D4_Index { get { return Read<int>(0x13D4); } }
		public int x13D8_Count { get { return Read<int>(0x13D8); } }
		public float x13DC { get { return Read<float>(0x13DC); } }
	}

	public partial class CameraManager
	{
		public static CameraManager Instance { get { return ObjectManager.Instance?.xA20_Ptr_5088Bytes_CameraManager.Dereference(); } }
	}
}
