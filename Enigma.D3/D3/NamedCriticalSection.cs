using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Enigma.D3.Win32;

namespace Enigma.D3
{
	public class NamedCriticalSection : MemoryObject
	{
		public const int SizeOf = 4 + CriticalSection.SizeOf;

		public NamedCriticalSection(MemoryBase memory, int address)
			: base(memory, address) { }

		public string x00_Name { get { return Dereference(0x00, 256); } }
		public CriticalSection x04_CriticalSection { get { return Field<CriticalSection>(0x04); } }
	}
}