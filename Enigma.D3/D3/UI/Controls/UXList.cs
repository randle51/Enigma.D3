using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.UI.Controls
{
	public class UXList : UXItemsControl
	{
		// 2.0.6.24641
		public const int SizeOf = 0x11A0;
		public const int VTable = 0x017C6000;

		public UXList(MemoryBase memory, int address)
			: base(memory, address) { }

		public int x0A58 { get { return Field<int>(0x0A58); } }
		public int x0A5C { get { return Field<int>(0x0A5C); } }
		public int x0A60 { get { return Field<int>(0x0A60); } }
		public float x0A64 { get { return Field<float>(0x0A64); } }
		public float x0A68 { get { return Field<float>(0x0A68); } }
		public float x0A6C { get { return Field<float>(0x0A6C); } }
		public float x0A70 { get { return Field<float>(0x0A70); } }
		public int _x0A74 { get { return Field<int>(0x0A74); } }
		public int _x0A78 { get { return Field<int>(0x0A78); } }
		public int _x0A7C { get { return Field<int>(0x0A7C); } }
		public int _x0A80 { get { return Field<int>(0x0A80); } }
		public int _x0A84 { get { return Field<int>(0x0A84); } }
		public int x0A88 { get { return Field<int>(0x0A88); } }
		public int x0A8C { get { return Field<int>(0x0A8C); } }
		public int x0A90 { get { return Field<int>(0x0A90); } }
		public int x0A94 { get { return Field<int>(0x0A94); } }
		public int x0A98 { get { return Field<int>(0x0A98); } }
		public int x0A9C_Neg1 { get { return Field<int>(0x0A9C); } }
		public int x0AA0_Neg1 { get { return Field<int>(0x0AA0); } }
		public int x0AA4 { get { return Field<int>(0x0AA4); } }
		public int x0AA8 { get { return Field<int>(0x0AA8); } }
		public int x0AAC { get { return Field<int>(0x0AAC); } }
		public int x0AB0_StructStart { get { return Field<int>(0x0AB0); } }
		public int _x0AB4 { get { return Field<int>(0x0AB4); } }
		public int _x0AB8 { get { return Field<int>(0x0AB8); } }
		public int _x0ABC { get { return Field<int>(0x0ABC); } }
		public int x0AC0 { get { return Field<int>(0x0AC0); } }
		public int x0AC4_StructStart { get { return Field<int>(0x0AC4); } }
		public int _x0AC8 { get { return Field<int>(0x0AC8); } }
		public int _x0ACC { get { return Field<int>(0x0ACC); } }
		public int _x0AD0 { get { return Field<int>(0x0AD0); } }
		public int _x0AD4 { get { return Field<int>(0x0AD4); } }
		public UIReference x0AD8_UIRef_ItemsControl { get { return Field<UIReference>(0x0AD8); } }
		public UIReference x0CE0_UIRef_StackPanel { get { return Field<UIReference>(0x0CE0); } }
		public int x0EE8 { get { return Field<int>(0x0EE8); } }
		public int _x0EEC { get { return Field<int>(0x0EEC); } }
		public UIReference x0EF0_UIRef_ScrollBar { get { return Field<UIReference>(0x0EF0); } }
		public int x10F8 { get { return Field<int>(0x10F8); } }
		public int x10FC { get { return Field<int>(0x10FC); } }
		public int x1100 { get { return Field<int>(0x1100); } }
		public int x1104 { get { return Field<int>(0x1104); } }
		public int x1108 { get { return Field<int>(0x1108); } }
		public int x110C { get { return Field<int>(0x110C); } }
		public int x1110 { get { return Field<int>(0x1110); } }
		public int x1114 { get { return Field<int>(0x1114); } }
		public int x1118 { get { return Field<int>(0x1118); } }
		public int x111C { get { return Field<int>(0x111C); } }
		public int x1120_StructStart_Min52Bytes_ArrayEx_ { get { return Field<int>(0x1120); } }
		public int _x1124 { get { return Field<int>(0x1124); } }
		public int _x1128 { get { return Field<int>(0x1128); } }
		public int _x112C { get { return Field<int>(0x112C); } }
		public int _x1130 { get { return Field<int>(0x1130); } }
		public int _x1134 { get { return Field<int>(0x1134); } }
		public int _x1138 { get { return Field<int>(0x1138); } }
		public int _x113C { get { return Field<int>(0x113C); } }
		public int _x1140 { get { return Field<int>(0x1140); } }
		public int _x1144 { get { return Field<int>(0x1144); } }
		public int _x1148 { get { return Field<int>(0x1148); } }
		public int _x114C { get { return Field<int>(0x114C); } }
		public int _x1150 { get { return Field<int>(0x1150); } }
		public int _x1154 { get { return Field<int>(0x1154); } }
		public int x1158 { get { return Field<int>(0x1158); } }
		public int x115C { get { return Field<int>(0x115C); } }
		public int x1160_StructStart_Min52Bytes_ArrayEx_ { get { return Field<int>(0x1160); } }
		public int _x1164 { get { return Field<int>(0x1164); } }
		public int _x1168 { get { return Field<int>(0x1168); } }
		public int _x116C { get { return Field<int>(0x116C); } }
		public int _x1170 { get { return Field<int>(0x1170); } }
		public int _x1174 { get { return Field<int>(0x1174); } }
		public int _x1178 { get { return Field<int>(0x1178); } }
		public int _x117C { get { return Field<int>(0x117C); } }
		public int _x1180 { get { return Field<int>(0x1180); } }
		public int _x1184 { get { return Field<int>(0x1184); } }
		public int _x1188 { get { return Field<int>(0x1188); } }
		public int _x118C { get { return Field<int>(0x118C); } }
		public int _x1190 { get { return Field<int>(0x1190); } }
		public int _x1194 { get { return Field<int>(0x1194); } }
		public int x1198 { get { return Field<int>(0x1198); } }
		public int _x119C { get { return Field<int>(0x119C); } }
	}
}
