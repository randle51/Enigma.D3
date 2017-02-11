using Enigma.D3.MemoryModel64.MemoryManagement;
using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Enigma.D3.MemoryModel64.Collections
{
	public class LinkedList : MemoryObject
	{
		public const int SizeOf = 0x20; // 32

		public Ptr<LinkedListNode> x00_First { get { return Read<Ptr<LinkedListNode>>(0x00); } }
		public Ptr<LinkedListNode> x08_Last { get { return Read<Ptr<LinkedListNode>>(0x08); } }
		public int Count { get { return Read<int>(0x10); } }
		public uint x14_Padding { get { return Read<uint>(0x14); } }
		public Ptr<Allocator<LinkedListNode>> x18_Allocator { get { return Read<Ptr<Allocator<LinkedListNode>>>(0x18); } }
	}

	public class LinkedList<T> : LinkedList, IReadOnlyCollection<T>
	{
		public new Ptr<LinkedListNode<T>> x00_First { get { return Read<Ptr<LinkedListNode<T>>>(0x00); } }
		public new Ptr<LinkedListNode<T>> x08_Last { get { return Read<Ptr<LinkedListNode<T>>>(0x08); } }
		public new Ptr<Allocator<LinkedListNode<T>>> x18_Allocator { get { return Read<Ptr<Allocator<LinkedListNode<T>>>>(0x18); } }

		public IEnumerator<T> GetEnumerator()
		{
			var ptr = x00_First;
			while (!ptr.IsInvalid)
			{
				var node = ptr.Dereference();
				yield return node.Value;
				ptr = node.Next;
			}
		}

		IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
	}

	public class LinkedListB<T> : LinkedList<T>
	{
		public new const int SizeOf = 0x28;

		public int x20_Boolean => Read<int>(0x20);
		public int x24_Padding => Read<int>(0x28);
	}

	public class LinkedListNode : MemoryObject { }

	public class LinkedListNode<T> : LinkedListNode
	{
		private static int _sizeOfValue = ((TypeHelper<T>.SizeOf + 7) / 8) * 8; // Align to 8 bytes
		public static int SizeOf = _sizeOfValue + 8;

		public T Value { get { return Read<T>(0x00); } }
		public Ptr<LinkedListNode<T>> Previous { get { return Read<Ptr<LinkedListNode<T>>>(_sizeOfValue + 0x00); } }
		public Ptr<LinkedListNode<T>> Next { get { return Read<Ptr<LinkedListNode<T>>>(_sizeOfValue + 0x08); } }
	}

	public class LinkedListWithAllocator<T> : LinkedList<T>
	{
		public new const int SizeOf = 0x58; // 88

		public Allocator<LinkedListNode<T>> x20_Allocator { get { return Read<Allocator<LinkedListNode<T>>>(0x20); } }
		public int x4C_Padding { get { return Read<int>(0x4C); } }
		public int x50_Boolean { get { return Read<int>(0x50); } }
		public int x54_Padding { get { return Read<int>(0x54); } }
	}
}
