using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Enigma.D3.Collections;

namespace Enigma.D3
{
	public class Cinematography : MemoryObject
	{
		// 2.0.5.24017
		public const int SizeOf = 0xFC; // 252

		public Cinematography(ProcessMemory memory, int address)
			: base(memory, address) { }

		public int x00_Neg1 { get { return Field<int>(0x00); } }
		public int x04_MouseScrollValue { get { return Field<int>(0x04); } } // Tracked during free camera mode.
		public int x08_Neg1 { get { return Field<int>(0x08); } }
		public float x0C_FreeCameraX { get { return Field<float>(0x0C); } }
		public float x10_FreeCameraY { get { return Field<float>(0x10); } }
		public float x14_FreeCameraZ { get { return Field<float>(0x14); } }
		public float x18_FreeCameraPitch { get { return Field<float>(0x18); } }
		public float x1C_FreeCameraYaw { get { return Field<float>(0x1C); } }
		public float x20_FreeCameraZoom { get { return Field<float>(0x20); } }
		public int x24_MouseX { get { return Field<int>(0x24); } } // Tracked during free camera mode.
		public int x28_MouseY { get { return Field<int>(0x28); } } // Tracked during free camera mode.
		public int x2C { get { return Field<int>(0x2C); } }
		public int x30 { get { return Field<int>(0x30); } }
		public int x34 { get { return Field<int>(0x34); } }
		public int x38 { get { return Field<int>(0x38); } }
		public int x3C { get { return Field<int>(0x3C); } }
		public int x40 { get { return Field<int>(0x40); } }
		public int x44 { get { return Field<int>(0x44); } }
		public Struct_X48 x48_Ptr_Struct { get { return Dereference<Struct_X48>(0x48); } }
		public int x4C_StructStart_Min68Bytes { get { return Field<int>(0x4C); } }
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
		public int x90_StructStart_Min4Bytes { get { return Field<int>(0x90); } }
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
		public int _xE8 { get { return Field<int>(0xE8); } }
		public int _xEC { get { return Field<int>(0xEC); } }
		public int _xF0 { get { return Field<int>(0xF0); } }
		public int xF4 { get { return Field<int>(0xF4); } }
		public ListPack xF8_Ptr_ListPack_ItemSize128 { get { return Dereference<ListPack>(0xF8); } }



		public class Struct_X48 : MemoryObject
		{
			public const int SizeOf = 0xAC;

			public Struct_X48(ProcessMemory memory, int address)
				: base(memory, address) { }

			public int x00_VTable { get { return Field<int>(0x00); } }
			public int x04 { get { return Field<int>(0x04); } }
			public int x08 { get { return Field<int>(0x08); } }
			public float x0C_1f { get { return Field<float>(0x0C); } }
			public float x10_1f { get { return Field<float>(0x10); } }
			public float x14 { get { return Field<float>(0x14); } }
			public float x18 { get { return Field<float>(0x18); } }
			public int x1C_Neg1_FocusedAcdId { get { return Field<int>(0x1C); } }
			public int x20_Neg1 { get { return Field<int>(0x20); } }
			public int x24_Neg1 { get { return Field<int>(0x24); } }
			public int x28 { get { return Field<int>(0x28); } }
			public int x2C { get { return Field<int>(0x2C); } }
			public int x30 { get { return Field<int>(0x30); } }
			public int x34 { get { return Field<int>(0x34); } }
			public int x38 { get { return Field<int>(0x38); } }
			public int x3C { get { return Field<int>(0x3C); } }
			public int x40 { get { return Field<int>(0x40); } }
			public int x44 { get { return Field<int>(0x44); } }
			public int x48 { get { return Field<int>(0x48); } }
			public int x4C { get { return Field<int>(0x4C); } }
			public int x50 { get { return Field<int>(0x50); } }
			public int x54 { get { return Field<int>(0x54); } }
			public int x58 { get { return Field<int>(0x58); } }
			public int x5C { get { return Field<int>(0x5C); } }
			public int x60 { get { return Field<int>(0x60); } }
			public int x64 { get { return Field<int>(0x64); } }
			public int x68 { get { return Field<int>(0x68); } }
			public int x6C { get { return Field<int>(0x6C); } }
			public int x70 { get { return Field<int>(0x70); } }
			public int x74 { get { return Field<int>(0x74); } }
			public int x78 { get { return Field<int>(0x78); } }
			public int x7C { get { return Field<int>(0x7C); } }
			public int x80 { get { return Field<int>(0x80); } }
			public int x84 { get { return Field<int>(0x84); } }
			public float x88 { get { return Field<float>(0x88); } }
			public float x8C { get { return Field<float>(0x8C); } }
			public float x90 { get { return Field<float>(0x90); } }
			public int x94 { get { return Field<int>(0x94); } }
			public int x98 { get { return Field<int>(0x98); } }
			public int x9C { get { return Field<int>(0x9C); } }
			public int xA0 { get { return Field<int>(0xA0); } }
			public int xA4 { get { return Field<int>(0xA4); } }
			public int xA8_ObserverSnoId { get { return Field<int>(0xA8); } }
		}
	}
}
