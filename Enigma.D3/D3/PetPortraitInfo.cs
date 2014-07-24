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
		public const int SizeOf = 0;

		public PetPortraitInfo(MemoryBase memory, int address)
			: base(memory, address) { }

		public ArrayB x000_Array { get { return Field<ArrayB>(0x000); } }
		public int _x034 { get { return Field<int>(0x034); } }
		public UIReference x038_UIRef_Menu_ { get { return Field<UIReference>(0x038); } }
		public UIReference x240_UIRef_MenuContent { get { return Field<UIReference>(0x240); } }
		public UIReference x448_UIRef_MenuList { get { return Field<UIReference>(0x448); } }
		public int x650_Neg1_PetId_ { get { return Field<int>(0x650); } }
		public int _x654 { get { return Field<int>(0x654); } }
		public UIReference x658_UIRef { get { return Field<UIReference>(0x658); } }
		public Item[] x860_Array { get { return Field<Item>(0x860, 21); } }
		public int xA04_Count { get { return Field<int>(0xA04); } }



		public class Item : MemoryObject
		{
			public const int SizeOf = 0x14;

			public Item(MemoryBase memory, int address)
				: base(memory, address) { }

			public int x00_Neg1 { get { return Field<int>(0x00); } }
			public int x04 { get { return Field<int>(0x04); } }
			public int x08 { get { return Field<int>(0x08); } }
			public int x0C { get { return Field<int>(0x0C); } }
			public int x10 { get { return Field<int>(0x10); } }
		}
	}
}
