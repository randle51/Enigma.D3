using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.UI.Controls
{
	public class UXIcon : UXButton
	{
		public new const int SizeOf = 0x1580; //5504
		public new const int VTable = 0x017712E0;

		public UIReference x0F48_UIRef_Timer { get { return Read<UIReference>(0x0F48); } }
		public UIReference x1150_UIRef_Label { get { return Read<UIReference>(0x1150); } }
		public UIReference x1358_UIRef_RechargeTimer { get { return Read<UIReference>(0x1358); } }
		public int x1560 { get { return Read<int>(0x1560); } }
		public int x1564 { get { return Read<int>(0x1564); } }
		public int x1568_IsDisabled { get { return Read<int>(0x1568); } }
		public int x156C_PowerSnoId { get { return Read<int>(0x156C); } }
		public int _x1570 { get { return Read<int>(0x1570); } }
		public int x1574_Neg1 { get { return Read<int>(0x1574); } }
		public int x1578_AnnId { get { return Read<int>(0x1578); } }
		public int _x157C { get { return Read<int>(0x157C); } }
	}
}
