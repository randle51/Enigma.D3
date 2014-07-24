using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.UI.Controls
{
	public class UXControl35 : UXButton
	{
		// 2.0.6.24641
		public const int SizeOf = 0xF60;
		public const int VTable = 0x017C5D40;

		public UXControl35(MemoryBase memory, int address)
			: base(memory, address) { }

		public int _xF38 { get { return Field<int>(0xF38); } }
		public int _xF3C { get { return Field<int>(0xF3C); } }
		public int _xF40 { get { return Field<int>(0xF40); } }
		public int _xF44 { get { return Field<int>(0xF44); } }
		public int _xF48 { get { return Field<int>(0xF48); } }
		public int _xF4C { get { return Field<int>(0xF4C); } }
		public int xF50_Neg1 { get { return Field<int>(0xF50); } }
		public int xF54_Neg1 { get { return Field<int>(0xF54); } }
		public int xF58_Neg1 { get { return Field<int>(0xF58); } }
		public int xF5C_Neg1 { get { return Field<int>(0xF5C); } }
	}
}
