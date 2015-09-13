using Enigma.Memory;
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

		public Allocator x000_Allocator_100x20Bytes { get { return Read<Allocator>(0x00); } }
		public Allocator x01C_Allocator_100x156Bytes { get { return Read<Allocator>(0x1C); } }
		public Allocator x038_Allocator_512x60Bytes { get { return Read<Allocator>(0x38); } }
		public Allocator x054_Allocator_32x60Bytes { get { return Read<Allocator>(0x54); } }
		public int x070_Counter { get { return Read<int>(0x70); } }
	}
}
