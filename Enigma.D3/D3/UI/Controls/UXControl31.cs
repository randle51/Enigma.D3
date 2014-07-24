using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.UI.Controls
{
	public class UXControl31 : UXButton
	{
		// 2.0.6.24641
		public const int SizeOf = 0xF38;
		public const int VTable = 0x017C3040;

		public UXControl31(MemoryBase memory, int address)
			: base(memory, address) { }
	}
}
