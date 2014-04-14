using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.Legacy
{
	public class SnoGroup<T> : MemoryObject
	{
		public const int SizeOf = 0x7C; // 1.0.8.16603 @ 00E8F0C0

		public SnoGroup(ProcessMemory memory, int address)
			: base(memory, address) { }

		public int _x00 { get { return Field<int>(0x00); } }
		public int _x04 { get { return Field<int>(0x04); } }
		public int _x08 { get { return Field<int>(0x08); } }
		public int _x0C { get { return Field<int>(0x0C); } }
		public Container<SnoDefinition<T>> x10_Definitions { get { return Dereference<Container<SnoDefinition<T>>>(0x10); } }
		public int _x14 { get { return Field<int>(0x14); } }
		public int _x18 { get { return Field<int>(0x18); } }
		public string x1C_Name { get { return Field(0x1C, 32); } }
		public int x3C_SnoGroupType { get { return Field<int>(0x3C); } }
		public int _x40 { get { return Field<int>(0x40); } }
		public int _x44 { get { return Field<int>(0x44); } }
		public int _x48 { get { return Field<int>(0x48); } }
		public int _x4C { get { return Field<int>(0x4C); } }
		public int _x50 { get { return Field<int>(0x50); } }
		public int _x54 { get { return Field<int>(0x54); } }
		public int x58_FieldPtr_x00 { get { return Field<int>(0x58); } } // <-- Points to x00
		public int _x5C { get { return Field<int>(0x5C); } }
		public int _x60 { get { return Field<int>(0x60); } }
		public int _x64 { get { return Field<int>(0x64); } }
		public int _x68 { get { return Field<int>(0x68); } }
		public int _x6C { get { return Field<int>(0x6C); } }
		public int _x70 { get { return Field<int>(0x70); } }
		public int _x74 { get { return Field<int>(0x74); } }
		public int _x78 { get { return Field<int>(0x78); } }

		public override string ToString()
		{
			return x1C_Name;
		}
	}
}
