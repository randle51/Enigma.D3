using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3
{
	public class NetworkMessage : MemoryObject
	{
		// 2.0.0.20874
		public const int SizeOf = 8 + 32;

		public NetworkMessage(ProcessMemory memory, int address)
			: base(memory, address) { }

		public int x00_DataLength { get { return Field<int>(0x00); } }
		public int x04 { get { return Field<int>(0x04); } }
		public short x08_UsedLength { get { return Field<short>(0x08); } }
		public short x0A_Flags { get { return Field<short>(0x0A); } }
		//public int x08_Data0 { get { return Field<int>(0x08); } }
		public int x0C_Type { get { return Field<int>(0x0C); } }
		public int x10_Sequence { get { return Field<int>(0x10); } }
		public int x14_Data3 { get { return Field<int>(0x14); } }
		public int x18_Data4 { get { return Field<int>(0x18); } }
		public int x1C_Data5 { get { return Field<int>(0x1C); } }
		public int x20_Data6 { get { return Field<int>(0x20); } }
		public int x24_Data7 { get { return Field<int>(0x24); } }
		public int x28_Data8 { get { return Field<int>(0x28); } }
	}
}
