using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.UI.Controls
{
	public class UXComboBox : UXItemsControl
	{
		public new const int SizeOf = 0xEC8; //3784
		public new const int VTable = 0x01743918;

		public int xA48 { get { return Read<int>(0xA48); } }
		public int xA4C { get { return Read<int>(0xA4C); } }
		public int xA50 { get { return Read<int>(0xA50); } }
		public int xA54 { get { return Read<int>(0xA54); } }
		public Ptr<UXLabel> xA58_Ptr_Label { get { return ReadPointer<UXLabel>(0xA58); } }
		public int _xA5C { get { return Read<int>(0xA5C); } }
		public UIReference xA60_UIRef_ItemsControl_Background { get { return Read<UIReference>(0xA60); } }
		public UIReference xC68_UIRef_Button_Arrow { get { return Read<UIReference>(0xC68); } }
		public int xE70 { get { return Read<int>(0xE70); } }
		public int xE74_Neg1 { get { return Read<int>(0xE74); } }
		public int xE78_StructStart_Min52Bytes_Array_ { get { return Read<int>(0xE78); } }
		public int _xE7C { get { return Read<int>(0xE7C); } }
		public int _xE80 { get { return Read<int>(0xE80); } }
		public int _xE84 { get { return Read<int>(0xE84); } }
		public int _xE88 { get { return Read<int>(0xE88); } }
		public int _xE8C { get { return Read<int>(0xE8C); } }
		public int _xE90 { get { return Read<int>(0xE90); } }
		public int _xE94 { get { return Read<int>(0xE94); } }
		public int _xE98 { get { return Read<int>(0xE98); } }
		public int _xE9C { get { return Read<int>(0xE9C); } }
		public int _xEA0 { get { return Read<int>(0xEA0); } }
		public int _xEA4 { get { return Read<int>(0xEA4); } }
		public int _xEA8 { get { return Read<int>(0xEA8); } }
		public int _xEAC { get { return Read<int>(0xEAC); } }
		public RefString xEB0_RefString { get { return Read<RefString>(0xEB0); } }
		public int xEBC { get { return Read<int>(0xEBC); } }
		public int xEC0 { get { return Read<int>(0xEC0); } }
		public int _xEC4 { get { return Read<int>(0xEC4); } }
	}
}
