using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Enigma.D3.Collections;
using Enigma.D3.Memory;
using Enigma.Memory;

namespace Enigma.D3
{
	public class InactiveMarkerManager : MemoryObject
	{
		public const int SizeOf = 0x170;

		public Allocator x000_Allocator_256x8Bytes { get { return Read<Allocator>(0x000); } }
		public Allocator x01C_Allocator_64x20Bytes { get { return Read<Allocator>(0x01C); } }
		public Allocator x038_Allocator_32x20Bytes { get { return Read<Allocator>(0x038); } }
		public Allocator x054_Allocator_10x12Bytes { get { return Read<Allocator>(0x054); } }
		public Allocator x070_Allocator_512x12Bytes { get { return Read<Allocator>(0x070); } }
		public Allocator x08C_Allocator_512x376Bytes { get { return Read<Allocator>(0x08C); } }
		public Allocator x0A8_Allocator_64x72Bytes { get { return Read<Allocator>(0x0A8); } }
		public Allocator x0C4_Allocator_512x112Bytes { get { return Read<Allocator>(0x0C4); } }
		public Allocator x0E0_Allocator_512x216 { get { return Read<Allocator>(0x0E0); } }
		public int _x0FC { get { return Read<int>(0x0FC); } }
		public Map x100_Map { get { return Read<Map>(0x100); } }
		public int _x164 { get { return Read<int>(0x164); } }
		public int _x168 { get { return Read<int>(0x168); } }
		public int _x16C { get { return Read<int>(0x16C); } }
	}
}
