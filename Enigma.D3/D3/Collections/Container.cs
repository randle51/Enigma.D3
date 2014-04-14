using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Enigma.D3.Memory;

namespace Enigma.D3.Collections
{
	public class Container : Container<MemoryObject>
	{
		public Container(ProcessMemory memory, int address)
			: base(memory, address) { }
	}

	public class Container<T> : MemoryObject
	{
		// 2.0.0.20874
		public const int SizeOf = 0x124;

		public Container(ProcessMemory memory, int address)
			: base(memory, address) { }

		public string x000_Name { get { return Field(0x000, 256); } }
		public int x100_Capacity { get { return Field<int>(0x100); } }
		public int x104_ItemSize { get { return Field<int>(0x104); } }
		public int x108_MaxIndex { get { return Field<int>(0x108); } }
		public int x10C_Count { get { return Field<int>(0x10C); } }
		public short x110_NextHash { get { return Field<short>(0x110); } } // Incremented by 1 for each new item, starts as a Djb hash (using base 0) of Name
		public short x112_NextIndex { get { return Field<short>(0x112); } } // Incremented by 1 for each new item
		public int x114_Free { get { return Field<int>(0x114); } }
		public int x118_NeedsToExpand { get { return Field<int>(0x118); } }
		public int x11C_PtrItems { get { return Field<int>(0x11C); } } // Could this be the memory methods override?
		public int x120_Allocation { get { return Field<int>(0x120); } }

		public int x110_NextId { get { return Field<int>(0x110); } }
		public T[] x11C_Items { get { return Dereference<T>(0x11C, x100_Capacity); } }
	}
}
