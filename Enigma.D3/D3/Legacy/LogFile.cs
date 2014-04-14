using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.Legacy
{
	public class LogFile : MemoryObject
	{
		public const int SizeOf = 0;

		public LogFile(ProcessMemory memory, int address)
			: base(memory, address) { }

		public int x000 { get { return Field<int>(0x000); } }
		public CriticalSection x004_CriticalSection { get { return Field<CriticalSection>(0x004); } }
		public string x01C_FileName { get { return Field(0x01C, 128); } }
		public string x09C_FullPath { get { return Field(0x09C, 260); } }
		public int x1A0 { get { return Field<int>(0x1A0); } }
	}
}
