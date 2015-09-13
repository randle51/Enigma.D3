using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Enigma.D3.Collections;
using Enigma.D3.Memory;
using Enigma.Memory;

namespace Enigma.D3
{
	public class NavCellPath : MemoryObject
	{
		public const int SizeOf = 0x10; // 16

		public Ptr<Allocator> x00_Ptr_Allocator_500x36Bytes { get { return ReadPointer<Allocator>(0x00); } }
		public Ptr<X04> x04_Ptr_12Bytes { get { return ReadPointer<X04>(0x04); } }
		public Ptr<Map> x08_Ptr_112Bytes_Map { get { return ReadPointer<Map>(0x08); } }
		public Ptr<Allocator> x0C_Ptr_Allocator_256x16Bytes { get { return ReadPointer<Allocator>(0x0C); } }


		public class X04 : MemoryObject
		{
			public const int SizeOf = 12;
		
			public int x00_256 { get { return Read<int>(0x00); } }
			public int x04 { get { return Read<int>(0x04); } }
			public int x08_Ptr_2048Bytes { get { return Read<int>(0x08); } }
		}
	}
}
