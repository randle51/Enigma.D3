using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.UI.Controls
{
	public class UXColorPicker : UXItemsControl
	{
		public new const int SizeOf = 0xC78; //3192
		public new const int VTable = 0x017598C0;

		public UIReference xA48_UIRef { get { return Read<UIReference>(0xA48); } }
		public int xC50_Neg1 { get { return Read<int>(0xC50); } }
		public int _xC54 { get { return Read<int>(0xC54); } }
		public int xC58 { get { return Read<int>(0xC58); } }
		public int _xC5C { get { return Read<int>(0xC5C); } }
		public int xC60 { get { return Read<int>(0xC60); } }
		public int _xC64 { get { return Read<int>(0xC64); } }
		public int xC68 { get { return Read<int>(0xC68); } }
		public int _xC6C { get { return Read<int>(0xC6C); } }
		public int xC70 { get { return Read<int>(0xC70); } }
		public int xC74 { get { return Read<int>(0xC74); } }
	}
}
