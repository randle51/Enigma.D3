using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.UI.Controls
{
	internal class UXText : UXItemsControl
	{
		// 2.0.6.24641
		public const int SizeOf = 0xC80;
		public const int VTable = 0x017C33E8;

		public UXText(MemoryBase memory, int address)
			: base(memory, address) { }

		public int xA58 { get { return Field<int>(0xA58); } }
		public int xA5C { get { return Field<int>(0xA5C); } }
		public int xA60 { get { return Field<int>(0xA60); } }
		public int xA64 { get { return Field<int>(0xA64); } }
		public int xA68 { get { return Field<int>(0xA68); } }
		public float xA6C { get { return Field<float>(0xA6C); } }
		public int xA70 { get { return Field<int>(0xA70); } }
		public int xA74 { get { return Field<int>(0xA74); } }
		public UIReference xA78_UIRef { get { return Field<UIReference>(0xA78); } }
	}
}
