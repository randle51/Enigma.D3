using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.UI.Controls
{
	public class UXIcon : UXButton
	{
		public new const int SizeOf = 0x1478; //5240
		public new const int VTable = 0x01826950;

		public UIReference x0E40_UIRef_Timer { get { return Read<UIReference>(0x0E40); } }
		public UIReference x1048_UIRef_Label { get { return Read<UIReference>(0x1048); } }
		public UIReference x1250_UIRef_RechargeTimer { get { return Read<UIReference>(0x1250); } }
		public int x1458 { get { return Read<int>(0x1458); } }
		public int x145C { get { return Read<int>(0x145C); } }
		public int x1460_IsDisabled { get { return Read<int>(0x1460); } }
		public int x1464_PowerSnoId { get { return Read<int>(0x1464); } }
		public int _x1468 { get { return Read<int>(0x1468); } }
		public int x146C_Neg1 { get { return Read<int>(0x146C); } }
		public int x1470_AnnId { get { return Read<int>(0x1470); } }
		public int _x1474 { get { return Read<int>(0x1474); } }
	}
}
