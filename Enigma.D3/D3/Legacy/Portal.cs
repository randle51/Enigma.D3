using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.Legacy
{
	public class Portal : MemoryObject
	{
		public const int SizeOf = 0x0C; // 1.0.8.16603 : [0x00F3BDD0] CPortal::CreateNew

		public Portal(ProcessMemory memory, int address)
			: base(memory, address) { }

		public int x00 { get { return Field<int>(0x00); } }
		public int x04 { get { return Field<int>(0x04); } }
		public int x08 { get { return Field<int>(0x08); } }
	}
}
