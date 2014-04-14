using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.Legacy
{
	public class SnoFile : MemoryObject
	{
		public const int SizeOf = 0x70; // 1.0.8.16603 : [0x00EA1D10] SNOFilesInitialize

		public SnoFile(ProcessMemory memory, int address)
			: base(memory, address) { }

		public Allocator x00_PtrAllocator { get { return Dereference<Allocator>(0x00); } } // <-- Points to field x48
		public int _x04 { get { return Field<int>(0x04); } }
		public int x08_ArrayBase_ { get { return Field<int>(0x08); } } // <-- Each element is 4 bytes (probably a pointer).
		public int _x0C { get { return Field<int>(0x0C); } }
		public int x10_Count_ { get { return Field<int>(0x10); } }
		public int _x14 { get { return Field<int>(0x14); } }
		public AllocatorV2 x18_AllocatorV2 { get { return Field<AllocatorV2>(0x18); } }
		public int _x34 { get { return Field<int>(0x34); } }
		public int x38 { get { return Field<int>(0x38); } }
		public int _x3C { get { return Field<int>(0x3C); } }
		public int x40_MaxIndex_ { get { return Field<int>(0x40); } }
		public int x44_Count_ { get { return Field<int>(0x44); } }
		public Allocator x48_Allocator12x10 { get { return Field<Allocator>(0x48); } }
		public int _x64 { get { return Field<int>(0x64); } }
		public int x68_IsLoaded_ { get { return Field<int>(0x68); } }
		public int _x6C { get { return Field<int>(0x6C); } }
	}
}
