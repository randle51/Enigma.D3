using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.Legacy
{
	public class AllocatorData : MemoryObject
	{
		public const int SizeOf = 0x34; // 1.0.8.16603

		public AllocatorData(ProcessMemory memory, int address)
			: base(memory, address) { }

		public AllocatorData NextBlock { get { return Dereference<AllocatorData>(0x00); } }
		public int AllocationStart1 { get { return Field<int>(0x04); } }
		public int x08 { get { return Field<int>(0x08); } }
		public int Limit { get { return Field<int>(0x0C); } }
		public int ElementSize { get { return Field<int>(0x10); } }
		public int ElementCount { get { return Field<int>(0x14); } }
		public int x18 { get { return Field<int>(0x18); } }
		public int x1C { get { return Field<int>(0x1C); } }
		public int FreeCount { get { return Field<int>(0x20); } }
		public int x24 { get { return Field<int>(0x24); } }
		public int AllocationStart2 { get { return Field<int>(0x28); } }
		public int x2C { get { return Field<int>(0x2C); } }
		public int GoodFood { get { return Field<int>(0x30); } }
	}
}
