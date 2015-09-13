using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.UI.Controls
{
	public class UXRadioButtonGroup : UXItemsControlBase
	{
		public new const int SizeOf = 0x470; //1136
		public new const int VTable = 0x01826D50;

		public int x468 { get { return Read<int>(0x468); } }
		public int x46C { get { return Read<int>(0x46C); } }
	}
}
