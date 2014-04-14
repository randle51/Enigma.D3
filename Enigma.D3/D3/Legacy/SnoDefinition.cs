using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.Legacy
{
	public class SnoDefinition<T> : MemoryObject
	{
		public const int SizeOf = 16;

		public SnoDefinition(ProcessMemory memory, int address)
			: base(memory, address) { }

		public int x00_Id { get { return Field<int>(0x00); } }
		public int x04_Unknown { get { return Field<int>(0x04); } }
		public int x08_Unknown { get { return Field<int>(0x08); } }
		public T x0C_SnoItem { get { return Dereference<T>(0x0C); } }
	}
}
