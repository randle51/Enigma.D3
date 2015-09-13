using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Enigma.D3.Collections;
using Enigma.D3.Memory;
using Enigma.Memory;

namespace Enigma.D3
{
	public class LightManager : MemoryObject
	{
		public const int SizeOf = 0x5C;

		public Allocator x00_Allocator_128x12Bytes { get { return Read<Allocator>(0x00); } }
		public LinkedList x1C_List { get { return Read<LinkedList>(0x1C); } }
		public int _x2C { get { return Read<int>(0x2C); } }
		public int _x30 { get { return Read<int>(0x30); } }
		public int _x34 { get { return Read<int>(0x34); } }
		public int _x38 { get { return Read<int>(0x38); } }
		public int x3C_Neg1 { get { return Read<int>(0x3C); } }
		public int x40_Neg1 { get { return Read<int>(0x40); } }
		public int x44_Neg1 { get { return Read<int>(0x44); } }
		public int x48_Neg1 { get { return Read<int>(0x48); } }
		public int x4C_Neg1 { get { return Read<int>(0x4C); } }
		public int x50_Neg1 { get { return Read<int>(0x50); } }
		public int x54_Neg1 { get { return Read<int>(0x54); } }
		public int x58_Neg1 { get { return Read<int>(0x58); } }
	}
}
