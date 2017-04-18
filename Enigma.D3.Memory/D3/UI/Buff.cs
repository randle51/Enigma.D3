using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.UI
{
	public class Buff : MemoryObject
	{
		public const int SizeOf = 0xA48;

		public int x000_PowerSnoId { get { return Read<int>(0x000); } }
		public int x004_Neg1 { get { return Read<int>(0x004); } }
		public PlayerData x008_PlayerData { get { return ReadPointer<PlayerData>(0x008).Dereference(); } }
		public int x00C_AnnId { get { return Read<int>(0x00C); } }
		public int x010_DurationInTicks { get { return Read<int>(0x010); } }
		public int x014_StackCount { get { return Read<int>(0x014); } }
		public int x018_IsCancellable { get { return Read<int>(0x018); } }
		public int x01C_Ptr { get { return Read<int>(0x01C); } }
		public UIReference x020_Dlg { get { return Read<UIReference>(0x020); } }
		public UIReference x228_DlgIcon { get { return Read<UIReference>(0x228); } }
		public UIReference x430_DlgWindowFrame { get { return Read<UIReference>(0x430); } }
		public UIReference x638_DlgText { get { return Read<UIReference>(0x638); } }
		public UIReference x840_DlgTimer { get { return Read<UIReference>(0x840); } }
	}
}
