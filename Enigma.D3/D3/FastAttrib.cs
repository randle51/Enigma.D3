using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Enigma.D3.Collections;
using Enigma.D3.Memory;

namespace Enigma.D3
{
	public class FastAttrib : MemoryObject
	{
		// 2.0.1.22044
		public const int SizeOf = 0x5C;

		public FastAttrib(MemoryBase memory, int address)
			: base(memory, address) { }

		public Allocator<Map<int, Pointer>.Entry> x00_Allocator_10x12Bytes { get { return Field<Allocator<Map<int, Pointer>.Entry>>(0x00); } }
		public Allocator x1C_Allocator_10x12Bytes { get { return Field<Allocator>(0x1C); } }
		public Allocator x38_Allocator_10x12Bytes { get { return Field<Allocator>(0x38); } }
		public ExpandableContainer<FastAttribGroup> x54_Groups { get { return Dereference<ExpandableContainer<FastAttribGroup>>(0x54); } }
		public int x58 { get { return Field<int>(0x58); } }
	}
}
