using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.UI.Controls
{
	public class UXContextMenuItem : UXButton
	{
		// 2.0.6.24641
		public const int SizeOf = 0x1148;
		public const int VTable = 0x017C5C30;

		public UXContextMenuItem(MemoryBase memory, int address)
			: base(memory, address) { }

		public int x0F38_One { get { return Field<int>(0xF38); } }
		public int _x0F3C { get { return Field<int>(0xF3C); } }
		public UIReference x0F40_UIRef { get { return Field<UIReference>(0xF40); } }
	}
}
