using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.Legacy
{
	public class LinkedListNode<T> : MemoryObject
	{
		private static Lazy<int> _sizeOf = new Lazy<int>(() => typeof(T).SizeOf()); // 1.0.8.16603

		public LinkedListNode(ProcessMemory memory, int address)
			: base(memory, address) { }

		public T Value { get { return Field<T>(0x00); } }
		public LinkedListNode<T> Previous { get { return Dereference<LinkedListNode<T>>(_sizeOf.Value + 0x00); } }
		public LinkedListNode<T> Next { get { return Dereference<LinkedListNode<T>>(_sizeOf.Value + 0x04); } }

		public override string ToString()
		{
			return Value.ToString();
		}
	}
}
