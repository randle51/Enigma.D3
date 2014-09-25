using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.UI.Controls
{
	public class UXItemTag : UXButton
	{
		public new const int SizeOf = 0xF58; //3928
		public new const int VTable = 0x0175A358;

		public int xF48_Neg1 { get { return Read<int>(0xF48); } }
		public int xF4C_Neg1 { get { return Read<int>(0xF4C); } }
		public int xF50_One { get { return Read<int>(0xF50); } }
		public int _xF54 { get { return Read<int>(0xF54); } }
	}
}
