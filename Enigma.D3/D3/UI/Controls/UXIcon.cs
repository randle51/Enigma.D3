using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.UI.Controls
{
	[Obsolete("Gotten larger, fields not checked.")]
	public class UXIcon : UXButton
	{
		public new const int SizeOf = 0x1580;
		public new const int VTable = 0x01750FF0;

		public UIReference x0F48_UIRef_Timer { get { return Read<UIReference>(0x0F48); } }
		public UIReference x1150_UIRef_Label { get { return Read<UIReference>(0x1150); } }
		public int x1358 { get { return Read<int>(0x1358); } }
		public int x135C { get { return Read<int>(0x135C); } }
		public int x1360_Neg1 { get { return Read<int>(0x1360); } }
		public int x1364_Neg1 { get { return Read<int>(0x1364); } }
		public int x1368_Neg1 { get { return Read<int>(0x1368); } }
		public int x136C_Neg1 { get { return Read<int>(0x136C); } }
		public int x1370_Neg1 { get { return Read<int>(0x1370); } }
		public int _x1374 { get { return Read<int>(0x1374); } }
	}
}
