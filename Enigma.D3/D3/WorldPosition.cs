using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3
{
	public class WorldPosition : MemoryObject
	{
		// 2.0.3.22427
		public const int SizeOf = 0x10; // 16

		public WorldPosition(ProcessMemory memory, int address)
			: base(memory, address) { }

		public float x00_X { get { return Field<float>(0x00); } }
		public float x04_Y { get { return Field<float>(0x04); } }
		public float x08_Z { get { return Field<float>(0x08); } }
		public int x0C_WorldId { get { return Field<int>(0x0C); } }
	}
}
