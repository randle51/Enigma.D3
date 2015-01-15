using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.UI.Controls
{
	public class UXTimer : UXItemsControl
	{
		public new const int SizeOf = 0xC60; //3168
		public new const int VTable = 0x01773E20;

		public int xA48 { get { return Read<int>(0xA48); } }
		public int xA4C { get { return Read<int>(0xA4C); } }
		public int xA50 { get { return Read<int>(0xA50); } }
		public int _xA54 { get { return Read<int>(0xA54); } }
		public UIReference xA58_UIRef_Blinker { get { return Read<UIReference>(0xA58); } }
	}
}
