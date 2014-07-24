using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.UI.Controls
{
	public class UXListItem : UXLabel
	{
		// 2.0.6.24641
		public const int SizeOf = 0xF08;
		public const int VTable = 0x017C6280;

		public UXListItem(MemoryBase memory, int address)
			: base(memory, address) { }

		public int xC78 { get { return Field<int>(0xC78); } }
		public int _xC7C { get { return Field<int>(0xC7C); } }
		public UIReference xC80_UIRef { get { return Field<UIReference>(0xC80); } }
		public int xE88_Neg1 { get { return Field<int>(0xE88); } }
		public int xE8C { get { return Field<int>(0xE8C); } }
		public int xE90 { get { return Field<int>(0xE90); } }
		public int xE94 { get { return Field<int>(0xE94); } }
		public int xE98_Neg1 { get { return Field<int>(0xE98); } }
		public int xE9C_Neg1 { get { return Field<int>(0xE9C); } }
		public int xEA0_StructStart_Min16Bytes { get { return Field<int>(0xEA0); } }
		public int _xEA4 { get { return Field<int>(0xEA4); } }
		public int _xEA8 { get { return Field<int>(0xEA8); } }
		public int _xEAC { get { return Field<int>(0xEAC); } }
		public int xEB0_Neg1 { get { return Field<int>(0xEB0); } }
		public int xEB4_Neg1 { get { return Field<int>(0xEB4); } }
		public int xEB8_Neg1 { get { return Field<int>(0xEB8); } }
		public int xEBC_StructStart_Min16Bytes { get { return Field<int>(0xEBC); } }
		public int _xEC0 { get { return Field<int>(0xEC0); } }
		public int _xEC4 { get { return Field<int>(0xEC4); } }
		public int _xEC8 { get { return Field<int>(0xEC8); } }
		public int xECC_Neg1 { get { return Field<int>(0xECC); } }
		public int xED0_Neg1 { get { return Field<int>(0xED0); } }
		public int xED4_Neg1 { get { return Field<int>(0xED4); } }
		public int xED8_StructStart_Min16Bytes { get { return Field<int>(0xED8); } }
		public int _xEDC { get { return Field<int>(0xEDC); } }
		public int _xEE0 { get { return Field<int>(0xEE0); } }
		public int _xEE4 { get { return Field<int>(0xEE4); } }
		public int xEE8_Neg1 { get { return Field<int>(0xEE8); } }
		public int xEEC_Neg1 { get { return Field<int>(0xEEC); } }
		public int xEF0 { get { return Field<int>(0xEF0); } }
		public int xEF4 { get { return Field<int>(0xEF4); } }
		public int xEF8 { get { return Field<int>(0xEF8); } }
		public int xEFC { get { return Field<int>(0xEFC); } }
		public int xF00 { get { return Field<int>(0xF00); } }
		public int _xF04 { get { return Field<int>(0xF04); } }
	}
}
