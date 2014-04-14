using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3
{
	public class RefStringData : MemoryObject
	{
		public const int SizeOf = 0x18;

		public RefStringData(ProcessMemory memory, int address)
			: base(memory, address) { }

		public short x00_ReferenceCount { get { return Field<short>(0x00); } }
		public short x02_SizeCategory { get { return Field<short>(0x02); } }
		public int x04_Length { get { return Field<int>(0x04); } }
		public int x08_MaxLength { get { return Field<int>(0x08); } }
		public int x0C_PtrRefStringDataAllocators { get { return Dereference<int>(0x0C); } }
		public int x10_CreationTime { get { return Field<int>(0x10); } }
		public string x14_Text { get { return Field(0x14, x04_Length); } }
	}
}
