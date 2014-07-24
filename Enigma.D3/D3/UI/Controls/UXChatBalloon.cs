using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.UI.Controls
{
	public class UXChatBalloon : UXLabel
	{
		// 2.0.6.24641
		public const int SizeOf = 0xC78;
		public const int VTable = 0x017C31C8;

		public UXChatBalloon(MemoryBase memory, int address)
			: base(memory, address) { }
	}
}
