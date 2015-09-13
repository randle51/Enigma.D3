using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.UI.Controls
{
	public class UXHotKeyButton : UXButton
	{
		public new const int SizeOf = 0xE48; //3656
		public new const int VTable = 0x01826648;

		public int xF48_Neg1 { get { return Read<int>(0xF48); } }
		public int xF4C { get { return Read<int>(0xF4C); } }
	}
}
