using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.UI.Controls
{
	public class UXItemsControl : UXItemsControlBase
	{
		public new const int SizeOf = 0xA20; //2592
		public new const int VTable = 0x017D2CA8;

		public UIRect x468_UIRect { get { return Read<UIRect>(0x468); } }
		public int x478_Neg1 { get { return Read<int>(0x478); } }
		public int x47C { get { return Read<int>(0x47C); } }
		public int x480 { get { return Read<int>(0x480); } }
		public int x484 { get { return Read<int>(0x484); } }
		public int x488 { get { return Read<int>(0x488); } }
		public float x48C { get { return Read<float>(0x48C); } }
		public float x490 { get { return Read<float>(0x490); } }
		public int x494_Neg1 { get { return Read<int>(0x494); } }
		public int x498_Neg1 { get { return Read<int>(0x498); } }
		public int x49C { get { return Read<int>(0x49C); } }
		public int x4A0_Flags { get { return Read<int>(0x4A0); } }
		public int x4A4 { get { return Read<int>(0x4A4); } }
		public int x4A8_Neg1_Anim2DSnoId { get { return Read<int>(0x4A8); } }
		public int x4AC_StructStart_Min16Bytes_Anim2DRelated { get { return Read<int>(0x4AC); } }
		public int _x4B0 { get { return Read<int>(0x4B0); } }
		public int _x4B4 { get { return Read<int>(0x4B4); } }
		public int _x4B8 { get { return Read<int>(0x4B8); } }
		public UIRect x4BC_UIRect_1600x1200 { get { return Read<UIRect>(0x4BC); } }
		public UIRect x4CC_UIRect { get { return Read<UIRect>(0x4CC); } }
		public float x4DC_Neg1f { get { return Read<float>(0x4DC); } }
		public float x4E0_Neg1f { get { return Read<float>(0x4E0); } }
		public float x4E4_Neg1f { get { return Read<float>(0x4E4); } }
		public float x4E8_Neg1f { get { return Read<float>(0x4E8); } }
		public int x4EC { get { return Read<int>(0x4EC); } }
		public int x4F0 { get { return Read<int>(0x4F0); } }
		public int x4F4 { get { return Read<int>(0x4F4); } }
		public int x4F8 { get { return Read<int>(0x4F8); } }
		public int x4FC_Ptr_32Bytes_Methods { get { return Read<int>(0x4FC); } }
		public string x500_String128 { get { return ReadString(0x500, 128); } }
		public int x580 { get { return Read<int>(0x580); } }
		public int x584 { get { return Read<int>(0x584); } }
		public float x588 { get { return Read<float>(0x588); } }
		public float x58C { get { return Read<float>(0x58C); } }
		public int x590 { get { return Read<int>(0x590); } }
		public int x594 { get { return Read<int>(0x594); } }
		public int x598 { get { return Read<int>(0x598); } }
		public int x59C { get { return Read<int>(0x59C); } }
		public int x5A0 { get { return Read<int>(0x5A0); } }
		public int x5A4 { get { return Read<int>(0x5A4); } }
		public string x5A8_String512 { get { return ReadString(0x5A8, 512); } }
		public string x7A8_String512 { get { return ReadString(0x7A8, 512); } }
		public int x9A8_Neg1 { get { return Read<int>(0x9A8); } }
		public int x9AC_Neg1 { get { return Read<int>(0x9AC); } }
		public int x9B0 { get { return Read<int>(0x9B0); } }
		public UIRect x9B4_UIRect { get { return Read<UIRect>(0x9B4); } }
		public UIRect x9C4_UIRect_1600x1200 { get { return Read<UIRect>(0x9C4); } }
		public UIRect x9D4_UIRect { get { return Read<UIRect>(0x9D4); } }
		public float x9E4 { get { return Read<float>(0x9E4); } }
		public float x9E8 { get { return Read<float>(0x9E8); } }
		public float x9EC_1f { get { return Read<float>(0x9EC); } }
		public float x9F0_1f { get { return Read<float>(0x9F0); } }
		public UIRect x9F4_UIRect { get { return Read<UIRect>(0x9F4); } }
		public int xA04 { get { return Read<int>(0xA04); } }
		public int xA08 { get { return Read<int>(0xA08); } }
		public int xA0C { get { return Read<int>(0xA0C); } }
		public int xA10 { get { return Read<int>(0xA10); } }
		public int xA14 { get { return Read<int>(0xA14); } }
		public float xA18_1f { get { return Read<float>(0xA18); } }
		public int xA1C { get { return Read<int>(0xA1C); } }
	}
}
