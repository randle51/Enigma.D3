using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace Enigma.D3.Legacy
{
	public class ExpandableContainer<T> : Container<T>, IEnumerable<T>
	{
		new public const int SizeOf = 0x190;

		public ExpandableContainer(ProcessMemory memory, int address)
			: base(memory, address) { }

		public int x150 { get { return Field<int>(0x150); } } // BlockCount?
		public int x154 { get { return Field<int>(0x154); } }

		// This group is actually a substructure
		public int x158_Elements { get { return Field<int>(0x158); } } // AllocatorV2*?
		public int x15C { get { return Field<int>(0x15C); } } // Count?
		public int x160 { get { return Field<int>(0x160); } }
		public int x164_Flags { get { return Field<int>(0x164); } }
		public int x168 { get { return Field<int>(0x168); } }
		public int x16C { get { return Field<int>(0x16C); } }
		public int x170_GoodFood { get { return Field<int>(0x170); } }
		public int x174 { get { return Field<int>(0x174); } }
		public int x178 { get { return Field<int>(0x178); } }
		public int x17C { get { return Field<int>(0x17C); } }
		public int x180 { get { return Field<int>(0x180); } }

		public int x184_Limit { get { return Field<int>(0x184); } }
		public int x188 { get { return Field<int>(0x188); } }
		public int x18C_Bits { get { return Field<int>(0x18C); } }

		protected override T GetByIndex(int index)
		{
			if (index > x108_MaxIndex)
				throw new ArgumentOutOfRangeException();

			// ptr = pointers[index / blockSize][index % blockSize];
			int blockSize = 1 << x18C_Bits;
			int blockNumber = index / blockSize;
			int blockOffset = index % blockSize;
			int blockBase = base.Memory.Read<int>(x148_Elements + sizeof(int) * blockNumber);
			int ptr = blockBase + blockOffset * x104_ElementSize;

			if (typeof(T).IsSubclassOf(typeof(MemoryObject)) ||
			typeof(T).Equals(typeof(MemoryObject)))
			{
				return (T)Activator.CreateInstance(
					typeof(T),
					base.Memory, ptr);
			}
			else
			{
				return (T)Marshal.PtrToStructure((IntPtr)ptr, typeof(T));
			}
		}

		public override IEnumerator<T> GetEnumerator()
		{
			int maxIndex = base.x108_MaxIndex;
			if (maxIndex <= 0)
				yield break;

			int elementSize = x104_ElementSize;
			int blockCapacity = 1 << x18C_Bits;
			int blockCount = (maxIndex / blockCapacity) + 1;

			// TODO: Read them as needed instead? If enumerating all items this method is probably
			// faster than idividual ReadProcessMemory calls.
			int[] blockPointers = base.Memory.Read<int>(x148_Elements, blockCount);

			for (int i = 0; i <= maxIndex; i++)
			{
				int blockIndex = i / blockCapacity;
				int blockPointer = blockPointers[blockIndex];
				int blockOffset = elementSize * (i % blockCapacity);

				int elementPointer = blockPointer + blockOffset;

				if (typeof(T).IsSubclassOf(typeof(MemoryObject)) ||
					typeof(T).Equals(typeof(MemoryObject)))
				{
					yield return (T)Activator.CreateInstance(
						typeof(T),
						base.Memory, elementPointer);
				}
				else
				{
					yield return (T)Marshal.PtrToStructure((IntPtr)elementPointer, typeof(T));
				}
			}
		}
	}
}
