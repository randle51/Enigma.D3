using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.Legacy
{
	public class SoundSubsystem : MemoryObject
	{
		public const int SizeOf = 0x1D0; // 1.0.8.16603 : [0x00AE3EC0]

		public SoundSubsystem(ProcessMemory memory, int address)
			: base(memory, address) { }


	}
}
