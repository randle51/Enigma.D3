using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.UI.Controls
{
	public class UXTree : UXItemsControl
	{
		// 2.0.6.24641
		public const int SizeOf = 0xE70;
		public const int VTable = 0x017C28E0;

		public UXTree(MemoryBase memory, int address)
			: base(memory, address) { }

		public int xA58 { get { return Field<int>(0xA58); } }
		public int _xA5C { get { return Field<int>(0xA5C); } }
		public UIReference xA60_UIRef_StackPanel { get { return Field<UIReference>(0xA60); } }
		public UIReference xC68_UIRef { get { return Field<UIReference>(0xC68); } }
	}
}
