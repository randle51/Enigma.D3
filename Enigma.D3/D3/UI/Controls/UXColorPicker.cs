using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.UI.Controls
{
	public class UXColorPicker : UXItemsControl
	{
		// 2.0.6.24641
		public const int SizeOf = 0xC88;
		public const int VTable = 0x017C2670;

		public UXColorPicker(MemoryBase memory, int address)
			: base(memory, address) { }

		public UIReference xA58_UIRef { get { return Field<UIReference>(0xA58); } }
		public int xC60_Neg1 { get { return Field<int>(0xC60); } }
		public int _xC64 { get { return Field<int>(0xC64); } }
		public int xC68 { get { return Field<int>(0xC68); } }
		public int _xC6C { get { return Field<int>(0xC6C); } }
		public int xC70 { get { return Field<int>(0xC70); } }
		public int _xC74 { get { return Field<int>(0xC74); } }
		public int xC78 { get { return Field<int>(0xC78); } }
		public int _xC7C { get { return Field<int>(0xC7C); } }
		public int xC80 { get { return Field<int>(0xC80); } }
		public int xC84 { get { return Field<int>(0xC84); } }
	}
}
