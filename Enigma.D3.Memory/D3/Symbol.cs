using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3
{
	public class Symbol : MemoryObject
	{
		public const int SizeOf = 8;

		public int x00_Id { get { return Read<int>(0x00); } }
		public string x04_Name { get { return ReadStringPointer(0x04, 256).Dereference(); } } // Max size unknown.

		public override string ToString()
		{
			return x00_Id + " = " + x04_Name;
		}
	}
}
