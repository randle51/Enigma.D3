using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.UI.Controls
{
	public class UXControl35 : UXButton
	{
		public new const int SizeOf = 0xF70; //3952
		public new const int VTable = 0x0175CFF0;

		public int _xF48 { get { return Read<int>(0xF48); } }
		public int _xF4C { get { return Read<int>(0xF4C); } }
		public int _xF50 { get { return Read<int>(0xF50); } }
		public int _xF54 { get { return Read<int>(0xF54); } }
		public int _xF58 { get { return Read<int>(0xF58); } }
		public int _xF5C { get { return Read<int>(0xF5C); } }
		public int xF60_Neg1 { get { return Read<int>(0xF60); } }
		public int xF64_Neg1 { get { return Read<int>(0xF64); } }
		public int xF68_Neg1 { get { return Read<int>(0xF68); } }
		public int xF6C_Neg1 { get { return Read<int>(0xF6C); } }
	}
}
