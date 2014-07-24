using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.UI.Controls
{
	public class UXItemsControl : UXItemsControlBase
	{
		// 2.0.6.24641
		public const int SizeOf = 0xA58;
		public const int VTable = 0x01770C30;

		public UXItemsControl(MemoryBase memory, int address)
			: base(memory, address) { }

		public int x4A0 { get { return Field<int>(0x4A0); } }
		public int x4A4_MouseDownStartX { get { return Field<int>(0x4A4); } }
		public int x4A8_MouseDownStartY { get { return Field<int>(0x4A8); } }
		public int x4AC { get { return Field<int>(0x4AC); } }
		public int x4B0_Neg1 { get { return Field<int>(0x4B0); } }
		public int x4B4_Neg1 { get { return Field<int>(0x4B4); } }
		public int x4B8 { get { return Field<int>(0x4B8); } }
		public int x4BC_Flags_MouseState_ { get { return Field<int>(0x4BC); } } // 4 = IsMouseOver? 5 = IsMouseDown?
		public int x4C0 { get { return Field<int>(0x4C0); } }
		public int x4C4_Neg1 { get { return Field<int>(0x4C4); } }
		public int _x4C8 { get { return Field<int>(0x4C8); } }
		public int _x4CC { get { return Field<int>(0x4CC); } }
		public int _x4D0 { get { return Field<int>(0x4D0); } }
		public int _x4D4 { get { return Field<int>(0x4D4); } }
		public int x4D8 { get { return Field<int>(0x4D8); } }
		public int _x4DC { get { return Field<int>(0x4DC); } }
		public int x4E0 { get { return Field<int>(0x4E0); } }
		public int _x4E4 { get { return Field<int>(0x4E4); } }
		public int x4E8 { get { return Field<int>(0x4E8); } }
		public int x4EC { get { return Field<int>(0x4EC); } }
		public int x4F0 { get { return Field<int>(0x4F0); } }
		public int x4F4 { get { return Field<int>(0x4F4); } }
		public float x4F8 { get { return Field<float>(0x4F8); } }
		public float x4FC { get { return Field<float>(0x4FC); } }
		public float x500 { get { return Field<float>(0x500); } }
		public float x504 { get { return Field<float>(0x504); } }
		public float x508 { get { return Field<float>(0x508); } }
		public float x50C { get { return Field<float>(0x50C); } }
		public float x510 { get { return Field<float>(0x510); } }
		public float x514 { get { return Field<float>(0x514); } }
		public int x518 { get { return Field<int>(0x518); } }
		public int x51C { get { return Field<int>(0x51C); } }
		public int x520 { get { return Field<int>(0x520); } }
		public int x524 { get { return Field<int>(0x524); } }
		public int x528_Ptr_32Bytes { get { return Field<int>(0x528); } }
		public string x52C_String128 { get { return Field(0x52C, 128); } }
		public int x5AC { get { return Field<int>(0x5AC); } }
		public int x5B0 { get { return Field<int>(0x5B0); } }
		public float x5B4 { get { return Field<float>(0x5B4); } }
		public int _x5B8 { get { return Field<int>(0x5B8); } }
		public int x5BC { get { return Field<int>(0x5BC); } }
		public int x5C0 { get { return Field<int>(0x5C0); } }
		public int x5C4 { get { return Field<int>(0x5C4); } }
		public int x5C8 { get { return Field<int>(0x5C8); } }
		public int x5CC { get { return Field<int>(0x5CC); } }
		public int x5D0 { get { return Field<int>(0x5D0); } }
		public string x5D4_String512 { get { return Field(0x5D4, 512); } }
		public string x7D4_String512 { get { return Field(0x7D4, 512); } }
		public int x9D4_Neg1 { get { return Field<int>(0x9D4); } }
		public int x9D8_Neg1 { get { return Field<int>(0x9D8); } }
		public int x9DC { get { return Field<int>(0x9DC); } }
		public int x9E0 { get { return Field<int>(0x9E0); } }
		public int _x9E4 { get { return Field<int>(0x9E4); } }
		public int x9E8 { get { return Field<int>(0x9E8); } }
		public int _x9EC { get { return Field<int>(0x9EC); } }
		public int x9F0 { get { return Field<int>(0x9F0); } }
		public int x9F4 { get { return Field<int>(0x9F4); } }
		public int x9F8 { get { return Field<int>(0x9F8); } }
		public int x9FC { get { return Field<int>(0x9FC); } }
		//public RefString xA00_RefString { get { return Field<RefString>(0xA00); } } // ?
		public int xA0C { get { return Field<int>(0xA0C); } }
		public int xA10 { get { return Field<int>(0xA10); } }
		public int xA14 { get { return Field<int>(0xA14); } }
		public float xA18 { get { return Field<float>(0xA18); } }
		public float xA1C { get { return Field<float>(0xA1C); } }
		//public RefString xA20_RefString { get { return Field<RefString>(0xA20); } } // ?
		public int _xA2C { get { return Field<int>(0xA2C); } }
		public int xA30 { get { return Field<int>(0xA30); } }
		public int xA34 { get { return Field<int>(0xA34); } }
		public int xA38 { get { return Field<int>(0xA38); } }
		public int xA3C_Neg1 { get { return Field<int>(0xA3C); } }
		public int xA40 { get { return Field<int>(0xA40); } }
		public int _xA44 { get { return Field<int>(0xA44); } }
		public int xA48 { get { return Field<int>(0xA48); } }
		public int _xA4C { get { return Field<int>(0xA4C); } }
		public float xA50 { get { return Field<float>(0xA50); } }
		public int xA54 { get { return Field<int>(0xA54); } }
	}
}
