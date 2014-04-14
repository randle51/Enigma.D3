using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.Preferences
{
	public class SocialPreferences : MemoryObject
	{
		// 2.0.0.20874
		public const int SizeOf = 0x2C; // = 44

		public SocialPreferences(ProcessMemory memory, int address)
			: base(memory, address) { }

		public int x00_NotifyFriendOnline { get { return Field<int>(0x00); } }  // default = 1, min = 0, max = 1
		public int x04_NotifyFriendOffline { get { return Field<int>(0x04); } }  // default = 0, min = 0, max = 1
		public int x08_NotifyFriendRequest { get { return Field<int>(0x08); } }  // default = 1, min = 0, max = 1
		public int x0C_NotifyFriendAchievement { get { return Field<int>(0x0C); } }  // default = 1, min = 0, max = 1
		public int x10_NotifyDisplayWindow { get { return Field<int>(0x10); } }  // default = 1, min = 0, max = 1
		public int x14_NotifyDuration { get { return Field<int>(0x14); } }  // default = 1, min = 0, max = 1
		public int x18_AllowQuickJoin { get { return Field<int>(0x18); } }  // default = 1, min = 0, max = 1
		public int x1C_NotifyAuctionHouseEvent { get { return Field<int>(0x1C); } }  // default = 1, min = 0, max = 1
		public int x20_NotifyFriendBroadcastDisabled { get { return Field<int>(0x20); } }  // default = 0, min = 0, max = 1
		public int x24_ShowLocalPlayersListDisabled { get { return Field<int>(0x24); } }  // default = 0, min = 0, max = 1
		public int x28_NotifyGuildMemberOnlineDisabled { get { return Field<int>(0x28); } }  // default = 0, min = 0, max = 1
	}
}
