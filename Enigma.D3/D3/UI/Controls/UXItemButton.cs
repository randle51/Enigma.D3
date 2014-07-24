using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.UI.Controls
{
	public class UXItemButton : UXButton
	{
		// 2.0.6.24641
		public const int SizeOf = 0xF58;
		public const int VTable = 0x017C2F68;

		public UXItemButton(MemoryBase memory, int address)
			: base(memory, address) { }

		public int xF38_Neg1 { get { return Field<int>(0xF38); } }
		public int xF3C_Flags { get { return Field<int>(0xF3C); } }
		public int xF40 { get { return Field<int>(0xF40); } }
		public int xF44_Neg1 { get { return Field<int>(0xF44); } }
		public int xF48_Neg1 { get { return Field<int>(0xF48); } }
		public int _xF4C { get { return Field<int>(0xF4C); } }
		public int xF50 { get { return Field<int>(0xF50); } }
		public int _xF54 { get { return Field<int>(0xF54); } }
	}
}
