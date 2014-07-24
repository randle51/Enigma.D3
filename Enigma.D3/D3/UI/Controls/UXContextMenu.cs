using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.UI.Controls
{
	public class UXContextMenu : UXStackPanel
	{
		// 2.0.6.24641
		public const int SizeOf = 0x12B0;
		public const int VTable = 0x017AF8D0;

		public UXContextMenu(MemoryBase memory, int address)
			: base(memory, address) { }

		public int x0A80 { get { return Field<int>(0x0A80); } }
		public int _x0A84 { get { return Field<int>(0x0A84); } }
		public UIReference x0A88_UIRef { get { return Field<UIReference>(0x0A88); } }
		public int _x0C90 { get { return Field<int>(0x0C90); } }
		public int _x0C94 { get { return Field<int>(0x0C94); } }
		public int _x0C98 { get { return Field<int>(0x0C98); } }
		public int _x0C9C { get { return Field<int>(0x0C9C); } }
		public int _x0CA0 { get { return Field<int>(0x0CA0); } }
		public int _x0CA4 { get { return Field<int>(0x0CA4); } }
		public int _x0CA8 { get { return Field<int>(0x0CA8); } }
		public int _x0CAC { get { return Field<int>(0x0CAC); } }
		public int _x0CB0 { get { return Field<int>(0x0CB0); } }
		public int _x0CB4 { get { return Field<int>(0x0CB4); } }
		public int _x0CB8 { get { return Field<int>(0x0CB8); } }
		public int _x0CBC { get { return Field<int>(0x0CBC); } }
		public int _x0CC0 { get { return Field<int>(0x0CC0); } }
		public int _x0CC4 { get { return Field<int>(0x0CC4); } }
		public int _x0CC8 { get { return Field<int>(0x0CC8); } }
		public int _x0CCC { get { return Field<int>(0x0CCC); } }
		public int _x0CD0 { get { return Field<int>(0x0CD0); } }
		public int _x0CD4 { get { return Field<int>(0x0CD4); } }
		public int _x0CD8 { get { return Field<int>(0x0CD8); } }
		public int _x0CDC { get { return Field<int>(0x0CDC); } }
		public int _x0CE0 { get { return Field<int>(0x0CE0); } }
		public int _x0CE4 { get { return Field<int>(0x0CE4); } }
		public int _x0CE8 { get { return Field<int>(0x0CE8); } }
		public int _x0CEC { get { return Field<int>(0x0CEC); } }
		public int _x0CF0 { get { return Field<int>(0x0CF0); } }
		public int _x0CF4 { get { return Field<int>(0x0CF4); } }
		public int _x0CF8 { get { return Field<int>(0x0CF8); } }
		public int _x0CFC { get { return Field<int>(0x0CFC); } }
		public int _x0D00 { get { return Field<int>(0x0D00); } }
		public int _x0D04 { get { return Field<int>(0x0D04); } }
		public int _x0D08 { get { return Field<int>(0x0D08); } }
		public int _x0D0C { get { return Field<int>(0x0D0C); } }
		public int _x0D10 { get { return Field<int>(0x0D10); } }
		public int _x0D14 { get { return Field<int>(0x0D14); } }
		public int _x0D18 { get { return Field<int>(0x0D18); } }
		public int _x0D1C { get { return Field<int>(0x0D1C); } }
		public int _x0D20 { get { return Field<int>(0x0D20); } }
		public int _x0D24 { get { return Field<int>(0x0D24); } }
		public int _x0D28 { get { return Field<int>(0x0D28); } }
		public int _x0D2C { get { return Field<int>(0x0D2C); } }
		public int _x0D30 { get { return Field<int>(0x0D30); } }
		public int _x0D34 { get { return Field<int>(0x0D34); } }
		public int _x0D38 { get { return Field<int>(0x0D38); } }
		public int _x0D3C { get { return Field<int>(0x0D3C); } }
		public int _x0D40 { get { return Field<int>(0x0D40); } }
		public int _x0D44 { get { return Field<int>(0x0D44); } }
		public int _x0D48 { get { return Field<int>(0x0D48); } }
		public int _x0D4C { get { return Field<int>(0x0D4C); } }
		public int _x0D50 { get { return Field<int>(0x0D50); } }
		public int _x0D54 { get { return Field<int>(0x0D54); } }
		public int _x0D58 { get { return Field<int>(0x0D58); } }
		public int _x0D5C { get { return Field<int>(0x0D5C); } }
		public int _x0D60 { get { return Field<int>(0x0D60); } }
		public int _x0D64 { get { return Field<int>(0x0D64); } }
		public int _x0D68 { get { return Field<int>(0x0D68); } }
		public int _x0D6C { get { return Field<int>(0x0D6C); } }
		public int _x0D70 { get { return Field<int>(0x0D70); } }
		public int _x0D74 { get { return Field<int>(0x0D74); } }
		public int _x0D78 { get { return Field<int>(0x0D78); } }
		public int _x0D7C { get { return Field<int>(0x0D7C); } }
		public int _x0D80 { get { return Field<int>(0x0D80); } }
		public int _x0D84 { get { return Field<int>(0x0D84); } }
		public int _x0D88 { get { return Field<int>(0x0D88); } }
		public int _x0D8C { get { return Field<int>(0x0D8C); } }
		public int _x0D90 { get { return Field<int>(0x0D90); } }
		public int _x0D94 { get { return Field<int>(0x0D94); } }
		public int _x0D98 { get { return Field<int>(0x0D98); } }
		public int _x0D9C { get { return Field<int>(0x0D9C); } }
		public int _x0DA0 { get { return Field<int>(0x0DA0); } }
		public int _x0DA4 { get { return Field<int>(0x0DA4); } }
		public int _x0DA8 { get { return Field<int>(0x0DA8); } }
		public int _x0DAC { get { return Field<int>(0x0DAC); } }
		public int _x0DB0 { get { return Field<int>(0x0DB0); } }
		public int _x0DB4 { get { return Field<int>(0x0DB4); } }
		public int _x0DB8 { get { return Field<int>(0x0DB8); } }
		public int _x0DBC { get { return Field<int>(0x0DBC); } }
		public int _x0DC0 { get { return Field<int>(0x0DC0); } }
		public int _x0DC4 { get { return Field<int>(0x0DC4); } }
		public int _x0DC8 { get { return Field<int>(0x0DC8); } }
		public int _x0DCC { get { return Field<int>(0x0DCC); } }
		public int _x0DD0 { get { return Field<int>(0x0DD0); } }
		public int _x0DD4 { get { return Field<int>(0x0DD4); } }
		public int _x0DD8 { get { return Field<int>(0x0DD8); } }
		public int _x0DDC { get { return Field<int>(0x0DDC); } }
		public int _x0DE0 { get { return Field<int>(0x0DE0); } }
		public int _x0DE4 { get { return Field<int>(0x0DE4); } }
		public int _x0DE8 { get { return Field<int>(0x0DE8); } }
		public int _x0DEC { get { return Field<int>(0x0DEC); } }
		public int _x0DF0 { get { return Field<int>(0x0DF0); } }
		public int _x0DF4 { get { return Field<int>(0x0DF4); } }
		public int _x0DF8 { get { return Field<int>(0x0DF8); } }
		public int _x0DFC { get { return Field<int>(0x0DFC); } }
		public int _x0E00 { get { return Field<int>(0x0E00); } }
		public int _x0E04 { get { return Field<int>(0x0E04); } }
		public int _x0E08 { get { return Field<int>(0x0E08); } }
		public int _x0E0C { get { return Field<int>(0x0E0C); } }
		public int _x0E10 { get { return Field<int>(0x0E10); } }
		public int _x0E14 { get { return Field<int>(0x0E14); } }
		public int _x0E18 { get { return Field<int>(0x0E18); } }
		public int _x0E1C { get { return Field<int>(0x0E1C); } }
		public int _x0E20 { get { return Field<int>(0x0E20); } }
		public int _x0E24 { get { return Field<int>(0x0E24); } }
		public int _x0E28 { get { return Field<int>(0x0E28); } }
		public int _x0E2C { get { return Field<int>(0x0E2C); } }
		public int _x0E30 { get { return Field<int>(0x0E30); } }
		public int _x0E34 { get { return Field<int>(0x0E34); } }
		public int _x0E38 { get { return Field<int>(0x0E38); } }
		public int _x0E3C { get { return Field<int>(0x0E3C); } }
		public int _x0E40 { get { return Field<int>(0x0E40); } }
		public int _x0E44 { get { return Field<int>(0x0E44); } }
		public int _x0E48 { get { return Field<int>(0x0E48); } }
		public int _x0E4C { get { return Field<int>(0x0E4C); } }
		public int _x0E50 { get { return Field<int>(0x0E50); } }
		public int _x0E54 { get { return Field<int>(0x0E54); } }
		public int _x0E58 { get { return Field<int>(0x0E58); } }
		public int _x0E5C { get { return Field<int>(0x0E5C); } }
		public int _x0E60 { get { return Field<int>(0x0E60); } }
		public int _x0E64 { get { return Field<int>(0x0E64); } }
		public int _x0E68 { get { return Field<int>(0x0E68); } }
		public int _x0E6C { get { return Field<int>(0x0E6C); } }
		public int _x0E70 { get { return Field<int>(0x0E70); } }
		public int _x0E74 { get { return Field<int>(0x0E74); } }
		public int _x0E78 { get { return Field<int>(0x0E78); } }
		public int _x0E7C { get { return Field<int>(0x0E7C); } }
		public int _x0E80 { get { return Field<int>(0x0E80); } }
		public int _x0E84 { get { return Field<int>(0x0E84); } }
		public int _x0E88 { get { return Field<int>(0x0E88); } }
		public int _x0E8C { get { return Field<int>(0x0E8C); } }
		public int _x0E90 { get { return Field<int>(0x0E90); } }
		public int _x0E94 { get { return Field<int>(0x0E94); } }
		public UIReference x0E98_UIRef { get { return Field<UIReference>(0x0E98); } }
		public UIReference x10A0_UIRef { get { return Field<UIReference>(0x10A0); } }
		public int x12A8_One { get { return Field<int>(0x12A8); } }
		public int x12AC_Neg1 { get { return Field<int>(0x12AC); } }
	}
}
