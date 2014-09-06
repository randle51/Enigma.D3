using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Enigma.D3.Memory;

namespace Enigma.D3.Sno
{
	public class GameBalanceGroup : MemoryObject
	{
		public const int SizeOf = 0x70; // 2.0.0.20874

		public int x00 { get { return Read<int>(0x00); } }
		public int x04 { get { return Read<int>(0x04); } }
		public int x08_Ptr_FieldX48 { get { return Read<int>(0x08); } }
		public int _x0C { get { return Read<int>(0x0C); } }
		public int x10_Array_ { get { return Read<int>(0x10); } }
		public int x14 { get { return Read<int>(0x14); } }
		public int x18 { get { return Read<int>(0x18); } }
		public int _x1C { get { return Read<int>(0x1C); } }
		public BasicAllocator x20_Allocator { get { return Read<BasicAllocator>(0x20); } }
		public int _x3C { get { return Read<int>(0x3C); } }
		public int _x40 { get { return Read<int>(0x40); } }
		public int _x44 { get { return Read<int>(0x44); } }
		public int x48_StructStart_ { get { return Read<int>(0x48); } }
		public int _x4C { get { return Read<int>(0x4C); } }
		public int _x50 { get { return Read<int>(0x50); } }
		public int _x54 { get { return Read<int>(0x54); } }
		public int _x58 { get { return Read<int>(0x58); } }
		public int _x5C { get { return Read<int>(0x5C); } }
		public int _x60 { get { return Read<int>(0x60); } }
		public int _x64 { get { return Read<int>(0x64); } }
		public int _x68 { get { return Read<int>(0x68); } }
		public int _x6C { get { return Read<int>(0x6C); } }
	}
}
