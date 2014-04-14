using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.Memory
{
	public class AllocatorBlock<T> : MemoryObject
	{
		public const int SizeOf = 0x30;

		public AllocatorBlock(ProcessMemory memory, int address)
			: base(memory, address) { }

		public T[] x00_Elements { get { return Dereference<T>(0x00, x08_Limit); } }
		public T x04_NextFreeElement { get { return Dereference<T>(0x04); } }
		public int x08_Limit { get { return Field<int>(0x08); } }
		public int x0C_ElementSize { get { return Field<int>(0x0C); } }
		public int x10_ElementCount { get { return Field<int>(0x10); } }
		public int x14 { get { return Field<int>(0x14); } }
		public int x18 { get { return Field<int>(0x18); } }
		public int x1C_FreeCount { get { return Field<int>(0x1C); } }
		public int x20 { get { return Field<int>(0x20); } }
		public BitArray x24_FreeSpaceBitmap { get { return new BitArray(Dereference<byte>(0x24, (x08_Limit + 7) / 8)); } }
		public int x28 { get { return Field<int>(0x28); } }
		public int x2C_GoodFood { get { return Field<int>(0x2C); } }
	}
}
