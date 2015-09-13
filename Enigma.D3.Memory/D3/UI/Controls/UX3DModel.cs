using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.UI.Controls
{
	[Obsolete("Fields not checked, size +4")]
	public class UX3DModel : UXItemsControl
	{
		public new const int SizeOf = 0xB28; //2856
		public new const int VTable = 0x01826F58;

		public int xA48_Neg1 { get { return Read<int>(0xA48); } }
		public int xA4C { get { return Read<int>(0xA4C); } }
		public int xA50_StructStart_VisualInventory_Min128Bytes { get { return Read<int>(0xA50); } }
		public int _xA54 { get { return Read<int>(0xA54); } }
		public int _xA58 { get { return Read<int>(0xA58); } }
		public int _xA5C { get { return Read<int>(0xA5C); } }
		public int _xA60 { get { return Read<int>(0xA60); } }
		public int _xA64 { get { return Read<int>(0xA64); } }
		public int _xA68 { get { return Read<int>(0xA68); } }
		public int _xA6C { get { return Read<int>(0xA6C); } }
		public int _xA70 { get { return Read<int>(0xA70); } }
		public int _xA74 { get { return Read<int>(0xA74); } }
		public int _xA78 { get { return Read<int>(0xA78); } }
		public int _xA7C { get { return Read<int>(0xA7C); } }
		public int _xA80 { get { return Read<int>(0xA80); } }
		public int _xA84 { get { return Read<int>(0xA84); } }
		public int _xA88 { get { return Read<int>(0xA88); } }
		public int _xA8C { get { return Read<int>(0xA8C); } }
		public int _xA90 { get { return Read<int>(0xA90); } }
		public int _xA94 { get { return Read<int>(0xA94); } }
		public int _xA98 { get { return Read<int>(0xA98); } }
		public int _xA9C { get { return Read<int>(0xA9C); } }
		public int _xAA0 { get { return Read<int>(0xAA0); } }
		public int _xAA4 { get { return Read<int>(0xAA4); } }
		public int _xAA8 { get { return Read<int>(0xAA8); } }
		public int _xAAC { get { return Read<int>(0xAAC); } }
		public int _xAB0 { get { return Read<int>(0xAB0); } }
		public int _xAB4 { get { return Read<int>(0xAB4); } }
		public int _xAB8 { get { return Read<int>(0xAB8); } }
		public int _xABC { get { return Read<int>(0xABC); } }
		public int _xAC0 { get { return Read<int>(0xAC0); } }
		public int _xAC4 { get { return Read<int>(0xAC4); } }
		public int _xAC8 { get { return Read<int>(0xAC8); } }
		public int _xACC { get { return Read<int>(0xACC); } }
		public int xAD0_StructStart_Min12Bytes { get { return Read<int>(0xAD0); } }
		public int _xAD4 { get { return Read<int>(0xAD4); } }
		public int _xAD8 { get { return Read<int>(0xAD8); } }
		public int xADC_StructStart_Min12Bytes { get { return Read<int>(0xADC); } }
		public int _xAE0 { get { return Read<int>(0xAE0); } }
		public int _xAE4 { get { return Read<int>(0xAE4); } }
		public int xAE8_Neg1 { get { return Read<int>(0xAE8); } }
		public int xAEC_Neg1 { get { return Read<int>(0xAEC); } }
		public int xAF0 { get { return Read<int>(0xAF0); } }
		public int xAF4 { get { return Read<int>(0xAF4); } }
		public int xAF8 { get { return Read<int>(0xAF8); } }
		public int xAFC { get { return Read<int>(0xAFC); } }
		public int xB00 { get { return Read<int>(0xB00); } }
		public int xB04 { get { return Read<int>(0xB04); } }
		public int xB08 { get { return Read<int>(0xB08); } }
		public int xB0C_Neg1 { get { return Read<int>(0xB0C); } }
		public int xB10 { get { return Read<int>(0xB10); } }
		public int xB14 { get { return Read<int>(0xB14); } }
		public int xB18 { get { return Read<int>(0xB18); } }
		public int xB1C { get { return Read<int>(0xB1C); } }
		public int xB20_One { get { return Read<int>(0xB20); } }
		public int _xB24 { get { return Read<int>(0xB24); } }
	}
}
