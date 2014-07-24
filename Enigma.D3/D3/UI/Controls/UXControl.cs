using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.UI.Controls
{
	public class UXControl : MemoryObject
	{
		// 2.0.6.24641
		public const int SizeOf = 0x460;
		public const int VTable = 0x0176DBD8;

		public UXControl(MemoryBase memory, int address)
			: base(memory, address) { }

		public int x000_VTable { get { return Field<int>(0x000); } }
		public int _x004 { get { return Field<int>(0x004); } }
		public int x008 { get { return Field<int>(0x008); } }
		public int x00C { get { return Field<int>(0x00C); } }
		public int x010 { get { return Field<int>(0x010); } }
		public int x014 { get { return Field<int>(0x014); } }
		public int x018 { get { return Field<int>(0x018); } }
		public int x01C { get { return Field<int>(0x01C); } }
		public int x020 { get { return Field<int>(0x020); } }
		public int x024_Flags { get { return Field<int>(0x024); } } // 1 = IsValid?, 2 = ???, 3 = IsVisible?
		public UXControl x028_UIControl { get { return Dereference<UXControl>(0x028); } }
		public UXControl x02C_UIControl { get { return Dereference<UXControl>(0x02C); } }
		public UIReference x030_Self { get { return Field<UIReference>(0x030); } }
		public UIReference x238_Parent { get { return Field<UIReference>(0x238); } }
		public int x440 { get { return Field<int>(0x440); } }
		public int x444 { get { return Field<int>(0x444); } }
		public int x448_UISnoId_StructStart_Min16Bytes { get { return Field<int>(0x448); } }
		public int x44C { get { return Field<int>(0x44C); } }
		public int x450 { get { return Field<int>(0x450); } }
		public int x454 { get { return Field<int>(0x454); } }
		public RefString x458_Ptr_RefString { get { return Dereference<RefString>(0x458); } }
		public RefString x45C_Ptr_RefString { get { return Dereference<RefString>(0x45C); } }

		public override string ToString()
		{
			return x030_Self.ToString();
		}
	}
}
