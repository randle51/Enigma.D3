using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.UI.Controls
{
	public class UXChatEditLine : UXTextBox
	{
		// 2.0.6.24641
		public const int SizeOf = 0xF48;
		public const int VTable = 0x0176DC90;

		public UXChatEditLine(MemoryBase memory, int address)
			: base(memory, address) { }

		public int xCD8_StructStart_Min96Bytes { get { return Field<int>(0xCD8); } }
		public int _xCDC { get { return Field<int>(0xCDC); } }
		public int _xCE0 { get { return Field<int>(0xCE0); } }
		public int _xCE4 { get { return Field<int>(0xCE4); } }
		public int _xCE8 { get { return Field<int>(0xCE8); } }
		public int _xCEC { get { return Field<int>(0xCEC); } }
		public int _xCF0 { get { return Field<int>(0xCF0); } }
		public int _xCF4 { get { return Field<int>(0xCF4); } }
		public int _xCF8 { get { return Field<int>(0xCF8); } }
		public int _xCFC { get { return Field<int>(0xCFC); } }
		public int _xD00 { get { return Field<int>(0xD00); } }
		public int _xD04 { get { return Field<int>(0xD04); } }
		public int _xD08 { get { return Field<int>(0xD08); } }
		public int _xD0C { get { return Field<int>(0xD0C); } }
		public int _xD10 { get { return Field<int>(0xD10); } }
		public int _xD14 { get { return Field<int>(0xD14); } }
		public int _xD18 { get { return Field<int>(0xD18); } }
		public int _xD1C { get { return Field<int>(0xD1C); } }
		public int _xD20 { get { return Field<int>(0xD20); } }
		public int _xD24 { get { return Field<int>(0xD24); } }
		public int _xD28 { get { return Field<int>(0xD28); } }
		public int _xD2C { get { return Field<int>(0xD2C); } }
		public int _xD30 { get { return Field<int>(0xD30); } }
		public int _xD34 { get { return Field<int>(0xD34); } }
		public UIReference xD38_UIRef_ChannelName { get { return Field<UIReference>(0xD38); } }
		public float xF40 { get { return Field<float>(0xF40); } }
	}
}
