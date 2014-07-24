using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.UI.Controls
{
	public class UXHotKeyButton : UXButton
	{
		// 2.0.6.24641
		public const int SizeOf = 0xF40;
		public const int VTable = 0x017C2B98;

		public UXHotKeyButton(MemoryBase memory, int address)
			: base(memory, address) { }

		public int xF38_Neg1 { get { return Field<int>(0xF38); } }
		public int xF3C { get { return Field<int>(0xF3C); } }
	}
}
