using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.Legacy
{
	public class AcdContainerWrapper : MemoryObject
	{
		public const int SizeOf = 64;

		public AcdContainerWrapper(ProcessMemory memory, int address)
			: base(memory, address) { }

		public ExpandableContainer<Acd> x00_Container { get { return Dereference<ExpandableContainer<Acd>>(0x00); } }
		public PairIntInt[] x04_AnnIdToAcdId { get { return Dereference<PairIntInt>(0x04, 8996); } }
		public Allocator x08_Allocator { get { return Field<Allocator>(0x08); } }
		public Allocator x24_Allocator { get { return Field<Allocator>(0x24); } }

		public struct PairIntInt
		{
			public int Item1;
			public int Item2;

			public override string ToString()
			{
				return Item1.ToString() + " <-> " + Item2.ToString();
			}
		}
	}
}
