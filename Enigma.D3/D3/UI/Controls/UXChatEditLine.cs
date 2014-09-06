using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.UI.Controls
{
	public class UXChatEditLine : UXTextBox
	{
		public new const int SizeOf = 0xF58;
		public new const int VTable = 0x01702278;

		public int xCE8_StructStart_Min96Bytes { get { return Read<int>(0xCE8); } }
		public int _xCEC { get { return Read<int>(0xCEC); } }
		public int _xCF0 { get { return Read<int>(0xCF0); } }
		public int _xCF4 { get { return Read<int>(0xCF4); } }
		public int _xCF8 { get { return Read<int>(0xCF8); } }
		public int _xCFC { get { return Read<int>(0xCFC); } }
		public int _xD00 { get { return Read<int>(0xD00); } }
		public int _xD04 { get { return Read<int>(0xD04); } }
		public int _xD08 { get { return Read<int>(0xD08); } }
		public int _xD0C { get { return Read<int>(0xD0C); } }
		public int _xD10 { get { return Read<int>(0xD10); } }
		public int _xD14 { get { return Read<int>(0xD14); } }
		public int _xD18 { get { return Read<int>(0xD18); } }
		public int _xD1C { get { return Read<int>(0xD1C); } }
		public int _xD20 { get { return Read<int>(0xD20); } }
		public int _xD24 { get { return Read<int>(0xD24); } }
		public int _xD28 { get { return Read<int>(0xD28); } }
		public int _xD2C { get { return Read<int>(0xD2C); } }
		public int _xD30 { get { return Read<int>(0xD30); } }
		public int _xD34 { get { return Read<int>(0xD34); } }
		public int _xD38 { get { return Read<int>(0xD38); } }
		public int _xD3C { get { return Read<int>(0xD3C); } }
		public int _xD40 { get { return Read<int>(0xD40); } }
		public int _xD44 { get { return Read<int>(0xD44); } }
		public UIReference xD48_UIRef_ChannelName { get { return Read<UIReference>(0xD48); } }
		public float xF50 { get { return Read<float>(0xF50); } }
		public int _xF54 { get { return Read<int>(0xF54); } }
	}
}
