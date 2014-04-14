using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.Legacy
{
	public class AllocatorV2 : MemoryObject
	{
		public const int SizeOf = 0x1C; // 1.0.8.16603

		public AllocatorV2(ProcessMemory memory, int address)
			: base(memory, address) { }

		public int x00_Ptr { get { return Field<int>(0x00); } }
		public int x04 { get { return Field<int>(0x04); } }
		public int x08 { get { return Field<int>(0x08); } }
		public int x0C_Flags { get { return Field<int>(0x0C); } }
		public int _x10 { get { return Field<int>(0x10); } }
		public int _x14 { get { return Field<int>(0x14); } }
		public int x18_GoodFood { get { return Field<int>(0x18); } }
	}
}
