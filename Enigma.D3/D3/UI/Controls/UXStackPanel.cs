using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.UI.Controls
{
	public class UXStackPanel : UXItemsControl
	{
		public new const int SizeOf = 0xA70; //2672
		public new const int VTable = 0x01759CA0;

		public int xA48 { get { return Read<int>(0xA48); } }
		public int xA4C { get { return Read<int>(0xA4C); } }
		public float xA50 { get { return Read<float>(0xA50); } }
		public float xA54 { get { return Read<float>(0xA54); } }
		public float xA58 { get { return Read<float>(0xA58); } }
		public float xA5C { get { return Read<float>(0xA5C); } }
		public float xA60 { get { return Read<float>(0xA60); } }
		public int xA64_Base_x500 { get { return Read<int>(0xA64); } }
		public int xA68_Base_x504 { get { return Read<int>(0xA68); } }
		public int xA6C { get { return Read<int>(0xA6C); } }
	}
}
