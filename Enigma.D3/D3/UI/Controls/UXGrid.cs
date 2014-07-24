using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.UI.Controls
{
	public class UXGrid : UXList
	{
		// 2.0.6.24641
		public const int SizeOf = 0x11A8;
		public const int VTable = 0x017C5F00;

		public UXGrid(MemoryBase memory, int address)
			: base(memory, address) { }

		public float x11A0 { get { return Field<float>(0x11A0); } }
		public int _x11A4 { get { return Field<int>(0x11A4); } }
	}
}
