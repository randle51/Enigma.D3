using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.Memory
{
	public class BasicAllocator : BasicAllocator<MemoryObject>
	{
		public BasicAllocator(MemoryBase memory, int address)
			: base(memory, address) { }
	}

	public class BasicAllocator<T> : MemoryObject
	{
		// 2.0.0.20874
		public const int SizeOf = 0x1C;

		public BasicAllocator(MemoryBase memory, int address)
			: base(memory, address) { }

		public Pointer<T> x00_Allocation { get { return Field<Pointer<T>>(0x00); } }
		public int x04 { get { return Field<int>(0x04); } }
		public int x08_Size { get { return Field<int>(0x08); } }
		public int x0C_Flags { get { return Field<int>(0x0C); } } // 1 => can/should free, 2 => call free()/realloc() instead of using Blizzard classes.
		public MemoryManager.VTable x10_MemoryVTable { get { return Dereference<MemoryManager.VTable>(0x10); } }
		public int _x14 { get { return Field<int>(0x14); } }
		public int x18_GoodFood { get { return Field<int>(0x18); } }

		public override string ToString()
		{
			string validity = x18_GoodFood == 0x600DF00D ? "Valid" : ((uint)x18_GoodFood == 0xFEEDFACE ? "Invalid" : "Corrupt");
			return base.ToString() + " Size: " + x08_Size + ", State: " + validity;
		}
	}
}