using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Enigma.D3.Memory;

namespace Enigma.D3.UI.Controls
{
	public class UXEvent : UXControl
	{
		// 2.0.6.24641
		public const int SizeOf = 0x4A8;
		public const int VTable = 0x017B5730;

		public UXEvent(MemoryBase memory, int address)
			: base(memory, address) { }

		public int x460 { get { return Field<int>(0x460); } }
		public int x464 { get { return Field<int>(0x464); } }
		public int x468 { get { return Field<int>(0x468); } }
		public int x46C { get { return Field<int>(0x46C); } }
		public int x470 { get { return Field<int>(0x470); } }
		public int x474 { get { return Field<int>(0x474); } }
		public int x478 { get { return Field<int>(0x478); } }
		public int x47C { get { return Field<int>(0x47C); } }
		public int x480_Ptr_Allocator_Fieldx484 { get { return Field<int>(0x480); } }
		public Allocator x484_Allocator_10x12Bytes { get { return Field<Allocator>(0x484); } }
		public int x4A0_One { get { return Field<int>(0x4A0); } }
		public int x4A4 { get { return Field<int>(0x4A4); } }
	}
}
