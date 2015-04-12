using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.UI.Controls
{
	public class UXTutorial : UXItemsControl
	{
		public new const int SizeOf = 0xC58; //3160
		public new const int VTable = 0x01827260;

		public UIReference xA48_UIRef { get { return Read<UIReference>(0xA48); } }
		public int xC50_Neg1 { get { return Read<int>(0xC50); } }
		public int xC54_Neg1 { get { return Read<int>(0xC54); } }
		public int xC58_Neg1 { get { return Read<int>(0xC58); } }
		public int xC5C { get { return Read<int>(0xC5C); } }
		public int xC60 { get { return Read<int>(0xC60); } }
		public int xC64 { get { return Read<int>(0xC64); } }
		public int xC68 { get { return Read<int>(0xC68); } }
		public int _xC6C { get { return Read<int>(0xC6C); } }
		public int _xC70 { get { return Read<int>(0xC70); } }
		public int _xC74 { get { return Read<int>(0xC74); } }
		public int _xC78 { get { return Read<int>(0xC78); } }
		public int _xC7C { get { return Read<int>(0xC7C); } }
	}
}
