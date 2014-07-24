using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Enigma.D3.Memory;

namespace Enigma.D3
{
	public class SnoGroupSearch : MemoryObject
	{
		// 2.0.3.22472
		public const int SizeOf = 0x14D0; // 5328

		public SnoGroupSearch(MemoryBase memory, int address)
			: base(memory, address) { }

		public int x0000_Count { get { return Field<int>(0x0000); } }
		public Item[] x0004_Items { get { return Field<Item>(0x0004, 70); } }
		public int x13B4_Count { get { return Field<int>(0x13B4); } }
		public Pointer<ValueTypeDescriptor>[] x13B8_ValueTypes { get { return Field<Pointer<ValueTypeDescriptor>>(0x13B8, 70); } }


		public class Item : MemoryObject
		{
			// 2.0.3.22427
			public const int SizeOf = 0x48; // 72

			public Item(MemoryBase memory, int address)
				: base(memory, address) { }

			public string x00_SnoGroupName { get { return Field(0x00, 32); } }
			public int x20_SnoGroupId { get { return Field<int>(0x20); } }
			public int x24 { get { return Field<int>(0x24); } }
			public int x28 { get { return Field<int>(0x28); } }
			public int x2C { get { return Field<int>(0x2C); } }
			public int x30 { get { return Field<int>(0x30); } }
			public int x34 { get { return Field<int>(0x34); } }
			public int x38 { get { return Field<int>(0x38); } }
			public int x3C_Flags { get { return Field<int>(0x3C); } }
			public int _x40 { get { return Field<int>(0x40); } }
			public int x44 { get { return Field<int>(0x44); } }
		}
	}
}
