using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3
{
	public class Player : MemoryObject
	{
		// 2.0.5.24017
		public const int SizeOf = 0x1A388; // 107400

		public Player(ProcessMemory memory, int address)
			: base(memory, address) { }

		public int x00000_LocalDataIndex { get { return Field<int>(0x00000); } }
	}
}
