using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Enigma.Memory;

namespace Enigma.D3
{
	public class TimedEvent : MemoryObject
	{
		public const int SizeOf = 0x0C; // 12

		public int _x00 { get { return Read<int>(0x00); } } // TimedEventSnoId?
		public int _x04 { get { return Read<int>(0x04); } }
		public int _x08 { get { return Read<int>(0x08); } } // EndTick?
	}
}
