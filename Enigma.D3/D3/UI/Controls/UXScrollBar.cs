using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.UI.Controls
{
	public class UXScrollBar : UXItemsControl
	{
		// 2.0.6.24641
		public const int SizeOf = 0x16B8;
		public const int VTable = 0x017C54F8;

		public UXScrollBar(MemoryBase memory, int address)
			: base(memory, address) { }

		public int x0A58 { get { return Field<int>(0x0A58); } }
		public int x0A5C { get { return Field<int>(0x0A5C); } }
		public int x0A60 { get { return Field<int>(0x0A60); } }
		public int x0A64 { get { return Field<int>(0x0A64); } }
		public int x0A68 { get { return Field<int>(0x0A68); } }
		public int x0A6C { get { return Field<int>(0x0A6C); } }
		public int x0A70 { get { return Field<int>(0x0A70); } }
		public int _x0A74 { get { return Field<int>(0x0A74); } }
		public UIReference x0A78_UIRef_Parent { get { return Field<UIReference>(0x0A78); } }
		public UIReference x0C80_UIRef_Button_Thumb { get { return Field<UIReference>(0x0C80); } }
		public UIReference x0E88_UIRef_Button_TrackUp { get { return Field<UIReference>(0x0E88); } }
		public UIReference x1090_UIRef_TrackDown { get { return Field<UIReference>(0x1090); } }
		public UIReference x1298_UIRef_Button_Up { get { return Field<UIReference>(0x1298); } }
		public UIReference x14A0_UIRef_Button_Down { get { return Field<UIReference>(0x14A0); } }
		public int x16A8 { get { return Field<int>(0x16A8); } }
		public int x16AC { get { return Field<int>(0x16AC); } }
		public int x16B0_Method { get { return Field<int>(0x16B0); } }
		public int x16B4 { get { return Field<int>(0x16B4); } }
	}
}
