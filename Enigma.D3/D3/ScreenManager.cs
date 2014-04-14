using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Enigma.D3.Collections;
using Enigma.D3.UI;

namespace Enigma.D3
{
	public class ScreenManager : MemoryObject
	{
		// 2.0.4.23119
		public const int SizeOf = 0x24; // 2.0.0.21962, fields not updated

		public ScreenManager(ProcessMemory memory, int address)
			: base(memory, address) { }

		public int x00_Ptr_1896Bytes { get { return Field<int>(0x00); } }
		public int x04_Ptr_440Bytes { get { return Field<int>(0x04); } }
		public int x08_Ptr_64Bytes { get { return Field<int>(0x08); } }
		public int x0C_Ptr_400Bytes { get { return Field<int>(0x0C); } }
		public int x10_Ptr_2320Bytes_HeroSelect { get { return Field<int>(0x10); } }
		public ScreenManager_X14 x14_Ptr_576Bytes { get { return Dereference<ScreenManager_X14>(0x14); } }
		public int x18_Ptr_2064Bytes { get { return Field<int>(0x18); } }
		public int x1C_Ptr_4Bytes { get { return Field<int>(0x1C); } }



		public class ScreenManager_X14 : MemoryObject
		{
			// 2.0.3.22427
			public const int SizeOf = 0x280;

			public ScreenManager_X14(ProcessMemory memory, int address)
				: base(memory, address) { }

			public int x000_VTable { get { return Field<int>(0x000); } }
			public int _x004 { get { return Field<int>(0x004); } }
			public ListPack<ListItem> x008_ListPack88 { get { return Field<ListPack<ListItem>>(0x008); } }
			public UIReference x038_UIReference { get { return Field<UIReference>(0x038); } }
			public int _x240 { get { return Field<int>(0x240); } }
			public int _x244 { get { return Field<int>(0x244); } }
			public int _x248 { get { return Field<int>(0x248); } }
			public int _x24C { get { return Field<int>(0x24C); } }
			public int _x250 { get { return Field<int>(0x250); } }
			public int _x254 { get { return Field<int>(0x254); } }
			public int _x258 { get { return Field<int>(0x258); } }
			public int _x25C { get { return Field<int>(0x25C); } }
			public int _x260 { get { return Field<int>(0x260); } }
			public int _x264 { get { return Field<int>(0x264); } }
			public int _x268 { get { return Field<int>(0x268); } }
			public int _x26C { get { return Field<int>(0x26C); } }
			public int _x270 { get { return Field<int>(0x270); } }
			public int _x274 { get { return Field<int>(0x274); } }
			public int _x278 { get { return Field<int>(0x278); } }
			public int _x27C { get { return Field<int>(0x27C); } }

			public class ListItem : MemoryObject
			{
				public const int SizeOf = 8;

				public ListItem(ProcessMemory memory, int address)
					: base(memory, address) { }

				public int x00 { get { return Field<int>(0x00); } }
				public Struct_x04 x04_ScreenManager_UIRefs { get { return Field<Struct_x04>(0x04); } }



				public class Struct_x04 : MemoryObject
				{
					public const int SizeOf = 0x54;

					public Struct_x04(ProcessMemory memory, int address)
						: base(memory, address) { }

					public int _x00 { get { return Field<int>(0x00); } }
					public int _x04 { get { return Field<int>(0x04); } }
					public RefString x08_RefString { get { return Field<RefString>(0x08); } }
					public RefString x14_RefString { get { return Field<RefString>(0x14); } }
					public RefString x20_RefString { get { return Field<RefString>(0x20); } }
					public RefString x2C_RefString { get { return Field<RefString>(0x2C); } }
					public int x38 { get { return Field<int>(0x38); } }
					public int x3C { get { return Field<int>(0x3C); } }
					public int x40_StructStart_Min16Bytes { get { return Field<int>(0x40); } }
					public int _x44 { get { return Field<int>(0x44); } }
					public int _x48 { get { return Field<int>(0x48); } }
					public int _x4C { get { return Field<int>(0x4C); } }
					public int x50 { get { return Field<int>(0x50); } }
				}
			}
		}
	}
}