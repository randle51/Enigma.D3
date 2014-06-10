using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Enigma.D3.Enums;

namespace Enigma.D3
{
	public class SnoDefinition : SnoDefinition<MemoryObject>
	{
		public SnoDefinition(ProcessMemory memory, int address)
			: base(memory, address) { }
	}

	public class SnoDefinition<T> : MemoryObject
	{
		public const int SizeOf = 20;

		public SnoDefinition(ProcessMemory memory, int address)
			: base(memory, address) { }

		public int x00_Id { get { return Field<int>(0x00); } }
		public int _x04 { get { return Field<int>(0x04); } }
		public SnoGroupId x08_SnoGroupId { get { return (SnoGroupId)Field<int>(0x08); } }
		public int x0C_Size { get { return Field<int>(0x0C); } }
		public T x10_SnoItem { get { return Dereference<T>(0x10); } }
	}
}
