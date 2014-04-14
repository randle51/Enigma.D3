using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.Legacy
{
	public class Buff : MemoryObject
	{
		public const int SizeOf = 0xA48; // 1.0.8.16603 : [0x00C63EE0] BuffManager::Create (see the allocator item size and subtract 2 ints)

		public Buff(ProcessMemory memory, int address)
			: base(memory, address) { }

		public int x000 { get { return Field<int>(0x000); } }
		public int x004 { get { return Field<int>(0x004); } }
		public Player x008_Player { get { return Dereference<Player>(0x008); } }
		public int x00C_UnknownId { get { return Field<int>(0x00C); } }
		public int x010_DurationInTicks { get { return Field<int>(0x010); } } // <-- A tick is 1/60th of a second.
		public int x014_StackCount { get { return Field<int>(0x014); } }
		public int x018_IsCancellable { get { return Field<int>(0x018); } }
		public int _x01C { get { return Field<int>(0x01C); } }
		public UIReference x020_Dlg { get { return Field<UIReference>(0x020); } }
		public UIReference x228_DlgIcon { get { return Field<UIReference>(0x228); } }
		public UIReference x430_DlgWindowFrame { get { return Field<UIReference>(0x430); } }
		public UIReference x638_DlgText { get { return Field<UIReference>(0x638); } } // <-- This is the stack number, not tooltip!
		public UIReference x840_DlgTimer { get { return Field<UIReference>(0x840); } }
	}
}
