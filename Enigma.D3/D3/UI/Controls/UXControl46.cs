using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.UI.Controls
{
	public class UXControl46 : UXItemsControl
	{
		public new const int SizeOf = 0xC60; //3168
		public new const int VTable = 0x0175CCB8;

		public int xA48 { get { return Read<int>(0xA48); } }
		public int xA4C { get { return Read<int>(0xA4C); } }
		public UIReference xA50_UIRef { get { return Read<UIReference>(0xA50); } }
		public int xC58 { get { return Read<int>(0xC58); } }
		public int xC5C { get { return Read<int>(0xC5C); } }
	}
}
