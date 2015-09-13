using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Enigma.D3.Memory;
using Enigma.Memory;

namespace Enigma.D3
{
	public class Sprites : MemoryObject
	{
		public const int SizeOf = 0x294; // 660

		[ArraySize(27)]
		public X00[] x000 { get { return Read<X00>(0x000, 27); } }
		public Allocator x21C_Allocator_768x20Bytes { get { return Read<Allocator>(0x21C); } }
		public Allocator x238_Allocator_768x12Bytes { get { return Read<Allocator>(0x238); } }
		public int x254 { get { return Read<int>(0x254); } }
		public Allocator x258_Allocator_768x24Bytes { get { return Read<Allocator>(0x258); } }
		public int x274 { get { return Read<int>(0x274); } }
		public int x278_Ptr_x3600Bytes { get { return Read<int>(0x278); } }
		public int _x27C { get { return Read<int>(0x27C); } }
		public int _x280 { get { return Read<int>(0x280); } }
		public int _x284 { get { return Read<int>(0x284); } }
		public int _x288 { get { return Read<int>(0x288); } }
		public int _x28C { get { return Read<int>(0x28C); } }
		public int _x290 { get { return Read<int>(0x290); } }


		public class X00 : MemoryObject
		{
			public const int SizeOf = 0x14; // 20

			public int _x00 { get { return Read<int>(0x00); } }
			public int x04_Neg1 { get { return Read<int>(0x04); } }
			public int x08 { get { return Read<int>(0x08); } }
			public int x0C { get { return Read<int>(0x0C); } }
			public int x10 { get { return Read<int>(0x10); } }
		}
	}
}
