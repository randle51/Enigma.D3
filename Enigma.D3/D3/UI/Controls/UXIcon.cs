using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.UI.Controls
{
	public class UXIcon : UXButton
	{
		// 2.0.6.24641
		public const int SizeOf = 0x1368;
		public const int VTable = 0x017C2EA0;

		public UXIcon(MemoryBase memory, int address)
			: base(memory, address) { }

		public UIReference x0F38_UIRef_Timer { get { return Field<UIReference>(0x0F38); } }
		public UIReference x1140_UIRef_Label { get { return Field<UIReference>(0x1140); } }
		public int x1348 { get { return Field<int>(0x1348); } }
		public int x134C { get { return Field<int>(0x134C); } }
		public int x1350_Neg1 { get { return Field<int>(0x1350); } }
		public int x1354_Neg1 { get { return Field<int>(0x1354); } }
		public int x1358_Neg1 { get { return Field<int>(0x1358); } }
		public int x135C_Neg1 { get { return Field<int>(0x135C); } }
		public int x1360_Neg1 { get { return Field<int>(0x1360); } }
		public int _x1364 { get { return Field<int>(0x1364); } }
	}
}
