using System;
using System.Linq;
using System.Text;
using Enigma.D3.Collections;
using Enigma.D3.Memory;

namespace Enigma.D3.UI
{
	public class UIControlReference : MemoryObject
	{
		// 2.0.4.23119
		public const int SizeOf = 0x210; // 528

		public UIControlReference(ProcessMemory memory, int address)
			: base(memory, address) { }

		public UIReference x000_UIReference { get { return Field<UIReference>(0x000); } }
		public UIControl x208_UIControl { get { return Dereference<UIControl>(0x208); } }
		public UIControl x20C_UIControl { get { return Dereference<UIControl>(0x20C); } }
	}

	// not confirmed/tested
	public class TextUIControl : UIControl
	{
		public TextUIControl(ProcessMemory memory, int address)
			: base(memory, address) { }

		public string xA58_Text { get { return Dereference(0xA58, xA68_TextLength); } }
		public int _xA5C { get { return Field<int>(0xA5C); } }
		public int _xA60 { get { return Field<int>(0xA60); } }
		public int _xA64 { get { return Field<int>(0xA64); } }
		public int xA68_TextLength { get { return Field<int>(0xA68); } }
		// ...

		public override string ToString()
		{
			return base.ToString() + ", Text = " + xA58_Text;
		}
	}

	public class UIControl : MemoryObject
	{
		// 2.0.4.23119

		// SizeOf = ???
		// I have no idea about typical size. I think size varies with control type.

		public UIControl(ProcessMemory memory, int address)
			: base(memory, address) { }

