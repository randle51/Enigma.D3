using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Enigma.D3.Collections;
using Enigma.Memory;

namespace Enigma.D3
{
	public class ParentObjects : MemoryObject
	{
		public const int SizeOf = 0x64; // 100

		public int _x000 { get { return Read<int>(0x000); } }
		[ArraySize(8)]
		public Item[] x004_Items { get { return Read<Item>(0x004, 8); } }


		public class Item : MemoryObject
		{
			public const int SizeOf = 12;

			public int x00 { get { return Read<int>(0x00); } }
			public int x04 { get { return Read<int>(0x04); } }
			public int x08 { get { return Read<int>(0x08); } }
		}
	}
}
