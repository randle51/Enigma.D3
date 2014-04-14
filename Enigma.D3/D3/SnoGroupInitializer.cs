using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Enigma.D3.Memory;

namespace Enigma.D3
{
	public class SnoGroupInitializer : MemoryObject
	{
		public const int SizeOf = 8;

		public SnoGroupInitializer(ProcessMemory memory, int address)
			: base(memory, address) { }

		public int x00_Initializer { get { return Field<int>(0x00); } }
		public int x04_SnoGroupAddress { get { return Field<int>(0x04); } }

		public SnoGroup GetSnoGroup()
		{
			return new SnoGroup(Memory, Memory.Read<int>(x04_SnoGroupAddress));
		}
	}
}
