using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace Enigma.D3.Legacy
{
	public class Container<T> : MemoryObject, IEnumerable<T>
	{
		public const int SizeOf = 0x150;

		public Container(ProcessMemory memory, int address)
			: base(memory, address) { }

		public string x000_Name { get { return Field(0x000, 256); } }
		public int x100_Limit { get { return Field<int>(0x100); } }
		public int x104_ElementSize { get { return Field<int>(0x104); } }
		public short x108_MaxIndex { get { return Field<short>(0x108); } }
		public int x10C_Count { get { return Field<int>(0x10C); } }
		public int x110_Hash { get { return Field<int>(0x110); } }
		public LinkedList<int> x114_FreeSlots { get { return Field<LinkedList<int>>(0x114); } }
		public Allocator x124_Allocator { get { return Field<Allocator>(0x124); } }
		public int x140 { get { return Field<int>(0x140); } }
		public int x144 { get { return Field<int>(0x144); } }
		public int x148_Elements { get { return Field<int>(0x148); } }
		public int x14C { get { return Field<int>(0x14C); } }

		public T this[int index]
		{
			get
			{
				return GetByIndex(index);
			}
		}

		protected virtual T GetByIndex(int index)
		{
			if (index > x108_MaxIndex)
				throw new ArgumentOutOfRangeException();

			int ptr = x148_Elements + index * x104_ElementSize;

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

		public virtual IEnumerator<T> GetEnumerator()
		{
			int maxIndex = x108_MaxIndex;
			if (maxIndex < 0)
				yield break;

			int elementSize = x104_ElementSize;
			int blockPointer = x148_Elements;
			if (blockPointer == 0)
				yield break;

			for (int i = 0; i <= maxIndex; i++)
			{
				int blockOffset = elementSize * i;
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

		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public override string ToString()
		{
			return x000_Name;
		}
	}
}
