using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Enigma.D3.Memory;

namespace Enigma.D3.Collections
{
	public class ExpandableContainer : ExpandableContainer<MemoryObject>
	{
		public ExpandableContainer(ProcessMemory memory, int address)
			: base(memory, address) { }
	}

	public class ExpandableContainer<T> : Container<T>
	{
		// 2.0.0.20874
		public const int SizeOf = 0x168; // = 360

		public ExpandableContainer(ProcessMemory memory, int address)
			: base(memory, address) { }

		public int x124 { get { return Field<int>(0x124); } }
		public int x128 { get { return Field<int>(0x128); } }
		public int _x12C { get { return Field<int>(0x12C); } }
		public BasicAllocator x130_Allocator { get { return Field<BasicAllocator>(0x130); } }
		public int _x14C { get { return Field<int>(0x14C); } }
		public int _x150 { get { return Field<int>(0x150); } }
		public int _x154 { get { return Field<int>(0x154); } }
		public MemoryManager.VTable x158_MemoryVTable { get { return Dereference<MemoryManager.VTable>(0x158); } }
		public int x15C_Limit { get { return Field<int>(0x15C); } }
		public int x160_MaxLimit_ { get { return Field<int>(0x160); } }
		public int x164_Bits { get { return Field<int>(0x164); } }

		public T this[short index]
		{
			get
			{
				var blockSize = 1 << x164_Bits;
				var blockNumber = index / blockSize;
				var blockOffset = index % blockSize;
				var blockBase = base.Memory.Read<int>(base.x120_Allocation + 4 * blockNumber);
				var itemPtr = blockBase + blockOffset * x104_ItemSize;
				var item =  base.Memory.Read<T>(itemPtr);
				return item;
			}
		}
	}
}
