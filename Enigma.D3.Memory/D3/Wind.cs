using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Enigma.Memory;

namespace Enigma.D3
{
	public class Wind : MemoryObject
	{
		public const int SizeOf = 0x40; // 64

		public int _x00 { get { return Read<int>(0x00); } }
		public int _x04 { get { return Read<int>(0x04); } }
		public int _x08 { get { return Read<int>(0x08); } }
		public int _x0C { get { return Read<int>(0x0C); } }
		public int _x10 { get { return Read<int>(0x10); } }
		public int _x14 { get { return Read<int>(0x14); } }
		public int _x18 { get { return Read<int>(0x18); } }
		public int _x1C { get { return Read<int>(0x1C); } }
		public int _x20 { get { return Read<int>(0x20); } }
		public int _x24 { get { return Read<int>(0x24); } }
		public int _x28 { get { return Read<int>(0x28); } }
		public int _x2C { get { return Read<int>(0x2C); } }
		public int _x30 { get { return Read<int>(0x30); } }
		public int _x34 { get { return Read<int>(0x34); } }
		public int _x38 { get { return Read<int>(0x38); } }
		public int _x3C { get { return Read<int>(0x3C); } }
	}
}
