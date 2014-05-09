using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Enigma.D3.Collections;
using Enigma.D3.Memory;

namespace Enigma.D3
{
	public class ActorCommonDataManager : MemoryObject
	{
		// 2.0.0.21962
		public const int SizeOf = 0xE8;

		public ActorCommonDataManager(ProcessMemory memory, int address)
			: base(memory, address) { }
		
		public ExpandableContainer<ActorCommonData> x00_ActorCommonData { get { return Dereference<ExpandableContainer<ActorCommonData>>(0x00); } }
		public int[] x04_Ptr_18608Bytes_AnnToAcd { get { return Dereference<int>(0x04, 4652); } }
		public Allocator x08_Allocator_1000x52Bytes { get { return Field<Allocator>(0x08); } }
		public Allocator x24_Allocator_2048x12Bytes { get { return Field<Allocator>(0x24); } }
		public int _x40 { get { return Field<int>(0x40); } }
		public int _x44 { get { return Field<int>(0x44); } }
		public int _x48 { get { return Field<int>(0x48); } }
		public int _x4C { get { return Field<int>(0x4C); } }
		public int _x50 { get { return Field<int>(0x50); } }
		public int _x54 { get { return Field<int>(0x54); } }
		public int _x58 { get { return Field<int>(0x58); } }
		public int _x5C { get { return Field<int>(0x5C); } }
		public int _x60 { get { return Field<int>(0x60); } }
		public int _x64 { get { return Field<int>(0x64); } }
		public int _x68 { get { return Field<int>(0x68); } }
		public int _x6C { get { return Field<int>(0x6C); } }
		public int _x70 { get { return Field<int>(0x70); } }
		public int _x74 { get { return Field<int>(0x74); } }
		public int _x78 { get { return Field<int>(0x78); } }
		public int _x7C { get { return Field<int>(0x7C); } }
		public int _x80 { get { return Field<int>(0x80); } }
		public int _x84 { get { return Field<int>(0x84); } }
		public int _x88 { get { return Field<int>(0x88); } }
		public int _x8C { get { return Field<int>(0x8C); } }
		public int _x90 { get { return Field<int>(0x90); } }
		public int _x94 { get { return Field<int>(0x94); } }
		public int _x98 { get { return Field<int>(0x98); } }
		public int _x9C { get { return Field<int>(0x9C); } }
		public int _xA0 { get { return Field<int>(0xA0); } }
		public int _xA4 { get { return Field<int>(0xA4); } }
		public int _xA8 { get { return Field<int>(0xA8); } }
		public int _xAC { get { return Field<int>(0xAC); } }
		public int _xB0 { get { return Field<int>(0xB0); } }
		public int _xB4 { get { return Field<int>(0xB4); } }
		public int _xB8 { get { return Field<int>(0xB8); } }
		public int _xBC { get { return Field<int>(0xBC); } }
		public int _xC0 { get { return Field<int>(0xC0); } }
		public int _xC4 { get { return Field<int>(0xC4); } }
		public int _xC8 { get { return Field<int>(0xC8); } }
		public int _xCC { get { return Field<int>(0xCC); } }
		public int _xD0 { get { return Field<int>(0xD0); } }
		public int _xD4 { get { return Field<int>(0xD4); } }
		public int _xD8 { get { return Field<int>(0xD8); } }
		public int _xDC { get { return Field<int>(0xDC); } }
		public int _xE0 { get { return Field<int>(0xE0); } }
		public int _xE4 { get { return Field<int>(0xE4); } }
	}
}
