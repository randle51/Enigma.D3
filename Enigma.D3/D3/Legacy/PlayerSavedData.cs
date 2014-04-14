using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.Legacy
{
	public class PlayerSavedData : MemoryObject
	{
		public const int SizeOf = 0x970; // 1.0.8.16603 : [0x00D47A00] ParseProtobufMessage (see 0x4C message, PlayerSavedDataMessage)

		public PlayerSavedData(ProcessMemory memory, int address)
			: base(memory, address) { }

		public byte[] x000 { get { return Field<byte>(0x000, 92); } }
		public int x05C { get { return Field<int>(0x05C); } }
		public byte[] x060 { get { return Field<byte>(0x060, 2304); } }
		public SavePoint x960_SavePoint { get { return Field<SavePoint>(0x960); } }
	}
}
