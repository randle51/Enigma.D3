using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.UI.Controls
{
	public class UXItemsControl : UXItemsControlBase
	{
		public new const int SizeOf = 0xA48;
		public new const int VTable = 0x01705180;

		public UIRect x490_UIRect { get { return Read<UIRect>(0x490); } }
		public int x4A0_Neg1 { get { return Read<int>(0x4A0); } }
		public int x4A4 { get { return Read<int>(0x4A4); } }
		public int x4A8 { get { return Read<int>(0x4A8); } }
		public int x4AC { get { return Read<int>(0x4AC); } }
		public int x4B0 { get { return Read<int>(0x4B0); } }
		public float x4B4 { get { return Read<float>(0x4B4); } }
		public float x4B8 { get { return Read<float>(0x4B8); } }
		public int x4BC_Neg1 { get { return Read<int>(0x4BC); } }
		public int x4C0_Neg1 { get { return Read<int>(0x4C0); } }
		public int x4C4 { get { return Read<int>(0x4C4); } }
		public int x4C8_Flags { get { return Read<int>(0x4C8); } }
		public int x4CC { get { return Read<int>(0x4CC); } }
		public int x4D0_Neg1_Anim2DSnoId { get { return Read<int>(0x4D0); } }
		public int x4D4_StructStart_Min16Bytes_Anim2DRelated { get { return Read<int>(0x4D4); } }
		public int _x4D8 { get { return Read<int>(0x4D8); } }
		public int _x4DC { get { return Read<int>(0x4DC); } }
		public int _x4E0 { get { return Read<int>(0x4E0); } }
		public UIRect x4E4_UIRect_1600x1200 { get { return Read<UIRect>(0x4E4); } }
		public UIRect x4F4_UIRect { get { return Read<UIRect>(0x4F4); } }
		public float x504_Neg1f { get { return Read<float>(0x504); } }
		public float x508_Neg1f { get { return Read<float>(0x508); } }
		public float x50C_Neg1f { get { return Read<float>(0x50C); } }
		public float x510_Neg1f { get { return Read<float>(0x510); } }
		public int x514 { get { return Read<int>(0x514); } }
		public int x518 { get { return Read<int>(0x518); } }
		public int x51C { get { return Read<int>(0x51C); } }
		public int x520 { get { return Read<int>(0x520); } }
		public int x524_Ptr_32Bytes_Methods { get { return Read<int>(0x524); } }
		public string x528_String128 { get { return ReadString(0x528, 128); } }
		public int x5A8 { get { return Read<int>(0x5A8); } }
		public int x5AC { get { return Read<int>(0x5AC); } }
		public float x5B0 { get { return Read<float>(0x5B0); } }
		public float x5B4 { get { return Read<float>(0x5B4); } }
		public int x5B8 { get { return Read<int>(0x5B8); } }
		public int x5BC { get { return Read<int>(0x5BC); } }
		public int x5C0 { get { return Read<int>(0x5C0); } }
		public int x5C4 { get { return Read<int>(0x5C4); } }
		public int x5C8 { get { return Read<int>(0x5C8); } }
		public int x5CC { get { return Read<int>(0x5CC); } }
		public string x5D0_String512 { get { return ReadString(0x5D0, 512); } }
		public string x7D0_String512 { get { return ReadString(0x7D0, 512); } }
		public int x9D0_Neg1 { get { return Read<int>(0x9D0); } }
		public int x9D4_Neg1 { get { return Read<int>(0x9D4); } }
		public int x9D8 { get { return Read<int>(0x9D8); } }
		public UIRect x9DC_UIRect { get { return Read<UIRect>(0x9DC); } }
		public UIRect x9EC_UIRect_1600x1200 { get { return Read<UIRect>(0x9EC); } }
		public UIRect x9FC_UIRect { get { return Read<UIRect>(0x9FC); } }
		public float xA0C { get { return Read<float>(0xA0C); } }
		public float xA10 { get { return Read<float>(0xA10); } }
		public float xA14_1f { get { return Read<float>(0xA14); } }
		public float xA18_1f { get { return Read<float>(0xA18); } }
		public UIRect xA1C_UIRect { get { return Read<UIRect>(0xA1C); } }
		public int xA2C { get { return Read<int>(0xA2C); } }
		public int xA30 { get { return Read<int>(0xA30); } }
		public int xA34 { get { return Read<int>(0xA34); } }
		public int xA38 { get { return Read<int>(0xA38); } }
		public int xA3C { get { return Read<int>(0xA3C); } }
		public float xA40_1f { get { return Read<float>(0xA40); } }
		public int xA44 { get { return Read<int>(0xA44); } }

		//public int x490 { get { return Read<int>(0x490); } }
		//public int x494_MouseDownStartX { get { return Read<int>(0x494); } }
		//public int x498_MouseDownStartY { get { return Read<int>(0x498); } }
		//public int x49C { get { return Read<int>(0x49C); } }
		//public int x4A0_Neg1 { get { return Read<int>(0x4A0); } }
		//public int x4A4_Neg1 { get { return Read<int>(0x4A4); } }
		//public int x4A8 { get { return Read<int>(0x4A8); } }
		//public int x4AC_Flags_MouseState_ { get { return Read<int>(0x4AC); } } // 4 = IsMouseOver? 5 = IsMouseDown?
		//public int x4B0 { get { return Read<int>(0x4B0); } }
		//public int x4B4_Neg1_Anim2DSnoId { get { return Read<int>(0x4B4); } }
		//public float x4B8_StructStart_Min16Bytes { get { return Read<int>(0x4B8); } } // Related to the x4B4 Anim2D SNO
		//public float x4BC { get { return Read<int>(0x4BC); } }
		//public float x4C0 { get { return Read<int>(0x4C0); } }
		//public float x4C4 { get { return Read<int>(0x4C4); } }
		//public UIRect x4C8_UIRect { get { return Read<UIRect>(0x4C8); } }
		//public UIRect x4D8_UIRect { get { return Read<UIRect>(0x4D8); } }
		//public float x4E8 { get { return Read<float>(0x4E8); } }
		//public float x4EC { get { return Read<float>(0x4EC); } }
		//public float x4F0 { get { return Read<float>(0x4F0); } }
		//public float x4F4 { get { return Read<float>(0x4F4); } }
		//public float x4F8 { get { return Read<float>(0x4F8); } }
		//public float x4FC { get { return Read<float>(0x4FC); } }
		//public float x500 { get { return Read<float>(0x500); } }
		//public float x504 { get { return Read<float>(0x504); } }
		//public int x508 { get { return Read<int>(0x508); } }
		//public int x50C { get { return Read<int>(0x50C); } }
		//public int x510 { get { return Read<int>(0x510); } }
		//public int x514 { get { return Read<int>(0x514); } }
		//public int x518_Ptr_32Bytes { get { return Read<int>(0x518); } }
		//public string x51C_String128 { get { return ReadString(0x51C, 128); } }
		//public int x59C { get { return Read<int>(0x59C); } }
		//public int x5A0 { get { return Read<int>(0x5A0); } }
		//public float x5A4 { get { return Read<float>(0x5A4); } }
		//public int _x5A8 { get { return Read<int>(0x5A8); } }
		//public int x5AC { get { return Read<int>(0x5AC); } }
		//public int x5B0 { get { return Read<int>(0x5B0); } }
		//public int x5B4 { get { return Read<int>(0x5B4); } }
		//public int x5B8 { get { return Read<int>(0x5B8); } }
		//public int x5BC { get { return Read<int>(0x5BC); } }
		//public int x5C0 { get { return Read<int>(0x5C0); } }
		//public string x5C4_String512 { get { return ReadString(0x5C4, 512); } }
		//public string x7C4_String512 { get { return ReadString(0x7C4, 512); } }
		//public int x9C4_Neg1 { get { return Read<int>(0x9C4); } }
		//public int x9C8_Neg1 { get { return Read<int>(0x9C8); } }
		//public int x9CC { get { return Read<int>(0x9CC); } }
		//public int x9D0 { get { return Read<int>(0x9D0); } }
		//public int _x9D4 { get { return Read<int>(0x9D4); } }
		//public int x9D8 { get { return Read<int>(0x9D8); } }
		//public int _x9DC { get { return Read<int>(0x9DC); } }
		//public int x9E0 { get { return Read<int>(0x9E0); } }
		//public int x9E4 { get { return Read<int>(0x9E4); } }
		//public int x9E8 { get { return Read<int>(0x9E8); } }
		//public int x9EC { get { return Read<int>(0x9EC); } }
		////public RefString x9F0_RefString { get { return Read<RefString>(0x9F0); } } // ?
		//public int x9FC { get { return Read<int>(0x9FC); } }
		//public int xA00 { get { return Read<int>(0xA00); } }
		//public int xA04 { get { return Read<int>(0xA04); } }
		//public float xA08 { get { return Read<float>(0xA08); } }
		//public float xA0C { get { return Read<float>(0xA0C); } }
		////public RefString xA10_RefString { get { return Read<RefString>(0xA10); } } // ?
		//public int _xA1C { get { return Read<int>(0xA1C); } }
		//public int xA20 { get { return Read<int>(0xA20); } }
		//public int xA24 { get { return Read<int>(0xA24); } }
		//public int xA28 { get { return Read<int>(0xA28); } }
		//public int xA2C_Neg1 { get { return Read<int>(0xA2C); } }
		//public int xA30 { get { return Read<int>(0xA30); } }
		//public int _xA34 { get { return Read<int>(0xA34); } }
		//public int xA38 { get { return Read<int>(0xA38); } }
		//public int _xA3C { get { return Read<int>(0xA3C); } }
		//public float xA40 { get { return Read<float>(0xA40); } }
		//public int xA44 { get { return Read<int>(0xA44); } }
	}
}
