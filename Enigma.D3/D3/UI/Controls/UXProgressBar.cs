using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.UI.Controls
{
	public class UXProgressBar : UXItemsControl
	{
		public new const int SizeOf = 0x1498;
		public new const int VTable = 0x017535E0;

		public int x0A48 { get { return Read<int>(0x0A48); } }
		public int x0A4C { get { return Read<int>(0x0A4C); } }
		public int x0A50 { get { return Read<int>(0x0A50); } }
		public int x0A54 { get { return Read<int>(0x0A54); } }
		public int x0A58 { get { return Read<int>(0x0A58); } }
		public int _x0A5C { get { return Read<int>(0x0A5C); } }
		public UIReference x0A60_UIRef_Foreground { get { return Read<UIReference>(0x0A60); } }
		public UIReference x0C68_UIRef_Background { get { return Read<UIReference>(0x0C68); } }
		public UIReference x0E70_UIRef { get { return Read<UIReference>(0x0E70); } }
		public UIReference x1078_UIRef { get { return Read<UIReference>(0x1078); } }
		public UIReference x1280_UIRef { get { return Read<UIReference>(0x1280); } }
		public int x1488 { get { return Read<int>(0x1488); } }
		public int x148C { get { return Read<int>(0x148C); } }
		public float x1490 { get { return Read<float>(0x1490); } }
		public int x1494 { get { return Read<int>(0x1494); } }
	}
}
