using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.UI.Controls
{
	public class UXTree : UXItemsControl
	{
		public new const int SizeOf = 0xE60; //3680
		public new const int VTable = 0x01770D20;

		public int xA48 { get { return Read<int>(0xA48); } }
		public int _xA4C { get { return Read<int>(0xA4C); } }
		public UIReference xA50_UIRef_StackPanel { get { return Read<UIReference>(0xA50); } }
		public UIReference xC58_UIRef { get { return Read<UIReference>(0xC58); } }
	}
}
