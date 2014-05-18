using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Enigma.D3.Collections;

namespace Enigma.D3
{
	public class PlayerInput : MemoryObject
	{
		// 2.0.5.24017
		public const int SizeOf = 0x5C;

		public PlayerInput(ProcessMemory memory, int address)
			: base(memory, address) { }

		public ListB<int> x00_ListB_Of_ActorId { get { return Field<ListB<int>>(0x00); } }
		public int x14_StructStart_Min56Bytes { get { return Field<int>(0x14); } }

		public int x14 { get { return Field<byte>(0x14); } }
		public int x15 { get { return Field<byte>(0x15); } }
		public int x16 { get { return Field<byte>(0x16); } }
		public int x17 { get { return Field<byte>(0x17); } }

		public int x18_Neg1 { get { return Field<int>(0x18); } }
		public int x1C_Neg1 { get { return Field<int>(0x1C); } }
		public int x20_Neg1 { get { return Field<int>(0x20); } }
		public int x24 { get { return Field<int>(0x24); } }
		public int x28 { get { return Field<int>(0x28); } }
		public int x2C { get { return Field<int>(0x2C); } }
		public int x30_Neg1 { get { return Field<int>(0x30); } }
		public int x34_Neg1 { get { return Field<int>(0x34); } }
		public int x38_Neg1 { get { return Field<int>(0x38); } }
		public int x3C_Neg1 { get { return Field<int>(0x3C); } }
		public int x40_Neg1 { get { return Field<int>(0x40); } }
		public int x44_Neg1_SelectedItemAcdId { get { return Field<int>(0x44); } }
		public int _x48 { get { return Field<int>(0x48); } }
		public int x4C_Neg1 { get { return Field<int>(0x4C); } }
		public int x50_Neg1 { get { return Field<int>(0x50); } }
		public int x54 { get { return Field<int>(0x54); } }
		public int x58 { get { return Field<int>(0x58); } }
	}
}
