using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Enigma.D3.Memory;

namespace Enigma.D3.Sno
{
	public class SnoGroupSearch : MemoryObject
	{
		// 2.0.3.22472
		public const int SizeOf = 0x14D0; // 5328

		public int x0000_Count { get { return Read<int>(0x0000); } }
		public Item[] x0004_Items { get { return Read<Item>(0x0004, 70); } }
		public int x13B4_Count { get { return Read<int>(0x13B4); } }
		public Ptr<ValueTypeDescriptor>[] x13B8_ValueTypes { get { return Read<Ptr<ValueTypeDescriptor>>(0x13B8, 70); } }


		public class Item : MemoryObject
		{
			// 2.0.3.22427
			public const int SizeOf = 0x48; // 72

			public string x00_SnoGroupName { get { return ReadString(0x00, 32); } }
			public int x20_SnoGroupId { get { return Read<int>(0x20); } }
			public int x24 { get { return Read<int>(0x24); } }
			public int x28 { get { return Read<int>(0x28); } }
			public int x2C { get { return Read<int>(0x2C); } }
			public int x30 { get { return Read<int>(0x30); } }
			public int x34 { get { return Read<int>(0x34); } }
			public int x38 { get { return Read<int>(0x38); } }
			public int x3C_Flags { get { return Read<int>(0x3C); } }
			public int _x40 { get { return Read<int>(0x40); } }
			public int x44 { get { return Read<int>(0x44); } }
		}
	}
}
