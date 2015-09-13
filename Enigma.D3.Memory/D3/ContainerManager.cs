using Enigma.Memory;
using System;
using System.Linq;
using System.Text;
using Enigma.D3.Collections;
using Enigma.D3.Memory;

namespace Enigma.D3
{
	public class ContainerManager : MemoryObject
	{
		// 2.0.0.20874
		public const int SizeOf = 0x30; // = 48

		public LinkedList<Ptr<Container>> x00_List { get { return Read<LinkedList<Ptr<Container>>>(0x00); } }
		public Allocator x10_NodeAllocator { get { return Read<Allocator>(0x10); } }
		public int x2C_Boolean { get { return Read<int>(0x2C); } }
	}
}