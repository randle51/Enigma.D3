using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.Legacy
{
	public class SnoActor : MemoryObject
	{
		public const int SizeOf = 0x354;

		public SnoActor(ProcessMemory memory, int address)
			: base(memory, address) { }

		public int Id { get { return Field<int>(0x000); } }

		public SnoActorType Type { get { return (SnoActorType)Field<int>(0x010); } }
	}
}
