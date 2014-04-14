using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.Legacy
{
	public class SavePoint : MemoryObject
	{
		public const int SizeOf = 0x10; // 1.0.8.16603 : [0x00D47A00] ParseProtobufMessage (see 0x4F message, SavePointDataMessage)

		public SavePoint(ProcessMemory memory, int address)
			: base(memory, address) { }

		public byte[] x00 { get { return Field<byte>(0x00, 16); } }
	}
}