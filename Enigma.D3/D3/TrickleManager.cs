using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Enigma.D3.Collections;
using Enigma.Memory;

namespace Enigma.D3
{
	public class TrickleManager : MemoryObject
	{
		public const int SizeOf = 8;

		public int x00_PtrAllocator_32x100Bytes { get { return Read<int>(0x00); } }
		public Ptr<ListB<Trickle>> x04_Ptr_Items { get { return ReadPointer<ListB<Trickle>>(0x04); } }
	}
}
