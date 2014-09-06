using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Enigma.D3.Memory;

namespace Enigma.D3.Collections
{
	public class ListPack : ListPack<MemoryObject> { }

	public class ListPack<T> : LinkedList<T>
	{
		// 2.0.1.22044
		public new const int SizeOf = 0x30; // 48

		public Allocator<Node> x10_NodeAllocator { get { return Read<Allocator<Node>>(0x10); } }
		public int x2C_Boolean { get { return Read<int>(0x2C); } }

		public override string ToString()
		{
			if (x10_NodeAllocator.x18_GoodFood != 0x600DF00D)
			{
				return base.ToString() + " { Valid: False }";
			}
			else
			{
				return base.ToString() + " { " + string.Join(", ",
					"Valid: True",
					"ItemSize: " + (x10_NodeAllocator.x00_ElementSize - 8),
					"Count: " + x08_Count) + "}";
			}
		}
	}
}
