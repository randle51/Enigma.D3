using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.UI
{
	public class UIHandler : MemoryObject
	{
		public const int SizeOf = 12; // 2.0.0.21806

		public string x00_Name { get { return ReadStringPointer(0x00, 512).Dereference(); } } // Max length is unknown.
		public int x04_Hash { get { return Read<int>(0x04); } }
		public int x08_Method { get { return Read<int>(0x08); } }
	}
}
