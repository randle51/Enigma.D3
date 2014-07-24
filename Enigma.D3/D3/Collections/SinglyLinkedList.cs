using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.Collections
{
	public class SinglyLinkedList<T> : MemoryObject, IEnumerable<T>
	{
		public const int SizeOf = 8;

		public SinglyLinkedList(MemoryBase memory, int address)
			: base(memory, address) { }

		public int x00_Count { get { return Field<int>(0x00); } }
		public Node x04_First { get { return Dereference<Node>(0x04); } }

		public IEnumerator<T> GetEnumerator()
		{
			var node = x04_First;
			while (node != null)
			{
				yield return node.x04_Element;
				node = node.x00_Next;
			}
		}

		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}



		public class Node : MemoryObject
		{
			public static readonly int SizeOf = 4 + TypeHelper<T>.SizeOf;

			public Node(MemoryBase memory, int address)
				: base(memory, address) { }

			public Node x00_Next { get { return Dereference<Node>(0x00); } }
			public T x04_Element { get { return Field<T>(0x04); } }
		}
	}
}
