using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.UI.Controls
{
	public class UXMinimap : UXItemsControl
	{
		// 2.0.6.24641
		public const int SizeOf = 0x12110;
		public const int VTable = 0x017B38C8;

		public UXMinimap(MemoryBase memory, int address)
			: base(memory, address) { }

		public int x00A58 { get { return Field<int>(0x00A58); } }
		public int _x00A5C { get { return Field<int>(0x00A5C); } }
		public UIReference x00A60_UIRef { get { return Field<UIReference>(0x00A60); } }
		public int x00C68 { get { return Field<int>(0x00C68); } }
		public int _x00C6C { get { return Field<int>(0x00C6C); } }
		public int x00C70 { get { return Field<int>(0x00C70); } }
		public int _x00C74 { get { return Field<int>(0x00C74); } }
		public int x00C78 { get { return Field<int>(0x00C78); } }
		public int _x00C7C { get { return Field<int>(0x00C7C); } }
		public int x00C80 { get { return Field<int>(0x00C80); } }
		public int _x00C84 { get { return Field<int>(0x00C84); } }
		public float x00C88_OffsetX { get { return Field<float>(0x00C88); } }
		public float x00C8C_OffsetY { get { return Field<float>(0x00C8C); } }
		public float x00C90_PrevOffsetX { get { return Field<float>(0x00C90); } } // These are set when starting to move map around.
		public float x00C94_PrevOffsetY { get { return Field<float>(0x00C94); } } // These are set when starting to move map around.
		public int x00C98_Neg1 { get { return Field<int>(0x00C98); } }
		public float x00C9C_1f { get { return Field<float>(0x00C9C); } }
		public float x00CA0_1f { get { return Field<float>(0x00CA0); } }
		public float x00CA4_1f { get { return Field<float>(0x00CA4); } }
		public int x00CA8_Neg1_TextureSnoId_MinimapMaskSidebar { get { return Field<int>(0x00CA8); } }
		public Item[] x00CAC_Items { get { return Field<Item>(0x00CAC, 256); } }
		public int x120AC { get { return Field<int>(0x120AC); } }
		public float _x120B0 { get { return Field<float>(0x120B0); } }
		public float _x120B4 { get { return Field<float>(0x120B4); } }
		public int _x120B8 { get { return Field<int>(0x120B8); } }
		public float _x120BC { get { return Field<float>(0x120BC); } }
		public float _x120C0 { get { return Field<float>(0x120C0); } }
		public int _x120C4 { get { return Field<int>(0x120C4); } }
		public float _x120C8 { get { return Field<float>(0x120C8); } }
		public float _x120CC { get { return Field<float>(0x120CC); } }
		public float _x120D0 { get { return Field<float>(0x120D0); } }
		public float _x120D4 { get { return Field<float>(0x120D4); } }
		public float _x120D8 { get { return Field<float>(0x120D8); } }
		public float _x120DC { get { return Field<float>(0x120DC); } }
		public float _x120E0 { get { return Field<float>(0x120E0); } }
		public float _x120E4 { get { return Field<float>(0x120E4); } }
		public float _x120E8 { get { return Field<float>(0x120E8); } }
		public float _x120EC { get { return Field<float>(0x120EC); } }
		public float _x120F0 { get { return Field<float>(0x120F0); } }
		public float _x120F4 { get { return Field<float>(0x120F4); } }
		public int x120F8_Neg1_MouseOverIndex { get { return Field<int>(0x120F8); } }
		public int x120FC_Neg1_MouseOverTick { get { return Field<int>(0x120FC); } }
		public int x12100 { get { return Field<int>(0x12100); } }
		public int x12104 { get { return Field<int>(0x12104); } }
		public int x12108 { get { return Field<int>(0x12108); } }
		public int _x1210C { get { return Field<int>(0x1210C); } }

		public class Item : MemoryObject
		{
			public const int SizeOf = 0x114;

			public Item(MemoryBase memory, int address)
				: base(memory, address) { }

			public string x000_Name { get { return Field(0x000, 0x100); } }
			public float x100_ScreenX { get { return Field<float>(0x100); } }
			public float x104_ScreenY { get { return Field<float>(0x104); } }
			public int x108_Neg1 { get { return Field<int>(0x108); } }
			public int x10C_Neg1 { get { return Field<int>(0x10C); } }
			public int x110 { get { return Field<int>(0x110); } }
		}
	}
}
