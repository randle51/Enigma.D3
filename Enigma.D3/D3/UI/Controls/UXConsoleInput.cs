using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.UI.Controls
{
	public class UXConsoleInput : UXTextBox
	{
		// 2.0.6.24641
		public const int SizeOf = 0xCD8;
		public const int VTable = 0x0176DB30;

		public UXConsoleInput(MemoryBase memory, int address)
			: base(memory, address) { }
	}
}
