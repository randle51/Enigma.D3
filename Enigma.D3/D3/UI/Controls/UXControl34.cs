using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.UI.Controls
{
	public class UXControl34 : UXRadioButton
	{
		// 2.0.6.24641
		public const int SizeOf = 0x1190;
		public const int VTable = 0x017C5E28;

		public UXControl34(MemoryBase memory, int address)
			: base(memory, address) { }

		public UXLabel x1188_Label { get { return Dereference<UXLabel>(0x1188); } }
		public int x118C_ProgressBar { get { return Field<int>(0x118C); } }
	}
}
