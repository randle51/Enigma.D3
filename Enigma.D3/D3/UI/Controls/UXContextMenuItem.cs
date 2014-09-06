using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.UI.Controls
{
	public class UXContextMenuItem : UXButton
	{
		public new const int SizeOf = 0x1158;
		public new const int VTable = 0x01753DE0;

		public int x0F48_One { get { return Read<int>(0xF48); } }
		public int _x0F4C { get { return Read<int>(0xF4C); } }
		public UIReference x0F50_UIRef { get { return Read<UIReference>(0xF50); } }
	}
}
