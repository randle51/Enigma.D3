using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.UI.Controls
{
	internal class UXText : UXItemsControl
	{
		public new const int SizeOf = 0xC70; //3184
		public new const int VTable = 0x01771838;

		public int xA48 { get { return Read<int>(0xA48); } }
		public int xA4C { get { return Read<int>(0xA4C); } }
		public int xA50 { get { return Read<int>(0xA50); } }
		public int xA54 { get { return Read<int>(0xA54); } }
		public int xA58 { get { return Read<int>(0xA58); } }
		public float xA5C { get { return Read<float>(0xA5C); } }
		public int xA60 { get { return Read<int>(0xA60); } }
		public int xA64 { get { return Read<int>(0xA64); } }
		public UIReference xA68_UIRef { get { return Read<UIReference>(0xA68); } }
	}
}
