using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enigma.D3.Collections;
using Enigma.Memory;

namespace Enigma.D3.Sno
{
	[Version("2.1.0.26451")]
	public partial class SnoFiles : MemoryObject
	{
		public const int SizeOf = 0x4A88;

		public X0000 x0000_Struct { get { return Read<X0000>(0x0000); } }
		[ArraySize(2)]
		public X0118[] x0118_StructArray { get { return Read<X0118>(0x0118, 2); } }
		[ArraySize(70)]
		public Map<int, Ptr<Item>>[] x09F8_SnoFileMaps { get { return Read<Map<int, Ptr<Item>>>(0x09F8, 70); } }
		public Map x2898_Map { get { return Read<Map>(0x2898); } } // { count = 0, entrySize = 16 }
		public int _x2908 { get { return Read<int>(0x2908); } }
		public int _x290C { get { return Read<int>(0x290C); } }
		public int _x2910 { get { return Read<int>(0x2910); } }
		public int _x2914 { get { return Read<int>(0x2914); } }
		public int _x2918 { get { return Read<int>(0x2918); } }
		public int _x291C { get { return Read<int>(0x291C); } }
		[ArraySize(70)]
		public Map<int, Ptr<Item2>>[] x2920_SnoStreamMaps { get { return Read<Map<int, Ptr<Item2>>>(0x2920, 70); } }
		public Ptr<X47C0> x47C0_Ptr_212Bytes { get { return ReadPointer<X47C0>(0x47C0); } }
		public int x47C4_Ptr_2000000Bytes { get { return Read<int>(0x47C4); } }
		public string x47C8_DataDirectory { get { return ReadString(0x47C8, 255); } }
		public string x48C7_String255 { get { return ReadString(0x48C7, 255); } }
		public short x49C6_Padding { get { return Read<short>(0x49C6); } }
		public int x49C8_SnoCoreDataHash { get { return Read<int>(0x49C8); } }
		public int _x49CC { get { return Read<int>(0x49CC); } }
		public Vector x49D0_Vector { get { return Read<Vector>(0x49D0); } }
		public int x4A08_StructStart_64Bytes { get { return Read<int>(0x4A08); } } // Some container related to "Banned Names"
		public int _x4A0C { get { return Read<int>(0x4A0C); } }
		public int _x4A10 { get { return Read<int>(0x4A10); } }
		public int _x4A14 { get { return Read<int>(0x4A14); } }
		public int _x4A18 { get { return Read<int>(0x4A18); } }
		public int _x4A1C { get { return Read<int>(0x4A1C); } }
		public int _x4A20 { get { return Read<int>(0x4A20); } }
		public int _x4A24 { get { return Read<int>(0x4A24); } }
		public int _x4A28 { get { return Read<int>(0x4A28); } }
		public int _x4A2C { get { return Read<int>(0x4A2C); } }
		public int _x4A30 { get { return Read<int>(0x4A30); } }
		public int _x4A34 { get { return Read<int>(0x4A34); } }
		public int _x4A38 { get { return Read<int>(0x4A38); } }
		public int _x4A3C { get { return Read<int>(0x4A3C); } }
		public int _x4A40 { get { return Read<int>(0x4A40); } }
		public int _x4A44 { get { return Read<int>(0x4A44); } }
		public int x4A48_StructStart_64Bytes { get { return Read<int>(0x4A48); } } // Some container related to "Banned Names"
		public int _x4A4C { get { return Read<int>(0x4A4C); } }
		public int _x4A50 { get { return Read<int>(0x4A50); } }
		public int _x4A54 { get { return Read<int>(0x4A54); } }
		public int _x4A58 { get { return Read<int>(0x4A58); } }
		public int _x4A5C { get { return Read<int>(0x4A5C); } }
		public int _x4A60 { get { return Read<int>(0x4A60); } }
		public int _x4A64 { get { return Read<int>(0x4A64); } }
		public int _x4A68 { get { return Read<int>(0x4A68); } }
		public int _x4A6C { get { return Read<int>(0x4A6C); } }
		public int _x4A70 { get { return Read<int>(0x4A70); } }
		public int _x4A74 { get { return Read<int>(0x4A74); } }
		public int _x4A78 { get { return Read<int>(0x4A78); } }
		public int _x4A7C { get { return Read<int>(0x4A7C); } }
		public int _x4A80 { get { return Read<int>(0x4A80); } }
		public int _x4A84 { get { return Read<int>(0x4A84); } }

