using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.Legacy
{
	public class ChatPreferences : MemoryObject
	{
		public const int SizeOf = 8; // 1.0.8.16603 : [008FFA20]

		public ChatPreferences(ProcessMemory memory, int address)
			: base(memory, address) { }

		// See field names at [0x01477DB8] (1.0.8.16603).
		public bool x00_MatureLanguageFilter { get { return Field<bool>(0x00); } }
		public bool x04_EchoQuestDialogToChat { get { return Field<bool>(0x04); } }
	}
}
