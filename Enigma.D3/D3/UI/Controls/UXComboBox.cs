using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.UI.Controls
{
	public class UXComboBox : UXItemsControl
	{
		// 2.0.6.24641
		public const int SizeOf = 0xED8;
		public const int VTable = 0x017AC8C8;

		public UXComboBox(MemoryBase memory, int address)
			: base(memory, address) { }

		public int xA58 { get { return Field<int>(0xA58); } }
		public int xA5C { get { return Field<int>(0xA5C); } }
		public int xA60 { get { return Field<int>(0xA60); } }
		public int xA64 { get { return Field<int>(0xA64); } }
		public UXLabel xA68_Label { get { return Dereference<UXLabel>(0xA68); } }
		public int _xA6C { get { return Field<int>(0xA6C); } }
		public UIReference xA70_UIRef_ItemsControl_Background { get { return Field<UIReference>(0xA70); } }
		public UIReference xC78_UIRef_Button_Arrow { get { return Field<UIReference>(0xC78); } }
		public int xE80 { get { return Field<int>(0xE80); } }
		public int xE84_Neg1 { get { return Field<int>(0xE84); } }
		public int xE88_StructStart_Min52Bytes_ArrayEx_ { get { return Field<int>(0xE88); } }
		public int _xE8C { get { return Field<int>(0xE8C); } }
		public int _xE90 { get { return Field<int>(0xE90); } }
		public int _xE94 { get { return Field<int>(0xE94); } }
		public int _xE98 { get { return Field<int>(0xE98); } }
		public int _xE9C { get { return Field<int>(0xE9C); } }
		public int _xEA0 { get { return Field<int>(0xEA0); } }
		public int _xEA4 { get { return Field<int>(0xEA4); } }
		public int _xEA8 { get { return Field<int>(0xEA8); } }
		public int _xEAC { get { return Field<int>(0xEAC); } }
		public int _xEB0 { get { return Field<int>(0xEB0); } }
		public int _xEB4 { get { return Field<int>(0xEB4); } }
		public int _xEB8 { get { return Field<int>(0xEB8); } }
		public int _xEBC { get { return Field<int>(0xEBC); } }
		public RefString xEC0_RefString { get { return Field<RefString>(0xEC0); } }
		public int xECC { get { return Field<int>(0xECC); } }
		public int xED0 { get { return Field<int>(0xED0); } }
		public int _xED4 { get { return Field<int>(0xED4); } }
	}
}
