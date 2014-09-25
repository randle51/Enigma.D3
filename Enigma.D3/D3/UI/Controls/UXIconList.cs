using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.UI.Controls
{
	public class UXIconList : UXItemsControl
	{
		public new const int SizeOf = 0xA70; //2672
		public new const int VTable = 0x01759BF8;

		public int xA48 { get { return Read<int>(0xA48); } }
		public int xA4C { get { return Read<int>(0xA4C); } }
		public float xA50 { get { return Read<float>(0xA50); } }
		public float xA54 { get { return Read<float>(0xA54); } }
		public float xA58 { get { return Read<float>(0xA58); } }
		public float xA5C { get { return Read<float>(0xA5C); } }
		public float xA60 { get { return Read<float>(0xA60); } }
		public float xA64 { get { return Read<float>(0xA64); } }
		public int xA68 { get { return Read<int>(0xA68); } }
		public int _xA6C { get { return Read<int>(0xA6C); } }
	}
}
