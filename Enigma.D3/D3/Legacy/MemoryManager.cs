using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.Legacy
{
	public class MemoryManager : MemoryObject
	{
		public const int SizeOf = 0x34; // 1.0.8.16603 : [] MemoryManager::Allocate

		public MemoryManager(ProcessMemory memory, int address)
			: base(memory, address) { }

		public int x00 { get { return Field<int>(0x00); } }
		public int x04 { get { return Field<int>(0x04); } }
		public int x08 { get { return Field<int>(0x08); } }
		public int x0C_PtrToMethodAddress_1537014 { get { return Field<int>(0x0C); } }
		public int x10 { get { return Field<int>(0x10); } }
		public int x14 { get { return Field<int>(0x14); } }
		public int x18 { get { return Field<int>(0x18); } }
		public int x1C { get { return Field<int>(0x1C); } }
		public int x20 { get { return Field<int>(0x20); } }
		public int x24 { get { return Field<int>(0x24); } }
		public int x28 { get { return Field<int>(0x28); } }
		public int x2C { get { return Field<int>(0x2C); } }
		public int x30 { get { return Field<int>(0x30); } }
		public int x34 { get { return Field<int>(0x34); } }
	}
}