using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.UI.Controls
{
	public class UXList : UXItemsControl
	{
		public new const int SizeOf = 0x1190; //4496
		public new const int VTable = 0x0175D2B0;

		public int x0A48 { get { return Read<int>(0x0A48); } }
		public int x0A4C { get { return Read<int>(0x0A4C); } }
		public int x0A50 { get { return Read<int>(0x0A50); } }
		public float x0A54 { get { return Read<float>(0x0A54); } }
		public float x0A58 { get { return Read<float>(0x0A58); } }
		public float x0A5C { get { return Read<float>(0x0A5C); } }
		public float x0A60 { get { return Read<float>(0x0A60); } }
		public int _x0A64 { get { return Read<int>(0x0A64); } }
		public int _x0A68 { get { return Read<int>(0x0A68); } }
		public int _x0A6C { get { return Read<int>(0x0A6C); } }
		public int _x0A70 { get { return Read<int>(0x0A70); } }
		public int _x0A74 { get { return Read<int>(0x0A74); } }
		public int x0A78 { get { return Read<int>(0x0A78); } }
		public int x0A7C { get { return Read<int>(0x0A7C); } }
		public int x0A80 { get { return Read<int>(0x0A80); } }
		public int x0A84 { get { return Read<int>(0x0A84); } }
		public int x0A88 { get { return Read<int>(0x0A88); } }
		public int x0A8C_Neg1 { get { return Read<int>(0x0A8C); } }
		public int x0A90_Neg1 { get { return Read<int>(0x0A90); } }
		public int x0A94 { get { return Read<int>(0x0A94); } }
		public int x0A98 { get { return Read<int>(0x0A98); } }
		public int x0A9C { get { return Read<int>(0x0A9C); } }
		public int x0AA0_StructStart { get { return Read<int>(0x0AA0); } }
		public int _x0AA4 { get { return Read<int>(0x0AA4); } }
		public int _x0AA8 { get { return Read<int>(0x0AA8); } }
		public int _x0AAC { get { return Read<int>(0x0AAC); } }
		public int x0AB0 { get { return Read<int>(0x0AB0); } }
		public int x0AB4_StructStart { get { return Read<int>(0x0AB4); } }
		public int _x0AB8 { get { return Read<int>(0x0AB8); } }
		public int _x0ABC { get { return Read<int>(0x0ABC); } }
		public int _x0AC0 { get { return Read<int>(0x0AC0); } }
		public int _x0AC4 { get { return Read<int>(0x0AC4); } }
		public UIReference x0AC8_UIRef_ItemsControl { get { return Read<UIReference>(0x0AC8); } }
		public UIReference x0CD0_UIRef_StackPanel { get { return Read<UIReference>(0x0CD0); } }
		public int x0ED8 { get { return Read<int>(0x0ED8); } }
		public int _x0EDC { get { return Read<int>(0x0EDC); } }
		public UIReference x0EE0_UIRef_ScrollBar { get { return Read<UIReference>(0x0EE0); } }
		public int x10E8 { get { return Read<int>(0x10E8); } }
		public int x10EC { get { return Read<int>(0x10EC); } }
		public int x10F0 { get { return Read<int>(0x10F0); } }
		public int x10F4 { get { return Read<int>(0x10F4); } }
		public int x10F8 { get { return Read<int>(0x10F8); } }
		public int x10FC { get { return Read<int>(0x10FC); } }
		public int x1100 { get { return Read<int>(0x1100); } }
		public int x1104 { get { return Read<int>(0x1104); } }
		public int x1108 { get { return Read<int>(0x1108); } }
		public int x110C { get { return Read<int>(0x110C); } }
		public int x1110_StructStart_Min52Bytes_Array_ { get { return Read<int>(0x1110); } }
		public int _x1114 { get { return Read<int>(0x1114); } }
		public int _x1118 { get { return Read<int>(0x1118); } }
		public int _x111C { get { return Read<int>(0x111C); } }
		public int _x1120 { get { return Read<int>(0x1120); } }
		public int _x1124 { get { return Read<int>(0x1124); } }
		public int _x1128 { get { return Read<int>(0x1128); } }
		public int _x112C { get { return Read<int>(0x112C); } }
		public int _x1130 { get { return Read<int>(0x1130); } }
		public int _x1134 { get { return Read<int>(0x1134); } }
		public int _x1138 { get { return Read<int>(0x1138); } }
		public int _x113C { get { return Read<int>(0x113C); } }
		public int _x1140 { get { return Read<int>(0x1140); } }
		public int _x1144 { get { return Read<int>(0x1144); } }
		public int x1148 { get { return Read<int>(0x1148); } }
		public int x114C { get { return Read<int>(0x114C); } }
		public int x1150_StructStart_Min52Bytes_Array_ { get { return Read<int>(0x1150); } }
		public int _x1154 { get { return Read<int>(0x1154); } }
		public int _x1158 { get { return Read<int>(0x1158); } }
		public int _x115C { get { return Read<int>(0x115C); } }
		public int _x1160 { get { return Read<int>(0x1160); } }
		public int _x1164 { get { return Read<int>(0x1164); } }
		public int _x1168 { get { return Read<int>(0x1168); } }
		public int _x116C { get { return Read<int>(0x116C); } }
		public int _x1170 { get { return Read<int>(0x1170); } }
		public int _x1174 { get { return Read<int>(0x1174); } }
		public int _x1178 { get { return Read<int>(0x1178); } }
		public int _x117C { get { return Read<int>(0x117C); } }
		public int _x1180 { get { return Read<int>(0x1180); } }
		public int _x1184 { get { return Read<int>(0x1184); } }
		public int x1188 { get { return Read<int>(0x1188); } }
		public int _x118C { get { return Read<int>(0x118C); } }
	}
}
