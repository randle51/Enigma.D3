using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Enigma.Memory;

namespace Enigma.D3
{
	public class MarkerManager : MemoryObject
	{
		public const int SizeOf = 12;

		public int x00 { get { return Read<int>(0x00); } }
		public int x04 { get { return Read<int>(0x04); } }
		public int x08 { get { return Read<int>(0x08); } }
	}
}
