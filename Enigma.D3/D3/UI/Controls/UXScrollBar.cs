using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.UI.Controls
{
	public class UXScrollBar : UXItemsControl
	{
		public new const int SizeOf = 0x16A8; //5800
		public new const int VTable = 0x0175C7A8;

		public int x0A48 { get { return Read<int>(0x0A48); } }
		public int x0A4C { get { return Read<int>(0x0A4C); } }
		public int x0A50 { get { return Read<int>(0x0A50); } }
		public int x0A54 { get { return Read<int>(0x0A54); } }
		public int x0A58 { get { return Read<int>(0x0A58); } }
		public int x0A5C { get { return Read<int>(0x0A5C); } }
		public int x0A60 { get { return Read<int>(0x0A60); } }
		public int _x0A64 { get { return Read<int>(0x0A64); } }
		public UIReference x0A68_UIRef_Parent { get { return Read<UIReference>(0x0A68); } }
		public UIReference x0C70_UIRef_Button_Thumb { get { return Read<UIReference>(0x0C70); } }
		public UIReference x0E78_UIRef_Button_TrackUp { get { return Read<UIReference>(0x0E78); } }
		public UIReference x1080_UIRef_TrackDown { get { return Read<UIReference>(0x1080); } }
		public UIReference x1288_UIRef_Button_Up { get { return Read<UIReference>(0x1288); } }
		public UIReference x1490_UIRef_Button_Down { get { return Read<UIReference>(0x1490); } }
		public int x1698 { get { return Read<int>(0x1698); } }
		public int x169C { get { return Read<int>(0x169C); } }
		public int x16A0_Method { get { return Read<int>(0x16A0); } }
		public int x16A4 { get { return Read<int>(0x16A4); } }
	}
}