		public int x000_PtrVTable { get { return Field<int>(0x000); } }
		public int _x004 { get { return Field<int>(0x004); } }
		public int _x008 { get { return Field<int>(0x008); } }
		public int _x00C { get { return Field<int>(0x00C); } }
		public int _x010 { get { return Field<int>(0x010); } }
		public int _x014 { get { return Field<int>(0x014); } }
		public int _x018 { get { return Field<int>(0x018); } }
		public int _x01C { get { return Field<int>(0x01C); } }
		public int _x020 { get { return Field<int>(0x020); } }
		public int x024_Visibility { get { return Field<int>(0x024); } }
		public UIControl x028_UIControl { get { return Dereference<UIControl>(0x028); } }
		public UIControl x02C_UIControl { get { return Dereference<UIControl>(0x02C); } }
		public UIReference x030_Self { get { return Field<UIReference>(0x030); } }
		public UIReference x238_Parent { get { return Field<UIReference>(0x238); } }
		public int _x440 { get { return Field<int>(0x440); } }
		public int _x444 { get { return Field<int>(0x444); } }
		public int x448_UISnoId { get { return Field<int>(0x448); } }
		public int _x44C { get { return Field<int>(0x44C); } }
		public int _x450 { get { return Field<int>(0x450); } }
		public int _x454 { get { return Field<int>(0x454); } }
		public int _x458 { get { return Field<int>(0x458); } }
		public int _x45C { get { return Field<int>(0x45C); } }
		public Array<UIControlReference> x460_Children { get { return Field<Array<UIControlReference>>(0x460); } }
		public int _x48C { get { return Field<int>(0x48C); } }
		public int _x490 { get { return Field<int>(0x490); } }
		public int _x494 { get { return Field<int>(0x494); } }
		public UIControl x498_UIControl { get { return Dereference<UIControl>(0x498); } }
		public UIControl x49C_UIControl { get { return Dereference<UIControl>(0x49C); } }
		public int _x4A0 { get { return Field<int>(0x4A0); } }
		public int _x4A4 { get { return Field<int>(0x4A4); } }
		public int _x4A8 { get { return Field<int>(0x4A8); } }
		public int _x4AC { get { return Field<int>(0x4AC); } }
		public int x4B0_TextureSnoId { get { return Field<int>(0x4B0); } }
		public int _x4B4 { get { return Field<int>(0x4B4); } }
		public int _x4B8 { get { return Field<int>(0x4B8); } }
		public int _x4BC { get { return Field<int>(0x4BC); } }
		public int _x4C0 { get { return Field<int>(0x4C0); } }
		public int _x4C4 { get { return Field<int>(0x4C4); } }
		public int _x4C8 { get { return Field<int>(0x4C8); } }
		public int _x4CC { get { return Field<int>(0x4CC); } }
		public int _x4D0 { get { return Field<int>(0x4D0); } }
		public int _x4D4 { get { return Field<int>(0x4D4); } }
		public UIRect x4D8_UIRect { get { return Field<UIRect>(0x4D8); } }
		public UIRect x4E8_UIRect { get { return Field<UIRect>(0x4E8); } }
		public int _x4EC { get { return Field<int>(0x4EC); } }
		public int _x4F0 { get { return Field<int>(0x4F0); } }
		public int _x4F4 { get { return Field<int>(0x4F4); } }
		public int _x4F8 { get { return Field<int>(0x4F8); } }
		public int _x4FC { get { return Field<int>(0x4FC); } }
		public int _x500 { get { return Field<int>(0x500); } }
		public int _x504 { get { return Field<int>(0x504); } }
		public int _x508 { get { return Field<int>(0x508); } }
		public int _x50C { get { return Field<int>(0x50C); } }
		public int _x510 { get { return Field<int>(0x510); } }
		public int _x514 { get { return Field<int>(0x514); } }
		public int _x518 { get { return Field<int>(0x518); } }
		public int _x51C { get { return Field<int>(0x51C); } }
		public int _x520 { get { return Field<int>(0x520); } }
		public int _x524 { get { return Field<int>(0x524); } }
		public int _x528 { get { return Field<int>(0x528); } }
		public int _x52C { get { return Field<int>(0x52C); } }
		public int _x530 { get { return Field<int>(0x530); } }
		public int _x534 { get { return Field<int>(0x534); } }
		public int _x538 { get { return Field<int>(0x538); } }
		public int _x53C { get { return Field<int>(0x53C); } }
		public int _x540 { get { return Field<int>(0x540); } }
		public int _x544 { get { return Field<int>(0x544); } }
		public int _x548 { get { return Field<int>(0x548); } }
		public int _x54C { get { return Field<int>(0x54C); } }
		public int _x550 { get { return Field<int>(0x550); } }
		public int _x554 { get { return Field<int>(0x554); } }
		public int _x558 { get { return Field<int>(0x558); } }
		public int _x55C { get { return Field<int>(0x55C); } }
		public int _x560 { get { return Field<int>(0x560); } }
		public int _x564 { get { return Field<int>(0x564); } }
		public int _x568 { get { return Field<int>(0x568); } }
		public int _x56C { get { return Field<int>(0x56C); } }
		public int _x570 { get { return Field<int>(0x570); } }
		public int _x574 { get { return Field<int>(0x574); } }
		public int _x578 { get { return Field<int>(0x578); } }
		public int _x57C { get { return Field<int>(0x57C); } }
		public int _x580 { get { return Field<int>(0x580); } }
		public int _x584 { get { return Field<int>(0x584); } }
		public int _x588 { get { return Field<int>(0x588); } }
		public int _x58C { get { return Field<int>(0x58C); } }
		public int _x590 { get { return Field<int>(0x590); } }
		public int _x594 { get { return Field<int>(0x594); } }
		public int _x598 { get { return Field<int>(0x598); } }
		public int _x59C { get { return Field<int>(0x59C); } }
		public int _x5A0 { get { return Field<int>(0x5A0); } }
		public int _x5A4 { get { return Field<int>(0x5A4); } }
		public int _x5A8 { get { return Field<int>(0x5A8); } }
		public int _x5AC { get { return Field<int>(0x5AC); } }
		public int _x5B0 { get { return Field<int>(0x5B0); } }
		public int _x5B4 { get { return Field<int>(0x5B4); } }
		public int _x5B8 { get { return Field<int>(0x5B8); } }
		public int _x5BC { get { return Field<int>(0x5BC); } }
		public int _x5C0 { get { return Field<int>(0x5C0); } }
		public int _x5C4 { get { return Field<int>(0x5C4); } }
		public int _x5C8 { get { return Field<int>(0x5C8); } }
		public int _x5CC { get { return Field<int>(0x5CC); } }
		public int _x5D0 { get { return Field<int>(0x5D0); } }
		public string x5D4_String512 { get { return Field(0x5D4, 512); } }
		public int _x5D4 { get { return Field<int>(0x5D4); } }
		public int _x5D8 { get { return Field<int>(0x5D8); } }
		public int _x5DC { get { return Field<int>(0x5DC); } }
		public int _x5E0 { get { return Field<int>(0x5E0); } }
		public int _x5E4 { get { return Field<int>(0x5E4); } }
		public int _x5E8 { get { return Field<int>(0x5E8); } }
		public int _x5EC { get { return Field<int>(0x5EC); } }
		public int _x5F0 { get { return Field<int>(0x5F0); } }
		public int _x5F4 { get { return Field<int>(0x5F4); } }
		public int _x5F8 { get { return Field<int>(0x5F8); } }
		public int _x5FC { get { return Field<int>(0x5FC); } }
		public int _x600 { get { return Field<int>(0x600); } }
		public int _x604 { get { return Field<int>(0x604); } }
		public int _x608 { get { return Field<int>(0x608); } }
		public int _x60C { get { return Field<int>(0x60C); } }
		public int _x610 { get { return Field<int>(0x610); } }
		public int _x614 { get { return Field<int>(0x614); } }
		public int _x618 { get { return Field<int>(0x618); } }
		public int _x61C { get { return Field<int>(0x61C); } }
		public int _x620 { get { return Field<int>(0x620); } }
		public int _x624 { get { return Field<int>(0x624); } }
		public int _x628 { get { return Field<int>(0x628); } }
		public int _x62C { get { return Field<int>(0x62C); } }
		public int _x630 { get { return Field<int>(0x630); } }
		public int _x634 { get { return Field<int>(0x634); } }
		public int _x638 { get { return Field<int>(0x638); } }
		public int _x63C { get { return Field<int>(0x63C); } }
		public int _x640 { get { return Field<int>(0x640); } }
		public int _x644 { get { return Field<int>(0x644); } }
		public int _x648 { get { return Field<int>(0x648); } }
		public int _x64C { get { return Field<int>(0x64C); } }
		public int _x650 { get { return Field<int>(0x650); } }
		public int _x654 { get { return Field<int>(0x654); } }
		public int _x658 { get { return Field<int>(0x658); } }
		public int _x65C { get { return Field<int>(0x65C); } }
		public int _x660 { get { return Field<int>(0x660); } }
		public int _x664 { get { return Field<int>(0x664); } }
		public int _x668 { get { return Field<int>(0x668); } }
		public int _x66C { get { return Field<int>(0x66C); } }
		public int _x670 { get { return Field<int>(0x670); } }
		public int _x674 { get { return Field<int>(0x674); } }
		public int _x678 { get { return Field<int>(0x678); } }
		public int _x67C { get { return Field<int>(0x67C); } }
		public int _x680 { get { return Field<int>(0x680); } }
		public int _x684 { get { return Field<int>(0x684); } }
		public int _x688 { get { return Field<int>(0x688); } }
		public int _x68C { get { return Field<int>(0x68C); } }
		public int _x690 { get { return Field<int>(0x690); } }
		public int _x694 { get { return Field<int>(0x694); } }
		public int _x698 { get { return Field<int>(0x698); } }
		public int _x69C { get { return Field<int>(0x69C); } }
		public int _x6A0 { get { return Field<int>(0x6A0); } }
		public int _x6A4 { get { return Field<int>(0x6A4); } }
		public int _x6A8 { get { return Field<int>(0x6A8); } }
		public int _x6AC { get { return Field<int>(0x6AC); } }
		public int _x6B0 { get { return Field<int>(0x6B0); } }
		public int _x6B4 { get { return Field<int>(0x6B4); } }
		public int _x6B8 { get { return Field<int>(0x6B8); } }
		public int _x6BC { get { return Field<int>(0x6BC); } }
		public int _x6C0 { get { return Field<int>(0x6C0); } }
		public int _x6C4 { get { return Field<int>(0x6C4); } }
		public int _x6C8 { get { return Field<int>(0x6C8); } }
		public int _x6CC { get { return Field<int>(0x6CC); } }
		public int _x6D0 { get { return Field<int>(0x6D0); } }
		public int _x6D4 { get { return Field<int>(0x6D4); } }
		public int _x6D8 { get { return Field<int>(0x6D8); } }
		public int _x6DC { get { return Field<int>(0x6DC); } }
		public int _x6E0 { get { return Field<int>(0x6E0); } }
		public int _x6E4 { get { return Field<int>(0x6E4); } }
		public int _x6E8 { get { return Field<int>(0x6E8); } }
		public int _x6EC { get { return Field<int>(0x6EC); } }
		public int _x6F0 { get { return Field<int>(0x6F0); } }
		public int _x6F4 { get { return Field<int>(0x6F4); } }
		public int _x6F8 { get { return Field<int>(0x6F8); } }
		public int _x6FC { get { return Field<int>(0x6FC); } }
		public int _x700 { get { return Field<int>(0x700); } }
		public int _x704 { get { return Field<int>(0x704); } }
		public int _x708 { get { return Field<int>(0x708); } }
		public int _x70C { get { return Field<int>(0x70C); } }
		public int _x710 { get { return Field<int>(0x710); } }
		public int _x714 { get { return Field<int>(0x714); } }
		public int _x718 { get { return Field<int>(0x718); } }

