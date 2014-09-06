using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.UI.Controls
{
	public class UXDrawHook : UXControl
	{
		public new const int SizeOf = 0x458;
		public new const int VTable = 0x01751870;

		public int x450 { get { return Read<int>(0x450); } }
		public int _x454 { get { return Read<int>(0x454); } }
	}
}
