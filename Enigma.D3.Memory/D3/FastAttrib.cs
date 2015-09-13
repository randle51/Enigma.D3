using Enigma.Memory;
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
		public const int SizeOf = 0x5C; // 92

		public Allocator<Map<int, Ptr>.Entry> x00_Allocator_10x12Bytes { get { return Read<Allocator<Map<int, Ptr>.Entry>>(0x00); } }
		public Allocator x1C_Allocator_10x12Bytes { get { return Read<Allocator>(0x1C); } }
		public Allocator x38_Allocator_10x12Bytes { get { return Read<Allocator>(0x38); } }
		public ExpandableContainer<FastAttribGroup> x54_Groups { get { return Dereference<ExpandableContainer<FastAttribGroup>>(0x54); } }
		public int x58 { get { return Read<int>(0x58); } }

		public static FastAttrib Instance { get { return Storage.Instance.IfNotNull(storage => storage.x14C_Ptr_92Bytes_FastAttrib.Dereference()); } }
	}
}
