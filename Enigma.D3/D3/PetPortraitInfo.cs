using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Enigma.D3.Collections;
using Enigma.D3.UI;

namespace Enigma.D3
{
	public class PetPortraitInfo : MemoryObject
	{
		// 2.1.0.26451
		public const int SizeOf = 0xA08; // 2568

		public Vector x000_Array { get { return Read<Vector>(0x000); } }
		public UIReference x038_UIRef_Menu_ { get { return Read<UIReference>(0x038); } }
		public UIReference x240_UIRef_MenuContent { get { return Read<UIReference>(0x240); } }
		public UIReference x448_UIRef_MenuList { get { return Read<UIReference>(0x448); } }
		public int x650_Neg1_PetId_ { get { return Read<int>(0x650); } }
		public int _x654 { get { return Read<int>(0x654); } }
		public UIReference x658_UIRef { get { return Read<UIReference>(0x658); } }
		public Item[] x860_Array { get { return Read<Item>(0x860, 21); } }
		public int xA04_Count { get { return Read<int>(0xA04); } }



		public class Item : MemoryObject
		{
			public const int SizeOf = 0x14;

			public int x00_Neg1 { get { return Read<int>(0x00); } }
			public int x04 { get { return Read<int>(0x04); } }
			public int x08 { get { return Read<int>(0x08); } }
			public int x0C { get { return Read<int>(0x0C); } }
			public int x10 { get { return Read<int>(0x10); } }
		}
	}
}
