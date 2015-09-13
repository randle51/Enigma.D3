using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.UI.Controls
{
	public class UXListItem : UXLabel
	{
		public new const int SizeOf = 0xE08; //3592
		public new const int VTable = 0x01829E98;

		public int xC88 { get { return Read<int>(0xC88); } }
		public int _xC8C { get { return Read<int>(0xC8C); } }
		public UIReference xC90_UIRef { get { return Read<UIReference>(0xC90); } }
		public int xE98_Neg1 { get { return Read<int>(0xE98); } }
		public int xE9C { get { return Read<int>(0xE9C); } }
		public int xEA0 { get { return Read<int>(0xEA0); } }
		public int xEA4 { get { return Read<int>(0xEA4); } }
		public int xEA8_Neg1 { get { return Read<int>(0xEA8); } }
		public int xEAC_Neg1 { get { return Read<int>(0xEAC); } }
		public int xEB0_StructStart_Min16Bytes { get { return Read<int>(0xEB0); } }
		public int _xEB4 { get { return Read<int>(0xEB4); } }
		public int _xEB8 { get { return Read<int>(0xEB8); } }
		public int _xEBC { get { return Read<int>(0xEBC); } }
		public int xEC0_Neg1 { get { return Read<int>(0xEC0); } }
		public int xEC4_Neg1 { get { return Read<int>(0xEC4); } }
		public int xEC8_Neg1 { get { return Read<int>(0xEC8); } }
		public int xECC_StructStart_Min16Bytes { get { return Read<int>(0xECC); } }
		public int _xED0 { get { return Read<int>(0xED0); } }
		public int _xED4 { get { return Read<int>(0xED4); } }
		public int _xED8 { get { return Read<int>(0xED8); } }
		public int xEDC_Neg1 { get { return Read<int>(0xEDC); } }
		public int xEE0_Neg1 { get { return Read<int>(0xEE0); } }
		public int xEE4_Neg1 { get { return Read<int>(0xEE4); } }
		public int xEE8_StructStart_Min16Bytes { get { return Read<int>(0xEE8); } }
		public int _xEEC { get { return Read<int>(0xEEC); } }
		public int _xEF0 { get { return Read<int>(0xEF0); } }
		public int _xEF4 { get { return Read<int>(0xEF4); } }
		public int xEF8_Neg1 { get { return Read<int>(0xEF8); } }
		public int xEFC_Neg1 { get { return Read<int>(0xEFC); } }
		public int xF00 { get { return Read<int>(0xF00); } }
		public int xF04 { get { return Read<int>(0xF04); } }
		public int xF08 { get { return Read<int>(0xF08); } }
		public int xF0C { get { return Read<int>(0xF0C); } }
		public int xF10 { get { return Read<int>(0xF10); } }
		public int _xF14 { get { return Read<int>(0xF14); } }
	}
}
