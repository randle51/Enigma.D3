using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enigma.D3.Collections;
using Enigma.D3.Memory;
using Enigma.Memory;

namespace Enigma.D3
{
	public class SphereTree : MemoryObject
	{
		public const int SizeOf = 0x40;

		public Ptr<SphereNode> x00_Ptr_SphereNode { get { return ReadPointer<SphereNode>(0x00); } }
		public ListB x04_ListB_SphereNode { get { return Read<ListB>(0x04); } }
		public Allocator x18_Allocator_10x32Bytes_SphereNode { get { return Read<Allocator>(0x18); } }
		public int x34 { get { return Read<int>(0x34); } }
		public int x38 { get { return Read<int>(0x38); } }
		public int x3C_FreeCount { get { return Read<int>(0x3C); } }
	}
}
