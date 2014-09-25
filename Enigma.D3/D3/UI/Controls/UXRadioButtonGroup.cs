using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.UI.Controls
{
	public class UXRadioButtonGroup : UXItemsControlBase
	{
		public new const int SizeOf = 0x498; //1176
		public new const int VTable = 0x0175A4F0;

		public int x490 { get { return Read<int>(0x490); } }
		public int x494 { get { return Read<int>(0x494); } }
	}
}
