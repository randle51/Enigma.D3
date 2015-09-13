using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Enigma.D3.Collections;
using Enigma.Memory;

namespace Enigma.D3
{
	public class WorldManager : MemoryObject
	{
		public const int SizeOf = 0x50;

		public int x00_Neg1 { get { return Read<int>(0x00); } }
		public int x04_Neg1 { get { return Read<int>(0x04); } }
		public int x08 { get { return Read<int>(0x08); } }
		public int x0C_Neg2 { get { return Read<int>(0x0C); } }
		public int x10_Neg2 { get { return Read<int>(0x10); } }
		public int x14_Neg1 { get { return Read<int>(0x14); } }
		public Vector x18_Map { get { return Read<Vector>(0x18); } }
	}
}
