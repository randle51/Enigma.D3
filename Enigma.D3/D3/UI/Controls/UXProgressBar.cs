using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.UI.Controls
{
	public class UXProgressBar : UXItemsControl
	{
		// 2.0.6.24641
		public const int SizeOf = 0x14A8;
		public const int VTable = 0x017C5430;

		public UXProgressBar(MemoryBase memory, int address)
			: base(memory, address) { }

		public int x0A58 { get { return Field<int>(0x0A58); } }
		public int x0A5C { get { return Field<int>(0x0A5C); } }
		public int x0A60 { get { return Field<int>(0x0A60); } }
		public int x0A64 { get { return Field<int>(0x0A64); } }
		public int x0A68 { get { return Field<int>(0x0A68); } }
		public int _x0A6C { get { return Field<int>(0x0A6C); } }
		public UIReference x0A70_UIRef_Foreground { get { return Field<UIReference>(0x0A70); } }
		public UIReference x0C78_UIRef_Background { get { return Field<UIReference>(0x0C78); } }
		public UIReference x0E80_UIRef { get { return Field<UIReference>(0x0E80); } }
		public UIReference x1088_UIRef { get { return Field<UIReference>(0x1088); } }
		public UIReference x1290_UIRef { get { return Field<UIReference>(0x1290); } }
		public int x1498 { get { return Field<int>(0x1498); } }
		public int x149C { get { return Field<int>(0x149C); } }
		public float x14A0 { get { return Field<float>(0x14A0); } }
		public int x14A4 { get { return Field<int>(0x14A4); } }
	}
}
