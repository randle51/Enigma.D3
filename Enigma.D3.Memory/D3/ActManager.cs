using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Enigma.D3.Memory;

namespace Enigma.D3
{
	public class ActManager : MemoryObject
	{
		// 2.0.4.23119
		public const int SizeOf = 0x38; // 56

		public Waypoint[] x00_Array { get { return ReadPointer<Waypoint>(0x00).ToArray(x08_Count); } }
		public int x04 { get { return Read<int>(0x04); } }
		public int x08_Count { get { return Read<int>(0x08); } }
		public int _x0C { get { return Read<int>(0x0C); } }
		public BasicAllocator x10_DynAllocator { get { return Read<BasicAllocator>(0x10); } }
		public int _x2C { get { return Read<int>(0x2C); } }
		public int _x30 { get { return Read<int>(0x30); } }
		public int _x34 { get { return Read<int>(0x34); } }

		public class Waypoint : MemoryObject
		{
			public const int SizeOf = 0x2C; // 44

			public int x00_ActId { get { return Read<int>(0x00); } }
			public int _x04 { get { return Read<int>(0x04); } }
			public int _x08 { get { return Read<int>(0x08); } }
			public int x0C_LevelAreaSnoId { get { return Read<int>(0x0C); } } // Connects to a quest/bounty (matches against QuestSNO.xC8)
			public int _x10 { get { return Read<int>(0x10); } }
			public int _x14 { get { return Read<int>(0x14); } }
			public int _x18 { get { return Read<int>(0x18); } }
			public int _x1C { get { return Read<int>(0x1C); } }
			public int _x20 { get { return Read<int>(0x20); } }
			public int x24_UILeft { get { return Read<int>(0x24); } } // Relative to map frame
			public int x28_UITop { get { return Read<int>(0x28); } } // Relative to map frame
		}
	}
}