		public string x7D4_String512 { get { return Field(0x7D4, 512); } }
		public int x9D4_Neg1 { get { return Field<int>(0x9D4); } }
		public int x9D8_Neg1 { get { return Field<int>(0x9D8); } }
		public int _x9DC { get { return Field<int>(0x9DC); } }
		public int _x9E0 { get { return Field<int>(0x9E0); } }
		public int _x9E4 { get { return Field<int>(0x9E4); } }
		public int _x9E8 { get { return Field<int>(0x9E8); } }
		public int _x9EC { get { return Field<int>(0x9EC); } }
		public int _x9F0 { get { return Field<int>(0x9F0); } }
		public int _x9F4 { get { return Field<int>(0x9F4); } }
		public int _x9F8 { get { return Field<int>(0x9F8); } }
		public int _x9FC { get { return Field<int>(0x9FC); } }
		public int _xA00 { get { return Field<int>(0xA00); } }
		public int _xA04 { get { return Field<int>(0xA04); } }
		public int _xA08 { get { return Field<int>(0xA08); } }
		public int _xA0C { get { return Field<int>(0xA0C); } }
		public int _xA10 { get { return Field<int>(0xA10); } }
		public int _xA14 { get { return Field<int>(0xA14); } }
		public int _xA18 { get { return Field<int>(0xA18); } }
		public int _xA1C { get { return Field<int>(0xA1C); } }
		public int _xA20 { get { return Field<int>(0xA20); } }
		public int _xA24 { get { return Field<int>(0xA24); } }
		public int _xA28 { get { return Field<int>(0xA28); } }
		public int _xA2C { get { return Field<int>(0xA2C); } }
		public int _xA30 { get { return Field<int>(0xA30); } }
		public int _xA34 { get { return Field<int>(0xA34); } }
		public int _xA38 { get { return Field<int>(0xA38); } }
		public int _xA3C { get { return Field<int>(0xA3C); } }
		public int _xA40 { get { return Field<int>(0xA40); } }
		public int _xA44 { get { return Field<int>(0xA44); } }
		public int _xA48 { get { return Field<int>(0xA48); } }
		public int _xA4C { get { return Field<int>(0xA4C); } }
		public int _xA50 { get { return Field<int>(0xA50); } }
		public int _xA54 { get { return Field<int>(0xA54); } }

		public override string ToString()
		{
			return base.ToString() + " " + x030_Self.x008_Name;
		}
	}
}