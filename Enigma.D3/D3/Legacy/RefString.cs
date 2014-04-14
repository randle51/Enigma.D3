using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.Legacy
{
	public class RefString : MemoryObject
	{
		public const int SizeOf = 12; // 1.0.8.16603

		public RefString(ProcessMemory memory, int address)
			: base(memory, address) { }

		public Data x00_Data { get { return Dereference<Data>(0x00); } }
		public int x04_PtrText { get { return Field<int>(0x04); } }
		public int x08_Bool { get { return Field<int>(0x08); } }



		public class Data : MemoryObject
		{
			// public const int SizeOf = 28; // 1.0.8.16603
			// Size is dynamic as Text can be of varied length.

			public Data(ProcessMemory memory, int address)
				: base(memory, address) { }

			public short x00_ReferenceCount { get { return Field<short>(0x00); } }
			public short x02_LengthEnum { get { return Field<short>(0x02); } }
			public int x04_Length { get { return Field<int>(0x04); } }
			public int x08_MaxLength { get { return Field<int>(0x08); } }
			public int x0C_RefBaseAllocator { get { return Field<int>(0x0C); } }
			public int x10_CreationTime { get { return Field<int>(0x10); } }
			public string x14_Text { get { return Field(0x14, x04_Length); } }
		}
	}
}
