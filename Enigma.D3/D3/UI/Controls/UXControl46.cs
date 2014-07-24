using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.UI.Controls
{
	public class UXControl46 : UXItemsControl
	{
		// 2.0.6.24641
		public const int SizeOf = 0xC80;
		public const int VTable = 0x017C5A08;

		public UXControl46(MemoryBase memory, int address)
			: base(memory, address) { }

		public int xA58 { get { return Field<int>(0xA58); } }
		public int xA5C { get { return Field<int>(0xA5C); } }
		public UIReference xA60_UIRef { get { return Field<UIReference>(0xA60); } }
		public int xC68 { get { return Field<int>(0xC68); } }
		public int xC6C { get { return Field<int>(0xC6C); } }
		public int _xC70 { get { return Field<int>(0xC70); } }
		public int _xC74 { get { return Field<int>(0xC74); } }
		public int _xC78 { get { return Field<int>(0xC78); } }
		public int _xC7C { get { return Field<int>(0xC7C); } }
	}
}
