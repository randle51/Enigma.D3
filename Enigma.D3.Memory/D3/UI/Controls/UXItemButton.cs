using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.UI.Controls
{
	public class UXItemButton : UXButton
	{
		public new const int SizeOf = 0xE60; //3680
		public new const int VTable = 0x01826A28;

		public int xF48_Neg1 { get { return Read<int>(0xF48); } }
		public int xF4C_Flags { get { return Read<int>(0xF4C); } }
		public int xF50 { get { return Read<int>(0xF50); } }
		public int xF54_Neg1 { get { return Read<int>(0xF54); } }
		public int xF58_Neg1 { get { return Read<int>(0xF58); } }
		public int _xF5C { get { return Read<int>(0xF5C); } }
		public int xF60 { get { return Read<int>(0xF60); } }
		public int _xF64 { get { return Read<int>(0xF64); } }
	}
}
