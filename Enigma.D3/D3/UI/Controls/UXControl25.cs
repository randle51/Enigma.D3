using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.UI.Controls
{
	public class UXControl25 : UXItemsControl
	{
		// 2.0.6.24641
		public const int SizeOf = 0xE68;
		public const int VTable = 0x017C5948;

		public UXControl25(MemoryBase memory, int address)
			: base(memory, address) { }

		public UIReference xA58_UIRef_Label { get { return Field<UIReference>(0xA58); } }
		public UIReference xC60_UIRef_ScrollBar { get { return Field<UIReference>(0xC60); } }
	}
}
