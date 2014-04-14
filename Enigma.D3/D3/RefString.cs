using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3
{
	public class RefString : MemoryObject
	{
		public const int SizeOf = 0x0C;

		public RefString(ProcessMemory memory, int address)
			: base(memory, address) { }

		public RefStringData x00_Data { get { return Dereference<RefStringData>(0x00); } }
		public string x04_PtrText { get { return Dereference(0x04, 256); } } // Dynamic Size?
		public int x08_Bool { get { return Field<int>(0x08); } }

		public override string ToString()
		{
			string text = Field<int>(0x04) == 0 ? x00_Data.x14_Text : x04_PtrText;
			return base.ToString() + ": " + text;
		}
	}
}
