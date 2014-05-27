using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Enigma.D3.Collections;
using Enigma.D3.Enums;
using Enigma.D3.Win32;

namespace Enigma.D3
{
	public class SnoGroup : SnoGroup<MemoryObject>
	{
		public SnoGroup(ProcessMemory memory, int address)
			: base(memory, address) { }
	}

	public class SnoGroup<T> : MemoryObject
	{
		// 2.0.3.22427
		public const int SizeOf = 0x84;

		public SnoGroup(ProcessMemory memory, int address)
			: base(memory, address) { }

		public int x00_VTable { get { return Field<int>(0x00); } }
		public int x04 { get { return Field<int>(0x04); } }
		public int x08 { get { return Field<int>(0x08); } }
		public int x0C { get { return Field<int>(0x0C); } }
		public Container<SnoDefinition<T>> x10_Container { get { return Dereference<Container<SnoDefinition<T>>>(0x10); } }
		public Container x14_Container { get { return Dereference<Container>(0x14); } }
		public int x18_Flags { get { return Field<int>(0x18); } }
		public string x1C_Name { get { return Field(0x1C, 32); } }
		public SnoGroupId x3C_SnoGroupId { get { return (SnoGroupId)Field<int>(0x3C); } }
		public int x40 { get { return Field<int>(0x40); } }
		public int x44 { get { return Field<int>(0x44); } }
		public int x48 { get { return Field<int>(0x48); } }
		public int x4C { get { return Field<int>(0x4C); } }
		public int x50 { get { return Field<int>(0x50); } }
		public int x54 { get { return Field<int>(0x54); } }
		public int x58 { get { return Field<int>(0x58); } }
		public int x5C { get { return Field<int>(0x5C); } }
		public int x60 { get { return Field<int>(0x60); } }
		public int x64_Limit { get { return Field<int>(0x64); } }
		public int x68_ItemSize { get { return Field<int>(0x68); } }
		public int x6C { get { return Field<int>(0x6C); } }
		public int x70 { get { return Field<int>(0x70); } }
		public ValueTypeDescriptor x74_Ptr_DataType { get { return Dereference<ValueTypeDescriptor>(0x74); } }
		public int x78_Counter { get { return Field<int>(0x78); } }
		public Struct_X7C x7C { get { return Dereference<Struct_X7C>(0x7C); } }
		public int x80_Neg1 { get { return Field<int>(0x80); } }


		public class Struct_X7C : MemoryObject
		{
			public const int SizeOf = 0;

			public Struct_X7C(ProcessMemory memory, int address)
				: base(memory, address) { }

			public CriticalSection x00_CriticalSection { get { return Field<CriticalSection>(0x00); } }
			public CriticalSection x18_CriticalSection { get { return Field<CriticalSection>(0x18); } }
			public CriticalSection x30_CriticalSection { get { return Field<CriticalSection>(0x30); } }
			public int x48 { get { return Field<int>(0x48); } }
			public int x4C { get { return Field<int>(0x4C); } }
		}
	}
}
