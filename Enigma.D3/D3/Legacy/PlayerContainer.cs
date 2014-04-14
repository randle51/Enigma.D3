using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.Legacy
{
	public class PlayerContainer : MemoryObject
	{
		public const int SizeOf = 0x47898;

		public PlayerContainer(ProcessMemory memory, int address)
			: base(memory, address) { }

		public Allocator x00_Allocator { get { return Dereference<Allocator>(0x00); } }
		public Allocator x1C_Allocator { get { return Dereference<Allocator>(0x1C); } }
		public Allocator x38_Allocator { get { return Dereference<Allocator>(0x38); } }
		public int x54 { get { return Field<int>(0x00); } }
		public Player[] Players { get{ return Field<Player>(0x58, 8);}}
	}
}
