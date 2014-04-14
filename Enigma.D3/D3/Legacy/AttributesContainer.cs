using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.Legacy
{
	public class AttributesContainer : MemoryObject
	{
		public const int SizeOf = 120; // = 0x78

		public AttributesContainer(ProcessMemory memory, int address)
			: base(memory, address) { }

		public Allocator x00_Allocator_1024x1064Bytes { get { return Field<Allocator>(0x00); } }
		public Allocator x1C_Allocator_1024x__Bytes { get { return Field<Allocator>(0x1C); } }
		public Allocator x38_Allocator_1024x12Bytes { get { return Field<Allocator>(0x38); } }
		public Allocator x54_Allocator_1024x12Bytes { get { return Field<Allocator>(0x54); } }
		public ExpandableContainer<MemoryObject> x70_FastAttribGroups { get { return Field<ExpandableContainer<MemoryObject>>(0x70); } }
		public int _x74 { get { return Field<int>(0x74); } }
	}
}
