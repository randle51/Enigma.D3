using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3
{
	public class RefString : MemoryObject
	{
		public const int SizeOf = 0x0C;

		public RefStringData x00_Data { get { return ReadPointer<RefStringData>(0x00).Dereference(); } }
		public string x04_PtrText { get { return ReadStringPointer(0x04, x00_Data == null ? 256 : x00_Data.x08_MaxLength).Dereference(); } } // Dynamic Size?
		public int x08_Bool { get { return Read<int>(0x08); } }

		public override string ToString()
		{
			return Read<int>(0x04) == 0 ? x00_Data.x14_Text : x04_PtrText;
		}
	}
}
