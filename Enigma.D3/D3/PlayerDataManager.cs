using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Enigma.D3.Memory;

namespace Enigma.D3
{
	public class PlayerDataManager : MemoryObject
	{
		// 2.0.0.20874
		public const int SizeOf = 0x686D8; // = 427736

		public PlayerDataManager(ProcessMemory memory, int address)
			: base(memory, address) { }

		public Allocator x0000_Allocator_10x272Bytes { get { return Field<Allocator>(0x00); } }
		public Allocator x001C_Allocator_10x12Bytes { get { return Field<Allocator>(0x1C); } }
		public Allocator x0038_Allocator_10x16Bytes { get { return Field<Allocator>(0x38); } }
		public int _x0054 { get { return Field<int>(0x54); } }
		public PlayerData[] x0058_Items { get { return Field<PlayerData>(0x58, 8); } }
	}
}
