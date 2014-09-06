using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Enigma.D3.Win32;

namespace Enigma.D3
{
	public class NamedCriticalSection : MemoryObject
	{
		public const int SizeOf = 4 + CriticalSection.SizeOf;

		public string x00_Name { get { return ReadStringPointer(0x00, 256).Dereference(); } }
		public CriticalSection x04_CriticalSection { get { return Read<CriticalSection>(0x04); } }
	}
}