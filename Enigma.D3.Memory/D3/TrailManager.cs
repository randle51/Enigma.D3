using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Enigma.D3.Collections;
using Enigma.Memory;

namespace Enigma.D3
{
	public class TrailManager : MemoryObject
	{
		public const int SizeOf = 12;

		public int _x00 { get { return Read<int>(0x00); } }
		public int _x04 { get { return Read<int>(0x04); } }
		public Ptr<Container> x08_PtrContainer { get { return ReadPointer<Container>(0x08); } }
	}
}
