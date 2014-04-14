using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.Legacy
{
	public class BattleNetInterface : MemoryObject
	{
		public const int SizeOf = 16; // 1.0.8.16603 (see 00ACE680)

		public BattleNetInterface(ProcessMemory memory, int address)
			: base(memory, address) { }

		public int x00 { get { return Field<int>(0x00); } }
		public RefString x04 { get { return Field<RefString>(0x04); } }
	}
}
