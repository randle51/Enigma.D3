using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.UI.Controls
{
	public class UXCheckBox : UXItemsControl
	{
		// 2.0.6.24641
		public const int SizeOf = 0xAE0;
		public const int VTable = 0x017C3580;

		public UXCheckBox(MemoryBase memory, int address)
			: base(memory, address) { }

		public int xA58 { get { return Field<int>(0xA58); } }
		public int xA5C { get { return Field<int>(0xA5C); } }
		public int xA60 { get { return Field<int>(0xA60); } }
		public int _xA64 { get { return Field<int>(0xA64); } }
		public int _xA68 { get { return Field<int>(0xA68); } }
		public int xA6C { get { return Field<int>(0xA6C); } }
		public int xA70 { get { return Field<int>(0xA70); } }
		public int xA74_Neg1 { get { return Field<int>(0xA74); } }
		public int xA78_Neg1 { get { return Field<int>(0xA78); } }
		public int xA7C_Neg1 { get { return Field<int>(0xA7C); } }
		public int xA80_Neg1 { get { return Field<int>(0xA80); } }
		public int xA84_Neg1 { get { return Field<int>(0xA84); } }
		public int xA88_Neg1 { get { return Field<int>(0xA88); } }
		public int xA8C_Neg1 { get { return Field<int>(0xA8C); } }
		public int xA90_Neg1 { get { return Field<int>(0xA90); } }
		public int xA94_Neg1 { get { return Field<int>(0xA94); } }
		public int xA98_Neg1 { get { return Field<int>(0xA98); } }
		public int xA9C_Neg1 { get { return Field<int>(0xA9C); } }
		public int xAA0_Neg1 { get { return Field<int>(0xAA0); } }
		public int xAA4 { get { return Field<int>(0xAA4); } }
		public int xAA8 { get { return Field<int>(0xAA8); } }
		public int xAAC { get { return Field<int>(0xAAC); } }
		public int xAB0 { get { return Field<int>(0xAB0); } }
		public int xAB4 { get { return Field<int>(0xAB4); } }
		public int xAB8 { get { return Field<int>(0xAB8); } }
		public int xABC { get { return Field<int>(0xABC); } }
		public int xAC0 { get { return Field<int>(0xAC0); } }
		public int xAC4 { get { return Field<int>(0xAC4); } }
		public int xAC8 { get { return Field<int>(0xAC8); } }
		public int xACC { get { return Field<int>(0xACC); } }
		public int xAD0 { get { return Field<int>(0xAD0); } }
		public UXItemsControl xAD4_ItemsControl { get { return Dereference<UXItemsControl>(0xAD4); } }
		public UXLabel xAD8_Label { get { return Dereference<UXLabel>(0xAD8); } }
		public int _xADC { get { return Field<int>(0xADC); } }
	}
}
