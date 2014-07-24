using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Enigma.D3.Memory;

namespace Enigma.D3
{
	public class RefStringDataAllocators : MemoryObject
	{
		public const int SizeOf = 12;

		public RefStringDataAllocators(MemoryBase memory, int address)
			: base(memory, address) { }

		public Allocator<RefStringData> x00_PtrAllocator_1000x152Bytes_RefStringData128B { get { return Dereference<Allocator<RefStringData>>(0x00); } }
		public Allocator<RefStringData> x04_PtrAllocator_4x4120Bytes_RefStringData4KB { get { return Dereference<Allocator<RefStringData>>(0x04); } }
		public int x08_Method { get { return Field<int>(0x08); } }
	}
}