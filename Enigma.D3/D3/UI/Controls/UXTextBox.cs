using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.UI.Controls
{
	public class UXTextBox : UXLabel
	{
		// 2.0.6.24641
		public const int SizeOf = 0xCD8;
		public const int VTable = 0x0176DA88;

		public UXTextBox(MemoryBase memory, int address)
			: base(memory, address) { }

		public int xC78_Anim2DSnoId_EditBoxCursor { get { return Field<int>(0xC78); } }
		public float xC7C_AnimClock { get { return Field<float>(0xC7C); } }
		public float xC80_AnimClock { get { return Field<float>(0xC80); } }
		public float xC84_AnimClockFrom { get { return Field<float>(0xC84); } }
		public float xC88_AnimClockTo { get { return Field<float>(0xC88); } }
		public int xC8C_Flags { get { return Field<int>(0xC8C); } }
		public int xC90_CaretPosition { get { return Field<int>(0xC90); } }
		public int xC94_CaretMaxPosition { get { return Field<int>(0xC94); } }
		public int xC98_InputMaxLength { get { return Field<int>(0xC98); } }
		public int xC9C_InputLength { get { return Field<int>(0xC9C); } }
		public int xCA0 { get { return Field<int>(0xCA0); } }
		public int xCA4 { get { return Field<int>(0xCA4); } }
		public int xCA8 { get { return Field<int>(0xCA8); } }
		public int xCAC { get { return Field<int>(0xCAC); } }
		public int xCB0 { get { return Field<int>(0xCB0); } }
		public int xCB4 { get { return Field<int>(0xCB4); } }
		public int xCB8 { get { return Field<int>(0xCB8); } }
		public int xCBC { get { return Field<int>(0xCBC); } }
		public int xCC0 { get { return Field<int>(0xCC0); } }
		public int xCC4 { get { return Field<int>(0xCC4); } }
		public int xCC8 { get { return Field<int>(0xCC8); } }
		public float xCCC { get { return Field<float>(0xCCC); } }
		public float xCD0 { get { return Field<float>(0xCD0); } }
		public int xCD4 { get { return Field<int>(0xCD4); } }
	}
}
