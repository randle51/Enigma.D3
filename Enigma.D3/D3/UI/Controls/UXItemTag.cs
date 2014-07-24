using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.UI.Controls
{
	public class UXItemTag : UXButton
	{
		// 2.0.6.24641
		public const int SizeOf = 0xF48;
		public const int VTable = 0x017C30F8;

		public UXItemTag(MemoryBase memory, int address)
			: base(memory, address) { }

		public int xF38_Neg1 { get { return Field<int>(0xF38); } }
		public int xF3C_Neg1 { get { return Field<int>(0xF3C); } }
		public int xF40_One { get { return Field<int>(0xF40); } }
		public int _xF44 { get { return Field<int>(0xF44); } }
	}
}
