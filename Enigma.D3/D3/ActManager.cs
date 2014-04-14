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

		public ActManager(ProcessMemory memory, int address)
			: base(memory, address) { }

		public Waypoint[] x00_Array { get { return Dereference<Waypoint>(0x00, x08_Count); } }
		public int x04 { get { return Field<int>(0x04); } }
		public int x08_Count { get { return Field<int>(0x08); } }
		public int _x0C { get { return Field<int>(0x0C); } }
		public BasicAllocator x10_DynAllocator { get { return Field<BasicAllocator>(0x10); } }
		public int _x2C { get { return Field<int>(0x2C); } }
		public int _x30 { get { return Field<int>(0x30); } }
		public int _x34 { get { return Field<int>(0x34); } }

		public class Waypoint : MemoryObject
		{
			public const int SizeOf = 0x2C; // 44

			public Waypoint(ProcessMemory memory, int address)
				: base(memory, address) { }

			public int x00_ActId { get { return Field<int>(0x00); } }
			public int _x04 { get { return Field<int>(0x04); } }
			public int _x08 { get { return Field<int>(0x08); } }
			public int x0C_Id_ { get { return Field<int>(0x0C); } } // Connects to a quest/bounty (matches against QuestSNO.xC8)
			public int _x10 { get { return Field<int>(0x10); } }
			public int _x14 { get { return Field<int>(0x14); } }
			public int _x18 { get { return Field<int>(0x18); } }
			public int _x1C { get { return Field<int>(0x1C); } }
			public int _x20 { get { return Field<int>(0x20); } }
			public int _x24 { get { return Field<int>(0x24); } }
			public int _x28 { get { return Field<int>(0x28); } }
		}
	}
}
