using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.UI.Controls
{
	public class UX3DModel : UXItemsControl
	{
		// 2.0.6.24641
		public const int SizeOf = 0xB38;
		public const int VTable = 0x017C3498;

		public UX3DModel(MemoryBase memory, int address)
			: base(memory, address) { }

		public int xA58_Neg1 { get { return Field<int>(0xA58); } }
		public int xA5C { get { return Field<int>(0xA5C); } }
		public int xA60_StructStart_VisualInventory_Min128Bytes { get { return Field<int>(0xA60); } }
		public int _xA64 { get { return Field<int>(0xA64); } }
		public int _xA68 { get { return Field<int>(0xA68); } }
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
		public int _xAB0 { get { return Field<int>(0xAB0); } }
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
		public int xAE0_StructStart_Min12Bytes { get { return Field<int>(0xAE0); } }
		public int _xAE4 { get { return Field<int>(0xAE4); } }
		public int _xAE8 { get { return Field<int>(0xAE8); } }
		public int xAEC_StructStart_Min12Bytes { get { return Field<int>(0xAEC); } }
		public int _xAF0 { get { return Field<int>(0xAF0); } }
		public int _xAF4 { get { return Field<int>(0xAF4); } }
		public int xAF8_Neg1 { get { return Field<int>(0xAF8); } }
		public int xAFC_Neg1 { get { return Field<int>(0xAFC); } }
		public int xB00 { get { return Field<int>(0xB00); } }
		public int xB04 { get { return Field<int>(0xB04); } }
		public int xB08 { get { return Field<int>(0xB08); } }
		public int xB0C { get { return Field<int>(0xB0C); } }
		public int xB10 { get { return Field<int>(0xB10); } }
		public int xB14 { get { return Field<int>(0xB14); } }
		public int xB18 { get { return Field<int>(0xB18); } }
		public int xB1C_Neg1 { get { return Field<int>(0xB1C); } }
		public int xB20 { get { return Field<int>(0xB20); } }
		public int xB24 { get { return Field<int>(0xB24); } }
		public int xB28 { get { return Field<int>(0xB28); } }
		public int xB2C { get { return Field<int>(0xB2C); } }
		public int xB30_One { get { return Field<int>(0xB30); } }
		public int _xB34 { get { return Field<int>(0xB34); } }
	}
}
