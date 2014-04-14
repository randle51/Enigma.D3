using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.Legacy
{
	public class LinkedList<T> : MemoryObject, IEnumerable<T>
	{
		public const int SizeOf = 16; // 1.0.8.16603

		public LinkedList(ProcessMemory memory, int address)
			: base(memory, address) { }

		public LinkedListNode<T> First { get { return Dereference<LinkedListNode<T>>(0x00); } }
		public LinkedListNode<T> Last { get { return Dereference<LinkedListNode<T>>(0x04); } }
		public int Count { get { return Field<int>(0x08); } }
		public Allocator Allocator { get { return Dereference<Allocator>(0x0C); } }

		public LinkedListNode<T> this[int index]
		{
			get
			{
				if (index >= Count)
					throw new ArgumentOutOfRangeException("index");

				var node = First;
				for (int i = 0; i < index; i++)
				{
					node = node.Next;
				}
				return node;
			}
		}

		public IEnumerator<T> GetEnumerator()
		{
			var node = First;
			while (node != null)
			{
				yield return node.Value;
				node = node.Next;
			}
		}

		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public override string ToString()
		{
			var allocator = Allocator;
			var elementSize = allocator == null ? "N/A" : (allocator.x00_ElementSize - 8).ToString();
			return string.Format("Count = {0}, ElementSize = {1}", Count, elementSize);
		}
	}
}
