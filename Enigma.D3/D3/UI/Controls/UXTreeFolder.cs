using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.UI.Controls
{
	public class UXTreeFolder : UXItemsControl
	{
		public new const int SizeOf = 0xE38; //3640
		public new const int VTable = 0x018262F8;

		public float xA48 { get { return Read<float>(0xA48); } }
		public float xA4C { get { return Read<float>(0xA4C); } }
		public UIReference xA50_UIRef { get { return Read<UIReference>(0xA50); } }
		public UIReference xC58_UIRef { get { return Read<UIReference>(0xC58); } }
	}
}
