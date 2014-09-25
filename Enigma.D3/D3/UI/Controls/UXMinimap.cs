using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.UI.Controls
{
	public class UXMinimap : UXItemsControl
	{
		public new const int SizeOf = 0x12100; //73984
		public new const int VTable = 0x0174AAA0;

		public int x00A48 { get { return Read<int>(0x00A48); } }
		public int _x00A4C { get { return Read<int>(0x00A4C); } }
		public UIReference x00A50_UIRef { get { return Read<UIReference>(0x00A50); } }
		public UIRect x00C58_UIRect { get { return Read<UIRect>(0x00C58); } }
		public UIRect x00C68_UIRect { get { return Read<UIRect>(0x00C68); } }
		public float x00C78_OffsetX { get { return Read<float>(0x00C78); } }
		public float x00C7C_OffsetY { get { return Read<float>(0x00C7C); } }
		public float x00C80_PrevOffsetX { get { return Read<float>(0x00C80); } } // These are set when starting to move map around.
		public float x00C84_PrevOffsetY { get { return Read<float>(0x00C84); } } // These are set when starting to move map around.
		public int x00C88_Neg1 { get { return Read<int>(0x00C88); } }
		public float x00C8C_1f { get { return Read<float>(0x00C8C); } }
		public float x00C90_1f { get { return Read<float>(0x00C90); } }
		public float x00C94_1f { get { return Read<float>(0x00C94); } }
		public int x00C98_Neg1_TextureSnoId_MinimapMaskSidebar { get { return Read<int>(0x00C98); } }
		public Item[] x00C9C_Items { get { return Read<Item>(0x00C9C, 256); } }
		public int x1209C { get { return Read<int>(0x1209C); } }
		public float _x120A0 { get { return Read<float>(0x120A0); } }
		public float _x120A4 { get { return Read<float>(0x120A4); } }
		public int _x120A8 { get { return Read<int>(0x120A8); } }
		public float _x120AC { get { return Read<float>(0x120AC); } }
		public float _x120B0 { get { return Read<float>(0x120B0); } }
		public int _x120B4 { get { return Read<int>(0x120B4); } }
		public float _x120B8 { get { return Read<float>(0x120B8); } }
		public float _x120BC { get { return Read<float>(0x120BC); } }
		public float _x120C0 { get { return Read<float>(0x120C0); } }
		public float _x120C4 { get { return Read<float>(0x120C4); } }
		public float _x120C8 { get { return Read<float>(0x120C8); } }
		public float _x120CC { get { return Read<float>(0x120CC); } }
		public float _x120D0 { get { return Read<float>(0x120D0); } }
		public float _x120D4 { get { return Read<float>(0x120D4); } }
		public float _x120D8 { get { return Read<float>(0x120D8); } }
		public float _x120DC { get { return Read<float>(0x120DC); } }
		public float _x120E0 { get { return Read<float>(0x120E0); } }
		public float _x120E4 { get { return Read<float>(0x120E4); } }
		public int x120E8_Neg1_MouseOverIndex { get { return Read<int>(0x120E8); } }
		public int x120EC_Neg1_MouseOverTick { get { return Read<int>(0x120EC); } }
		public int x120F0 { get { return Read<int>(0x120F0); } }
		public int x120F4 { get { return Read<int>(0x120F4); } }
		public int x120F8 { get { return Read<int>(0x120F8); } }
		public int _x120FC { get { return Read<int>(0x120FC); } }

		public class Item : MemoryObject
		{
			public const int SizeOf = 0x12100; //73984

			public string x000_Name { get { return ReadString(0x000, 0x100); } }
			public float x100_ScreenX { get { return Read<float>(0x100); } }
			public float x104_ScreenY { get { return Read<float>(0x104); } }
			public int x108_Neg1 { get { return Read<int>(0x108); } }
			public int x10C_Neg1 { get { return Read<int>(0x10C); } }
			public int x110 { get { return Read<int>(0x110); } }
		}
	}
}
