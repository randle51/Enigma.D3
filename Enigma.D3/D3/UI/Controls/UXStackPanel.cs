using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.UI.Controls
{
	public class UXStackPanel : UXItemsControl
	{
		// 2.0.6.24641
		public const int SizeOf = 0xA80;
		public const int VTable = 0x017C2A50;

		public UXStackPanel(MemoryBase memory, int address)
			: base(memory, address) { }

		public int xA58 { get { return Field<int>(0xA58); } }
		public int xA5C { get { return Field<int>(0xA5C); } }
		public float xA60 { get { return Field<float>(0xA60); } }
		public float xA64 { get { return Field<float>(0xA64); } }
		public float xA68 { get { return Field<float>(0xA68); } }
		public float xA6C { get { return Field<float>(0xA6C); } }
		public float xA70 { get { return Field<float>(0xA70); } }
		public int xA74_Base_x500 { get { return Field<int>(0xA74); } }
		public int xA78_Base_x504 { get { return Field<int>(0xA78); } }
		public int xA7C { get { return Field<int>(0xA7C); } }
	}
}
