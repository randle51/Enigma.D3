using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.UI.Controls
{
	public class UXRadioButton : UXButton
	{
		// 2.0.6.24641
		public const int SizeOf = 0x1188;
		public const int VTable = 0x017C3318;

		public UXRadioButton(MemoryBase memory, int address)
			: base(memory, address) { }

		public int x0F38 { get { return Field<int>(0xF38); } }
		public int x0F3C { get { return Field<int>(0xF3C); } }
		public int x0F40 { get { return Field<int>(0xF40); } }
		public int x0F44 { get { return Field<int>(0xF44); } }
		public int x0F48_Neg1 { get { return Field<int>(0xF48); } }
		public int x0F4C_Neg1 { get { return Field<int>(0xF4C); } }
		public int x0F50_Neg1 { get { return Field<int>(0xF50); } }
		public int x0F54_Neg1 { get { return Field<int>(0xF54); } }
		public int x0F58_Neg1 { get { return Field<int>(0xF58); } }
		public int x0F5C_Neg1 { get { return Field<int>(0xF5C); } }
		public int x0F60_Neg1 { get { return Field<int>(0xF60); } }
		public int x0F64_Neg1 { get { return Field<int>(0xF64); } }
		public int x0F68_Neg1 { get { return Field<int>(0xF68); } }
		public int x0F6C_Neg1 { get { return Field<int>(0xF6C); } }
		public int x0F70_Neg1 { get { return Field<int>(0xF70); } }
		public int x0F74_Neg1 { get { return Field<int>(0xF74); } }
		public int x0F78_Neg1 { get { return Field<int>(0xF78); } }
		public int x0F7C_Neg1 { get { return Field<int>(0xF7C); } }
		public UIReference x0F80_UIRef { get { return Field<UIReference>(0xF80); } }
	}
}
