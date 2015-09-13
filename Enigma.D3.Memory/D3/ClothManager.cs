using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Enigma.D3.Collections;
using Enigma.Memory;

namespace Enigma.D3
{
	public class ClothManager : MemoryObject
	{
		public const int SizeOf = 0x18; // 24

		public Ptr<Container> x00_PtrContainer { get { return ReadPointer<Container>(0x00); } }
		public int _x04 { get { return Read<int>(0x04); } }
		public int _x08 { get { return Read<int>(0x08); } }
		public int _x0C { get { return Read<int>(0x0C); } }
		public int _x10 { get { return Read<int>(0x10); } }
		public int _x14 { get { return Read<int>(0x14); } }
	}
}
