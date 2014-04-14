using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Enigma.D3.Memory;

namespace Enigma.D3
{
	public class SceneAllocators : MemoryObject
	{
		// 2.0.0.21962
		public const int SizeOf = 0x74; // 116

		public SceneAllocators(ProcessMemory memory, int address)
			: base(memory, address) { }

		public Allocator x00_Allocator { get { return Field<Allocator>(0x00); } }
		public Allocator x1C_Allocator { get { return Field<Allocator>(0x1C); } }
		public Allocator x38_Allocator { get { return Field<Allocator>(0x38); } }
		public Allocator x54_Allocator { get { return Field<Allocator>(0x54); } }
		public int x70_Counter { get { return Field<int>(0x70); } }
	}
}
