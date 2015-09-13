using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Enigma.D3.Collections;
using Enigma.Memory;

namespace Enigma.D3
{
	public class RopeManager : MemoryObject
	{
		public const int SizeOf = 16;

		public int _x00 { get { return Read<int>(0x00); } }
		public int _x04 { get { return Read<int>(0x04); } }
		public int _x08 { get { return Read<int>(0x08); } }
		public Ptr<Container> x0C_PtrContainer { get { return ReadPointer<Container>(0x0C); } }
	}
}
