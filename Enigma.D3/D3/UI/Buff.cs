using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.UI
{
	public class Buff : MemoryObject
	{
		public const int SizeOf = 0xA48;

		public Buff(ProcessMemory memory, int address)
			: base(memory, address) { }

		public int x000_PowerSnoId { get { return Field<int>(0x000); } }
		public int x004_Neg1 { get { return Field<int>(0x004); } }
		public PlayerData x008_PlayerData { get { return Dereference<PlayerData>(0x008); } }
		public int x00C_AnnId { get { return Field<int>(0x00C); } }
		public int x010_DurationInTicks { get { return Field<int>(0x010); } }
		public int x014_StackCount { get { return Field<int>(0x014); } }
		public int x018_IsCancellable { get { return Field<int>(0x018); } }
		public int x01C_Ptr { get { return Field<int>(0x01C); } }
		public UIReference x020_Dlg { get { return Field<UIReference>(0x020); } }
		public UIReference x228_DlgIcon { get { return Field<UIReference>(0x228); } }
		public UIReference x430_DlgWindowFrame { get { return Field<UIReference>(0x430); } }
		public UIReference x638_DlgText { get { return Field<UIReference>(0x638); } }
		public UIReference x840_DlgTimer { get { return Field<UIReference>(0x840); } }
	}
}
