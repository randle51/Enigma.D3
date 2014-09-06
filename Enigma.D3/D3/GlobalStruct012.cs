using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enigma.D3.Collections;
using Enigma.D3.Memory;
using Enigma.Memory;

namespace Enigma.D3
{
	public class GlobalStruct012 : MemoryObject
	{
		public const int SizeOf = 0x888; // 2184

		[ArraySize(19)]
		public Map<int, Ptr<Item>>[] x000_Map { get { return Read<Map<int, Ptr<Item>>>(0x000, 19); } }
		public Allocator x850_Allocator_729000x16Bytes { get { return Read<Allocator>(0x850); } }
		public Allocator x86C_Allocator_165888x120Bytes { get { return Read<Allocator>(0x86C); } }

		public class Item : MemoryObject
		{
			public const int SizeOf = 0x2C; // 44

			public int x00_Id { get { return Read<int>(0x00); } }
			public int x04 { get { return Read<int>(0x04); } }
			public int x08_Ptr { get { return Read<int>(0x08); } }
			public int x0C { get { return Read<int>(0x0C); } }
			public Ptr<string> x10_PtrName { get { return ReadPointer<string>(0x10); } }
			public Ptr<string> x14_PtrSlug { get { return ReadPointer<string>(0x14); } }
			public Ptr<string> x18_Ptr { get { return ReadPointer<string>(0x18); } }
			public int _x1C { get { return Read<int>(0x1C); } }
			public int _x20 { get { return Read<int>(0x20); } }
			public int _x24 { get { return Read<int>(0x24); } }
			public int _x28 { get { return Read<int>(0x28); } }
		}
	}
}