		public class Item : MemoryObject
		{
			public const int SizeOf = 20;

			public RefString x00_Slug { get { return Read<RefString>(0x00); } }
			public int _x0C { get { return Read<int>(0x0C); } }
			public int _x10 { get { return Read<int>(0x10); } }
		}

		public class Item2 : MemoryObject
		{
			public const int SizeOf = 20;

			public int _x00 { get { return Read<int>(0x00); } }
			public int _x04 { get { return Read<int>(0x04); } }
			public int _x08 { get { return Read<int>(0x08); } }
			public int _x0C { get { return Read<int>(0x0C); } }
			public int _x10 { get { return Read<int>(0x10); } }
		}

		public class X0000 : MemoryObject
		{
			public const int SizeOf = 0x118; // 280

			public int _x000 { get { return Read<int>(0x000); } }
			public int _x004 { get { return Read<int>(0x004); } }
			public int _x008 { get { return Read<int>(0x008); } }
			public int _x00C { get { return Read<int>(0x00C); } }
			public int _x010 { get { return Read<int>(0x010); } }
			public int _x014 { get { return Read<int>(0x014); } }
			public int _x018 { get { return Read<int>(0x018); } }
			public int _x01C { get { return Read<int>(0x01C); } }
			public int _x020 { get { return Read<int>(0x020); } }
			public int _x024 { get { return Read<int>(0x024); } }
			public int _x028 { get { return Read<int>(0x028); } }
			public int _x02C { get { return Read<int>(0x02C); } }
			public int _x030 { get { return Read<int>(0x030); } }
			public int _x034 { get { return Read<int>(0x034); } }
			public int _x038 { get { return Read<int>(0x038); } }
			public int _x03C { get { return Read<int>(0x03C); } }
			public int _x040 { get { return Read<int>(0x040); } }
			public int _x044 { get { return Read<int>(0x044); } }
			public int _x048 { get { return Read<int>(0x048); } }
			public int _x04C { get { return Read<int>(0x04C); } }
			public int _x050 { get { return Read<int>(0x050); } }
			public int _x054 { get { return Read<int>(0x054); } }
			public int _x058 { get { return Read<int>(0x058); } }
			public int _x05C { get { return Read<int>(0x05C); } }
			public int _x060 { get { return Read<int>(0x060); } }
			public int _x064 { get { return Read<int>(0x064); } }
			public int _x068 { get { return Read<int>(0x068); } }
			public int _x06C { get { return Read<int>(0x06C); } }
			public int _x070 { get { return Read<int>(0x070); } }
			public int _x074 { get { return Read<int>(0x074); } }
			public int _x078 { get { return Read<int>(0x078); } }
			public int _x07C { get { return Read<int>(0x07C); } }
			public int _x080 { get { return Read<int>(0x080); } }
			public int _x084 { get { return Read<int>(0x084); } }
			public int _x088 { get { return Read<int>(0x088); } }
			public int _x08C { get { return Read<int>(0x08C); } }
			public int _x090 { get { return Read<int>(0x090); } }
			public int _x094 { get { return Read<int>(0x094); } }
			public int _x098 { get { return Read<int>(0x098); } }
			public int _x09C { get { return Read<int>(0x09C); } }
			public int _x0A0 { get { return Read<int>(0x0A0); } }
			public int _x0A4 { get { return Read<int>(0x0A4); } }
			public int _x0A8 { get { return Read<int>(0x0A8); } }
			public int _x0AC { get { return Read<int>(0x0AC); } }
			public int _x0B0 { get { return Read<int>(0x0B0); } }
			public int _x0B4 { get { return Read<int>(0x0B4); } }
			public int _x0B8 { get { return Read<int>(0x0B8); } }
			public int _x0BC { get { return Read<int>(0x0BC); } }
			public int _x0C0 { get { return Read<int>(0x0C0); } }
			public int _x0C4 { get { return Read<int>(0x0C4); } }
			public int _x0C8 { get { return Read<int>(0x0C8); } }
			public int _x0CC { get { return Read<int>(0x0CC); } }
			public int _x0D0 { get { return Read<int>(0x0D0); } }
			public int _x0D4 { get { return Read<int>(0x0D4); } }
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
		}

