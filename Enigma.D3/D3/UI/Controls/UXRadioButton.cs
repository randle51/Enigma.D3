using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.UI.Controls
{
	public class UXRadioButton : UXButton
	{
		public new const int SizeOf = 0x1090; //4240
		public new const int VTable = 0x01826DD8;

		public int x0F48 { get { return Read<int>(0xF48); } }
		public int x0F4C { get { return Read<int>(0xF4C); } }
		public int x0F50 { get { return Read<int>(0xF50); } }
		public int x0F54 { get { return Read<int>(0xF54); } }
		public int x0F58_Neg1 { get { return Read<int>(0xF58); } }
		public int x0F5C_Neg1 { get { return Read<int>(0xF5C); } }
		public int x0F60_Neg1 { get { return Read<int>(0xF60); } }
		public int x0F64_Neg1 { get { return Read<int>(0xF64); } }
		public int x0F68_Neg1 { get { return Read<int>(0xF68); } }
		public int x0F6C_Neg1 { get { return Read<int>(0xF6C); } }
		public int x0F70_Neg1 { get { return Read<int>(0xF70); } }
		public int x0F74_Neg1 { get { return Read<int>(0xF74); } }
		public int x0F78_Neg1 { get { return Read<int>(0xF78); } }
		public int x0F7C_Neg1 { get { return Read<int>(0xF7C); } }
		public int x0F80_Neg1 { get { return Read<int>(0xF80); } }
		public int x0F84_Neg1 { get { return Read<int>(0xF84); } }
		public int x0F88_Neg1 { get { return Read<int>(0xF88); } }
		public int x0F8C_Neg1 { get { return Read<int>(0xF8C); } }
		public UIReference x0F90_UIRef { get { return Read<UIReference>(0xF90); } }
	}
}
