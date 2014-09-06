using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.UI.Controls
{
	public class UXTextBox : UXLabel
	{
		public new const int SizeOf = 0xCE8;
		public new const int VTable = 0x01702070;

		public int xC88_Anim2DSnoId_EditBoxCursor { get { return Read<int>(0xC88); } }
		public float xC8C_AnimClock { get { return Read<float>(0xC8C); } }
		public float xC90_AnimClock { get { return Read<float>(0xC90); } }
		public float xC94_AnimClockFrom { get { return Read<float>(0xC94); } }
		public float xC98_AnimClockTo { get { return Read<float>(0xC98); } }
		public int xC9C_Flags { get { return Read<int>(0xC9C); } }
		public int xCA0_CaretPosition { get { return Read<int>(0xCA0); } }
		public int xCA4_CaretMaxPosition { get { return Read<int>(0xCA4); } }
		public int xCA8_InputMaxLength { get { return Read<int>(0xCA8); } }
		public int xCAC_InputLength { get { return Read<int>(0xCAC); } }
		public int xCB0 { get { return Read<int>(0xCB0); } }
		public int xCB4 { get { return Read<int>(0xCB4); } }
		public int xCB8 { get { return Read<int>(0xCB8); } }
		public int xCBC { get { return Read<int>(0xCBC); } }
		public int xCC0 { get { return Read<int>(0xCC0); } }
		public int xCC4 { get { return Read<int>(0xCC4); } }
		public int xCC8 { get { return Read<int>(0xCC8); } }
		public int xCCC { get { return Read<int>(0xCCC); } }
		public int xCD0 { get { return Read<int>(0xCD0); } }
		public int xCD4 { get { return Read<int>(0xCD4); } }
		public int xCD8 { get { return Read<int>(0xCD8); } }
		public float xCDC { get { return Read<float>(0xCDC); } }
		public float xCE0 { get { return Read<float>(0xCE0); } }
		public int xCE4 { get { return Read<int>(0xCE4); } }
	}
}
