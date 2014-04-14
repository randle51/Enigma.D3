using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.Legacy
{
	public class SocialPreferences : MemoryObject
	{
		public const int SizeOf = 0x28; // 1.0.8.16603 : [008FFA20]

		public SocialPreferences(ProcessMemory memory, int address)
			: base(memory, address) { }

		// See field names at [0x01477CD8] (1.0.8.16603).
		public bool x00_NotifyFriendOnline { get { return Field<bool>(0x00); } }
		public bool x04_NotifyFriendOffline { get { return Field<bool>(0x04); } }
		public bool x08_NotifyFriendRequest { get { return Field<bool>(0x08); } }
		public bool x0C_NotifyFriendAchievement { get { return Field<bool>(0x0C); } }
		public bool x10_NotifyDisplayWindow { get { return Field<bool>(0x10); } }
		public int x14_NotifyDuration { get { return Field<int>(0x14); } }
		public bool x18_AllowQuickJoin { get { return Field<bool>(0x18); } }
		public bool x1C_NotifyAuctionHouseEvent { get { return Field<bool>(0x1C); } }
		public bool x20_NotifyFriendBroadcastDisabled { get { return Field<bool>(0x20); } }
		public bool x24_ShowLocalPlayersListDisabled { get { return Field<bool>(0x24); } }
	}
}
