using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Enigma.D3.Collections;

namespace Enigma.D3.Memory
{
	public class Allocator : Allocator<MemoryObject>
	{
		public Allocator(ProcessMemory memory, int address)
			: base(memory, address) { }
	}

	public class Allocator<T> : MemoryObject
	{
		public const int SizeOf = 0x1C; // 2.0.0.20874

		public Allocator(ProcessMemory memory, int address)
			: base(memory, address) { }

		public int x00_ElementSize { get { return Field<int>(0x00); } }
		public int x04_Limit { get { return Field<int>(0x04); } }
		public SinglyLinkedList<AllocatorBlock<T>> x08_Blocks { get { return Field<SinglyLinkedList<AllocatorBlock<T>>>(0x08); } }
		public int x10_Flags { get { return Field<int>(0x10); } }
		public int x14_MemVT { get { return Field<int>(0x14); } }
		public int x18_GoodFood { get { return Field<int>(0x18); } } // 0xFEEDFACE when disposed.

		public override string ToString()
		{
			string state = x18_GoodFood == 0x600DF00D ? "Valid" :
				(uint)x18_GoodFood == 0xFEEDFACE ? "Disposed" : "Corrupt";
			return x04_Limit + "x" + x00_ElementSize + " bytes, Blocks: " + x08_Blocks.x00_Count + ", State: " + state;
		}
	}
}
