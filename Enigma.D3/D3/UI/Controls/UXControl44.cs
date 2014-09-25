using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.UI.Controls
{
	public class UXControl44 : UXButton
	{
		public new const int SizeOf = 0xF60; //3936
		public new const int VTable = 0x0175CD60;

		public int xF48 { get { return Read<int>(0xF48); } }
		public int xF4C { get { return Read<int>(0xF4C); } }
		public int xF50 { get { return Read<int>(0xF50); } }
		public int xF54 { get { return Read<int>(0xF54); } }
		public int xF58 { get { return Read<int>(0xF58); } }
		public int _xF5C { get { return Read<int>(0xF5C); } }
	}
}
