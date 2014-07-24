using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.UI.Controls
{
	public class UXTreeFolder : UXItemsControl
	{
		// 2.0.6.24641
		public const int SizeOf = 0xE70;
		public const int VTable = 0x017C2848;

		public UXTreeFolder(MemoryBase memory, int address)
			: base(memory, address) { }

		public float xA58 { get { return Field<float>(0xA58); } }
		public float xA5C { get { return Field<float>(0xA5C); } }
		public UIReference xA60_UIRef { get { return Field<UIReference>(0xA60); } }
		public UIReference xC68_UIRef { get { return Field<UIReference>(0xC68); } }
	}
}
