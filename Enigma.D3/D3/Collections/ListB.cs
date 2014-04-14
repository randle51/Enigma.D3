using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.Collections
{
	public class ListB : ListB<MemoryObject>
	{
		public ListB(ProcessMemory memory, int address)
			: base(memory, address) { }
	}


	public class ListB<T> : MemoryObject
	{
		// 2.0.1.22044
		public const int SizeOf = 0x14; // 20

		public ListB(ProcessMemory memory, int address)
			: base(memory, address) { }

		public LinkedList<T> x00_List { get { return Field<LinkedList<T>>(0x00); } }
		public int x10_Boolean { get { return Field<int>(0x10); } }
	}
}
