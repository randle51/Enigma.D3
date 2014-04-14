using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.Legacy
{
	public class Pointer<T> : MemoryObject
	{
		public const int SizeOf = 4;

		public Pointer(ProcessMemory memory, int address)
			: base(memory, address) { }

		public T Value { get { return Dereference<T>(0); } }
	}
}
