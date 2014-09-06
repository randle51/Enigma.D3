using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.UI.Controls
{
	public class UXControl32 : UXLabel
	{
		public new const int SizeOf = 0xC98;
		public new const int VTable = 0x01750DA8;

		public int xC88_Neg1 { get { return Read<int>(0xC88); } }
		public int xC8C { get { return Read<int>(0xC8C); } }
		public int xC90 { get { return Read<int>(0xC90); } }
		public int xC94 { get { return Read<int>(0xC94); } }
	}
}
