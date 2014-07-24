using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.UI.Controls
{
	public class UXControl44 : UXButton
	{
		// 2.0.6.24641
		public const int SizeOf = 0xF50;
		public const int VTable = 0x017C5AB0;

		public UXControl44(MemoryBase memory, int address)
			: base(memory, address) { }

		public int xF38 { get { return Field<int>(0xF38); } }
		public int xF3C { get { return Field<int>(0xF3C); } }
		public int xF40 { get { return Field<int>(0xF40); } }
		public int xF44 { get { return Field<int>(0xF44); } }
		public int xF48 { get { return Field<int>(0xF48); } }
		public int _xF4C { get { return Field<int>(0xF4C); } }
	}
}
