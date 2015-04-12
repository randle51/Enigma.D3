using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.UI.Controls
{
	public class UXLabel : UXItemsControl
	{
		public new const int SizeOf = 0xB78; //2936
		public new const int VTable = 0x01815E30;

		// TODO: Find the removed bytes

		public string xA20_Text_StructStart_Min84Bytes { get { return ReadStringPointer(0xA20, xA30_TextLength).Dereference(); } }
		public int xA24_FontSnoId { get { return Read<int>(0xA24); } }
		public int xA28_FontSize { get { return Read<int>(0xA28); } }
		public int _xA2C { get { return Read<int>(0xA2C); } }
		public int xA30_TextLength { get { return Read<int>(0xA30); } }
		public int _xA34 { get { return Read<int>(0xA34); } }
		public int _xA38 { get { return Read<int>(0xA38); } }
		public int _xA3C { get { return Read<int>(0xA3C); } }
		public int _xA40 { get { return Read<int>(0xA40); } }
		public int _xA44 { get { return Read<int>(0xA44); } }
		public int _xA48 { get { return Read<int>(0xA48); } }
		public int _xA4C { get { return Read<int>(0xA4C); } }
		public int _xA50 { get { return Read<int>(0xA50); } }
		public int _xA54 { get { return Read<int>(0xA54); } }
		public int _xA58 { get { return Read<int>(0xA58); } }
		public int _xA5C { get { return Read<int>(0xA5C); } }
		public int _xA60 { get { return Read<int>(0xA60); } }
		public int _xA64 { get { return Read<int>(0xA64); } }
		public int _xA68 { get { return Read<int>(0xA68); } }
		public int _xA6C { get { return Read<int>(0xA6C); } }
		public int _xA70 { get { return Read<int>(0xA70); } }
		public int _xA74 { get { return Read<int>(0xA74); } }
		public int xA78_StructStart_Min52Bytes { get { return Read<int>(0xA78); } }
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
		public int xAB0_StructStart_Min84Bytes { get { return Read<int>(0xAB0); } }
		public int _xAB4 { get { return Read<int>(0xAB4); } }
		public int _xAB8 { get { return Read<int>(0xAB8); } }
		public int _xABC { get { return Read<int>(0xABC); } }
		public int _xAC0 { get { return Read<int>(0xAC0); } }
		public int _xAC4 { get { return Read<int>(0xAC4); } }
		public int _xAC8 { get { return Read<int>(0xAC8); } }
		public int _xACC { get { return Read<int>(0xACC); } }
		public int _xAD0 { get { return Read<int>(0xAD0); } }
		public int _xAD4 { get { return Read<int>(0xAD4); } }
		public int _xAD8 { get { return Read<int>(0xAD8); } }
		public int _xADC { get { return Read<int>(0xADC); } }
		public int _xAE0 { get { return Read<int>(0xAE0); } }
		public int _xAE4 { get { return Read<int>(0xAE4); } }
		public int _xAE8 { get { return Read<int>(0xAE8); } }
		public int _xAEC { get { return Read<int>(0xAEC); } }
		public int _xAF0 { get { return Read<int>(0xAF0); } }
		public int _xAF4 { get { return Read<int>(0xAF4); } }
		public int _xAF8 { get { return Read<int>(0xAF8); } }
		public int _xAFC { get { return Read<int>(0xAFC); } }
		public int _xB00 { get { return Read<int>(0xB00); } }
		public int _xB04 { get { return Read<int>(0xB04); } }
		public int xB08_StructStart_Min84Bytes { get { return Read<int>(0xB08); } }
		public int _xB0C { get { return Read<int>(0xB0C); } }
		public int _xB10 { get { return Read<int>(0xB10); } }
		public int _xB14 { get { return Read<int>(0xB14); } }
		public int _xB18 { get { return Read<int>(0xB18); } }
		public int _xB1C { get { return Read<int>(0xB1C); } }
		public int _xB20 { get { return Read<int>(0xB20); } }
		public int _xB24 { get { return Read<int>(0xB24); } }
		public int _xB28 { get { return Read<int>(0xB28); } }
		public int _xB2C { get { return Read<int>(0xB2C); } }
		public int _xB30 { get { return Read<int>(0xB30); } }
		public int _xB34 { get { return Read<int>(0xB34); } }
		public int _xB38 { get { return Read<int>(0xB38); } }
		public int _xB3C { get { return Read<int>(0xB3C); } }
		public int _xB40 { get { return Read<int>(0xB40); } }
		public int _xB44 { get { return Read<int>(0xB44); } }
		public int _xB48 { get { return Read<int>(0xB48); } }
		public int _xB4C { get { return Read<int>(0xB4C); } }
		public int _xB50 { get { return Read<int>(0xB50); } }
		public int _xB54 { get { return Read<int>(0xB54); } }
		public int _xB58 { get { return Read<int>(0xB58); } }
		public int _xB5C { get { return Read<int>(0xB5C); } }
		public int xB60_Neg1 { get { return Read<int>(0xB60); } }
		public int xB64_Neg1 { get { return Read<int>(0xB64); } }
		public int xB68 { get { return Read<int>(0xB68); } }
		public int xB6C_Neg1 { get { return Read<int>(0xB6C); } }
		public int xB70 { get { return Read<int>(0xB70); } }
		public int xB74 { get { return Read<int>(0xB74); } }
		public float xB78 { get { return Read<float>(0xB78); } }
		public float xB7C { get { return Read<float>(0xB7C); } }
		public float xB80 { get { return Read<float>(0xB80); } }
		public float xB84 { get { return Read<float>(0xB84); } }
		public int xB88_StructStart_Min84Bytes { get { return Read<int>(0xB88); } }
		public int _xB8C { get { return Read<int>(0xB8C); } }
		public int _xB90 { get { return Read<int>(0xB90); } }
		public int _xB94 { get { return Read<int>(0xB94); } }
		public int _xB98 { get { return Read<int>(0xB98); } }
		public int _xB9C { get { return Read<int>(0xB9C); } }
		public int _xBA0 { get { return Read<int>(0xBA0); } }
		public int _xBA4 { get { return Read<int>(0xBA4); } }
		public int _xBA8 { get { return Read<int>(0xBA8); } }
		public int _xBAC { get { return Read<int>(0xBAC); } }
		public int _xBB0 { get { return Read<int>(0xBB0); } }
		public int _xBB4 { get { return Read<int>(0xBB4); } }
		public int _xBB8 { get { return Read<int>(0xBB8); } }
		public int _xBBC { get { return Read<int>(0xBBC); } }
		public int _xBC0 { get { return Read<int>(0xBC0); } }
		public int _xBC4 { get { return Read<int>(0xBC4); } }
		public int _xBC8 { get { return Read<int>(0xBC8); } }
		public int _xBCC { get { return Read<int>(0xBCC); } }
		public int _xBD0 { get { return Read<int>(0xBD0); } }
		public int _xBD4 { get { return Read<int>(0xBD4); } }
		public int _xBD8 { get { return Read<int>(0xBD8); } }
		public int _xBDC { get { return Read<int>(0xBDC); } }
		public int _xBE0 { get { return Read<int>(0xBE0); } }
		public int _xBE4 { get { return Read<int>(0xBE4); } }
		public int xBE8_Color { get { return Read<int>(0xBE8); } }
		public int xBEC { get { return Read<int>(0xBEC); } }
		public int xBF0 { get { return Read<int>(0xBF0); } }
		public int xBF4 { get { return Read<int>(0xBF4); } }
		public int xBF8 { get { return Read<int>(0xBF8); } }
		public int xBFC { get { return Read<int>(0xBFC); } }
		public int xC00 { get { return Read<int>(0xC00); } }
		public int xC04 { get { return Read<int>(0xC04); } }
		public int xC08 { get { return Read<int>(0xC08); } }
		public int xC0C { get { return Read<int>(0xC0C); } }
		public int xC10_FontSnoId { get { return Read<int>(0xC10); } }
		public int xC14_DefaultFontSize { get { return Read<int>(0xC14); } }
		public int xC18_FontSize { get { return Read<int>(0xC18); } }
		public int xC1C { get { return Read<int>(0xC1C); } }
		public int _xC20 { get { return Read<int>(0xC20); } }
		public int xC24_Flags { get { return Read<int>(0xC24); } }
		public int xC28 { get { return Read<int>(0xC28); } }
		public float xC2C { get { return Read<float>(0xC2C); } }
		public float xC30 { get { return Read<float>(0xC30); } }
		public float xC34 { get { return Read<float>(0xC34); } }
		public float xC38 { get { return Read<float>(0xC38); } }
		public int _xC3C { get { return Read<int>(0xC3C); } }
	}
}
