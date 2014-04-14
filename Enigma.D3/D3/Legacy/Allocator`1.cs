using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.Legacy
{
	public class Allocator<T> : MemoryObject
	{
		public const int SizeOf = 0x1C; // 1.0.8.16603

		public Allocator(ProcessMemory memory, int address)
			: base(memory, address) { }

		public int x00_ElementSize { get { return Field<int>(0x00); } }
		public int x04_Limit { get { return Field<int>(0x04); } }
		public int x08_ExpansionCount { get { return Field<int>(0x08); } }
		public AllocatorData<T> x0C_Data { get { return Dereference<AllocatorData<T>>(0x0C); } }
		public int x10_Flags { get { return Field<int>(0x10); } }
		public int x14 { get { return Field<int>(0x14); } }
		public int x18_GoodFood { get { return Field<int>(0x18); } }

		public override string ToString()
		{
			return x04_Limit + "x" + x00_ElementSize + " bytes, Blocks: " + x08_ExpansionCount;
		}
	}
}