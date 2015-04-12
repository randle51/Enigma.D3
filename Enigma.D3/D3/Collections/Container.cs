using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Enigma.D3.Memory;

namespace Enigma.D3.Collections
{
	public class Container : Container<MemoryObject> { }

	public class Container<T> : MemoryObject, IEnumerable<T>
	{
		// 2.0.0.20874
		public const int SizeOf = 0x124;

		public string x000_Name { get { return ReadString(0x000, 256); } }
		public int x100_Capacity { get { return Read<int>(0x100); } }
		public int x104_ItemSize { get { return Read<int>(0x104); } }
		public int x108_MaxIndex { get { return Read<int>(0x108); } }
		public int x10C_Count { get { return Read<int>(0x10C); } }
		public short x110_NextHash { get { return Read<short>(0x110); } } // Incremented by 1 for each new item, starts as a Djb hash (using base 0) of Name
		public short x112_NextIndex { get { return Read<short>(0x112); } } // Incremented by 1 for each new item
		public int x114_Free { get { return Read<int>(0x114); } }
		public int x118_NeedsToExpand { get { return Read<int>(0x118); } }
		public int x11C_PtrItems { get { return Read<int>(0x11C); } }
		public int x120_Allocation { get { return Read<int>(0x120); } } // 0 in Container, BlockAllocations in ExpandableContainer

		public int x110_NextId { get { return Read<int>(0x110); } }
		public Ptr<T> x11C_Ptr_Items { get { return ReadPointer<T>(0x11C); } }

		public IEnumerator<T> GetEnumerator()
		{
			short maxIndex = (short)x108_MaxIndex;
			if (maxIndex < 0)
				yield break;

			int itemSize = x104_ItemSize;
			int blockPointer = x11C_PtrItems;
			if (blockPointer == 0)
				yield break;
			
			for (int i = 0; i <= maxIndex; i++)
			{
				int blockOffset = itemSize * i;
				int itemAddress = blockPointer + blockOffset;

				yield return Memory.Reader.Read<T>(itemAddress);
			}
		}

		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}
