using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.UI.Controls
{
	public class UXLabel : UXItemsControl
	{
		// 2.0.6.24641
		public const int SizeOf = 0xC78;
		public const int VTable = 0x017B2D38;

		public UXLabel(MemoryBase memory, int address)
			: base(memory, address) { }

		public string xA58_Text_StructStart_Min84Bytes { get { return Dereference(0xA58, xA68_TextLength); } }
		public int xA5C_FontSnoId { get { return Field<int>(0xA5C); } }
		public int xA60_FontSize { get { return Field<int>(0xA60); } }
		public int _xA64 { get { return Field<int>(0xA64); } }
		public int xA68_TextLength { get { return Field<int>(0xA68); } }
		public int _xA6C { get { return Field<int>(0xA6C); } }
		public int _xA70 { get { return Field<int>(0xA70); } }
		public int _xA74 { get { return Field<int>(0xA74); } }
		public int _xA78 { get { return Field<int>(0xA78); } }
		public int _xA7C { get { return Field<int>(0xA7C); } }
		public int _xA80 { get { return Field<int>(0xA80); } }
		public int _xA84 { get { return Field<int>(0xA84); } }
		public int _xA88 { get { return Field<int>(0xA88); } }
		public int _xA8C { get { return Field<int>(0xA8C); } }
		public int _xA90 { get { return Field<int>(0xA90); } }
		public int _xA94 { get { return Field<int>(0xA94); } }
		public int _xA98 { get { return Field<int>(0xA98); } }
		public int _xA9C { get { return Field<int>(0xA9C); } }
		public int _xAA0 { get { return Field<int>(0xAA0); } }
		public int _xAA4 { get { return Field<int>(0xAA4); } }
		public int _xAA8 { get { return Field<int>(0xAA8); } }
		public int _xAAC { get { return Field<int>(0xAAC); } }
		public int xAB0_StructStart_Min52Bytes { get { return Field<int>(0xAB0); } }
		public int _xAB4 { get { return Field<int>(0xAB4); } }
		public int _xAB8 { get { return Field<int>(0xAB8); } }
		public int _xABC { get { return Field<int>(0xABC); } }
		public int _xAC0 { get { return Field<int>(0xAC0); } }
		public int _xAC4 { get { return Field<int>(0xAC4); } }
		public int _xAC8 { get { return Field<int>(0xAC8); } }
		public int _xACC { get { return Field<int>(0xACC); } }
		public int _xAD0 { get { return Field<int>(0xAD0); } }
		public int _xAD4 { get { return Field<int>(0xAD4); } }
		public int _xAD8 { get { return Field<int>(0xAD8); } }
		public int _xADC { get { return Field<int>(0xADC); } }
		public int _xAE0 { get { return Field<int>(0xAE0); } }
		public int _xAE4 { get { return Field<int>(0xAE4); } }
		public int xAE8_StructStart_Min84Bytes { get { return Field<int>(0xAE8); } }
		public int _xAEC { get { return Field<int>(0xAEC); } }
		public int _xAF0 { get { return Field<int>(0xAF0); } }
		public int _xAF4 { get { return Field<int>(0xAF4); } }
		public int _xAF8 { get { return Field<int>(0xAF8); } }
		public int _xAFC { get { return Field<int>(0xAFC); } }
		public int _xB00 { get { return Field<int>(0xB00); } }
		public int _xB04 { get { return Field<int>(0xB04); } }
		public int _xB08 { get { return Field<int>(0xB08); } }
		public int _xB0C { get { return Field<int>(0xB0C); } }
		public int _xB10 { get { return Field<int>(0xB10); } }
		public int _xB14 { get { return Field<int>(0xB14); } }
		public int _xB18 { get { return Field<int>(0xB18); } }
		public int _xB1C { get { return Field<int>(0xB1C); } }
		public int _xB20 { get { return Field<int>(0xB20); } }
		public int _xB24 { get { return Field<int>(0xB24); } }
		public int _xB28 { get { return Field<int>(0xB28); } }
		public int _xB2C { get { return Field<int>(0xB2C); } }
		public int _xB30 { get { return Field<int>(0xB30); } }
		public int _xB34 { get { return Field<int>(0xB34); } }
		public int _xB38 { get { return Field<int>(0xB38); } }
		public int _xB3C { get { return Field<int>(0xB3C); } }
		public int xB40_StructStart_Min84Bytes { get { return Field<int>(0xB40); } }
		public int _xB44 { get { return Field<int>(0xB44); } }
		public int _xB48 { get { return Field<int>(0xB48); } }
		public int _xB4C { get { return Field<int>(0xB4C); } }
		public int _xB50 { get { return Field<int>(0xB50); } }
		public int _xB54 { get { return Field<int>(0xB54); } }
		public int _xB58 { get { return Field<int>(0xB58); } }
		public int _xB5C { get { return Field<int>(0xB5C); } }
		public int _xB60 { get { return Field<int>(0xB60); } }
		public int _xB64 { get { return Field<int>(0xB64); } }
		public int _xB68 { get { return Field<int>(0xB68); } }
		public int _xB6C { get { return Field<int>(0xB6C); } }
		public int _xB70 { get { return Field<int>(0xB70); } }
		public int _xB74 { get { return Field<int>(0xB74); } }
		public int _xB78 { get { return Field<int>(0xB78); } }
		public int _xB7C { get { return Field<int>(0xB7C); } }
		public int _xB80 { get { return Field<int>(0xB80); } }
		public int _xB84 { get { return Field<int>(0xB84); } }
		public int _xB88 { get { return Field<int>(0xB88); } }
		public int _xB8C { get { return Field<int>(0xB8C); } }
		public int _xB90 { get { return Field<int>(0xB90); } }
		public int _xB94 { get { return Field<int>(0xB94); } }
		public int xB98_Neg1 { get { return Field<int>(0xB98); } }
		public int xB9C_Neg1 { get { return Field<int>(0xB9C); } }
		public int xBA0 { get { return Field<int>(0xBA0); } }
		public int xBA4_Neg1 { get { return Field<int>(0xBA4); } }
		public int xBA8 { get { return Field<int>(0xBA8); } }
		public int xBAC { get { return Field<int>(0xBAC); } }
		public float xBB0 { get { return Field<float>(0xBB0); } }
		public float xBB4 { get { return Field<float>(0xBB4); } }
		public float xBB8 { get { return Field<float>(0xBB8); } }
		public float xBBC { get { return Field<float>(0xBBC); } }
		public int xBC0_StructStart_Min84Bytes { get { return Field<int>(0xBC0); } }
		public int _xBC4 { get { return Field<int>(0xBC4); } }
		public int _xBC8 { get { return Field<int>(0xBC8); } }
		public int _xBCC { get { return Field<int>(0xBCC); } }
		public int _xBD0 { get { return Field<int>(0xBD0); } }
		public int _xBD4 { get { return Field<int>(0xBD4); } }
		public int _xBD8 { get { return Field<int>(0xBD8); } }
		public int _xBDC { get { return Field<int>(0xBDC); } }
		public int _xBE0 { get { return Field<int>(0xBE0); } }
		public int _xBE4 { get { return Field<int>(0xBE4); } }
		public int _xBE8 { get { return Field<int>(0xBE8); } }
		public int _xBEC { get { return Field<int>(0xBEC); } }
		public int _xBF0 { get { return Field<int>(0xBF0); } }
		public int _xBF4 { get { return Field<int>(0xBF4); } }
		public int _xBF8 { get { return Field<int>(0xBF8); } }
		public int _xBFC { get { return Field<int>(0xBFC); } }
		public int _xC00 { get { return Field<int>(0xC00); } }
		public int _xC04 { get { return Field<int>(0xC04); } }
		public int _xC08 { get { return Field<int>(0xC08); } }
		public int _xC0C { get { return Field<int>(0xC0C); } }
		public int _xC10 { get { return Field<int>(0xC10); } }
		public int _xC14 { get { return Field<int>(0xC14); } }
		public int _xC18 { get { return Field<int>(0xC18); } }
		public int _xC1C { get { return Field<int>(0xC1C); } }
		public int xC20_Color { get { return Field<int>(0xC20); } }
		public int xC24 { get { return Field<int>(0xC24); } }
		public int xC28 { get { return Field<int>(0xC28); } }
		public int xC2C { get { return Field<int>(0xC2C); } }
		public int xC30 { get { return Field<int>(0xC30); } }
		public int xC34 { get { return Field<int>(0xC34); } }
		public int xC38 { get { return Field<int>(0xC38); } }
		public int xC3C { get { return Field<int>(0xC3C); } }
		public int xC40 { get { return Field<int>(0xC40); } }
		public int xC44 { get { return Field<int>(0xC44); } }
		public int xC48_FontSnoId { get { return Field<int>(0xC48); } }
		public int xC4C_DefaultFontSize { get { return Field<int>(0xC4C); } }
		public int xC50_FontSize { get { return Field<int>(0xC50); } }
		public int xC54 { get { return Field<int>(0xC54); } }
		public int _xC58 { get { return Field<int>(0xC58); } }
		public int xC5C_Flags { get { return Field<int>(0xC5C); } }
		public int xC60 { get { return Field<int>(0xC60); } }
		public float xC64 { get { return Field<float>(0xC64); } }
		public float xC68 { get { return Field<float>(0xC68); } }
		public float xC6C { get { return Field<float>(0xC6C); } }
		public float xC70 { get { return Field<float>(0xC70); } }
		public int _xC74 { get { return Field<int>(0xC74); } }
	}
}
