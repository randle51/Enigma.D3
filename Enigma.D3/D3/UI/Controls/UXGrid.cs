using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.UI.Controls
{
	public class UXGrid : UXList
	{
		public new const int SizeOf = 0x1118; //4376
		public new const int VTable = 0x01829B28;

		public float x1190 { get { return Read<float>(0x1190); } }
		public int _x1194 { get { return Read<int>(0x1194); } }
	}
}
