using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.Legacy
{
	public class UIReference : MemoryObject
	{
		public const int SizeOf = 0x208; // 1.0.8.16603

		public UIReference(ProcessMemory memory, int address)
			: base(memory, address) { }

		public long Hash { get { return Field<long>(0x000); } }
		public string Name { get { return Field(0x008, 0x200); } }

		public override string ToString()
		{
			return Name;
		}
	}
}
