using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Enigma.D3.Memory;
using Enigma.Memory;

namespace Enigma.D3
{
	public class AnimationBuffer : MemoryObject
	{
		public const int SizeOf = 0x28; // 40

		public int x00_Ptr_8160Bytes { get { return Read<int>(0x00); } }
		public int x04_Ptr_8160Bytes { get { return Read<int>(0x04); } }
		public int x08 { get { return Read<int>(0x08); } }
		public Allocator x0C_Allocator_192x8160Bytes { get { return Read<Allocator>(0x0C); } }
	}
}
