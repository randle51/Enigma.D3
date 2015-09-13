using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Enigma.Memory;

namespace Enigma.D3
{
	public class ShakeManager : MemoryObject
	{
		public const int SizeOf = 0x20;

		public int x00_x1D8A7FC { get { return Read<int>(0x00); } }
		public int x04_x1D8A800 { get { return Read<int>(0x04); } }
		public int x08_x1D8A804 { get { return Read<int>(0x08); } }
		public int x0C_x1A95244 { get { return Read<int>(0x0C); } }
		public int x10_x1A95248 { get { return Read<int>(0x10); } }
		public int x14_x1A9524C { get { return Read<int>(0x14); } }
		public int x18_x1A95250 { get { return Read<int>(0x18); } }
		public int x1C_Shakes { get { return Read<int>(0x1C); } }
	}
}
