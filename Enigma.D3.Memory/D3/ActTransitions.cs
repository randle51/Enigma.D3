using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Enigma.Memory;

namespace Enigma.D3
{
	public class ActTransitions : MemoryObject
	{
		public const int SizeOf = 8;

		public int x00 { get { return Read<int>(0x00); } }
		public int x04 { get { return Read<int>(0x04); } }
	}
}
