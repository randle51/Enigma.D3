using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Enigma.D3.Enums;
using Enigma.D3.Memory;

namespace Enigma.D3
{
	public class GlobalStruct001 : MemoryObject
	{
		// 2.0.3.22427
		public const int SizeOf = 0x38;

		public GlobalStruct001(MemoryBase memory, int address)
			: base(memory, address) { }

		public int x00 { get { return Field<int>(0x00); } }
		public int x04 { get { return Field<int>(0x04); } }
		public int x08_Limit { get { return Field<int>(0x08); } }
		public int _x0C { get { return Field<int>(0x0C); } }
		public BasicAllocator<Item> x10_DynAllocator { get { return Field<BasicAllocator<Item>>(0x10); } }
		public int _x2C { get { return Field<int>(0x2C); } }
		public int x30_One { get { return Field<int>(0x30); } }
		public int _x34 { get { return Field<int>(0x34); } }

		public Item[] DumpAllItems()
		{
			var allocation = x10_DynAllocator.x00_Allocation.Value.Address;
			return Enumerable.Range(0, x08_Limit).Select(a => Memory.Read<Item>(allocation + Item.SizeOf * a)).ToArray();
		}

		public class Item : MemoryObject
		{
			public const int SizeOf = 0x10;

			public Item(MemoryBase memory, int address)
				: base(memory, address) { }

			public int x00 { get { return Field<int>(0x00); } }
			public SnoGroupId x04_SnoGroup { get { return (SnoGroupId)Field<int>(0x04); } }
			public int x08_SnoId { get { return Field<int>(0x08); } }
			public int x0C { get { return Field<int>(0x0C); } }
		}
	}
}