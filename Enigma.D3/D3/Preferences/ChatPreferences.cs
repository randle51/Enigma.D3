using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.Preferences
{
	public class ChatPreferences : MemoryObject
	{
		// 2.0.0.20874
		public const int SizeOf = 8;

		public int x00_MatureLanguageFilter { get { return Read<int>(0x00); } }  // default = 1, min = 0, max = 1
		public int x04_EchoQuestDialogToChat { get { return Read<int>(0x04); } }  // default = 1, min = 0, max = 1
	}
}
