using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3
{
	public class MessageDescriptor : MemoryObject
	{
		// 2.0.0.20874
		public const int SizeOf = 0x30; // = 48

		public MessageDescriptor(ProcessMemory memory, int address)
			: base(memory, address) { }

		public int x00_VTable { get { return Field<int>(0x00); } }
		public string x04_Name { get { return Dereference(0x04, 64); } } // Size limit unknown
		public int _x08 { get { return Field<int>(0x08); } }
		public FieldDescriptor[] x0C_Fields { get { return Dereference<FieldDescriptor>(0x0C, x10_FieldCount); } }
		public int x10_FieldCount { get { return Field<int>(0x10); } }
		public int _x14 { get { return Field<int>(0x14); } }
		public int _x18 { get { return Field<int>(0x18); } }
		public int _x1C { get { return Field<int>(0x1C); } }
		public int _x20 { get { return Field<int>(0x20); } }
		public int _x24 { get { return Field<int>(0x24); } }
		public int _x28 { get { return Field<int>(0x28); } }
		public MessageDescriptor x2C_Next { get { return Dereference<MessageDescriptor>(0x2C); } }
	}
}
