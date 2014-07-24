using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.UI.Controls
{
	public class UXVideo : UXItemsControl
	{
		// 2.0.6.24641
		public const int SizeOf = 0xAE8;
		public const int VTable = 0x017C2D30;

		public UXVideo(MemoryBase memory, int address)
			: base(memory, address) { }

		public int xA58 { get { return Field<int>(0xA58); } }
		public int _xA5C { get { return Field<int>(0xA5C); } }
		public int _xA60 { get { return Field<int>(0xA60); } }
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
		public int xAD8_Neg1 { get { return Field<int>(0xAD8); } }
		public int xADC { get { return Field<int>(0xADC); } }
		public int xAE0 { get { return Field<int>(0xAE0); } }
		public int _xAE4 { get { return Field<int>(0xAE4); } }
	}
}
