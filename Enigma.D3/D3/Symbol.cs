using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3
{
	public class Symbol : MemoryObject
	{
		public const int SizeOf = 8;

		public Symbol(MemoryBase memory, int address)
			: base(memory, address) { }

		public int x00_Id { get { return Field<int>(0x00); } }
		public string x04_Name { get { return Dereference(0x04, 256); } } // Max size unknown.
	}
}
