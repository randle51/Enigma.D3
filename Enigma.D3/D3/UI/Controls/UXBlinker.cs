using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.UI.Controls
{
	public class UXBlinker : UXLabel
	{
		public new const int SizeOf = 0xB90; //2960
		public new const int VTable = 0x01826888;

		public int xC88 { get { return Read<int>(0xC88); } }
		public int xC8C { get { return Read<int>(0xC8C); } }
		public int xC90 { get { return Read<int>(0xC90); } }
		public int xC94 { get { return Read<int>(0xC94); } }
		public int xC98 { get { return Read<int>(0xC98); } }
		public int _xC9C { get { return Read<int>(0xC9C); } }
	}
}
