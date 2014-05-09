using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Enigma.D3.Memory;

namespace Enigma.D3.Collections
{
	public class LinkedList : LinkedList<MemoryObject>
	{
		public LinkedList(ProcessMemory memory, int address)
			: base(memory, address) { }
	}

	public class LinkedList<T> : MemoryObject, IEnumerable<T>
	{
		// 2.0.0.20874
		public const int SizeOf = 0x10; // = 16

		public LinkedList(ProcessMemory memory, int address)
			: base(memory, address) { }

		public Node x00_First { get { return Dereference<Node>(0x00); } }
		public Node x04_Last { get { return Dereference<Node>(0x04); } }
		public int x08_Count { get { return Field<int>(0x08); } }
		public Allocator<Node> x0C_NodeAllocator { get { return Dereference<Allocator<Node>>(0x0C); } }

		public IEnumerator<T> GetEnumerator()
		{
			var node = x00_First;
			while (node != null)
			{
				yield return node.x00_Value;
				node = node.x08_Next;
			}
		}

		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public override string ToString()
		{
			return base.ToString() + " Count = " + x08_Count;
		}


		public class Node : MemoryObject
		{
			private static int _sizeOfValue = TypeHelper<T>.SizeOf;
			public static int SizeOf = _sizeOfValue + 8;

			public Node(ProcessMemory memory, int address)
				: base(memory, address) { }

			public T x00_Value { get { return Field<T>(0x00); } }
			public Node x04_Previous { get { return Dereference<Node>(_sizeOfValue + 0x00); } }
			public Node x08_Next { get { return Dereference<Node>(_sizeOfValue + 0x04); } }

			public override string ToString()
			{
				return x00_Value.ToString();
			}
		}
	}
}