		public class X0118 : MemoryObject
		{
			public const int SizeOf = 0x470; // 1136

			public Ptr<ListPack<Item>> x000_ListPack20 { get { return ReadPointer<ListPack<Item>>(0x000); } }
			public X0000 x004_Struct { get { return Read<X0000>(0x004); } }
			public X0000 x11C_Struct { get { return Read<X0000>(0x11C); } }
			public X0000 x234_Struct { get { return Read<X0000>(0x234); } }
			public X0000 x34C_Struct { get { return Read<X0000>(0x34C); } }
			public int _x464 { get { return Read<int>(0x464); } }
			public int _x468 { get { return Read<int>(0x468); } }
			public int _x46C { get { return Read<int>(0x46C); } }
		}

		public class X47C0 : MemoryObject
		{
			public const int SizeOf = 0xD4; // 212

			public int x00_VTable { get { return Read<int>(0x00); } }
			public int _x04 { get { return Read<int>(0x04); } }
			public int _x08 { get { return Read<int>(0x08); } }
			public int _x0C { get { return Read<int>(0x0C); } }
			public int _x10 { get { return Read<int>(0x10); } }
			public int _x14 { get { return Read<int>(0x14); } }
			public int _x18 { get { return Read<int>(0x18); } }
			public int _x1C { get { return Read<int>(0x1C); } }
			public int _x20 { get { return Read<int>(0x20); } }
			public int _x24 { get { return Read<int>(0x24); } }
			public int _x28 { get { return Read<int>(0x28); } }
			public int _x2C { get { return Read<int>(0x2C); } }
			public int _x30 { get { return Read<int>(0x30); } }
			public int _x34 { get { return Read<int>(0x34); } }
			public int _x38 { get { return Read<int>(0x38); } }
			public int _x3C { get { return Read<int>(0x3C); } }
			public int _x40 { get { return Read<int>(0x40); } }
			public int _x44 { get { return Read<int>(0x44); } }
			public int _x48 { get { return Read<int>(0x48); } }
			public int _x4C { get { return Read<int>(0x4C); } }
			public int _x50 { get { return Read<int>(0x50); } }
			public int _x54 { get { return Read<int>(0x54); } }
			public int _x58 { get { return Read<int>(0x58); } }
			public int _x5C { get { return Read<int>(0x5C); } }
			public int _x60 { get { return Read<int>(0x60); } }
			public int _x64 { get { return Read<int>(0x64); } }
			public int _x68 { get { return Read<int>(0x68); } }
			public int _x6C { get { return Read<int>(0x6C); } }
			public int _x70 { get { return Read<int>(0x70); } }
			public int _x74 { get { return Read<int>(0x74); } }
			public int _x78 { get { return Read<int>(0x78); } }
			public int _x7C { get { return Read<int>(0x7C); } }
			public int _x80 { get { return Read<int>(0x80); } }
			public int _x84 { get { return Read<int>(0x84); } }
			public int _x88 { get { return Read<int>(0x88); } }
			public int _x8C { get { return Read<int>(0x8C); } }
			public int _x90 { get { return Read<int>(0x90); } }
			public int _x94 { get { return Read<int>(0x94); } }
			public int _x98 { get { return Read<int>(0x98); } }
			public int _x9C { get { return Read<int>(0x9C); } }
			public int _xA0 { get { return Read<int>(0xA0); } }
			public int _xA4 { get { return Read<int>(0xA4); } }
			public int _xA8 { get { return Read<int>(0xA8); } }
			public int _xAC { get { return Read<int>(0xAC); } }
			public int _xB0 { get { return Read<int>(0xB0); } }
			public int _xB4 { get { return Read<int>(0xB4); } }
			public int _xB8 { get { return Read<int>(0xB8); } }
			public Win32.CriticalSection xBC_CriticalSection { get { return Read<Win32.CriticalSection>(0xBC); } }
		}
	}

	public partial class SnoFiles
	{
		public static SnoFiles Instance { get { return Engine.TryGet(a => a.PtrSnoFiles.Dereference()); } }
	}
}
