using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.UI.Controls
{
	public class UXRadioButtonGroup : UXItemsControlBase
	{
		// 2.0.6.24641
		public const int SizeOf = 0x4A8;
		public const int VTable = 0x017C3290;

		public UXRadioButtonGroup(MemoryBase memory, int address)
			: base(memory, address) { }

		public int x4A0 { get { return Field<int>(0x4A0); } }
		public int x4A4 { get { return Field<int>(0x4A4); } }
	}
}
