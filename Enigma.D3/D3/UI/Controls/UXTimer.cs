using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.UI.Controls
{
	public class UXTimer : UXItemsControl
	{
		// 2.0.6.24641
		public const int SizeOf = 0xC70;
		public const int VTable = 0x017C5868;

		public UXTimer(MemoryBase memory, int address)
			: base(memory, address) { }

		public int xA58 { get { return Field<int>(0xA58); } }
		public int xA5C { get { return Field<int>(0xA5C); } }
		public int xA60 { get { return Field<int>(0xA60); } }
		public int _xA64 { get { return Field<int>(0xA64); } }
		public UIReference xA68_UIRef_Blinker { get { return Field<UIReference>(0xA68); } }
	}
}
