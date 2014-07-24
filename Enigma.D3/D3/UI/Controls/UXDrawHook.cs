using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.UI.Controls
{
	public class UXDrawHook : UXControl
	{
		// 2.0.6.24641
		public const int SizeOf = 0x468;
		public const int VTable = 0x017C3770;

		public UXDrawHook(MemoryBase memory, int address)
			: base(memory, address) { }

		public int x460 { get { return Field<int>(0x460); } }
		public int _x464 { get { return Field<int>(0x464); } }
	}
}
