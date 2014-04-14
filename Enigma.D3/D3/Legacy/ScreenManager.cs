using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.Legacy
{
	public class ScreenManager : MemoryObject
	{
		public const int SizeOf = 32; // 1.0.8.16603 : [0x0098AC00] CScreenManager::Create

		public ScreenManager(ProcessMemory memory, int address)
			: base(memory, address) { }

		public byte[] x00 { get { return Dereference<byte>(0x00, 1768); } }
		public X04 x04 { get { return Dereference<X04>(0x04); } } // shares base class with X0C (can see on VTable override)
		public byte[] x08 { get { return Dereference<byte>(0x08, 64); } }
		public X0C x0C { get { return Dereference<X0C>(0x0C); } } // shares base class with X04 (can see on VTable override)
		public HeroSelect x10_HeroSelect { get { return Dereference<HeroSelect>(0x10); } }
		public X14 x14 { get { return Dereference<X14>(0x14); } }
		public byte[] x18 { get { return Dereference<byte>(0x18, 2416); } }
		public byte[] x1C { get { return Dereference<byte>(0x1C, 4); } }



		public class X04 : MemoryObject
		{
			// 1.0.8.16603 (see 0098A670)
			// Shares base class with X0C, at least 0x120 (228) bytes.
			public const int SizeOf = 440; // = 0x1B8

			public X04(ProcessMemory memory, int address)
				: base(memory, address) { }

			public int x000_VTable { get { return Field<int>(0x000); } }
			public int _x004 { get { return Field<int>(0x004); } }
			public SpecialList[] x008_Array { get { return Field<SpecialList>(0x008, 3); } }
			public int x098_Count_ { get { return Field<int>(0x098); } }
			public int x09C_RelatedTo_ToastDuration { get { return Field<int>(0x09C); } }
			public int x0A0_Boolean_ { get { return Field<int>(0x0A0); } }
			public int x0A4 { get { return Field<int>(0x0A4); } }
			public int x0A8 { get { return Field<int>(0x0A8); } }
			public int _x0AC { get { return Field<int>(0x0AC); } }
			public int x0B0_Array_ { get { return Field<int>(0x0B0); } }
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
			public int x0E0 { get { return Field<int>(0x0E0); } }
			public int _x0E4 { get { return Field<int>(0x0E4); } }
			public int x0E8_Array_ { get { return Field<int>(0x0E8); } }
			public int x0EC { get { return Field<int>(0x0EC); } }
			public int x0F0 { get { return Field<int>(0x0F0); } }
			public int _x0F4 { get { return Field<int>(0x0F4); } }
			public int x0F8 { get { return Field<int>(0x0F8); } }
			public int x0FC { get { return Field<int>(0x0FC); } }
			public int x100 { get { return Field<int>(0x100); } }
			public int x104_Flags { get { return Field<int>(0x104); } }
			public int x108 { get { return Field<int>(0x108); } }
			public int x10C { get { return Field<int>(0x10C); } }
			public int x110_GoodFood { get { return Field<int>(0x110); } }
			public int _x114 { get { return Field<int>(0x114); } }
			public int x118 { get { return Field<int>(0x118); } }
			public int _x11C { get { return Field<int>(0x11C); } }
			public int x120_Struct_ { get { return Field<int>(0x120); } }
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
			public int x188 { get { return Field<int>(0x188); } }
			public int _x18C { get { return Field<int>(0x18C); } }
			public int x190 { get { return Field<int>(0x190); } }
			public int x194 { get { return Field<int>(0x194); } }
			public int x198 { get { return Field<int>(0x198); } }
			public int x19C { get { return Field<int>(0x19C); } }
			public int x1A0 { get { return Field<int>(0x1A0); } }
			public int _x1A4 { get { return Field<int>(0x1A4); } }
			public int _x1A8 { get { return Field<int>(0x1A8); } }
			public int _x1AC { get { return Field<int>(0x1AC); } }
			public int x1B0 { get { return Field<int>(0x1B0); } }
			public int _x1B4 { get { return Field<int>(0x1B4); } }
		}

		public class X0C : MemoryObject
		{
			// 1.0.8.16603 (see ...)
			// Shares base class with X04, at least 0x120 (228) bytes.
			public const int SizeOf = 400; // = 0x190

			public X0C(ProcessMemory memory, int address)
				: base(memory, address) { }

			public int x000_VTable { get { return Field<int>(0x000); } } // 14C6FAC
			public int _x004 { get { return Field<int>(0x004); } }
			public SpecialList[] x008_Array { get { return Field<SpecialList>(0x008, 3); } }
			public int x098_Count_ { get { return Field<int>(0x098); } }
			public int x09C_RelatedTo_ToastDuration { get { return Field<int>(0x09C); } }
			public int x0A0_Boolean_ { get { return Field<int>(0x0A0); } }
			public int x0A4 { get { return Field<int>(0x0A4); } }
			public int x0A8 { get { return Field<int>(0x0A8); } }
			public int _x0AC { get { return Field<int>(0x0AC); } }
			public int x0B0_Array_ { get { return Field<int>(0x0B0); } }
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
			public int x0E0 { get { return Field<int>(0x0E0); } }
			public int _x0E4 { get { return Field<int>(0x0E4); } }
			public int x0E8_Array_ { get { return Field<int>(0x0E8); } }
			public int x0EC { get { return Field<int>(0x0EC); } }
			public int x0F0 { get { return Field<int>(0x0F0); } }
			public int _x0F4 { get { return Field<int>(0x0F4); } }
			public int x0F8 { get { return Field<int>(0x0F8); } }
			public int x0FC { get { return Field<int>(0x0FC); } }
			public int x100 { get { return Field<int>(0x100); } }
			public int x104_Flags { get { return Field<int>(0x104); } }
			public int x108 { get { return Field<int>(0x108); } }
			public int x10C { get { return Field<int>(0x10C); } }
			public int x110_GoodFood { get { return Field<int>(0x110); } }
			public int _x114 { get { return Field<int>(0x114); } }
			public int x118 { get { return Field<int>(0x118); } }
			public int _x11C { get { return Field<int>(0x11C); } }
			public int x120_Struct_ { get { return Field<int>(0x120); } }
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
		}

		public class SpecialList : MemoryObject
		{
			// 1.0.8.16603
			public const int SizeOf = 0x30;

			public SpecialList(ProcessMemory memory, int address)
				: base(memory, address) { }

			public LinkedList<int> x00_List { get { return Field<LinkedList<int>>(0x00); } }
			public Allocator x10_Allocator_10x12Bytes { get { return Field<Allocator>(0x10); } } // ListNodeAllocator?
			public int x2C_Boolean_ { get { return Field<int>(0x2C); } } // True for valid/initialized?
		}



		public class X14 : MemoryObject
		{
			// 1.0.8.16603 (see 0x0098AC00)
			public const int SizeOf = 568; // = 0x238

			public X14(ProcessMemory memory, int address)
				: base(memory, address) { }

			public int x000 { get { return Field<int>(0x000); } }
			public int x004 { get { return Field<int>(0x004); } }
			public int x008 { get { return Field<int>(0x008); } }
			public Allocator x00C_Allocator { get { return Dereference<Allocator>(0x00C); } } // <-- Points to x010
			public Allocator x010_Allocator { get { return Field<Allocator>(0x010); } }
			public int x02C { get { return Field<int>(0x02C); } }
			public UIReference x030_UIReference { get { return Field<UIReference>(0x030); } }
		}
	}
}
