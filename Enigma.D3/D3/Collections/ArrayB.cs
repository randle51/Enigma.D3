using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.Collections
{
	public class ArrayB : ArrayB<MemoryObject>
	{
		public ArrayB(MemoryBase memory, int address)
			: base(memory, address) { }
	}

	public class ArrayB<T> : Array<T>
	{
		public const int SizeOf = 0x34;

		public ArrayB(MemoryBase memory, int address)
			: base(memory, address) { }

		public int _x2C { get { return Field<int>(0x2C); } }
		public int x30_One { get { return Field<int>(0x30); } }
	}
}
