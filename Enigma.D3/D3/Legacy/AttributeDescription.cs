using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.Legacy
{
	public class AttributeDescription : MemoryObject
	{
		public const int SizeOf = 0x28;

		public AttributeDescription(ProcessMemory memory, int address)
			: base(memory, address) { }


	}
}
