using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.UI.Controls
{
	public class UXChatEditLine : UXTextBox
	{
		public new const int SizeOf = 0xE48; //3656
		public new const int VTable = 0x017CF258;

		public int xBD8_StructStart_Min96Bytes { get { return Read<int>(0xBD8); } }
		public int _xBDC { get { return Read<int>(0xBDC); } }
		public int _xBE0 { get { return Read<int>(0xBE0); } }
		public int _xBE4 { get { return Read<int>(0xBE4); } }
		public int _xBE8 { get { return Read<int>(0xBE8); } }
		public int _xBEC { get { return Read<int>(0xBEC); } }
		public int _xBF0 { get { return Read<int>(0xBF0); } }
		public int _xBF4 { get { return Read<int>(0xBF4); } }
		public int _xBF8 { get { return Read<int>(0xBF8); } }
		public int _xBFC { get { return Read<int>(0xBFC); } }
		public int _xC00 { get { return Read<int>(0xC00); } }
		public int _xC04 { get { return Read<int>(0xC04); } }
		public int _xC08 { get { return Read<int>(0xC08); } }
		public int _xC0C { get { return Read<int>(0xC0C); } }
		public int _xC10 { get { return Read<int>(0xC10); } }
		public int _xC14 { get { return Read<int>(0xC14); } }
		public int _xC18 { get { return Read<int>(0xC18); } }
		public int _xC1C { get { return Read<int>(0xC1C); } }
		public int _xC20 { get { return Read<int>(0xC20); } }
		public int _xC24 { get { return Read<int>(0xC24); } }
		public int _xC28 { get { return Read<int>(0xC28); } }
		public int _xC2C { get { return Read<int>(0xC2C); } }
		public int _xC30 { get { return Read<int>(0xC30); } }
		public int _xC34 { get { return Read<int>(0xC34); } }
		public UIReference xC38_UIRef_ChannelName { get { return Read<UIReference>(0xC38); } }
		public float xE40 { get { return Read<float>(0xE40); } }
		public int _xE44 { get { return Read<int>(0xE44); } }
	}
}
