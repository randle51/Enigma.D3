using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.UI.Controls
{
	public class UXHotKey : UXControl
	{
		public new const int SizeOf = 0x468;
		public new const int VTable = 0x01754500;

		public int x450 { get { return Read<int>(0x450); } }
		public int x454 { get { return Read<int>(0x454); } }
		public int x458 { get { return Read<int>(0x458); } }
		public int x45C { get { return Read<int>(0x45C); } }
		public int x450_Neg1 { get { return Read<int>(0x460); } }
		public int x464 { get { return Read<int>(0x464); } }
	}
}
