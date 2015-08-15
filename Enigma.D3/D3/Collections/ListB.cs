using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.Collections
{
	public class ListB : ListB<MemoryObject> { }

	public class ListB<T> : LinkedList<T>
	{
		// 2.0.1.22044
		public const int SizeOf = 0x14; // 20

		public int x10_Boolean { get { return Read<int>(0x10); } }
	}
}
