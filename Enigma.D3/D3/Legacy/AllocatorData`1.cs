using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.Legacy
{
	public class AllocatorData<T> : MemoryObject
	{
		public const int SizeOf = 0x34; // 1.0.8.16603

		public AllocatorData(ProcessMemory memory, int address)
			: base(memory, address) { }

		public AllocatorData<T> x00_NextBlock { get { return Dereference<AllocatorData<T>>(0x00); } }
		public AllocationHeader x04_Header { get { return Field<AllocationHeader>(0x04); } }

		public class AllocationHeader : MemoryObject
		{
			public const int SizeOf = 0x30;

			public AllocationHeader(ProcessMemory memory, int address)
				: base(memory, address) { }

			public T[] x00_Elements { get { return Field<T>(0x04, x08_Limit); } }
			public T x04_NextFreeElement { get { return Dereference<T>(0x08); } }
			public int x08_Limit { get { return Field<int>(0x0C); } }
			public int x0C_ElementSize { get { return Field<int>(0x10); } }
			public int x10_ElementCount { get { return Field<int>(0x14); } }
			public int x14 { get { return Field<int>(0x18); } }
			public int x18 { get { return Field<int>(0x1C); } }
			public int x1C_FreeCount { get { return Field<int>(0x20); } }
			public int x20 { get { return Field<int>(0x24); } }
			public int x24_AllocationStart2 { get { return Field<int>(0x28); } } // (4?) byte aligned, 1 bit per slot, tells if used or not
			public int x28 { get { return Field<int>(0x2C); } }
			public int x2C_GoodFood { get { return Field<int>(0x30); } }
		}
	}
}
